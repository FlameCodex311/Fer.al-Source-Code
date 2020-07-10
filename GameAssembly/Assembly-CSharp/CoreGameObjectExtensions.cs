/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreGameObjectExtensions // TypeDefIndex: 13400
{
	// Extension methods
	public static T GetOrAddComponent<T>(this GameObject inGameObject)
		where T : Component;
	public static bool HasComponent<T>(this GameObject inGameObject)
		where T : Component;
	public static void SetParent(this GameObject inGameObject, GameObject inParent); // 0x000000018130DA60-0x000000018130DAC0
	public static void SafeDestroy(this GameObject inGameObject); // 0x000000018130D920-0x000000018130D9B0
	public static void SetLayerRecursively(this GameObject inGO, int inLayer); // 0x000000018130D9B0-0x000000018130DA60
	public static List<GameObject> GetGameObjectsWithLayer(this GameObject inGO, int inLayer, bool inExcludeInLayer = false /* Metadata: 0x00783C88 */); // 0x000000018130D6C0-0x000000018130D890
	public static bool IsPrefab(this GameObject inGO); // 0x000000018130D890-0x000000018130D920
}

