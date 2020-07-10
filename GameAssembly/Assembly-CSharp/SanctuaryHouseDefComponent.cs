/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180140D70-0x0000000180140DA0
public class SanctuaryHouseDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 10590
{
	// Fields
	[ChartClass] // 0x00000001800B5960-0x00000001800B5970
	public HouseNaming houseNaming; // 0x18
	[ChartClass] // 0x00000001800B5960-0x00000001800B5970
	public EntryPortal entryPortal; // 0x20
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> baseExpansions; // 0x28
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> edgeExpansions; // 0x30
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> decorExpansions; // 0x38
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> shrubExpansions; // 0x40
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> doorExpansions; // 0x48
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> lightExpansions; // 0x50
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> roofExpansions; // 0x58
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<Expansion> windowExpansions; // 0x60
	[ChartDef] // 0x00000001801432E0-0x0000000180143370
	[ChartList] // 0x00000001801432E0-0x0000000180143370
	public List<ChartDef> expansions; // 0x68
	[ChartDef] // 0x0000000180143620-0x00000001801436B0
	[ChartList] // 0x0000000180143620-0x00000001801436B0
	public List<ChartDef> upgrades; // 0x70
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<TwiggleBuildLocation> twiggleBuildLocations; // 0x78
	[ChartBundle] // 0x00000001800B5960-0x00000001800B5970
	public ChartBundle layoutData; // 0x80

	// Nested types
	[Serializable]
	public class Expansion // TypeDefIndex: 10591
	{
		// Fields
		[ChartInt] // 0x00000001800B5960-0x00000001800B5970
		public int number; // 0x10
		[ChartDef] // 0x0000000180143C60-0x0000000180143CF0
		[ChartList] // 0x0000000180143C60-0x0000000180143CF0
		public List<ChartDef> modelLists; // 0x18

		// Constructors
		public Expansion(); // 0x0000000181285970-0x00000001812859D0
	}

	[Serializable]
	public class HouseNaming // TypeDefIndex: 10592
	{
		// Fields
		[ChartList] // 0x00000001800BF800-0x00000001800BF830
		[ChartString] // 0x00000001800BF800-0x00000001800BF830
		public List<string> exteriorInteriorFloor; // 0x10
		[ChartList] // 0x00000001800BF800-0x00000001800BF830
		[ChartString] // 0x00000001800BF800-0x00000001800BF830
		public List<string> exteriorInteriorWall; // 0x18

		// Constructors
		public HouseNaming(); // 0x00000001812859D0-0x0000000181285A50
	}

	[Serializable]
	public class EntryPortal // TypeDefIndex: 10593
	{
		// Fields
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 localPosition; // 0x10
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 localScale; // 0x1C
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 safeSpawnPosition; // 0x28
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 safeSpawnRotation; // 0x34

		// Constructors
		public EntryPortal(); // 0x0000000181285880-0x0000000181285970
	}

	[Serializable]
	public class TwiggleBuildLocation // TypeDefIndex: 10594
	{
		// Fields
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 position; // 0x10
		[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
		public Vector3 rotation; // 0x1C

		// Constructors
		public TwiggleBuildLocation(); // 0x0000000181293B00-0x0000000181293B90
	}

	// Constructors
	public SanctuaryHouseDefComponent(); // 0x000000018128C910-0x000000018128CC60

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x00000001803581E0-0x00000001803581F0
}

