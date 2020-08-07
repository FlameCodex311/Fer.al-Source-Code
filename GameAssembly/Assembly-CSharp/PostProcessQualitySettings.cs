/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering.PostProcessing;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PostProcessQualitySettings : ManagedBehaviour // TypeDefIndex: 12152
{
	// Fields
	private PostProcessVolume _volume; // 0x50
	private bool _hasAOLayer; // 0x58
	private bool? _lastUseAOLayer; // 0x59
	private bool _hasBloomLayer; // 0x5B
	private bool? _lastUseBloomLayer; // 0x5C
	private bool _hasMotionBlurLayer; // 0x5E
	private bool? _lastUseMotionBlurLayer; // 0x5F

	// Constructors
	public PostProcessQualitySettings(); // 0x00000001804E7240-0x00000001804E72E0

	// Methods
	public override void MOnEnable(); // 0x00000001804E6BE0-0x00000001804E6E20
	public override void MUpdate(); // 0x00000001804E6E20-0x00000001804E7010
	private void UpdateQualitySettings(bool inUseAOLayer, bool inUseBloomLayer, bool inUseMotionBlurLayer); // 0x00000001804E7010-0x00000001804E7240
}

