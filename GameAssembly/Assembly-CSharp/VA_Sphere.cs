/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x0000000180111D70-0x0000000180111DB0
[ExecuteInEditMode] // 0x0000000180111D70-0x0000000180111DB0
public class VA_Sphere : VA_VolumetricShape // TypeDefIndex: 13254
{
	// Fields
	[Tooltip] // 0x000000018010F830-0x000000018010F860
	public SphereCollider SphereCollider; // 0x50
	[Tooltip] // 0x0000000180112130-0x0000000180112160
	public Vector3 Center; // 0x58
	[Tooltip] // 0x00000001801122D0-0x0000000180112300
	public float Radius; // 0x64

	// Constructors
	public VA_Sphere(); // 0x0000000181132210-0x0000000181132220

	// Methods
	public Matrix4x4 GetMatrix(); // 0x00000001811315F0-0x0000000181131910
	protected virtual void Reset(); // 0x0000000181132050-0x0000000181132090
	protected override void LateUpdate(); // 0x0000000181131910-0x0000000181132020
	private void UpdateFields(); // 0x0000000181132160-0x0000000181132210
	private bool LocalPointInSphere(Vector3 localPoint); // 0x0000000181132020-0x0000000181132050
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x0000000181132090-0x0000000181132160
}

