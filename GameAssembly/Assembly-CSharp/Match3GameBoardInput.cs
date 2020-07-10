/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3GameBoardInput : MonoBehaviour // TypeDefIndex: 12976
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
	public Match3GameBoardInput(); // 0x00000001816C2D10-0x00000001816C2D30

	// Methods
	private void Update(); // 0x00000001816C23B0-0x00000001816C2D10
}

