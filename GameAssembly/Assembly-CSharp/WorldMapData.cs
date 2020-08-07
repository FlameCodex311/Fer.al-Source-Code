/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldMapData // TypeDefIndex: 14293
{
	// Fields
	private static WorldMapData _instance; // 0x00
	public List<WorldMapInfo> worldMapInfos; // 0x10

	// Properties
	public static WorldMapData instance { get; } // 0x00000001805E7090-0x00000001805E71C0 

	// Nested types
	[Serializable]
	public class WorldMapInfo // TypeDefIndex: 14294
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string level; // 0x10
		public string uniqueMapId; // 0x18
		public string localization; // 0x20
		public MinimapManager.EBlipType worldBlipType; // 0x28
		public Vector2 worldMapPosition; // 0x2C
		public Vector3 scenePosition; // 0x34
		public Vector3 sceneRotation; // 0x40

		// Constructors
		public WorldMapInfo(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public WorldMapData(); // 0x00000001805E7030-0x00000001805E7090
	static WorldMapData(); // 0x00000001803774A0-0x00000001803774B0
}

