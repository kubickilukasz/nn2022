using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CashedFinder<T> where T : Object{
    public static T cashedResult;

	public static T Find(){
		if(cashedResult == null) cashedResult = Object.FindObjectOfType<T>(); 
		return cashedResult;
	}
}
