/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyGridManager : MonoBehaviour // TypeDefIndex: 12807
{
	// Fields
	public BuildersFollyGridSpot gridSpot; // 0x20
	internal float gridStart_X; // 0x28
	internal float gridStart_Z; // 0x2C
	internal float gridSize; // 0x30
	internal BuildersFollyGridSpot[,] gridSpots_center; // 0x38
	internal BuildersFollyGridSpot[,] gridSpots_corner; // 0x40
	internal BuildersFollyGridSpot[,] gridSpots_vSide; // 0x48
	internal BuildersFollyGridSpot[,] gridSpots_hSide; // 0x50
	private float _currentRowPos; // 0x58
	private float _currentColPos; // 0x5C
	private float _gridPosZ_row; // 0x60
	private float _gridPosX_col; // 0x64
	private List<GameObject> _buildersFollyGridSpots; // 0x68
	private BuildersFollyLevel_Scriptable _currentLevelData; // 0x70
	private BuildersFollyTileManager _tileManager; // 0x78
	private BuildersFollyGame _game; // 0x80

	// Constructors
	public BuildersFollyGridManager(); // 0x00000001814DD2A0-0x00000001814DD320

	// Methods
	private void Start(); // 0x00000001814DD240-0x00000001814DD2A0
	public void SetupGrid(); // 0x00000001814DABE0-0x00000001814DB0C0
	internal void SetupGrids(); // 0x00000001814DB0C0-0x00000001814DD240
	private void AdjustMats(List<BuildersFollyFixedTile> inTiles); // 0x00000001814D9A90-0x00000001814D9B30
	private void EdgeChq(BuildersFollyFixedTile inTile); // 0x00000001814D9C00-0x00000001814DA000
	private BuildersFollyInputManager.EDir GetDir(BuildersFollyGridSpot inSpot1, BuildersFollyGridSpot inSpot2); // 0x00000001814DA000-0x00000001814DA090
	internal void SetTileGridSpots(BuildersFollyTile inSelectedTile); // 0x00000001814DA540-0x00000001814DABE0
	internal void ClearGrid(); // 0x00000001814D9B30-0x00000001814D9C00
	internal void ResetGrid(BuildersFollyLevel_Scriptable inLevelData); // 0x00000001814DA090-0x00000001814DA540
}

