using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO: MW usuwanie z stacktrece'a 
public static class DebugTools{
	public static T FlowDebug<T>(T arg, string prefix = ""){ 
		Debug.Log(prefix+arg?.ToString());
		return arg;		
	}
	
	public static void DrawLink(Transform start, Transform end, float time, Color color){
		GameObject newObject = new GameObject("Link Drawer", typeof(LinkDrawer));
		LinkDrawer drawer = newObject.GetComponent<LinkDrawer>();
		drawer.a = start;
		drawer.b = end;
		drawer.color = color;
		MonoBehaviour.Destroy(newObject, time);
	}

	public static void DrawLink(Transform start, Vector3 end, float time, Color color){
		GameObject newObject = new GameObject("Link Drawer", typeof(LinkDrawer));
		LinkDrawer drawer = newObject.GetComponent<LinkDrawer>();
		drawer.a = start;
		drawer.b = newObject.transform;
		drawer.color = color;
		newObject.transform.position = end;
		MonoBehaviour.Destroy(newObject, time);
	}
}
