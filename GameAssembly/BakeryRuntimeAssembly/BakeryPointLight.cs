/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

[DisallowMultipleComponent] // 0x00000001800B4050-0x00000001800B4080
[ExecuteInEditMode] // 0x00000001800B4050-0x00000001800B4080
public class BakeryPointLight : UnityEngine.MonoBehaviour // TypeDefIndex: 8968
{
	// Fields
	public int UID; // 0x18
	public Color color; // 0x1C
	public float intensity; // 0x2C
	public float shadowSpread; // 0x30
	public float cutoff; // 0x34
	public bool realisticFalloff; // 0x38
	public int samples; // 0x3C
	public ftLightProjectionMode projMode; // 0x40
	public Texture2D cookie; // 0x48
	public float angle; // 0x50
	public Cubemap cubemap; // 0x58
	public UnityEngine.Object iesFile; // 0x60
	public int bitmask; // 0x68
	public bool bakeToIndirect; // 0x6C
	public bool shadowmask; // 0x6D
	public float indirectIntensity; // 0x70

	// Nested types
	public enum ftLightProjectionMode // TypeDefIndex: 8969
	{
		Omni = 0,
		Cookie = 1,
		Cubemap = 2,
		IES = 3
	}

	// Constructors
	public BakeryPointLight(); // 0x00000001822BDA90-0x00000001822BDAF0
}

