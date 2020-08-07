/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 76: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9124-9142

public class ftLightmaps // TypeDefIndex: 9138
{
	// Fields
	private static List<int> lightmapRefCount; // 0x00
	private static List<LightmapAdditionalData> globalMapsAdditional; // 0x08
	private static bool directionalMode; // 0x10

	// Nested types
	private struct LightmapAdditionalData // TypeDefIndex: 9139
	{
		// Fields
		public Texture2D rnm0; // 0x00
		public Texture2D rnm1; // 0x08
		public Texture2D rnm2; // 0x10
		public int mode; // 0x18
	}

	// Constructors
	static ftLightmaps(); // 0x00000001820BC820-0x00000001820BC8B0
	public ftLightmaps(); // 0x0000000180373240-0x0000000180373250

	// Methods
	private static void OnSceneChangedPlay(Scene prev, Scene next); // 0x00000001820BA230-0x00000001820BA2A0
	public static void RefreshFull(); // 0x00000001820BA2A0-0x00000001820BA3A0
	public static GameObject FindInScene(string nm, Scene scn); // 0x00000001820BA080-0x00000001820BA210
	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage); // 0x00000001820BA210-0x00000001820BA230
	public static void RefreshScene(Scene scene, ftLightmapsStorage storage = null, bool updateNonBaked = false /* Metadata: 0x00778C57 */); // 0x00000001820BA620-0x00000001820BC4C0
	public static void UnloadScene(ftLightmapsStorage storage); // 0x00000001820BC4C0-0x00000001820BC820
	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage); // 0x00000001820BA3A0-0x00000001820BA620
}

