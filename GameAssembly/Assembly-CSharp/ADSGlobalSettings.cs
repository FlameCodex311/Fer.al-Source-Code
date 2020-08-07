/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Boxophobic;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ADSGlobalSettings : MonoBehaviour // TypeDefIndex: 11449
{
	// Fields
	[BCategory] // 0x00000001801E41B0-0x00000001801E41E0
	public int category_Update; // 0x20
	public UpdateMode realtimeUpdate; // 0x24
	[BCategory] // 0x00000001801E4F10-0x00000001801E4F40
	public int category_Globals; // 0x28
	public Texture2D globalTexture; // 0x30
	public Vector4 globalSizeCenter; // 0x38
	[Space] // 0x00000001801E50A0-0x00000001801E50C0
	public GlobalSettingEnum globalSettings; // 0x48
	[BCategory] // 0x00000001801E5240-0x00000001801E5270
	public int category_Simple; // 0x4C
	[BInteractive] // 0x00000001801E5540-0x00000001801E5560
	public int InteractiveGlobalsSimple; // 0x50
	[Range] // 0x00000001801E5720-0x00000001801E5740
	public float globalTintIntensity; // 0x54
	public Color globalTintColorOne; // 0x58
	public Color globalTintColorTwo; // 0x68
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float globalLeavesAmount; // 0x78
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float globalLeavesVar; // 0x7C
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float globalSizeMin; // 0x80
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float globalSizeMax; // 0x84
	[BCategory] // 0x00000001801E6120-0x00000001801E6150
	public int category_Seasons; // 0x88
	[BInteractive] // 0x00000001801E5540-0x00000001801E5560
	public int InteractiveGlobalsSeasons; // 0x8C
	[BRangeOptions] // 0x00000001801E6550-0x00000001801E6610
	public float season; // 0x90
	[Range] // 0x00000001801E6D60-0x00000001801E6DA0
	[Space] // 0x00000001801E6D60-0x00000001801E6DA0
	public float winterTintIntensity; // 0x94
	public Color winterTintColorOne; // 0x98
	public Color winterTintColorTwo; // 0xA8
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float winterLeavesAmount; // 0xB8
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float winterLeavesVar; // 0xBC
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float winterSizeMin; // 0xC0
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float winterSizeMax; // 0xC4
	[Range] // 0x00000001801E6D60-0x00000001801E6DA0
	[Space] // 0x00000001801E6D60-0x00000001801E6DA0
	public float springTintIntensity; // 0xC8
	public Color springTintColorOne; // 0xCC
	public Color springTintColorTwo; // 0xDC
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float springLeavesAmount; // 0xEC
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float springLeavesVar; // 0xF0
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float springSizeMin; // 0xF4
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float springSizeMax; // 0xF8
	[Range] // 0x00000001801E6D60-0x00000001801E6DA0
	[Space] // 0x00000001801E6D60-0x00000001801E6DA0
	public float summerTintIntensity; // 0xFC
	public Color summerTintColorOne; // 0x100
	public Color summerTintColorTwo; // 0x110
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float summerLeavesAmount; // 0x120
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float summerLeavesVar; // 0x124
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float summerSizeMin; // 0x128
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float summerSizeMax; // 0x12C
	[Range] // 0x00000001801E6D60-0x00000001801E6DA0
	[Space] // 0x00000001801E6D60-0x00000001801E6DA0
	public float autumnTintIntensity; // 0x130
	public Color autumnTintColorOne; // 0x134
	public Color autumnTintColorTwo; // 0x144
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float autumnLeavesAmount; // 0x154
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float autumnLeavesVar; // 0x158
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float autumnSizeMin; // 0x15C
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float autumnSizeMax; // 0x160

	// Nested types
	public enum UpdateMode // TypeDefIndex: 11450
	{
		Off = 0,
		On = 1
	}

	public enum GlobalSettingEnum // TypeDefIndex: 11451
	{
		Simple = 0,
		Seasons = 1
	}

	// Constructors
	public ADSGlobalSettings(); // 0x0000000182163DB0-0x0000000182163FB0

	// Methods
	private void Start(); // 0x0000000182163D40-0x0000000182163DA0
	private void Update(); // 0x0000000182163DA0-0x0000000182163DB0
	private void SetGlobalShaderProperties(); // 0x0000000182163370-0x0000000182163D40
}

