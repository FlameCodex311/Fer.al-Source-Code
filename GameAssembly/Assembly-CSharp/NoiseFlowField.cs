/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NoiseFlowField : MonoBehaviour // TypeDefIndex: 11445
{
	// Fields
	private FastNoise _fastNoise; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3Int _gridSize; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _increment; // 0x34
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _offset; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _offsetSpeed; // 0x44

	// Constructors
	public NoiseFlowField(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001803774A0-0x00000001803774B0
	private void Update(); // 0x00000001803774A0-0x00000001803774B0
	private void OnDrawGizmos(); // 0x0000000180802130-0x0000000180802480
}

