/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SurfaceFXFootstep : ManagedBehaviour // TypeDefIndex: 11931
{
	// Fields
	[EventRef] // 0x00000001801CEA70-0x00000001801CEA80
	public string Event; // 0x50
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float waterLevel; // 0x58
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float grassLevel; // 0x5C
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float dirtLevel; // 0x60
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float woodLevel; // 0x64
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float stoneLevel; // 0x68
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float snowLevel; // 0x6C
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float iceLevel; // 0x70
	public static Dictionary<string, float> MixedLevels; // 0x00
	private EventInstance? _eventInstance; // 0x78

	// Properties
	private EventInstance? eventInstance { get; } // 0x0000000180CBA340-0x0000000180CBA5B0 

	// Constructors
	public SurfaceFXFootstep(); // 0x0000000180CBA2E0-0x0000000180CBA340

	// Methods
	private void SetTerrainParams(EventInstance inEventInstance, bool testBlending = false /* Metadata: 0x007B937F */); // 0x0000000180CB9A60-0x0000000180CBA2E0
	private void SetAvatarParams(EventInstance inEventInstance); // 0x0000000180CB98E0-0x0000000180CB99F0
	private void SetParameter(EventInstance inEventInstance, string pName, float pValue); // 0x0000000180CB99F0-0x0000000180CB9A60
	public override void MOnEnable(); // 0x0000000180CB9710-0x0000000180CB98E0
	public override void MOnDisable(); // 0x0000000180CB96F0-0x0000000180CB9710
}

