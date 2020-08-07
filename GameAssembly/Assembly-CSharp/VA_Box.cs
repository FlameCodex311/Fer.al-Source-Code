/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801E7760-0x00000001801E77A0
[ExecuteInEditMode] // 0x00000001801E7760-0x00000001801E77A0
public class VA_Box : VA_VolumetricShape // TypeDefIndex: 10915
{
	// Fields
	[Tooltip] // 0x00000001801E8D40-0x00000001801E8D70
	public BoxCollider BoxCollider; // 0x50
	[Tooltip] // 0x00000001801E8F40-0x00000001801E8F70
	public Vector3 Center; // 0x58
	[Tooltip] // 0x00000001801E91C0-0x00000001801E91F0
	public Vector3 Size; // 0x64

	// Constructors
	public VA_Box(); // 0x000000018066E860-0x000000018066E8D0

	// Methods
	public Matrix4x4 GetMatrix(); // 0x000000018066DD20-0x000000018066E0B0
	protected virtual void Reset(); // 0x000000018066E5A0-0x000000018066E5E0
	protected override void LateUpdate(); // 0x000000018066E0B0-0x000000018066E530
	private void UpdateFields(); // 0x000000018066E7A0-0x000000018066E860
	private bool LocalPointInBox(Vector3 localPoint); // 0x000000018066E530-0x000000018066E5A0
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x000000018066E5E0-0x000000018066E7A0
	private Vector3 ClipLocalPoint(Vector3 localPoint); // 0x000000018066DC70-0x000000018066DD20
}

