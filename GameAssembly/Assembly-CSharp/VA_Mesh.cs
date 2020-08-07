/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801EA4F0-0x00000001801EA530
[ExecuteInEditMode] // 0x00000001801EA4F0-0x00000001801EA530
public class VA_Mesh : VA_VolumetricShape // TypeDefIndex: 10917
{
	// Fields
	[Tooltip] // 0x00000001801E8D40-0x00000001801E8D70
	public MeshCollider MeshCollider; // 0x50
	[Tooltip] // 0x00000001801E8D40-0x00000001801E8D70
	public MeshFilter MeshFilter; // 0x58
	[Tooltip] // 0x00000001801EAAB0-0x00000001801EAAE0
	public Mesh Mesh; // 0x60
	[Tooltip] // 0x00000001801EAD50-0x00000001801EAD80
	public float RaySeparation; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private VA_MeshTree tree; // 0x70

	// Properties
	public bool IsBaked { get; } // 0x0000000180675160-0x00000001806751C0 

	// Constructors
	public VA_Mesh(); // 0x0000000180675100-0x0000000180675160

	// Methods
	public void ClearBake(); // 0x00000001806741F0-0x0000000180674260
	public void Bake(); // 0x0000000180674070-0x00000001806741F0
	protected virtual void Reset(); // 0x0000000180674ED0-0x0000000180674F30
	protected override void LateUpdate(); // 0x0000000180674350-0x0000000180674830
	private Vector3 FindClosestLocalPoint(Vector3 localPoint); // 0x0000000180674260-0x0000000180674350
	private void UpdateFields(); // 0x0000000180675020-0x0000000180675100
	private int RaycastHitCount(Vector3 origin, Vector3 direction, float separation); // 0x0000000180674990-0x0000000180674ED0
	private bool LocalPointInMesh(Vector3 localPoint, Vector3 worldPoint); // 0x0000000180674830-0x0000000180674990
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x0000000180674F30-0x0000000180675020
}

