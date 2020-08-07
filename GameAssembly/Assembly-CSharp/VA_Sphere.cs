/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801EB530-0x00000001801EB570
[ExecuteInEditMode] // 0x00000001801EB530-0x00000001801EB570
public class VA_Sphere : VA_VolumetricShape // TypeDefIndex: 10920
{
	// Fields
	[Tooltip] // 0x00000001801E8D40-0x00000001801E8D70
	public SphereCollider SphereCollider; // 0x50
	[Tooltip] // 0x00000001801EBA00-0x00000001801EBA30
	public Vector3 Center; // 0x58
	[Tooltip] // 0x00000001801EBC30-0x00000001801EBC60
	public float Radius; // 0x64

	// Constructors
	public VA_Sphere(); // 0x00000001806761B0-0x00000001806761C0

	// Methods
	public Matrix4x4 GetMatrix(); // 0x00000001806757E0-0x0000000180675B30
	protected virtual void Reset(); // 0x0000000180675FF0-0x0000000180676030
	protected override void LateUpdate(); // 0x0000000180675B30-0x0000000180675FC0
	private void UpdateFields(); // 0x0000000180676100-0x00000001806761B0
	private bool LocalPointInSphere(Vector3 localPoint); // 0x0000000180675FC0-0x0000000180675FF0
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x0000000180676030-0x0000000180676100
}

