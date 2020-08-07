/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldMapLocation : ManagedBehaviour // TypeDefIndex: 14295
{
	// Fields
	public string uniqueMapId; // 0x50
	public MinimapManager.EBlipType worldBlipType; // 0x58
	[Header] // 0x000000018020AF10-0x000000018020AF90
	[RootSelector] // 0x000000018020AF10-0x000000018020AF90
	public string localization; // 0x60

	// Constructors
	public WorldMapLocation(); // 0x00000001805E7460-0x00000001805E74D0

	// Methods
	public override void MOnEnable(); // 0x00000001805E72B0-0x00000001805E7430
	public void GenerateMapId(); // 0x00000001805E7230-0x00000001805E72B0
	public static string CreateNewGuid(); // 0x00000001805E71C0-0x00000001805E7230
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <MOnEnable>b__3_0(LevelDefComponent.WorldMapInfo x); // 0x00000001805E7430-0x00000001805E7460
}

