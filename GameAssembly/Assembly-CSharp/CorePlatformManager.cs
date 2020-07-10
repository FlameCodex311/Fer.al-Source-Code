/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CorePlatformManager : CoreManagerBase<CorePlatformManager> // TypeDefIndex: 13494
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static float <CurrentFPS>k__BackingField; // 0x00
	private static float fpsUpdateInterval; // 0x04
	private static float fpsAccumulator; // 0x08
	private static int fpsFrames; // 0x0C
	private static float fpsTimeleft; // 0x10
	private static Vector2? _deviceResolution; // 0x14
	private static PerformanceLevel _currentPerformance; // 0x20
	private bool? _frameRateControlEnabled; // 0x60
	private bool _lowPowerMode; // 0x62
	private bool _frameRateControlMode; // 0x63
	private float _frameRateControlModeTimer; // 0x64
	private float _batteryLevel; // 0x68
	private Coroutine _batteryLevelCoroutine; // 0x70
	private const float maxResolutionWidthScale = 1f; // Metadata: 0x00783DC0
	private const float maxResolutionHeightScale = 1f; // Metadata: 0x00783DC4
	private const float minResolutionWidthScale = 0.1f; // Metadata: 0x00783DC8
	private const float minResolutionHeightScale = 0.1f; // Metadata: 0x00783DCC
	private const float scaleWidthIncrement = 0.05f; // Metadata: 0x00783DD0
	private const float scaleHeightIncrement = 0.05f; // Metadata: 0x00783DD4
	private float _widthScale; // 0x78
	private float _heightScale; // 0x7C
	private float _oldWidthScale; // 0x80
	private float _oldHeightScale; // 0x84
	private uint _frameCount; // 0x88
	private const uint kNumFrameTimings = 2; // Metadata: 0x00783DD8
	private double _gpuFrameTime; // 0x90
	private double _cpuFrameTime; // 0x98
	[DebugField] // 0x000000018016F4F0-0x000000018016F550
	private static string _dynamicResolutionDebugInfo; // 0x28
	private static string[] _simplePlatformNames; // 0x30
	private CoreDeviceQualitySettingsEntry _currentDeviceQualitySettings; // 0xA0
	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> _deviceQualitySettingsMap; // 0xA8

	// Properties
	public static float CurrentFPS { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018131BEC0-0x000000018131BF20 0x000000018131C5A0-0x000000018131C610
	public static Vector2? DeviceResolution { get; } // 0x000000018131C180-0x000000018131C1F0 
	public string FPSCurrentString { get; } // 0x000000018131C1F0-0x000000018131C2B0 
	public static DeviceQualityLevel DeviceQuality { get; set; } // 0x000000018131C130-0x000000018131C180 0x000000018131C610-0x000000018131C660
	public static PerformanceLevel CurrentPerformance { get; } // 0x000000018131BF20-0x000000018131C0F0 
	private bool FrameRateControlEnabled { get; } // 0x000000018131C2B0-0x000000018131C330 
	public static string[] SimplePlatformNames { get; } // 0x000000018131C330-0x000000018131C5A0 
	public CoreDeviceQualitySettingsEntry CurrentDeviceQualitySettings { get; } // 0x000000018131BDD0-0x000000018131BEC0 
	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> DeviceQualitySettingsMap { get; } // 0x000000018131C0F0-0x000000018131C130 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BatteryLevelUpdate>d__35 : IEnumerator<object> // TypeDefIndex: 13495
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CorePlatformManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BatteryLevelUpdate>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181324650-0x00000001813246F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813246F0-0x0000000181324740
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <>c__DisplayClass55_0 // TypeDefIndex: 13496
	{
		// Fields
		public CorePlatformManager <>4__this; // 0x00
		public FrameTiming[] frameTimings; // 0x08
	}

	// Constructors
	public CorePlatformManager(); // 0x000000018131BD60-0x000000018131BDD0
	static CorePlatformManager(); // 0x000000018131BCE0-0x000000018131BD60

	// Methods
	public virtual bool AllowFrameRateControlMode(); // 0x00000001803C28F0-0x00000001803C2900
	public void SetDeviceQuality(DeviceQualityLevel inQuality); // 0x000000018131AD20-0x000000018131B1B0
	public override void Init(); // 0x000000018131A390-0x000000018131A4F0
	private void ClearDeviceCaching(); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void InitQualityLevel(); // 0x000000018131A2F0-0x000000018131A390
	private static void UnsupportedReset(MessageState inState); // 0x000000018131B370-0x000000018131B410
	public bool IsPhone(); // 0x000000018131A500-0x000000018131A560
	public bool IsMobilePlatform(); // 0x000000018131A4F0-0x000000018131A500
	[IteratorStateMachine] // 0x000000018016FD80-0x000000018016FDD0
	private IEnumerator BatteryLevelUpdate(); // 0x0000000181319F70-0x0000000181319FD0
	public override void MUpdate(); // 0x000000018131A560-0x000000018131A840
	private void UpdateFPS(); // 0x000000018131BA30-0x000000018131BCE0
	[DebugButton] // 0x0000000180170160-0x00000001801701C0
	public static void IncreaseDynamicResolutionScale(); // 0x000000018131A200-0x000000018131A2F0
	[DebugButton] // 0x0000000180170320-0x0000000180170380
	public static void DecreaseDynamicResolutionScale(); // 0x0000000181319FD0-0x000000018131A0C0
	private void UpdateDynamicResolution(); // 0x000000018131B410-0x000000018131BA30
	public static SimplePlatform EditorGetSimplePlatformFromBuildTarget(); // 0x00000001806FD3C0-0x00000001806FD3D0
	public static SimplePlatform GetSimplePlatformFromRunTime(); // 0x000000018131A0C0-0x000000018131A200
	protected void ResetDeviceQualitySettings(); // 0x000000018131A840-0x000000018131A860
	protected virtual void SetDeviceQualitySettingsMap(); // 0x000000018131A860-0x000000018131AD20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <UpdateDynamicResolution>g__DetermineResolution|55_0(ref <>c__DisplayClass55_0 param_0001635c); // 0x000000018131B1B0-0x000000018131B370
}

