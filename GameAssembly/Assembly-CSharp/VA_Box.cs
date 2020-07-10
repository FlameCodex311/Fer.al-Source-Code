/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x000000018010F530-0x000000018010F570
[ExecuteInEditMode] // 0x000000018010F530-0x000000018010F570
public class VA_Box : VA_VolumetricShape // TypeDefIndex: 13249
{
	// Fields
	[Tooltip] // 0x000000018010F830-0x000000018010F860
	public BoxCollider BoxCollider; // 0x50
	[Tooltip] // 0x000000018010FB00-0x000000018010FB30
	public Vector3 Center; // 0x58
	[Tooltip] // 0x000000018010FCC0-0x000000018010FCF0
	public Vector3 Size; // 0x64

	// Constructors
	public VA_Box(); // 0x0000000181222AA0-0x0000000181222B10

	// Methods
	public Matrix4x4 GetMatrix(); // 0x0000000181221F50-0x00000001812222F0
	protected virtual void Reset(); // 0x00000001812227E0-0x0000000181222820
	protected override void LateUpdate(); // 0x00000001812222F0-0x0000000181222770
	private void UpdateFields(); // 0x00000001812229E0-0x0000000181222AA0
	private bool LocalPointInBox(Vector3 localPoint); // 0x0000000181222770-0x00000001812227E0
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x0000000181222820-0x00000001812229E0
	private Vector3 ClipLocalPoint(Vector3 localPoint); // 0x0000000181221EA0-0x0000000181221F50
}

