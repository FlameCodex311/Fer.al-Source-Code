/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyTileManager : MonoBehaviour // TypeDefIndex: 12833
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
	public BuildersFollyTileManager(); // 0x00000001813C8D90-0x00000001813C8E80

	// Methods
	private void Start(); // 0x00000001813C88F0-0x00000001813C8950
	internal void AddTile(BuildersFollyTile inTile); // 0x00000001813C3270-0x00000001813C38F0
	internal void RemoveTile(BuildersFollyTile inTile, float inWaitTime = 0f /* Metadata: 0x0078326A */); // 0x00000001813C7910-0x00000001813C7FB0
	public void SetPathOnlyMaxValues(int inXmax, int inZmax); // 0x00000001813C87A0-0x00000001813C8810
	public bool CheckTilesPlacement(); // 0x00000001813C3DB0-0x00000001813C4680
	private bool MatNearSawTile(BuildersFollyTile inCheckTile); // 0x00000001813C7150-0x00000001813C7610
	internal void LayerChq(BuildersFollyTile inTile); // 0x00000001813C6030-0x00000001813C6230
	internal void CanPlayChq(); // 0x00000001813C38F0-0x00000001813C3DB0
	internal void RemoveConnectedPathsAmounts(BuildersFollyResourceTile inResourceTile); // 0x00000001813C76F0-0x00000001813C7910
	internal void SetPathTrapped(int inGridXspot, int inGridZspot); // 0x00000001813C8810-0x00000001813C88F0
	internal bool SawTrapChq(BuildersFollyTwiggle inTwiggle); // 0x00000001813C8390-0x00000001813C87A0
	internal BuildersFollyTile FindPreviousStation(BuildersFollyStationTile inSelectedStationTile, int inIndex = 0 /* Metadata: 0x0078326E */); // 0x00000001813C5400-0x00000001813C5BF0
	internal BuildersFollyTile FindPreviousStationTile(BuildersFollyTile inTile, Vector3 inPos, int inIndex); // 0x00000001813C49A0-0x00000001813C5400
	internal void UpdateSawsMove(); // 0x00000001813C8B20-0x00000001813C8D90
	internal void UpdateSawUnitMove(); // 0x00000001813C8950-0x00000001813C8B20
	internal bool PointChq(Vector3 inPoint1, Vector3 inPoint2, float inAdjustment = 1f /* Metadata: 0x00783272 */); // 0x00000001813C7610-0x00000001813C76F0
	internal void LoadTile(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyGridSpot[,] inGridSpots, int inRow, int inCol); // 0x00000001813C6230-0x00000001813C7150
	internal void RotateTile(BuildersFollyTile inTile, int inRotateTimes); // 0x00000001813C8120-0x00000001813C8390
	internal void FlipTile(BuildersFollyTile inTile, bool inHorizontal); // 0x00000001813C5BF0-0x00000001813C6030
	internal void ClearTiles(bool inClearAll = true /* Metadata: 0x00783276 */); // 0x00000001813C4680-0x00000001813C49A0
	internal void ResetTraps(); // 0x00000001813C7FB0-0x00000001813C8120
}

