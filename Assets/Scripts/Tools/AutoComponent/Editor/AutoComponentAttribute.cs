using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(AutoComponentAttribute))]
public class AutoComponentAttributeDrawer : PropertyDrawer{

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){ 
		AutoComponentAttribute aca_attribute = (AutoComponentAttribute) attribute;

		if(!aca_attribute.hideInInspector || property.objectReferenceValue == null){
			EditorGUI.PropertyField(position, property, label);
		}

		if(property.objectReferenceValue != null){
			return;
		}			
		
		System.Type type = aca_attribute.type;
		Component serialized = ((Component) property.serializedObject.targetObject);
		Object newValue = serialized.GetComponent(type);
		property.objectReferenceValue = newValue;

		if(newValue != null){
			EditorUtility.SetDirty(serialized);
		}
	}

}
