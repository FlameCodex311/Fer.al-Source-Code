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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SurfaceFXFootstep : ManagedBehaviour // TypeDefIndex: 10454
{
	// Fields
	[EventRef] // 0x00000001800BDB50-0x00000001800BDB60
	public string Event; // 0x50
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float waterLevel; // 0x58
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float grassLevel; // 0x5C
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float dirtLevel; // 0x60
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float woodLevel; // 0x64
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float stoneLevel; // 0x68
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float snowLevel; // 0x6C
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float iceLevel; // 0x70
	public static Dictionary<string, float> MixedLevels; // 0x00
	private EventInstance _eventInstance; // 0x78

	// Properties
	private EventInstance EventInstance { get; } // 0x0000000181204B60-0x0000000181204D00 

	// Constructors
	public SurfaceFXFootstep(); // 0x0000000181204B00-0x0000000181204B60

	// Methods
	private void SetTerrainParams(EventInstance inEventInstance, bool testBlending = false /* Metadata: 0x00781CDC */); // 0x0000000181204280-0x0000000181204B00
	private void SetAvatarParams(EventInstance inEventInstance); // 0x0000000181204150-0x0000000181204210
	private void SetParameter(EventInstance inEventInstance, string pName, float pValue); // 0x0000000181204210-0x0000000181204280
	public override void MOnEnable(); // 0x0000000181204010-0x0000000181204150
}

