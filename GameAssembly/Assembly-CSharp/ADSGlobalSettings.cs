/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Boxophobic;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ADSGlobalSettings : MonoBehaviour // TypeDefIndex: 13776
{
	// Fields
	[BCategory] // 0x000000018010A940-0x000000018010A970
	public int category_Update; // 0x20
	public UpdateMode realtimeUpdate; // 0x24
	[BCategory] // 0x000000018010B1B0-0x000000018010B1E0
	public int category_Globals; // 0x28
	public Texture2D globalTexture; // 0x30
	public Vector4 globalSizeCenter; // 0x38
	[Space] // 0x000000018010B2E0-0x000000018010B300
	public GlobalSettingEnum globalSettings; // 0x48
	[BCategory] // 0x000000018010B3B0-0x000000018010B3E0
	public int category_Simple; // 0x4C
	[BInteractive] // 0x000000018010B520-0x000000018010B540
	public int InteractiveGlobalsSimple; // 0x50
	[Range] // 0x000000018010B540-0x000000018010B560
	public float globalTintIntensity; // 0x54
	public Color globalTintColorOne; // 0x58
	public Color globalTintColorTwo; // 0x68
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float globalLeavesAmount; // 0x78
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float globalLeavesVar; // 0x7C
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float globalSizeMin; // 0x80
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float globalSizeMax; // 0x84
	[BCategory] // 0x000000018010BBD0-0x000000018010BC00
	public int category_Seasons; // 0x88
	[BInteractive] // 0x000000018010B520-0x000000018010B540
	public int InteractiveGlobalsSeasons; // 0x8C
	[BRangeOptions] // 0x000000018010BE10-0x000000018010BED0
	public float season; // 0x90
	[Range] // 0x000000018010C2C0-0x000000018010C300
	[Space] // 0x000000018010C2C0-0x000000018010C300
	public float winterTintIntensity; // 0x94
	public Color winterTintColorOne; // 0x98
	public Color winterTintColorTwo; // 0xA8
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float winterLeavesAmount; // 0xB8
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float winterLeavesVar; // 0xBC
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float winterSizeMin; // 0xC0
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float winterSizeMax; // 0xC4
	[Range] // 0x000000018010C2C0-0x000000018010C300
	[Space] // 0x000000018010C2C0-0x000000018010C300
	public float springTintIntensity; // 0xC8
	public Color springTintColorOne; // 0xCC
	public Color springTintColorTwo; // 0xDC
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float springLeavesAmount; // 0xEC
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float springLeavesVar; // 0xF0
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float springSizeMin; // 0xF4
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float springSizeMax; // 0xF8
	[Range] // 0x000000018010C2C0-0x000000018010C300
	[Space] // 0x000000018010C2C0-0x000000018010C300
	public float summerTintIntensity; // 0xFC
	public Color summerTintColorOne; // 0x100
	public Color summerTintColorTwo; // 0x110
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float summerLeavesAmount; // 0x120
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float summerLeavesVar; // 0x124
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float summerSizeMin; // 0x128
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float summerSizeMax; // 0x12C
	[Range] // 0x000000018010C2C0-0x000000018010C300
	[Space] // 0x000000018010C2C0-0x000000018010C300
	public float autumnTintIntensity; // 0x130
	public Color autumnTintColorOne; // 0x134
	public Color autumnTintColorTwo; // 0x144
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float autumnLeavesAmount; // 0x154
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float autumnLeavesVar; // 0x158
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float autumnSizeMin; // 0x15C
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float autumnSizeMax; // 0x160

	// Nested types
	public enum UpdateMode // TypeDefIndex: 13777
	{
		Off = 0,
		On = 1
	}

	public enum GlobalSettingEnum // TypeDefIndex: 13778
	{
		Simple = 0,
		Seasons = 1
	}

	// Constructors
	public ADSGlobalSettings(); // 0x000000018122EB10-0x000000018122ED10

	// Methods
	private void Start(); // 0x000000018122EAA0-0x000000018122EB00
	private void Update(); // 0x000000018122EB00-0x000000018122EB10
	private void SetGlobalShaderProperties(); // 0x000000018122E0D0-0x000000018122EAA0
}

