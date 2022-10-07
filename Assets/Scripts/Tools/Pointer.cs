using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO: MW jakieś fajne castowanie
public abstract class Pointer{
	public abstract object GetValue();
	
	public abstract void SetValue(object newValue);

	public abstract System.Type GetStoredType();

}

public class Pointer<T> : Pointer{
    public T value;

	public override object GetValue() => value;

	public override void SetValue(object newValue) => value = (T) newValue;

	public override System.Type GetStoredType() => typeof(T);

	public Pointer(){
		this.value = default(T);
	}

	public Pointer(T value){
		this.value = value;
	}

	public Pointer(Pointer<T> pointer){
		this.value = pointer.value;
	}

	public Pointer(Pointer pointer){
		this.value = (T)pointer.GetValue();
	}
}
