/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyPathManager // TypeDefIndex: 10479
{
	// Fields
	internal List<BuildersFollyData.BuildersFollyPath> paths; // 0x10
	private BuildersFollyTile _lastTile; // 0x18
	private Vector3 _lastPathPoint; // 0x20
	private Transform[] _chqPathPoints; // 0x30
	private float _halfGridDist; // 0x38
	private BuildersFollyTileManager _tileManager; // 0x40
	private List<BuildersFollyTile> _allTiles; // 0x48

	// Constructors
	public BuildersFollyPathManager(); // 0x0000000180AB2800-0x0000000180AB2860

	// Methods
	internal void SetupPaths(BuildersFollyTileManager inTileManager); // 0x0000000180AB2390-0x0000000180AB2440
	internal void MakePaths(); // 0x0000000180AB1E90-0x0000000180AB2390
	private List<BuildersFollyTile> GetSurroundingPathTiles(BuildersFollyResourceTile inBuildersFollyResourceTile); // 0x0000000180AB0590-0x0000000180AB0880
	internal bool IsPointClose(Vector3 inPoint1, Vector3 inPoint2); // 0x0000000180AB0880-0x0000000180AB0950
	private void MakePath(ref BuildersFollyData.BuildersFollyPath refPath, ref BuildersFollyData.BuildersFollyPath.PathPart refPathPart, BuildersFollyTile inFirstPathTile = null); // 0x0000000180AB0950-0x0000000180AB1E90
	private BuildersFollyGridSpot AddGridSpot(Vector3 inLastPathPoint, BuildersFollyGridSpot[] inGridSpots); // 0x0000000180AB0400-0x0000000180AB0590
	private void SynchPaths(); // 0x0000000180AB2440-0x0000000180AB2800
}

