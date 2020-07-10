/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

[DisallowMultipleComponent] // 0x00000001800B4050-0x00000001800B4080
[ExecuteInEditMode] // 0x00000001800B4050-0x00000001800B4080
public class BakeryLightMesh : UnityEngine.MonoBehaviour // TypeDefIndex: 8967
{
	// Fields
	public int UID; // 0x18
	public static List<MeshFilter> All; // 0x00
	public Color color; // 0x1C
	public float intensity; // 0x2C
	public Texture2D texture; // 0x30
	public float cutoff; // 0x38
	public int samples; // 0x3C
	public int samples2; // 0x40
	public int bitmask; // 0x44
	public bool selfShadow; // 0x48
	public bool bakeToIndirect; // 0x49
	public float indirectIntensity; // 0x4C
	public int lmid; // 0x50

	// Constructors
	public BakeryLightMesh(); // 0x00000001822BD900-0x00000001822BD970
	static BakeryLightMesh(); // 0x00000001822BD8A0-0x00000001822BD900

	// Methods
	private void OnDrawGizmosSelected(); // 0x00000001822BD760-0x00000001822BD8A0
}

