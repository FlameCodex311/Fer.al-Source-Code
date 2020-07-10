/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class ResolutionChecker // TypeDefIndex: 11722
{
	// Fields
	private static int? _minWidth; // 0x00
	private static int? _minHeight; // 0x08
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static int <_fullscreen>k__BackingField; // 0x10
	private static int _antiAliasing; // 0x14
	private static List<Vector2Int> _debugResolutions; // 0x18
	private static Resolution _resolution; // 0x20
	private static IDictionary<Resolution, string> _resolutionsNameLookup; // 0x30
	private static List<Resolution> _orderedResolutions; // 0x38

	// Properties
	private static int MinWidth { get; } // 0x0000000180FCB700-0x0000000180FCB860 
	private static int MinHeight { get; } // 0x0000000180FCB5A0-0x0000000180FCB700 
	private static int _fullscreen { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180FCBAA0-0x0000000180FCBB00 0x0000000180FCBFB0-0x0000000180FCC010
	public static bool IsFullscreen { get; set; } // 0x0000000180FCB500-0x0000000180FCB5A0 0x0000000180FCBE90-0x0000000180FCBFB0
	public static int AntiAliasing { get; } // 0x0000000180FCB470-0x0000000180FCB4D0 
	public static DeviceQualityLevel QualityLevel { get; } // 0x0000000180FCB920-0x0000000180FCB970 
	private static List<Vector2Int> debugResolutions { get; } // 0x0000000180FCBB00-0x0000000180FCBE90 
	public static Resolution Resolution { get; } // 0x0000000180FCB970-0x0000000180FCB9E0 
	public static IDictionary<Resolution, string> ResolutionsNameLookup { get; } // 0x0000000180FCB9E0-0x0000000180FCBAA0 
	public static List<Resolution> OrderedResolutions { get; } // 0x0000000180FCB860-0x0000000180FCB920 
	public static bool CanSetResolution { get; } // 0x0000000180FCB4D0-0x0000000180FCB500 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11723
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<Resolution, bool> <>9__40_2; // 0x08
		public static Func<Resolution, int> <>9__40_0; // 0x10
		public static Func<Resolution, int> <>9__40_1; // 0x18

		// Constructors
		static <>c(); // 0x0000000180FE42A0-0x0000000180FE4300
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RefreshResolutions>b__40_2(Resolution r); // 0x0000000180FE3B30-0x0000000180FE3E80
		internal int <RefreshResolutions>b__40_0(Resolution r); // 0x0000000180FE3AF0-0x0000000180FE3B10
		internal int <RefreshResolutions>b__40_1(Resolution r); // 0x0000000180FE3B10-0x0000000180FE3B30
	}

	// Constructors
	static ResolutionChecker(); // 0x0000000180FCB3C0-0x0000000180FCB470

	// Methods
	public static void Init(); // 0x0000000180FCA240-0x0000000180FCA370
	public static string ScreenModeText(bool inIsFullscreen); // 0x0000000180FCB2C0-0x0000000180FCB3C0
	public static string ResolutionText(Resolution inResolution); // 0x0000000180FCB1D0-0x0000000180FCB2C0
	public static string AntiAliasingText(int inAntiAliasing); // 0x0000000180FC99B0-0x0000000180FC9A20
	public static void ConfirmAndApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel inQualityLevel); // 0x0000000180FC9EF0-0x0000000180FCA240
	public static void ApplyResolutionSettings(Resolution inResolution, bool inIsFullscreen, DeviceQualityLevel? inQualityLevel); // 0x0000000180FC9A20-0x0000000180FC9DC0
	private static void OnDisplaysUpdated(); // 0x0000000180FCA990-0x0000000180FCA9E0
	private static void LoadSettings(); // 0x0000000180FCA370-0x0000000180FCA990
	private static void RefreshResolutions(); // 0x0000000180FCA9E0-0x0000000180FCB1D0
	private static void ChangeResolutionIfUnsupported(); // 0x0000000180FC9DC0-0x0000000180FC9EF0
}

