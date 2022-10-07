using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkDrawer : MonoBehaviour{
    public Transform a;
	public Transform b;
	
	public Color color;
	private Vector3 posA;
	private Vector3 posB;


	private void OnDrawGizmos() {
		Gizmos.color = color;
		if(a != null){
			posA = a.position;
		}

		if(b != null){
			posB = b.position;
		}
		Gizmos.DrawLine(posA, posB);

	}
}
