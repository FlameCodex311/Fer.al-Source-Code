/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 76: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9124-9142

[DisallowMultipleComponent] // 0x00000001801CDDD0-0x00000001801CDE00
[ExecuteInEditMode] // 0x00000001801CDDD0-0x00000001801CDE00
public class BakeryLightMesh : UnityEngine.MonoBehaviour // TypeDefIndex: 9126
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
	public BakeryLightMesh(); // 0x00000001820B99C0-0x00000001820B9A30
	static BakeryLightMesh(); // 0x00000001820B9960-0x00000001820B99C0

	// Methods
	private void OnDrawGizmosSelected(); // 0x00000001820B9820-0x00000001820B9960
}

