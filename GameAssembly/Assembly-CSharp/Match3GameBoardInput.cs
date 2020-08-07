/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3GameBoardInput : MonoBehaviour // TypeDefIndex: 10641
{
	// Fields
	public Match3GameBoard gameBoard; // 0x20
	public Camera gameBoardCamera; // 0x28
	public LayerMask touchMask; // 0x30
	public float dragThreshold; // 0x34
	public float tapThreshold; // 0x38
	private Match3Cell startTouchCell; // 0x40
	private Vector2 startTouchPos; // 0x48
	private float touchTimer; // 0x50

	// Constructors
	public Match3GameBoardInput(); // 0x00000001807DC1B0-0x00000001807DC1D0

	// Methods
	private void Update(); // 0x00000001807DBAD0-0x00000001807DC1B0
}

