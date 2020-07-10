/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Match3LevelGrowthRate // TypeDefIndex: 12985
{
	// Fields
	[Range] // 0x0000000180164B40-0x0000000180164BA0
	[SerializeField] // 0x0000000180164B40-0x0000000180164BA0
	[Tooltip] // 0x0000000180164B40-0x0000000180164BA0
	private int _roundToNearest; // 0x10
	[Range] // 0x0000000180164E30-0x0000000180164E90
	[SerializeField] // 0x0000000180164E30-0x0000000180164E90
	[Tooltip] // 0x0000000180164E30-0x0000000180164E90
	private int _startingLevelScore; // 0x14
	[Range] // 0x0000000180165190-0x00000001801651F0
	[SerializeField] // 0x0000000180165190-0x00000001801651F0
	[Tooltip] // 0x0000000180165190-0x00000001801651F0
	private float _growthRate; // 0x18
	[Range] // 0x00000001801654A0-0x0000000180165500
	[SerializeField] // 0x00000001801654A0-0x0000000180165500
	[Tooltip] // 0x00000001801654A0-0x0000000180165500
	private int _offset; // 0x1C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useDebugScore; // 0x20
	[Range] // 0x0000000180165A10-0x0000000180165A50
	[SerializeField] // 0x0000000180165A10-0x0000000180165A50
	private int _debugScore; // 0x24
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <E>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <Offset>k__BackingField; // 0x2C

	// Properties
	private float E { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
	private float Offset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0

	// Constructors
	public Match3LevelGrowthRate(); // 0x00000001816CEA40-0x00000001816CEA70

	// Methods
	public void Initialize(); // 0x00000001816CE990-0x00000001816CEA40
	public int GetScoreObjective(int currentLevelNumber); // 0x00000001816CE810-0x00000001816CE990
}

