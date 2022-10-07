using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomTools{
	
	static public Vector2 RandomPointOnCircle(float radius)
    {
        return Random.insideUnitCircle.normalized * radius;
    }

	static public Quaternion RandomQuantifiedAngle(int _quantification = 4){
		return Quaternion.Euler(0, Random.Range(0, _quantification) * (360f/(float)_quantification), 0);
	}

	/// <summary>
	/// wykonuje losowanie wa¿one
	/// </summary>
	/// <param name="wages"></param>
	/// <returns></returns>
	static public int WageRandom(float[] wages) {
		float sum = 0;
		for(int i = 0; i<wages.Length; i++) {
			sum += Mathf.Max(0f, wages[i]);
		}
		
		if(sum == 0f)
			return -1;

		float rand;
		do{
			rand = Random.Range(0, sum);
		} while(rand == sum);
				
		for(int i = 0; i<wages.Length; i++) {
			rand -=  wages[i];
			if(rand <= 0)
				return i;
		}
		throw new System.Exception("Unreachable code reached");
	}


}
