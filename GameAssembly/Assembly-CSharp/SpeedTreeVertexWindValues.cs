/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[DeComponentDescription] // 0x000000018014DA30-0x000000018014DA60
public class SpeedTreeVertexWindValues : MonoBehaviour // TypeDefIndex: 11893
{
	// Fields
	public WindValuesMode mode; // 0x20
	[DeComment] // 0x000000018014EF50-0x000000018014EFF0
	[DeConditional] // 0x000000018014EF50-0x000000018014EFF0
	public bool __notForDisplay; // 0x24
	[DeBeginDisabled] // 0x0000000180150560-0x0000000180150610
	[DeBeginGroup] // 0x0000000180150560-0x0000000180150610
	[DeComment] // 0x0000000180150560-0x0000000180150610
	public float windStrength; // 0x28
	[DeEndDisabled] // 0x0000000180150A50-0x0000000180150AB0
	[DeEndGroup] // 0x0000000180150A50-0x0000000180150AB0
	[DeRange] // 0x0000000180150A50-0x0000000180150AB0
	public float windFrequency; // 0x2C
	[DeToggleButton] // 0x0000000180150DF0-0x0000000180150ED0
	[Space] // 0x0000000180150DF0-0x0000000180150ED0
	public bool showAdvancedOptions; // 0x30
	[DeBeginDisabled] // 0x0000000180151330-0x00000001801513C0
	[DeBeginGroup] // 0x0000000180151330-0x00000001801513C0
	[DeRange] // 0x0000000180151330-0x00000001801513C0
	[Space] // 0x0000000180151330-0x00000001801513C0
	public float treeSwaySpeed; // 0x34
	[DeRange] // 0x00000001801518A0-0x00000001801518D0
	public float treeSwayDisplacement; // 0x38
	[DeRange] // 0x00000001801519B0-0x00000001801519E0
	public float treeSwayStutter; // 0x3C
	[DeRange] // 0x00000001801518A0-0x00000001801518D0
	public float treeSwayStutterInfluence; // 0x40
	public float leavesWiggleDisplacement; // 0x44
	public float leavesWiggleSpeed; // 0x48
	[DeRange] // 0x0000000180151CE0-0x0000000180151D10
	public float branchDisplacement; // 0x4C
	[DeRange] // 0x0000000180151EF0-0x0000000180151F40
	[Space] // 0x0000000180151EF0-0x0000000180151F40
	public float redVertColorInfluence; // 0x50
	[DeEndDisabled] // 0x00000001801520E0-0x0000000180152130
	[DeEndGroup] // 0x00000001801520E0-0x0000000180152130
	[DeRange] // 0x00000001801520E0-0x0000000180152130
	public float blueVertColorInfluence; // 0x54
	[DeConditional] // 0x00000001801524C0-0x0000000180152500
	public bool __notForDisplay2; // 0x58
	private WindZone _windZone; // 0x60
	private float _lastWindZoneMain; // 0x68
	private float _lastWindZoneTurbulence; // 0x6C
	private Quaternion _lastRotaton; // 0x70

	// Nested types
	public enum WindValuesMode // TypeDefIndex: 11894
	{
		SetFromWindZone = 0,
		SetFromValues = 1
	}

	// Constructors
	public SpeedTreeVertexWindValues(); // 0x000000018135D2D0-0x000000018135D330

	// Methods
	private void Start(); // 0x000000018135D2C0-0x000000018135D2D0
	[DeMethodButton] // 0x00000001801526E0-0x0000000180152740
	public void ApplyWindValues(); // 0x000000018135CEA0-0x000000018135D200
	private void OnValidate(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x0000000180152990-0x00000001801529F0
	private void LogWindDirMag(); // 0x000000018135D200-0x000000018135D2C0
}

