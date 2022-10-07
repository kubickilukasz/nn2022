using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathTools{
	
	public static double Lerp(double a, double b, double t) => a*(1.0 - t) + t*b;

	public static Vector2 MemberwiseMultiply(Vector2 a, Vector2 b) => new Vector2(a.x*b.x, a.y*b.y);
	public static Vector2 MemberwiseDivide(Vector2 a, Vector2 b) => new Vector2(a.x/b.x, a.y/b.y);

	public static Vector3 MemberwiseMultiply(Vector3 a, Vector3 b) => new Vector3(a.x*b.x, a.y*b.y, a.z*b.z);
	public static Vector3 MemberwiseDivide(Vector3 a, Vector3 b) => new Vector3(a.x/b.x, a.y/b.y, a.z/b.z);

	public static (Vector2 normal, Vector2 parallel) CastVector(Vector2 _vectorToCast, Vector2 _axisToCastOn){
		Vector2 magnitudes = CastVectorValues(_vectorToCast, _axisToCastOn);
		Vector2 resultParallel = _axisToCastOn.normalized * magnitudes.x;
		Vector2 resultNormal = _vectorToCast - resultParallel;
		return (resultNormal, resultParallel);
	}

	/// <summary>
	/// Rzutuje wektor na inny. X = sk³adowa równoleg³a, Y = sk³adowa normalna
	/// </summary>
	/// <param name="_vectorToCast"></param>
	/// <param name="_axisToCastOn"></param>
	/// <returns></returns>
	public static Vector2 CastVectorValues(Vector2 _vectorToCast, Vector2 _axisToCastOn){
		_axisToCastOn.Normalize();
		Vector2 result = new Vector2(
			x: (_axisToCastOn.x*_vectorToCast.x) + (_axisToCastOn.y*_vectorToCast.y),
			y: -(_vectorToCast.x*_axisToCastOn.y) + ( _axisToCastOn.x*_vectorToCast.y)
		);
		return result;
	}

	/// <summary>
	/// dzia³a jak modulo, ale przy a ujemnym daje dodatni wynik
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	static public float PositiveModulo(float a, float b){ 
		float result = a%b;
		return (result < 0)? (b+result) : result;
	}

	public static int RoundAsHp(float _toFloor, int _maxHp, int _minHp = 0){ 
		if(_toFloor <= _minHp)
			return _minHp;
		
		if(_toFloor >= _maxHp)
			return _maxHp;

		int floored = Mathf.RoundToInt(_toFloor);
		if(floored == _maxHp && _toFloor < _maxHp){ 
			return floored - 1;	
		}

		if(floored == _minHp){
			return _minHp;
		}

		return floored;
	}

	public static int RandRound(float _f){ 
		if(_f < 0)
			return -RandRound(-_f);

		int result = Mathf.FloorToInt(_f);
		_f -= result;
		if(_f > Random.value){ 
			result += 1;	
		}
		return result;
	}
}
