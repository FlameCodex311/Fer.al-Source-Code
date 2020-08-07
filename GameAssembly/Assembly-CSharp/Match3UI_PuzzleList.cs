/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityAtoms;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_PuzzleList : MonoBehaviour // TypeDefIndex: 10679
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3PuzzleCollectionReference _puzzleCollection; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3UI_PuzzleItem _puzzleItemPrefab; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _puzzleItemParent; // 0x30
	private bool _isFirstSetup; // 0x38
	private List<Match3UI_PuzzleItem> _puzzleItems; // 0x40

	// Constructors
	public Match3UI_PuzzleList(); // 0x00000001807E7340-0x00000001807E73B0

	// Methods
	[DeMethodButton] // 0x00000001802521D0-0x0000000180252230
	public void Show(); // 0x00000001807E7130-0x00000001807E7200
	public void Hide(); // 0x00000001807E6CA0-0x00000001807E6D40
	private void Setup(); // 0x00000001807E6EA0-0x00000001807E7130
	private void SpawnPuzzleItems(); // 0x00000001807E7200-0x00000001807E7340
	private void SetupPuzzleItems(); // 0x00000001807E6D40-0x00000001807E6EA0
}

