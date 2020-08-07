/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyGridManager : MonoBehaviour // TypeDefIndex: 10465
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
	public BuildersFollyGridManager(); // 0x000000018213D620-0x000000018213D6A0

	// Methods
	private void Start(); // 0x000000018213D5C0-0x000000018213D620
	public void SetupGrid(); // 0x000000018213B130-0x000000018213B5D0
	internal void SetupGrids(); // 0x000000018213B5D0-0x000000018213D5C0
	private void AdjustMats(List<BuildersFollyFixedTile> inTiles); // 0x000000018213A070-0x000000018213A110
	private void EdgeChq(BuildersFollyFixedTile inTile); // 0x000000018213A1E0-0x000000018213A5C0
	private BuildersFollyInputManager.EDir GetDir(BuildersFollyGridSpot inSpot1, BuildersFollyGridSpot inSpot2); // 0x000000018213A5C0-0x000000018213A650
	internal void SetTileGridSpots(BuildersFollyTile inSelectedTile); // 0x000000018213AAD0-0x000000018213B130
	internal void ClearGrid(); // 0x000000018213A110-0x000000018213A1E0
	internal void ResetGrid(BuildersFollyLevel_Scriptable inLevelData); // 0x000000018213A650-0x000000018213AAD0
}

