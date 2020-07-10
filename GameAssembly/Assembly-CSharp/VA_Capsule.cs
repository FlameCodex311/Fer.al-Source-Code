/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x000000018010FEE0-0x000000018010FF20
[ExecuteInEditMode] // 0x000000018010FEE0-0x000000018010FF20
public class VA_Capsule : VA_VolumetricShape // TypeDefIndex: 13250
{
	// Fields
	[Tooltip] // 0x000000018010F830-0x000000018010F860
	public CapsuleCollider CapsuleCollider; // 0x50
	[Tooltip] // 0x0000000180110310-0x0000000180110340
	public Vector3 Center; // 0x58
	[Tooltip] // 0x00000001801105B0-0x00000001801105E0
	public float Radius; // 0x64
	[Tooltip] // 0x00000001801107C0-0x00000001801107F0
	public float Height; // 0x68
	[Tooltip] // 0x0000000180110A20-0x0000000180110AD0
	[VA_Popup] // 0x0000000180110A20-0x0000000180110AD0
	public int Direction; // 0x6C
	private static Matrix4x4 RotationX; // 0x00
	private static Matrix4x4 RotationY; // 0x40
	private static Matrix4x4 RotationZ; // 0x80

	// Constructors
	public VA_Capsule(); // 0x0000000181223AF0-0x0000000181223B10
	static VA_Capsule(); // 0x0000000181223890-0x0000000181223AF0

	// Methods
	public Matrix4x4 GetMatrix(); // 0x0000000181222B10-0x0000000181222FD0
	protected virtual void Reset(); // 0x0000000181223510-0x0000000181223550
	protected override void LateUpdate(); // 0x0000000181222FD0-0x0000000181223490
	private void UpdateFields(); // 0x00000001812237A0-0x0000000181223890
	private bool LocalPointInCapsule(Vector3 localPoint, float halfHeight); // 0x0000000181223490-0x0000000181223510
	private Vector3 SnapLocalPoint(Vector3 localPoint, float halfHeight); // 0x0000000181223550-0x00000001812237A0
}

