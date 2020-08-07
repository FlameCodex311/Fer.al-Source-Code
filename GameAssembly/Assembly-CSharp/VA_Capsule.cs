/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801E93D0-0x00000001801E9410
[ExecuteInEditMode] // 0x00000001801E93D0-0x00000001801E9410
public class VA_Capsule : VA_VolumetricShape // TypeDefIndex: 10916
{
	// Fields
	[Tooltip] // 0x00000001801E8D40-0x00000001801E8D70
	public CapsuleCollider CapsuleCollider; // 0x50
	[Tooltip] // 0x00000001801E9760-0x00000001801E9790
	public Vector3 Center; // 0x58
	[Tooltip] // 0x00000001801E9950-0x00000001801E9980
	public float Radius; // 0x64
	[Tooltip] // 0x00000001801E9BC0-0x00000001801E9BF0
	public float Height; // 0x68
	[Tooltip] // 0x00000001801E9E40-0x00000001801E9EF0
	[VA_Popup] // 0x00000001801E9E40-0x00000001801E9EF0
	public int Direction; // 0x6C
	private static Matrix4x4 RotationX; // 0x00
	private static Matrix4x4 RotationY; // 0x40
	private static Matrix4x4 RotationZ; // 0x80

	// Constructors
	public VA_Capsule(); // 0x000000018066F890-0x000000018066F8B0
	static VA_Capsule(); // 0x000000018066F630-0x000000018066F890

	// Methods
	public Matrix4x4 GetMatrix(); // 0x000000018066E8D0-0x000000018066ED80
	protected virtual void Reset(); // 0x000000018066F2C0-0x000000018066F300
	protected override void LateUpdate(); // 0x000000018066ED80-0x000000018066F240
	private void UpdateFields(); // 0x000000018066F550-0x000000018066F630
	private bool LocalPointInCapsule(Vector3 localPoint, float halfHeight); // 0x000000018066F240-0x000000018066F2C0
	private Vector3 SnapLocalPoint(Vector3 localPoint, float halfHeight); // 0x000000018066F300-0x000000018066F550
}

