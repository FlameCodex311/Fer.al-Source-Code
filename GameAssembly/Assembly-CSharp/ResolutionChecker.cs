/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class ResolutionChecker // TypeDefIndex: 13249
{
	// Fields
	private static int? _minWidth; // 0x00
	private static int? _minHeight; // 0x08
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static int <_fullscreen>k__BackingField; // 0x10
	private static int _antiAliasing; // 0x14
	private static List<Vector2Int> _debugResolutions; // 0x18
	private static Resolution _resolution; // 0x20
	private static IDictionary<Resolution, string> _resolutionsNameLookup; // 0x30
	private static List<Resolution> _orderedResolutions; // 0x38

	// Properties
	private static int MinWidth { get; } // 0x00000001804ACB20-0x00000001804ACC80 
	private static int MinHeight { get; } // 0x00000001804AC9C0-0x00000001804ACB20 
	private static int _fullscreen { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804ACEC0-0x00000001804ACF20 0x00000001804AD3B0-0x00000001804AD410
	public static bool IsFullscreen { get; set; } // 0x00000001804AC920-0x00000001804AC9C0 0x00000001804AD290-0x00000001804AD3B0
	public static int AntiAliasing { get; } // 0x00000001804AC890-0x00000001804AC8F0 
	public static DeviceQualityLevel QualityLevel { get; } // 0x00000001804ACD40-0x00000001804ACD90 
	private static List<Vector2Int> debugResolutions { get; } // 0x00000001804ACF20-0x00000001804AD290 
	public static Resolution Resolution { get; } // 0x00000001804ACD90-0x00000001804ACE00 
	public static IDictionary<Resolution, string> ResolutionsNameLookup { get; } // 0x00000001804ACE00-0x00000001804ACEC0 
	public static List<Resolution> OrderedResolutions { get; } // 0x00000001804ACC80-0x00000001804ACD40 
	public static bool CanSetResolution { get; } // 0x00000001804AC8F0-0x00000001804AC920 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13250
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<Resolution, bool> <>9__40_2; // 0x08
		public static Func<Resolution, int> <>9__40_0; // 0x10
		public static Func<Resolution, int> <>9__40_1; // 0x18

		// Constructors
		static <>c(); // 0x00000001804BC8E0-0x00000001804BC940
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RefreshResolutions>b__40_2(Resolution r); // 0x00000001804BC500-0x00000001804BC850
		internal int <RefreshResolutions>b__40_0(Resolution r); // 0x00000001804BC4C0-0x00000001804BC4E0
		internal int <RefreshResolutions>b__40_1(Resolution r); // 0x00000001804BC4E0-0x00000001804BC500
	}

	// Constructors
	static ResolutionChecker(); // 0x00000001804AC7E0-0x00000001804AC890

	// Methods
	public static void Init(); // 0x00000001804AB680-0x00000001804AB7B0
	public static string ScreenModeText(bool inIsFullscreen); // 0x00000001804AC6E0-0x00000001804AC7E0
	public static string ResolutionText(Resolution inResolution); // 0x00000001804AC5F0-0x00000001804AC6E0
	public static string AntiAliasingText(int inAntiAliasing); // 0x00000001804AAE00-0x00000001804AAE70
	public static void ConfirmAndApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel inQualityLevel); // 0x00000001804AB330-0x00000001804AB680
	public static void ApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel? inQualityLevel); // 0x00000001804AAE70-0x00000001804AB200
	private static void OnDisplaysUpdated(); // 0x00000001804ABDC0-0x00000001804ABE10
	private static void LoadSettings(); // 0x00000001804AB7B0-0x00000001804ABDC0
	private static void RefreshResolutions(); // 0x00000001804ABE10-0x00000001804AC5F0
	private static void ChangeResolutionIfUnsupported(); // 0x00000001804AB200-0x00000001804AB330
}

