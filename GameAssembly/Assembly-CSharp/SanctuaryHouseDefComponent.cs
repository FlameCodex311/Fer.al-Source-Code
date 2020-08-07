/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180222C70-0x0000000180222CA0
public class SanctuaryHouseDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 12091
{
	// Fields
	[ChartClass] // 0x00000001801DE450-0x00000001801DE460
	public HouseNaming houseNaming; // 0x18
	[ChartClass] // 0x00000001801DE450-0x00000001801DE460
	public EntryPortal entryPortal; // 0x20
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> baseExpansions; // 0x28
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> edgeExpansions; // 0x30
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> decorExpansions; // 0x38
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> shrubExpansions; // 0x40
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> doorExpansions; // 0x48
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> lightExpansions; // 0x50
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> roofExpansions; // 0x58
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<Expansion> windowExpansions; // 0x60
	[ChartDef] // 0x0000000180223C30-0x0000000180223CC0
	[ChartList] // 0x0000000180223C30-0x0000000180223CC0
	public List<ChartDef> expansions; // 0x68
	[ChartDef] // 0x0000000180223E80-0x0000000180223F10
	[ChartList] // 0x0000000180223E80-0x0000000180223F10
	public List<ChartDef> upgrades; // 0x70
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<TwiggleBuildLocation> twiggleBuildLocations; // 0x78
	[ChartBundle] // 0x00000001801DE450-0x00000001801DE460
	public ChartBundle layoutData; // 0x80

	// Nested types
	[Serializable]
	public class Expansion // TypeDefIndex: 12092
	{
		// Fields
		[ChartInt] // 0x00000001801DE450-0x00000001801DE460
		public int number; // 0x10
		[ChartDef] // 0x0000000180225B30-0x0000000180225BC0
		[ChartList] // 0x0000000180225B30-0x0000000180225BC0
		public List<ChartDef> modelLists; // 0x18

		// Constructors
		public Expansion(); // 0x00000001807AE000-0x00000001807AE060
	}

	[Serializable]
	public class HouseNaming // TypeDefIndex: 12093
	{
		// Fields
		[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
		[ChartString] // 0x0000000180203CA0-0x0000000180203CD0
		public List<string> exteriorInteriorFloor; // 0x10
		[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
		[ChartString] // 0x0000000180203CA0-0x0000000180203CD0
		public List<string> exteriorInteriorWall; // 0x18

		// Constructors
		public HouseNaming(); // 0x00000001807AE060-0x00000001807AE0E0
	}

	[Serializable]
	public class EntryPortal // TypeDefIndex: 12094
	{
		// Fields
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 localPosition; // 0x10
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 localScale; // 0x1C
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 safeSpawnPosition; // 0x28
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 safeSpawnRotation; // 0x34

		// Constructors
		public EntryPortal(); // 0x00000001807ADF10-0x00000001807AE000
	}

	[Serializable]
	public class TwiggleBuildLocation // TypeDefIndex: 12095
	{
		// Fields
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 position; // 0x10
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 rotation; // 0x1C

		// Constructors
		public TwiggleBuildLocation(); // 0x00000001807B8600-0x00000001807B8690
	}

	// Constructors
	public SanctuaryHouseDefComponent(); // 0x00000001807B6590-0x00000001807B68E0

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x00000001803774A0-0x00000001803774B0
}

