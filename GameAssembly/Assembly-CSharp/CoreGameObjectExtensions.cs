/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class CoreGameObjectExtensions // TypeDefIndex: 11071
{
	// Extension methods
	public static T GetOrAddComponent<T>(this GameObject inGameObject)
		where T : Component;
	public static bool HasComponent<T>(this GameObject inGameObject)
		where T : Component;
	public static void SetParent(this GameObject inGameObject, GameObject inParent); // 0x0000000180A680A0-0x0000000180A68100
	public static void SafeDestroy(this GameObject inGameObject); // 0x0000000180A67F60-0x0000000180A67FF0
	public static void SetLayerRecursively(this GameObject inGO, int inLayer); // 0x0000000180A67FF0-0x0000000180A680A0
	public static List<GameObject> GetGameObjectsWithLayer(this GameObject inGO, int inLayer, bool inExcludeInLayer = false /* Metadata: 0x0077C743 */); // 0x0000000180A67D10-0x0000000180A67ED0
	public static bool IsPrefab(this GameObject inGO); // 0x0000000180A67ED0-0x0000000180A67F60
}

