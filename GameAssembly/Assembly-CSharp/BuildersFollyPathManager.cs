/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyPathManager // TypeDefIndex: 12821
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
	public BuildersFollyPathManager(); // 0x00000001814ECD80-0x00000001814ECDE0

	// Methods
	internal void SetupPaths(BuildersFollyTileManager inTileManager); // 0x00000001814EC900-0x00000001814EC9B0
	internal void MakePaths(); // 0x00000001814EC3D0-0x00000001814EC900
	private List<BuildersFollyTile> GetSurroundingPathTiles(BuildersFollyResourceTile inBuildersFollyResourceTile); // 0x00000001814EA990-0x00000001814EACA0
	internal bool IsPointClose(Vector3 inPoint1, Vector3 inPoint2); // 0x00000001814EACA0-0x00000001814EAD70
	private void MakePath(ref BuildersFollyData.BuildersFollyPath refPath, ref BuildersFollyData.BuildersFollyPath.PathPart refPathPart, BuildersFollyTile inFirstPathTile = null); // 0x00000001814EAD70-0x00000001814EC3D0
	private BuildersFollyGridSpot AddGridSpot(Vector3 inLastPathPoint, BuildersFollyGridSpot[] inGridSpots); // 0x00000001814EA7F0-0x00000001814EA990
	private void SynchPaths(); // 0x00000001814EC9B0-0x00000001814ECD80
}

