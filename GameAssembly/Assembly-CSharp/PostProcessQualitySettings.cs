/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering.PostProcessing;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PostProcessQualitySettings : ManagedBehaviour // TypeDefIndex: 10649
{
	// Fields
	private PostProcessVolume _volume; // 0x50
	private bool _useAOLayerInHigh; // 0x58
	private bool _useBloomLayerInHigh; // 0x59
	private DeviceQualityLevel _lastQualityLevel; // 0x5C

	// Constructors
	public PostProcessQualitySettings(); // 0x000000018115DCB0-0x000000018115DD10

	// Methods
	public override void MOnEnable(); // 0x000000018115D8F0-0x000000018115DA90
	public override void MUpdate(); // 0x000000018115DA90-0x000000018115DB00
	private void UpdateQualitySettings(DeviceQualityLevel inQualityLevel); // 0x000000018115DB00-0x000000018115DCB0
}

