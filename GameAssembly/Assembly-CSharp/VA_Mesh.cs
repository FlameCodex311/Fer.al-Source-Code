/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x00000001801111A0-0x00000001801111E0
[ExecuteInEditMode] // 0x00000001801111A0-0x00000001801111E0
public class VA_Mesh : VA_VolumetricShape // TypeDefIndex: 13251
{
	// Fields
	[Tooltip] // 0x000000018010F830-0x000000018010F860
	public MeshCollider MeshCollider; // 0x50
	[Tooltip] // 0x000000018010F830-0x000000018010F860
	public MeshFilter MeshFilter; // 0x58
	[Tooltip] // 0x0000000180111560-0x0000000180111590
	public Mesh Mesh; // 0x60
	[Tooltip] // 0x0000000180111730-0x0000000180111760
	public float RaySeparation; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private VA_MeshTree tree; // 0x70

	// Properties
	public bool IsBaked { get; } // 0x0000000181130F90-0x0000000181130FF0 

	// Constructors
	public VA_Mesh(); // 0x0000000181130F30-0x0000000181130F90

	// Methods
	public void ClearBake(); // 0x0000000181130010-0x0000000181130080
	public void Bake(); // 0x000000018112FE90-0x0000000181130010
	protected virtual void Reset(); // 0x0000000181130D00-0x0000000181130D60
	protected override void LateUpdate(); // 0x0000000181130170-0x0000000181130660
	private Vector3 FindClosestLocalPoint(Vector3 localPoint); // 0x0000000181130080-0x0000000181130170
	private void UpdateFields(); // 0x0000000181130E50-0x0000000181130F30
	private int RaycastHitCount(Vector3 origin, Vector3 direction, float separation); // 0x00000001811307C0-0x0000000181130D00
	private bool LocalPointInMesh(Vector3 localPoint, Vector3 worldPoint); // 0x0000000181130660-0x00000001811307C0
	private Vector3 SnapLocalPoint(Vector3 localPoint); // 0x0000000181130D60-0x0000000181130E50
}

