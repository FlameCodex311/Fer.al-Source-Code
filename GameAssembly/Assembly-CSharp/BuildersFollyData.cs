/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyData : MonoBehaviour // TypeDefIndex: 12784
{
	// Nested types
	public enum EGridSizes // TypeDefIndex: 12785
	{
		None = 0,
		_6X4 = 1,
		_6X8 = 2,
		_8X4 = 3,
		_10X8 = 4,
		_12X8 = 5,
		_8X8 = 6,
		_14X8 = 7,
		_6X6 = 8,
		_8X6 = 9
	}

	public enum EGridData // TypeDefIndex: 12786
	{
		None = 0,
		PathOnly = 1,
		Path = 2,
		Block = 3,
		Deliver = 4,
		Resource = 5,
		Station = 6
	}

	public enum ETileTypes // TypeDefIndex: 12787
	{
		None = 0,
		FixedBlock1 = 1,
		FixedBlock2 = 2,
		FixedDeliver = 3,
		FixedResource = 4,
		PathStraight = 5,
		PathCorner = 6,
		StationBuild = 7,
		StationKiln = 8,
		StationCut = 9,
		StationSew = 10,
		StationDye = 11,
		FixedBlock3 = 12,
		FixedStar = 13,
		PathTool = 14,
		FixedSawTrap2 = 15,
		FixedSawTrap3 = 16,
		FixedSawTrap4 = 17
	}

	public enum EStationType // TypeDefIndex: 12788
	{
		None = 0,
		Resource = 1,
		Cut = 2,
		Sew = 3,
		Build = 4,
		Kiln = 5,
		Dye = 6,
		Deliver = 7
	}

	public enum ETileGridPlacement // TypeDefIndex: 12789
	{
		Center = 0,
		Corner = 1,
		Side = 2
	}

	public enum ELevelCategory // TypeDefIndex: 12790
	{
		Furniture = 0,
		Ornaments = 1,
		SpecialAssignments = 2,
		Holidays = 3
	}

	internal class BuildersFollyPath // TypeDefIndex: 12791
	{
		// Fields
		internal List<Vector3> path; // 0x10
		internal List<BuildersFollyGridSpot> gridSpots; // 0x18
		internal List<Station> stations; // 0x20
		internal List<PathPart> pathParts; // 0x28

		// Nested types
		internal class PathPart // TypeDefIndex: 12792
		{
			// Fields
			internal List<BuildersFollyGridSpot> pathGridSpots; // 0x10

			// Constructors
			public PathPart(); // 0x000000018036B6C0-0x000000018036B6D0
		}

		// Constructors
		internal BuildersFollyPath(); // 0x00000001814ECDE0-0x00000001814ECEB0
	}

	internal class Station // TypeDefIndex: 12793
	{
		// Fields
		internal EPortState outputState; // 0x10
		internal EPortState[] inputState; // 0x18
		internal EStationType stationType; // 0x20
		internal Station[] inputStations; // 0x28
		internal Station outputStation; // 0x30
		internal BuildersFollyTwiggle outputTwiggle; // 0x38
		internal BuildersFollyTwiggle[] inputTwiggle; // 0x40
		internal BuildersFollyTile buildersFollyTile; // 0x48

		// Nested types
		internal enum EPortState // TypeDefIndex: 12794
		{
			Empty = 0,
			TwiggleWaiting = 1
		}

		// Constructors
		public Station(); // 0x000000018036B6C0-0x000000018036B6D0
		public Station(BuildersFollyTile inBuildersFollyResourceTile); // 0x00000001814ED070-0x00000001814ED160
		public Station(BuildersFollyResource inGoalResource, Station inOutputStation = null); // 0x00000001814ECEE0-0x00000001814ED070
	}

	[Serializable]
	public class BuildersFollyStationData // TypeDefIndex: 12795
	{
		// Fields
		public EStationType stationType; // 0x10
		public Sprite stationIcon; // 0x18
		public BuildersFollyResource[] resources; // 0x20

		// Constructors
		public BuildersFollyStationData(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class BuildersFollyCameraData // TypeDefIndex: 12796
	{
		// Fields
		public EGridSizes gridSize; // 0x10
		public Vector3 positionOverride; // 0x14
		public Vector3 rotationOverride; // 0x20
		public float worldCratesXoverride; // 0x2C

		// Constructors
		public BuildersFollyCameraData(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public BuildersFollyData(); // 0x0000000180E095D0-0x0000000180E095E0
}

