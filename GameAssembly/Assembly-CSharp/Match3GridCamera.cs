/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180240A10-0x0000000180240A60
public class Match3GridCamera : MonoBehaviour // TypeDefIndex: 10644
{
	// Fields
	public float minPadding; // 0x20
	public float horizontalPadding; // 0x24
	public Vector3 cameraOffset; // 0x28
	private Camera _camera; // 0x38
	private Match3Grid _grid; // 0x40

	// Properties
	public Camera Camera { get; } // 0x00000001803743D0-0x00000001803743E0 

	// Constructors
	public Match3GridCamera(); // 0x00000001807DC4F0-0x00000001807DC510

	// Methods
	private void Awake(); // 0x00000001807DC1D0-0x00000001807DC210
	private void Update(); // 0x00000001803774A0-0x00000001803774B0
	public void SetTargetGrid(Match3Grid inGrid); // 0x00000001807DC210-0x00000001807DC4F0
}

