/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[SelectionBase] // 0x00000001800B36B0-0x00000001800B36C0
public class Match3Cell : MonoBehaviour // TypeDefIndex: 12951
{
	// Fields
	public Vector2Int cellPos; // 0x20
	public List<GameObject> gridMarkers; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3Tile <Tile>k__BackingField; // 0x30
	private Dictionary<Match3CellConnection, List<Match3Cell>> _connections; // 0x38

	// Properties
	public Match3Tile Tile { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	public Match3TileType TileType { get; } // 0x00000001812E3790-0x00000001812E37A0 
	public Match3Cell North { get; } // 0x00000001816C18F0-0x00000001816C1950 
	public Match3Cell East { get; } // 0x00000001816C1890-0x00000001816C18F0 
	public Match3Cell South { get; } // 0x00000001816C1950-0x00000001816C19B0 
	public Match3Cell West { get; } // 0x00000001816C19B0-0x00000001816C1A10 

	// Constructors
	public Match3Cell(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x00000001816BF060-0x00000001816BF0C0
	private void OnDestroy(); // 0x00000001816BF5C0-0x00000001816BF670
	public List<Match3Cell> GetCellConnection(Match3CellConnection inConnection); // 0x00000001816BF2D0-0x00000001816BF350
	private void SetCellConnection(Match3CellConnection inConnection, List<Match3Cell> connectedList); // 0x00000001816BF670-0x00000001816BF720
	private void SetupCellConnectionWithGrid(Match3CellConnection inConnection, Match3Grid inGrid); // 0x00000001816BF890-0x00000001816C1710
	public void SetupAllCellConnections(Match3Grid inGrid); // 0x00000001816BF760-0x00000001816BF890
	public bool CanBeSwapped(); // 0x00000001816BF0C0-0x00000001816BF150
	public bool CanMatch(bool ignoreCellTileDistance = false /* Metadata: 0x0078348F */); // 0x00000001816BF150-0x00000001816BF2D0
	public void OnCellMatched(bool attackNeighbors = true /* Metadata: 0x00783490 */, bool clearedByPeacock = false /* Metadata: 0x00783491 */); // 0x00000001816BF3F0-0x00000001816BF5C0
	public void OnCellAttacked(); // 0x00000001816BF350-0x00000001816BF3F0
	public void SetCellPos(int x, int y); // 0x00000001816BF720-0x00000001816BF760
	private void SetupGridMarkings(); // 0x00000001816C1710-0x00000001816C1890
}

