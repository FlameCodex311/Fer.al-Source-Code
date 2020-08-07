/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CoreDeviceQualitySettingsEntry // TypeDefIndex: 11117
{
	// Fields
	public int _targetFrameRate; // 0x10
	public bool _useLowPowerMode; // 0x14
	public bool _useFrameRateControl; // 0x15
	public ThreadPriority _unityBackgroundLoadingPriority; // 0x18
	public bool _useConstantCollection; // 0x1C
	public int _animationUpdatePerFrame; // 0x20
	public bool _usePostProcessingOcclusion; // 0x24
	public bool _usePostProcessingBloom; // 0x25
	public bool _usePostProcessingMotionBlur; // 0x26
	public bool _useShadows; // 0x27
	public bool _useAA; // 0x28
	private List<string> _qualityLevelNames; // 0x30
	public string _unityQualityLevel; // 0x38
	public Dictionary<AssetQualityLevel, AssetQualityLevel> _assetQualityMapping; // 0x40
	public AudioQualityLevel _audioQuality; // 0x48
	public int _maxResolution; // 0x4C

	// Properties
	public int TargetFrameRate { get; } // 0x0000000180387590-0x0000000180387930 
	public int TargetVSyncCount { get; } // 0x0000000180A67A70-0x0000000180A67A90 
	public bool UseLowPowerMode { get; } // 0x00000001809A8910-0x00000001809A8920 
	public bool UseFrameRateControl { get; } // 0x0000000180A67B30-0x0000000180A67B40 
	public ThreadPriority UnityBackgroundLoadingPriority { get; } // 0x00000001803F46B0-0x00000001803F46C0 
	public bool UseConstantCollection { get; } // 0x000000018041B650-0x000000018041B660 
	public int AnimationUpdatePerFrame { get; } // 0x00000001803FB670-0x00000001803FB680 
	public bool UsePostProcessingOcclusion { get; set; } // 0x00000001804F2E90-0x00000001804F2EA0 0x00000001804F2EA0-0x00000001804F2EB0
	public bool UsePostProcessingBloom { get; set; } // 0x00000001804D2E30-0x00000001804D2E40 0x000000018099F300-0x000000018099F310
	public bool UsePostProcessingMotionBlur { get; set; } // 0x00000001804D2E20-0x00000001804D2E30 0x000000018099F2C0-0x000000018099F2D0
	public bool UseShadows { get; set; } // 0x0000000180A67B40-0x0000000180A67B50 0x0000000180A67B50-0x0000000180A67B60
	public bool UseAA { get; set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
	public int UnityQualityLevel { get; } // 0x0000000180A67A90-0x0000000180A67B30 
	public AudioQualityLevel AudioQualityLevel { get; } // 0x0000000180379ED0-0x0000000180379EE0 
	public string AudioQualityPostfix { get; } // 0x0000000180A67A30-0x0000000180A67A70 
	public int MaxResolution { get; } // 0x000000018078C430-0x000000018078C440 

	// Constructors
	public CoreDeviceQualitySettingsEntry(); // 0x0000000180A679A0-0x0000000180A67A30

	// Methods
	public AssetQualityLevel GetAdjustedAssetQualityLevel(AssetQualityLevel inQualityLevel); // 0x0000000180A67710-0x0000000180A679A0
}

