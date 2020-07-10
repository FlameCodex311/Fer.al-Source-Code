/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldMapData // TypeDefIndex: 12721
{
	// Fields
	private static WorldMapData _instance; // 0x00
	public List<WorldMapInfo> worldMapInfos; // 0x10

	// Properties
	public static WorldMapData instance { get; } // 0x0000000180FFFDD0-0x0000000180FFFF00 

	// Nested types
	[Serializable]
	public class WorldMapInfo // TypeDefIndex: 12722
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string level; // 0x10
		public string uniqueMapId; // 0x18
		public MinimapManager.EBlipType worldBlipType; // 0x20
		public Vector2 worldMapPosition; // 0x24

		// Constructors
		public WorldMapInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public WorldMapData(); // 0x0000000180FFFD70-0x0000000180FFFDD0
	static WorldMapData(); // 0x00000001803581E0-0x00000001803581F0
}

