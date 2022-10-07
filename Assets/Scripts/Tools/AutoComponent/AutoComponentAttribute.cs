using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// automatycznie używa GetComponent, gdy pole jest nullem na etapie serializacji 
/// </summary>
public class AutoComponentAttribute : PropertyAttribute {
	public readonly System.Type type;
	public readonly bool hideInInspector;

	public AutoComponentAttribute(System.Type _type, bool _hideInInspector = false){ 
		type = _type;
		hideInInspector = _hideInInspector;
	}

}
