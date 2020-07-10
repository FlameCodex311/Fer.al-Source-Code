/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CoreDeviceQualitySettingsEntry // TypeDefIndex: 13446
{
	// Fields
	public int _targetFrameRate; // 0x10
	public bool _useLowPowerMode; // 0x14
	public bool _useFrameRateControl; // 0x15
	public ThreadPriority _unityBackgroundLoadingPriority; // 0x18
	public bool _useConstantCollection; // 0x1C
	public int _animationUpdatePerFrame; // 0x20
	private List<string> _qualityLevelNames; // 0x28
	public string _unityQualityLevel; // 0x30
	public Dictionary<AssetQualityLevel, AssetQualityLevel> _assetQualityMapping; // 0x38
	public AudioQualityLevel _audioQuality; // 0x40
	public int _maxResolution; // 0x44

	// Properties
	public int TargetFrameRate { get; } // 0x000000018036CFF0-0x000000018036D000 
	public int TargetVSyncCount { get; } // 0x000000018130D450-0x000000018130D470 
	public bool UseLowPowerMode { get; } // 0x0000000180491CD0-0x0000000180491CE0 
	public bool UseFrameRateControl { get; } // 0x00000001807874B0-0x00000001807874C0 
	public ThreadPriority UnityBackgroundLoadingPriority { get; } // 0x0000000180367710-0x0000000180367720 
	public bool UseConstantCollection { get; } // 0x000000018036CB20-0x000000018036CB30 
	public int AnimationUpdatePerFrame { get; } // 0x00000001803C2700-0x00000001803C2710 
	public int UnityQualityLevel { get; } // 0x000000018130D470-0x000000018130D510 
	public AudioQualityLevel AudioQualityLevel { get; } // 0x000000018047AB20-0x000000018047AB30 
	public string AudioQualityPostfix { get; } // 0x000000018130D410-0x000000018130D450 
	public int MaxResolution { get; } // 0x0000000180478650-0x0000000180478660 

	// Constructors
	public CoreDeviceQualitySettingsEntry(); // 0x000000018130D380-0x000000018130D410

	// Methods
	public AssetQualityLevel GetAdjustedAssetQualityLevel(AssetQualityLevel inQualityLevel); // 0x000000018130D0A0-0x000000018130D380
}

