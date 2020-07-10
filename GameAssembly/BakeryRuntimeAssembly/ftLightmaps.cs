/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

public class ftLightmaps // TypeDefIndex: 8972
{
	// Fields
	private static List<int> lightmapRefCount; // 0x00
	private static List<LightmapAdditionalData> globalMapsAdditional; // 0x08
	private static bool directionalMode; // 0x10

	// Nested types
	private struct LightmapAdditionalData // TypeDefIndex: 8973
	{
		// Fields
		public Texture2D rnm0; // 0x00
		public Texture2D rnm1; // 0x08
		public Texture2D rnm2; // 0x10
		public int mode; // 0x18
	}

	// Constructors
	static ftLightmaps(); // 0x00000001822C0870-0x00000001822C0900
	public ftLightmaps(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	private static void OnSceneChangedPlay(Scene prev, Scene next); // 0x00000001822BE190-0x00000001822BE200
	public static void RefreshFull(); // 0x00000001822BE200-0x00000001822BE300
	public static GameObject FindInScene(string nm, Scene scn); // 0x00000001822BDFD0-0x00000001822BE170
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage); // 0x00000001822BE170-0x00000001822BE190
	public static void RefreshScene(Scene scene, ftLightmapsStorage storage = null, bool updateNonBaked = false /* Metadata: 0x00743F69 */); // 0x00000001822BE5B0-0x00000001822C0500
	public static void UnloadScene(ftLightmapsStorage storage); // 0x00000001822C0500-0x00000001822C0870
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage); // 0x00000001822BE300-0x00000001822BE5B0
}

