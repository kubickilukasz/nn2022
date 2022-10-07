using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SemiEditorTools{

	public static bool IsSelected(Component component, bool allowGameObject = true){
		#if UNITY_EDITOR
		if(component == null)
			return false;
		Object[] selected = UnityEditor.Selection.objects;
		foreach(Object obj in selected){
			if(obj == component || (allowGameObject && obj == component.gameObject)){
				return true;
			}
		}
		#endif
		return false;
	}

	

}
