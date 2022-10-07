using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ArrayAndListTools{

	static public int FindFirst<T>(T[] tab, T element) where T : System.IComparable{
		for(int i = 0; i< tab.Length; i++){
			if(tab[i].CompareTo(element) == 0){
				return i;
			}
		}
		return -1;
	}

	static public T RandomElement<T>(this T[] array)
	{
		return array[Random.Range(0, array.Length)];
	}

	public static T GetRandomElement<T>(this List<T> _list) => _list[Random.Range(0, _list.Count)];
    
	static public GameObject[] ToGameObjectArray(this Transform[] arr)
	{
		return CalcForAll(arr, (Transform t) => t.gameObject);
	}

	public static void RemoveRandom<T>(this List<T> _list){ 
		if(_list == null || _list.Count == 0){ 
			throw new System.Exception("empty list random removal");	
		}
		_list.RemoveAt(Random.Range(0, _list.Count));
	}

	public static T Pop<T>(this List<T> list, int index){
		T result = list[index];
		list.RemoveAt(index);
		return result;
	}

	public static T PopRandom<T>(this List<T> _list){ 
		if(_list == null || _list.Count == 0){ 
			throw new System.Exception("empty list random removal");	
		}
		int index = Random.Range(0, _list.Count);
		T result = _list[index];
		_list.RemoveAt(index);
		return result;
	}

	static public T[] FilledArray<T>(int size, T initialValue){ 
		T[] result = new T[size];
		for(int i =0; i<size; i++){
			result[i] = initialValue;
		}
		return result;		
	}

	static public int Count<T>(this T[] b, System.Func<T, bool> conditioner){ 
		int result = 0;
		for(int i = 0; i<b.Length; i++){ 
			if(conditioner(b[i])){ 
				result++;
			}
		}
		return result;
	}

	static public T[] CalcForAll<T, Y>(this Y[] a, System.Func<Y, T> func){ 
		T[] result = new T[a.Length];
		for(int i =0 ; i< a.Length; i++){ 
			result[i] = func(a[i]);
		}
		return result;
	}

	public static List<T> MergeLists<T>(params List<T>[] _lists){ 
		int count = 0;
		foreach(List<T> list in _lists)
			count += list.Count;

		List<T> result = new List<T>(count);
		foreach(List<T> list in _lists) 
			if(list != null)
				foreach(T t in list) 
					result.Add(t);

		return result;


	}

	public static T[] MergeArrays<T>(this List<T[]> list){
		int size = 0;
		foreach(T[] arr in list) size += arr.Length;

		T[] result = new T[size];

		int i = 0;
		foreach(T[] arr in list) foreach(T t in arr){
			result[i++] = t;
		}

		return result;

	}

}
