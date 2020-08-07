/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3Grid : MonoBehaviour // TypeDefIndex: 10643
{
	// Fields
	public Match3Cell cellPrefab; // 0x20
	public Match3Tile tilePrefab; // 0x28
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public Vector2Int gridSize; // 0x30
	public float cellSpacing; // 0x38
	private Match3Cell[,] cells; // 0x40

	// Constructors
	public Match3Grid(); // 0x00000001807DD090-0x00000001807DD0A0

	// Methods
	public void BuildGrid(); // 0x00000001807DC660-0x00000001807DC710
	public void ClearGrid(); // 0x00000001807DC710-0x00000001807DC850
	private void InitializeCells(); // 0x00000001807DCC20-0x00000001807DCE30
	private void SetupCellNeighbors(); // 0x00000001807DCEF0-0x00000001807DCFA0
	public Match3Cell GetCell(Vector2Int inCellPos); // 0x00000001807DC8F0-0x00000001807DC940
	public Match3Cell GetCell(int x, int y); // 0x00000001807DC850-0x00000001807DC8F0
	public Vector2Int WorldPosToGridPos(Vector3 inWorldPos); // 0x00000001807DCFA0-0x00000001807DD090
	public Vector3 GridPosToWorldPos(Vector2Int inGridPos); // 0x00000001807DCB40-0x00000001807DCC20
	public Vector3 GridPosToLocalPos(Vector2Int inGridPos); // 0x00000001807DCAB0-0x00000001807DCB40
	public Vector2Int LocalPosToGridPos(Vector3 inLocalPos); // 0x00000001807DCE30-0x00000001807DCEF0
	public Vector3 GetCenterPosition(); // 0x00000001807DC940-0x00000001807DCAB0
}

