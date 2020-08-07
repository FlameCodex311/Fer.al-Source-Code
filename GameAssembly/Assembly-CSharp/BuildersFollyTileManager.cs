/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyTileManager : MonoBehaviour // TypeDefIndex: 10491
{
	// Fields
	public BuildersFollyTile[] tiles; // 0x20
	internal List<BuildersFollyTile> allTiles; // 0x28
	internal List<BuildersFollyResourceTile> resourceTiles; // 0x30
	internal List<BuildersFollyFixedTile> deliveryTiles; // 0x38
	internal List<BuildersFollyStationTile> stationTiles; // 0x40
	internal List<BuildersFollySawTrapTile> sawTrapTiles; // 0x48
	private float _halfGridDist; // 0x50
	private int _pathsOnlyXmax; // 0x54
	private int _pathsOnlyZmax; // 0x58
	private int _checkGridXspot; // 0x5C
	private int _checkGridZspot; // 0x60
	private BuildersFollyTile _checkTile1; // 0x68
	private BuildersFollyTile _checkTile2; // 0x70
	private BuildersFollyLevel_Scriptable _currentLevelData; // 0x78
	private BuildersFollyStationTile _startStation; // 0x80
	private BuildersFollyGame _game; // 0x88

	// Constructors
	public BuildersFollyTileManager(); // 0x0000000180AB8E70-0x0000000180AB8F60

	// Methods
	private void Start(); // 0x0000000180AB89F0-0x0000000180AB8A50
	internal void AddTile(BuildersFollyTile inTile); // 0x0000000180AB36B0-0x0000000180AB3CF0
	internal void RemoveTile(BuildersFollyTile inTile, float inWaitTime = 0f /* Metadata: 0x0077BD15 */); // 0x0000000180AB7A80-0x0000000180AB8100
	public void SetPathOnlyMaxValues(int inXmax, int inZmax); // 0x0000000180AB88B0-0x0000000180AB8910
	public bool CheckTilesPlacement(); // 0x0000000180AB4180-0x0000000180AB49E0
	private bool MatNearSawTile(BuildersFollyTile inCheckTile); // 0x0000000180AB7300-0x0000000180AB7790
	internal void LayerChq(BuildersFollyTile inTile); // 0x0000000180AB62B0-0x0000000180AB64A0
	internal void CanPlayChq(); // 0x0000000180AB3CF0-0x0000000180AB4180
	internal void RemoveConnectedPathsAmounts(BuildersFollyResourceTile inResourceTile); // 0x0000000180AB7870-0x0000000180AB7A80
	internal void SetPathTrapped(int inGridXspot, int inGridZspot); // 0x0000000180AB8910-0x0000000180AB89F0
	internal bool SawTrapChq(BuildersFollyTwiggle inTwiggle); // 0x0000000180AB84D0-0x0000000180AB88B0
	internal BuildersFollyTile FindPreviousStation(BuildersFollyStationTile inSelectedStationTile, int inIndex = 0 /* Metadata: 0x0077BD19 */); // 0x0000000180AB56F0-0x0000000180AB5E90
	internal BuildersFollyTile FindPreviousStationTile(BuildersFollyTile inTile, Vector3 inPos, int inIndex); // 0x0000000180AB4CF0-0x0000000180AB56F0
	internal void UpdateSawsMove(); // 0x0000000180AB8C10-0x0000000180AB8E70
	internal void UpdateSawUnitMove(); // 0x0000000180AB8A50-0x0000000180AB8C10
	internal bool PointChq(Vector3 inPoint1, Vector3 inPoint2, float inAdjustment = 1f /* Metadata: 0x0077BD1D */); // 0x0000000180AB7790-0x0000000180AB7870
	internal void LoadTile(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyGridSpot[,] inGridSpots, int inRow, int inCol); // 0x0000000180AB64A0-0x0000000180AB7300
	internal void RotateTile(BuildersFollyTile inTile, int inRotateTimes); // 0x0000000180AB8270-0x0000000180AB84D0
	internal void FlipTile(BuildersFollyTile inTile, bool inHorizontal); // 0x0000000180AB5E90-0x0000000180AB62B0
	internal void ClearTiles(bool inClearAll = true /* Metadata: 0x0077BD21 */); // 0x0000000180AB49E0-0x0000000180AB4CF0
	internal void ResetTraps(); // 0x0000000180AB8100-0x0000000180AB8270
}

