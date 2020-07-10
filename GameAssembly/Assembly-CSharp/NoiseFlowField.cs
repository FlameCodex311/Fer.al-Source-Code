/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NoiseFlowField : MonoBehaviour // TypeDefIndex: 13772
{
	// Fields
	private FastNoise _fastNoise; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3Int _gridSize; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _increment; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _offset; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _offsetSpeed; // 0x44

	// Constructors
	public NoiseFlowField(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001803581E0-0x00000001803581F0
	private void Update(); // 0x00000001803581E0-0x00000001803581F0
	private void OnDrawGizmos(); // 0x0000000180E94030-0x0000000180E94380
}

