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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_PuzzleList : MonoBehaviour // TypeDefIndex: 13014
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3PuzzleCollectionReference _puzzleCollection; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3UI_PuzzleItem _puzzleItemPrefab; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _puzzleItemParent; // 0x30
	private bool _isFirstSetup; // 0x38
	private List<Match3UI_PuzzleItem> _puzzleItems; // 0x40

	// Constructors
	public Match3UI_PuzzleList(); // 0x00000001810AABC0-0x00000001810AAC30

	// Methods
	[DeMethodButton] // 0x00000001800B7390-0x00000001800B73F0
	public void Show(); // 0x00000001810AA9A0-0x00000001810AAA70
	public void Hide(); // 0x00000001810AA500-0x00000001810AA5A0
	private void Setup(); // 0x00000001810AA700-0x00000001810AA9A0
	private void SpawnPuzzleItems(); // 0x00000001810AAA70-0x00000001810AABC0
	private void SetupPuzzleItems(); // 0x00000001810AA5A0-0x00000001810AA700
}

