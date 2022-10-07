using UnityEngine;

public static class VectorReplace{

#region replacement
	public static Vector2 XAs(this Vector2 v2, float x)=>
		new Vector2(x, v2.y);

	public static Vector2 YAs(this Vector2 v2, float y)=>
		new Vector2(v2.x, y);

	public static Vector2Int XAs(this Vector2Int v2i, int x)=>
		new Vector2Int(x, v2i.y);

	public static Vector2Int YAs(this Vector2Int v2i, int y)=>
		new Vector2Int(v2i.x, y);

	public static Vector3 XAs(this Vector3 v3, float x)=>
		new Vector3(x, v3.y, v3.z);

	public static Vector3 YAs(this Vector3 v3, float y)=>
		new Vector3(v3.x, y, v3.z);

	public static Vector3 ZAs(this Vector3 v3, float z)=>
		new Vector3(v3.x, v3.y, z);

	public static Vector3Int XAs(this Vector3Int v3i, int x)=>
		new Vector3Int(x, v3i.y, v3i.z);

	public static Vector3Int YAs(this Vector3Int v3i, int y)=>
		new Vector3Int(v3i.x, y, v3i.z);

	public static Vector3Int ZAs(this Vector3Int v3i, int z)=>
		new Vector3Int(v3i.x, v3i.y, z);

	public static Vector4 XAs(this Vector4 v4, float x)=>
		new Vector4(x, v4.y, v4.z, v4.w);

	public static Vector4 YAs(this Vector4 v4, float y)=>
		new Vector4(v4.x, y, v4.z, v4.w);

	public static Vector4 ZAs(this Vector4 v4, float z)=>
		new Vector4(v4.x, v4.y, z, v4.w);

	public static Vector4 WAs(this Vector4 v4, float w)=>
		new Vector4(v4.x, v4.y, v4.z, w);
	#endregion

#region adders
	public static Vector2 XInced(this Vector2 v2, float xAdder)=>
		new Vector2(v2.x + xAdder, v2.y);

	public static Vector2 YInced(this Vector2 v2, float yAdder)=>
		new Vector2(v2.x, v2.y + yAdder);

	public static Vector2Int XInced(this Vector2Int v2i, int xAdder)=>
		new Vector2Int(v2i.x + xAdder, v2i.y);

	public static Vector2Int YInced(this Vector2Int v2i, int yAdder)=>
		new Vector2Int(v2i.x, v2i.y + yAdder);

	public static Vector3 XInced(this Vector3 v3, float xAdder)=>
		new Vector3(v3.x + xAdder, v3.y, v3.z);

	public static Vector3 YInced(this Vector3 v3, float yAdder)=>
		new Vector3(v3.x, v3.y + yAdder, v3.z);

	public static Vector3 ZInced(this Vector3 v3, float zAdder)=>
		new Vector3(v3.x, v3.y, v3.z + zAdder);

	public static Vector3Int XInced(this Vector3Int v3i, int xAdder)=>
		new Vector3Int(v3i.x + xAdder, v3i.y, v3i.z);

	public static Vector3Int YInced(this Vector3Int v3i, int yAdder)=>
		new Vector3Int(v3i.x, v3i.y + yAdder, v3i.z);

	public static Vector3Int ZInced(this Vector3Int v3i, int zAdder)=>
		new Vector3Int(v3i.x, v3i.y, v3i.z + zAdder);

	public static Vector4 XInced(this Vector4 v4, float xAdder)=>
		new Vector4(v4.x + xAdder, v4.y, v4.z, v4.w);

	public static Vector4 YInced(this Vector4 v4, float yAdder)=>
		new Vector4(v4.x, v4.y + yAdder, v4.z, v4.w);

	public static Vector4 ZInced(this Vector4 v4, float zAdder)=>
		new Vector4(v4.x, v4.y, v4.z + zAdder, v4.w);

	public static Vector4 WInced(this Vector4 v4, float wAdder)=>
		new Vector4(v4.x, v4.y, v4.z, v4.w + wAdder);


#endregion

#region subtracters
	public static Vector2 XDeced(this Vector2 v2, float xSubtracter)=>
		new Vector2(v2.x - xSubtracter, v2.y);

	public static Vector2 YDeced(this Vector2 v2, float ySubtracter)=>
		new Vector2(v2.x, v2.y - ySubtracter);

	public static Vector2Int XDeced(this Vector2Int v2i, int xSubtracter)=>
		new Vector2Int(v2i.x - xSubtracter, v2i.y);

	public static Vector2Int YDeced(this Vector2Int v2i, int ySubtracter)=>
		new Vector2Int(v2i.x, v2i.y - ySubtracter);

	public static Vector3 XDeced(this Vector3 v3, float xSubtracter)=>
		new Vector3(v3.x - xSubtracter, v3.y, v3.z);

	public static Vector3 YDeced(this Vector3 v3, float ySubtracter)=>
		new Vector3(v3.x, v3.y - ySubtracter, v3.z);

	public static Vector3 ZDeced(this Vector3 v3, float zSubtracter)=>
		new Vector3(v3.x, v3.y, v3.z - zSubtracter);

	public static Vector3Int XDeced(this Vector3Int v3i, int xSubtracter)=>
		new Vector3Int(v3i.x - xSubtracter, v3i.y, v3i.z);

	public static Vector3Int YDeced(this Vector3Int v3i, int ySubtracter)=>
		new Vector3Int(v3i.x, v3i.y - ySubtracter, v3i.z);

	public static Vector3Int ZDeced(this Vector3Int v3i, int zSubtracter)=>
		new Vector3Int(v3i.x, v3i.y, v3i.z - zSubtracter);

	public static Vector4 XDeced(this Vector4 v4, float xSubtracter)=>
		new Vector4(v4.x - xSubtracter, v4.y, v4.z, v4.w);

	public static Vector4 YDeced(this Vector4 v4, float ySubtracter)=>
		new Vector4(v4.x, v4.y - ySubtracter, v4.z, v4.w);

	public static Vector4 ZDeced(this Vector4 v4, float zSubtracter)=>
		new Vector4(v4.x, v4.y, v4.z - zSubtracter, v4.w);

	public static Vector4 WDeced(this Vector4 v4, float wSubtracter)=>
		new Vector4(v4.x, v4.y, v4.z, v4.w - wSubtracter);


#endregion

#region multipliers
	public static Vector2 XMuled(this Vector2 v2, float xMultiplier)=>
		new Vector2(v2.x * xMultiplier, v2.y);

	public static Vector2 YMuled(this Vector2 v2, float yMultiplier)=>
		new Vector2(v2.x, v2.y * yMultiplier);

	public static Vector2Int XMuled(this Vector2Int v2i, int xMultiplier)=>
		new Vector2Int(v2i.x * xMultiplier, v2i.y);

	public static Vector2Int YMuled(this Vector2Int v2i, int yMultiplier)=>
		new Vector2Int(v2i.x, v2i.y * yMultiplier);

	public static Vector3 XMuled(this Vector3 v3, float xMultiplier)=>
		new Vector3(v3.x * xMultiplier, v3.y, v3.z);

	public static Vector3 YMuled(this Vector3 v3, float yMultiplier)=>
		new Vector3(v3.x, v3.y * yMultiplier, v3.z);

	public static Vector3 ZMuled(this Vector3 v3, float zMultiplier)=>
		new Vector3(v3.x, v3.y, v3.z * zMultiplier);

	public static Vector3Int XMuled(this Vector3Int v3i, int xMultiplier)=>
		new Vector3Int(v3i.x * xMultiplier, v3i.y, v3i.z);

	public static Vector3Int YMuled(this Vector3Int v3i, int yMultiplier)=>
		new Vector3Int(v3i.x, v3i.y * yMultiplier, v3i.z);

	public static Vector3Int ZMuled(this Vector3Int v3i, int zMultiplier)=>
		new Vector3Int(v3i.x, v3i.y, v3i.z * zMultiplier);

	public static Vector4 XMuled(this Vector4 v4, float xMultiplier)=>
		new Vector4(v4.x * xMultiplier, v4.y, v4.z, v4.w);

	public static Vector4 YMuled(this Vector4 v4, float yMultiplier)=>
		new Vector4(v4.x, v4.y * yMultiplier, v4.z, v4.w);

	public static Vector4 ZMuled(this Vector4 v4, float zMultiplier)=>
		new Vector4(v4.x, v4.y, v4.z * zMultiplier, v4.w);

	public static Vector4 WMuled(this Vector4 v4, float wMultiplier)=>
		new Vector4(v4.x, v4.y, v4.z, v4.w * wMultiplier);


#endregion

#region dividers
	public static Vector2 XDived(this Vector2 v2, float xDivider)=>
		new Vector2(v2.x / xDivider, v2.y);

	public static Vector2 YDived(this Vector2 v2, float yDivider)=>
		new Vector2(v2.x, v2.y / yDivider);

	public static Vector2Int XDived(this Vector2Int v2i, int xDivider)=>
		new Vector2Int(v2i.x / xDivider, v2i.y);

	public static Vector2Int YDived(this Vector2Int v2i, int yDivider)=>
		new Vector2Int(v2i.x, v2i.y / yDivider);

	public static Vector3 XDived(this Vector3 v3, float xDivider)=>
		new Vector3(v3.x / xDivider, v3.y, v3.z);

	public static Vector3 YDived(this Vector3 v3, float yDivider)=>
		new Vector3(v3.x, v3.y / yDivider, v3.z);

	public static Vector3 ZDived(this Vector3 v3, float zDivider)=>
		new Vector3(v3.x, v3.y, v3.z / zDivider);

	public static Vector3Int XDived(this Vector3Int v3i, int xDivider)=>
		new Vector3Int(v3i.x / xDivider, v3i.y, v3i.z);

	public static Vector3Int YDived(this Vector3Int v3i, int yDivider)=>
		new Vector3Int(v3i.x, v3i.y / yDivider, v3i.z);

	public static Vector3Int ZDived(this Vector3Int v3i, int zDivider)=>
		new Vector3Int(v3i.x, v3i.y, v3i.z / zDivider);

	public static Vector4 XDived(this Vector4 v4, float xDivider)=>
		new Vector4(v4.x / xDivider, v4.y, v4.z, v4.w);

	public static Vector4 YDived(this Vector4 v4, float yDivider)=>
		new Vector4(v4.x, v4.y / yDivider, v4.z, v4.w);

	public static Vector4 ZDived(this Vector4 v4, float zDivider)=>
		new Vector4(v4.x, v4.y, v4.z / zDivider, v4.w);

	public static Vector4 WDived(this Vector4 v4, float wDivider)=>
		new Vector4(v4.x, v4.y, v4.z, v4.w / wDivider);


#endregion
}