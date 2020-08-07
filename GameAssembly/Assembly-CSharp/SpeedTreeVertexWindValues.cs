/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[DeComponentDescription] // 0x0000000180235470-0x00000001802354A0
public class SpeedTreeVertexWindValues : MonoBehaviour // TypeDefIndex: 13429
{
	// Fields
	public WindValuesMode mode; // 0x20
	[DeComment] // 0x00000001802356C0-0x0000000180235760
	[DeConditional] // 0x00000001802356C0-0x0000000180235760
	public bool __notForDisplay; // 0x24
	[DeBeginDisabled] // 0x0000000180235A80-0x0000000180235B30
	[DeBeginGroup] // 0x0000000180235A80-0x0000000180235B30
	[DeComment] // 0x0000000180235A80-0x0000000180235B30
	public float windStrength; // 0x28
	[DeEndDisabled] // 0x0000000180235E50-0x0000000180235EB0
	[DeEndGroup] // 0x0000000180235E50-0x0000000180235EB0
	[DeRange] // 0x0000000180235E50-0x0000000180235EB0
	public float windFrequency; // 0x2C
	[DeToggleButton] // 0x0000000180236240-0x0000000180236320
	[Space] // 0x0000000180236240-0x0000000180236320
	public bool showAdvancedOptions; // 0x30
	[DeBeginDisabled] // 0x00000001802366F0-0x0000000180236780
	[DeBeginGroup] // 0x00000001802366F0-0x0000000180236780
	[DeRange] // 0x00000001802366F0-0x0000000180236780
	[Space] // 0x00000001802366F0-0x0000000180236780
	public float treeSwaySpeed; // 0x34
	[DeRange] // 0x0000000180236BC0-0x0000000180236BF0
	public float treeSwayDisplacement; // 0x38
	[DeRange] // 0x0000000180236DA0-0x0000000180236DD0
	public float treeSwayStutter; // 0x3C
	[DeRange] // 0x0000000180236BC0-0x0000000180236BF0
	public float treeSwayStutterInfluence; // 0x40
	public float leavesWiggleDisplacement; // 0x44
	public float leavesWiggleSpeed; // 0x48
	[DeRange] // 0x00000001802371A0-0x00000001802371D0
	public float branchDisplacement; // 0x4C
	[DeRange] // 0x00000001802374A0-0x00000001802374F0
	[Space] // 0x00000001802374A0-0x00000001802374F0
	public float redVertColorInfluence; // 0x50
	[DeEndDisabled] // 0x0000000180237850-0x00000001802378A0
	[DeEndGroup] // 0x0000000180237850-0x00000001802378A0
	[DeRange] // 0x0000000180237850-0x00000001802378A0
	public float blueVertColorInfluence; // 0x54
	[DeConditional] // 0x0000000180237C20-0x0000000180237C60
	public bool __notForDisplay2; // 0x58
	private WindZone _windZone; // 0x60
	private float _lastWindZoneMain; // 0x68
	private float _lastWindZoneTurbulence; // 0x6C
	private Quaternion _lastRotaton; // 0x70

	// Nested types
	public enum WindValuesMode // TypeDefIndex: 13430
	{
		SetFromWindZone = 0,
		SetFromValues = 1
	}

	// Constructors
	public SpeedTreeVertexWindValues(); // 0x0000000180773CE0-0x0000000180773D40

	// Methods
	private void Start(); // 0x0000000180773CD0-0x0000000180773CE0
	[DeMethodButton] // 0x0000000180237E80-0x0000000180237EE0
	public void ApplyWindValues(); // 0x00000001807738B0-0x0000000180773C10
	private void OnValidate(); // 0x00000001803774A0-0x00000001803774B0
	[DeMethodButton] // 0x00000001802382B0-0x0000000180238310
	private void LogWindDirMag(); // 0x0000000180773C10-0x0000000180773CD0
}

