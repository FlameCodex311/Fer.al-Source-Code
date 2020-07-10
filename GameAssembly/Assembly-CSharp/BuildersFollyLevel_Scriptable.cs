/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyLevel_Scriptable : ScriptableObject // TypeDefIndex: 12815
{
	// Fields
	[Header] // 0x000000018012A0E0-0x000000018012A110
	public string levelName; // 0x18
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public int tierPoints1; // 0x20
	public int tierPoints2; // 0x24
	public int tierPoints3; // 0x28
	public BuildersFollyData.EGridSizes gridSize; // 0x2C
	[Header] // 0x000000018012A5E0-0x000000018012A610
	public BuildersFollyGoal[] goals; // 0x30
	[Header] // 0x000000018012A750-0x000000018012A780
	public int numberOfCutStations; // 0x38
	public int numberOfSewStations; // 0x3C
	public int numberOfBuildStations; // 0x40
	public int numberOfKilnStations; // 0x44
	public int numberOfDyeStations; // 0x48
	[NonSerialized]
	internal int gridXsize; // 0x4C
	internal int gridZsize; // 0x50
	internal int levelIndex; // 0x54
	public ResourceInfo[] resourceInfos; // 0x58
	public FixedTileInfo[] fixedTileInfos; // 0x60
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public RowInfo[] RowsInfo_CenterGrid; // 0x68
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public RowInfo[] RowsInfo_CornerGrid; // 0x70
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public RowInfo[] RowsInfo_vSideGrid; // 0x78
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public RowInfo[] RowsInfo_hSideGrid; // 0x80
	[NonSerialized]
	internal ObscuredInt highScore; // 0x88
	[NonSerialized]
	internal bool isUnlocked; // 0x9C

	// Nested types
	[Serializable]
	public class BuildersFollyGoal // TypeDefIndex: 12816
	{
		// Fields
		public BuildersFollyResource goalResource; // 0x10
		public int goalPoints; // 0x18
		public BuildersFollyResource.EResourceColor dyeColor; // 0x1C
		[NonSerialized]
		internal ObscuredInt oldPoints; // 0x20
		[NonSerialized]
		internal ObscuredInt newpoints; // 0x34

		// Constructors
		public BuildersFollyGoal(); // 0x00000001814D9A30-0x00000001814D9A90
	}

	[Serializable]
	public class BuildersFollyRewardTree // TypeDefIndex: 12817
	{
		// Fields
		public int tier2commonPercentages; // 0x10
		public int tier2uncommonPercentages; // 0x14
		public int tier3commonPercentages; // 0x18
		public int tier3uncommonPercentages; // 0x1C
		public int tier3rare; // 0x20
		public BuildersFollyRewardTree_Scriptable[] rewardTrees; // 0x28

		// Constructors
		public BuildersFollyRewardTree(); // 0x00000001814ECEB0-0x00000001814ECEE0
	}

	[Serializable]
	public class RowInfo // TypeDefIndex: 12818
	{
		// Fields
		public int[] columnsInfo; // 0x10
		public int[] rotationInfo; // 0x18

		// Constructors
		public RowInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class ResourceInfo // TypeDefIndex: 12819
	{
		// Fields
		public BuildersFollyResource resource; // 0x10
		public int startAmount; // 0x18
		public int gridXspot; // 0x1C
		public int gridZspot; // 0x20

		// Constructors
		public ResourceInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class FixedTileInfo // TypeDefIndex: 12820
	{
		// Fields
		public int gridXspot; // 0x10
		public int gridZspot; // 0x14
		public bool turnOffTopMat; // 0x18
		public bool turnOffBottomMat; // 0x19
		public bool turnOffLeftMat; // 0x1A
		public bool turnOffRightMat; // 0x1B

		// Constructors
		public FixedTileInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public BuildersFollyLevel_Scriptable(); // 0x00000001814EA770-0x00000001814EA7F0

	// Methods
	internal int GetStarCount(); // 0x00000001814EA620-0x00000001814EA770
}

