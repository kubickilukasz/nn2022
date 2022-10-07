using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO: MW setPair - lepsze czyszczenie starych zależności
public class ConcurrentTwoWayDictonary<TKey,TValue>{
    
	private readonly Dictionary<TKey, TValue> keyToValue = new Dictionary<TKey, TValue>();
	private readonly Dictionary<TValue, TKey> valueToKey = new Dictionary<TValue, TKey>();
	private readonly System.Threading.ReaderWriterLockSlim guard = new(System.Threading.LockRecursionPolicy.SupportsRecursion);

	public bool TryGetKeyFromValue(TValue value, out TKey key){ 
		bool result = false;
		try{ 
			guard.EnterReadLock();
			result = valueToKey.TryGetValue(value, out key);
			guard.ExitReadLock();
		}finally{
			if (guard.IsReadLockHeld) guard.ExitReadLock();
		}
	
		return result;
	}
	
	public bool TryGetValueFromKey(TKey key, out TValue value){ 
		bool result = false;
		try{ 
			guard.EnterReadLock();
			result = keyToValue.TryGetValue(key, out value);
			guard.ExitReadLock();
		}finally{
			if (guard.IsReadLockHeld) guard.ExitReadLock();
		}
	
		return result;	
	}

	public void SetPair(TKey key, TValue value){
		try{ 
			guard.EnterWriteLock();			
			keyToValue[key] = value;
			valueToKey[value] = key;
			guard.EnterWriteLock();
		}finally{
			if (guard.IsWriteLockHeld) guard.ExitWriteLock();
		}
	}

	public void Clear(){
		try{ 
			guard.EnterWriteLock();			
			keyToValue.Clear();
			valueToKey.Clear();
			guard.EnterWriteLock();
		}finally{
			if (guard.IsWriteLockHeld) guard.ExitWriteLock();
		}
	}
}
