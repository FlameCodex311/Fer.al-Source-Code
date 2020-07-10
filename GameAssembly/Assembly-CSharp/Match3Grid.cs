/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3Grid : MonoBehaviour // TypeDefIndex: 12978
{
	// Fields
	public Match3Cell cellPrefab; // 0x20
	public Match3Tile tilePrefab; // 0x28
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public Vector2Int gridSize; // 0x30
	public float cellSpacing; // 0x38
	private Match3Cell[,] cells; // 0x40

	// Constructors
	public Match3Grid(); // 0x00000001816CE110-0x00000001816CE120

	// Methods
	public void BuildGrid(); // 0x00000001816CD6A0-0x00000001816CD750
	public void ClearGrid(); // 0x00000001816CD750-0x00000001816CD890
	private void InitializeCells(); // 0x00000001816CDC60-0x00000001816CDEB0
	private void SetupCellNeighbors(); // 0x00000001816CDF70-0x00000001816CE020
	public Match3Cell GetCell(Vector2Int inCellPos); // 0x00000001816CD930-0x00000001816CD980
	public Match3Cell GetCell(int x, int y); // 0x00000001816CD890-0x00000001816CD930
	public Vector2Int WorldPosToGridPos(Vector3 inWorldPos); // 0x00000001816CE020-0x00000001816CE110
	public Vector3 GridPosToWorldPos(Vector2Int inGridPos); // 0x00000001816CDB80-0x00000001816CDC60
	public Vector3 GridPosToLocalPos(Vector2Int inGridPos); // 0x00000001816CDAF0-0x00000001816CDB80
	public Vector2Int LocalPosToGridPos(Vector3 inLocalPos); // 0x00000001816CDEB0-0x00000001816CDF70
	public Vector3 GetCenterPosition(); // 0x00000001816CD980-0x00000001816CDAF0
}

