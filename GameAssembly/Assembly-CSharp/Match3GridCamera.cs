/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x0000000180163B00-0x0000000180163B50
public class Match3GridCamera : MonoBehaviour // TypeDefIndex: 12979
{
	// Fields
	public float minPadding; // 0x20
	public float horizontalPadding; // 0x24
	public Vector3 cameraOffset; // 0x28
	private Camera _camera; // 0x38
	private Match3Grid _grid; // 0x40

	// Properties
	public Camera Camera { get; } // 0x0000000180369BB0-0x0000000180369BC0 

	// Constructors
	public Match3GridCamera(); // 0x00000001816CD520-0x00000001816CD540

	// Methods
	private void Awake(); // 0x00000001816CD200-0x00000001816CD240
	private void Update(); // 0x00000001803581E0-0x00000001803581F0
	public void SetTargetGrid(Match3Grid inGrid); // 0x00000001816CD240-0x00000001816CD520
}

