/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldMapLocation : ManagedBehaviour // TypeDefIndex: 12723
{
	// Fields
	public string uniqueMapId; // 0x50
	public MinimapManager.EBlipType worldBlipType; // 0x58

	// Constructors
	public WorldMapLocation(); // 0x0000000181000140-0x00000001810001A0

	// Methods
	public override void MOnEnable(); // 0x0000000180FFFFF0-0x0000000181000110
	public void GenerateMapId(); // 0x0000000180FFFF70-0x0000000180FFFFF0
	public static string CreateNewGuid(); // 0x0000000180FFFF00-0x0000000180FFFF70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <MOnEnable>b__2_0(LevelDefComponent.WorldMapInfo x); // 0x0000000181000110-0x0000000181000140
}

