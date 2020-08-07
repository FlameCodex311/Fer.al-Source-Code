/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[SelectionBase] // 0x00000001801CDAD0-0x00000001801CDAE0
public class Match3Cell : MonoBehaviour // TypeDefIndex: 10616
{
	// Fields
	public Vector2Int cellPos; // 0x20
	public List<GameObject> gridMarkers; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3Tile <Tile>k__BackingField; // 0x30
	private Dictionary<Match3CellConnection, List<Match3Cell>> _connections; // 0x38

	// Properties
	public Match3Tile Tile { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	public Match3TileType TileType { get; } // 0x00000001804FB160-0x00000001804FB170 
	public Match3Cell North { get; } // 0x00000001804FB0A0-0x00000001804FB100 
	public Match3Cell East { get; } // 0x00000001804FB040-0x00000001804FB0A0 
	public Match3Cell South { get; } // 0x00000001804FB100-0x00000001804FB160 
	public Match3Cell West { get; } // 0x00000001804FB170-0x00000001804FB1D0 

	// Constructors
	public Match3Cell(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001804F8890-0x00000001804F88F0
	private void OnDestroy(); // 0x00000001804F8DE0-0x00000001804F8E90
	public List<Match3Cell> GetCellConnection(Match3CellConnection inConnection); // 0x00000001804F8AF0-0x00000001804F8B70
	private void SetCellConnection(Match3CellConnection inConnection, List<Match3Cell> connectedList); // 0x00000001804F8E90-0x00000001804F8F40
	private void SetupCellConnectionWithGrid(Match3CellConnection inConnection, Match3Grid inGrid); // 0x00000001804F90B0-0x00000001804FAEC0
	public void SetupAllCellConnections(Match3Grid inGrid); // 0x00000001804F8F80-0x00000001804F90B0
	public bool CanBeSwapped(); // 0x00000001804F88F0-0x00000001804F8980
	public bool CanMatch(bool ignoreCellTileDistance = false /* Metadata: 0x0077BF4A */); // 0x00000001804F8980-0x00000001804F8AF0
	public void OnCellMatched(bool attackNeighbors = true /* Metadata: 0x0077BF4B */, bool clearedByPeacock = false /* Metadata: 0x0077BF4C */); // 0x00000001804F8C10-0x00000001804F8DE0
	public void OnCellAttacked(); // 0x00000001804F8B70-0x00000001804F8C10
	public void SetCellPos(int x, int y); // 0x00000001804F8F40-0x00000001804F8F80
	private void SetupGridMarkings(); // 0x00000001804FAEC0-0x00000001804FB040
}

