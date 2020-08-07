/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Match3LevelGrowthRate // TypeDefIndex: 10650
{
	// Fields
	[Range] // 0x0000000180241770-0x00000001802417D0
	[SerializeField] // 0x0000000180241770-0x00000001802417D0
	[Tooltip] // 0x0000000180241770-0x00000001802417D0
	private int _roundToNearest; // 0x10
	[Range] // 0x0000000180241B90-0x0000000180241BF0
	[SerializeField] // 0x0000000180241B90-0x0000000180241BF0
	[Tooltip] // 0x0000000180241B90-0x0000000180241BF0
	private int _startingLevelScore; // 0x14
	[Range] // 0x0000000180241EF0-0x0000000180241F50
	[SerializeField] // 0x0000000180241EF0-0x0000000180241F50
	[Tooltip] // 0x0000000180241EF0-0x0000000180241F50
	private float _growthRate; // 0x18
	[Range] // 0x0000000180242280-0x00000001802422E0
	[SerializeField] // 0x0000000180242280-0x00000001802422E0
	[Tooltip] // 0x0000000180242280-0x00000001802422E0
	private int _offset; // 0x1C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useDebugScore; // 0x20
	[Range] // 0x0000000180242870-0x00000001802428B0
	[SerializeField] // 0x0000000180242870-0x00000001802428B0
	private int _debugScore; // 0x24
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <E>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <Offset>k__BackingField; // 0x2C

	// Properties
	private float E { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
	private float Offset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50

	// Constructors
	public Match3LevelGrowthRate(); // 0x00000001807DDA00-0x00000001807DDA30

	// Methods
	public void Initialize(); // 0x00000001807DD950-0x00000001807DDA00
	public int GetScoreObjective(int currentLevelNumber); // 0x00000001807DD7E0-0x00000001807DD950
}

