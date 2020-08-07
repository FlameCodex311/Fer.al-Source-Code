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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CorePlatformManager : CoreManagerBase<CorePlatformManager> // TypeDefIndex: 11165
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	private const float maxResolutionWidthScale = 1f; // Metadata: 0x0077C87F
	private const float maxResolutionHeightScale = 1f; // Metadata: 0x0077C883
	private const float minResolutionWidthScale = 0.1f; // Metadata: 0x0077C887
	private const float minResolutionHeightScale = 0.1f; // Metadata: 0x0077C88B
	private const float scaleWidthIncrement = 0.05f; // Metadata: 0x0077C88F
	private const float scaleHeightIncrement = 0.05f; // Metadata: 0x0077C893
	private float _widthScale; // 0x78
	private float _heightScale; // 0x7C
	private float _oldWidthScale; // 0x80
	private float _oldHeightScale; // 0x84
	private uint _frameCount; // 0x88
	private const uint kNumFrameTimings = 2; // Metadata: 0x0077C897
	private double _gpuFrameTime; // 0x90
	private double _cpuFrameTime; // 0x98
	[DebugField] // 0x000000018024CB30-0x000000018024CB90
	private static string _dynamicResolutionDebugInfo; // 0x28
	private static string[] _simplePlatformNames; // 0x30
	private CoreDeviceQualitySettingsEntry _currentDeviceQualitySettings; // 0xA0
	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> _deviceQualitySettingsMap; // 0xA8

	// Properties
	public static float CurrentFPS { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180A9A4F0-0x0000000180A9A550 0x0000000180A9AD40-0x0000000180A9ADB0
	public static Vector2? DeviceResolution { get; } // 0x0000000180A9A7B0-0x0000000180A9A820 
	public string FPSCurrentString { get; } // 0x0000000180A9A820-0x0000000180A9A8E0 
	public static DeviceQualityLevel DeviceQuality { get; set; } // 0x0000000180A9A760-0x0000000180A9A7B0 0x0000000180A9ADB0-0x0000000180A9AE00
	public static PerformanceLevel CurrentPerformance { get; } // 0x0000000180A9A550-0x0000000180A9A720 
	private bool FrameRateControlEnabled { get; } // 0x0000000180A9A8E0-0x0000000180A9A960 
	[DebugField] // 0x000000018024D5F0-0x000000018024D650
	public static bool ToggleOcclusion { get; set; } // 0x0000000180A9AC80-0x0000000180A9ACE0 0x0000000180A9AF00-0x0000000180A9AF60
	[DebugField] // 0x000000018024D7C0-0x000000018024D820
	public static bool ToggleBloom { get; set; } // 0x0000000180A9AC20-0x0000000180A9AC80 0x0000000180A9AEA0-0x0000000180A9AF00
	[DebugField] // 0x000000018024DA70-0x000000018024DAD0
	public static bool ToggleShadows { get; set; } // 0x0000000180A9ACE0-0x0000000180A9AD40 0x0000000180A9AF60-0x0000000180A9B000
	[DebugField] // 0x000000018024DF80-0x000000018024DFE0
	public static bool ToggleAA { get; set; } // 0x0000000180A9ABC0-0x0000000180A9AC20 0x0000000180A9AE00-0x0000000180A9AEA0
	public static string[] SimplePlatformNames { get; } // 0x0000000180A9A960-0x0000000180A9ABC0 
	public CoreDeviceQualitySettingsEntry CurrentDeviceQualitySettings { get; } // 0x0000000180A9A400-0x0000000180A9A4F0 
	protected Dictionary<DeviceQualityLevel, CoreDeviceQualitySettingsEntry> DeviceQualitySettingsMap { get; } // 0x0000000180A9A720-0x0000000180A9A760 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BatteryLevelUpdate>d__35 : IEnumerator<object> // TypeDefIndex: 11166
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CorePlatformManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BatteryLevelUpdate>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AABDA0-0x0000000180AABE40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AABE40-0x0000000180AABE90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <>c__DisplayClass67_0 // TypeDefIndex: 11167
	{
		// Fields
		public CorePlatformManager <>4__this; // 0x00
		public FrameTiming[] frameTimings; // 0x08
	}

	// Constructors
	public CorePlatformManager(); // 0x0000000180A9A390-0x0000000180A9A400
	static CorePlatformManager(); // 0x0000000180A9A310-0x0000000180A9A390

	// Methods
	public virtual bool AllowFrameRateControlMode(); // 0x0000000180380950-0x0000000180380960
	public void SetDeviceQuality(DeviceQualityLevel inQuality); // 0x0000000180A99280-0x0000000180A996D0
	public override void Init(); // 0x0000000180A98910-0x0000000180A98A70
	private void ClearDeviceCaching(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void InitQualityLevel(); // 0x0000000180A98880-0x0000000180A98910
	private static void UnsupportedReset(MessageState inState); // 0x0000000180A99880-0x0000000180A99920
	public bool IsPhone(); // 0x0000000180A98A80-0x0000000180A98AE0
	public bool IsMobilePlatform(); // 0x0000000180A98A70-0x0000000180A98A80
	[IteratorStateMachine] // 0x000000018024CF50-0x000000018024CFA0
	private IEnumerator BatteryLevelUpdate(); // 0x0000000180A98500-0x0000000180A98560
	public override void MUpdate(); // 0x0000000180A98AE0-0x0000000180A98DB0
	private void UpdateFPS(); // 0x0000000180A9A060-0x0000000180A9A310
	[DebugButton] // 0x000000018024D1B0-0x000000018024D210
	public static void IncreaseDynamicResolutionScale(); // 0x0000000180A98790-0x0000000180A98880
	[DebugButton] // 0x000000018024D2C0-0x000000018024D320
	public static void DecreaseDynamicResolutionScale(); // 0x0000000180A98560-0x0000000180A98650
	private void UpdateDynamicResolution(); // 0x0000000180A99920-0x0000000180A9A060
	public static SimplePlatform EditorGetSimplePlatformFromBuildTarget(); // 0x0000000180781F20-0x0000000180781F30
	public static SimplePlatform GetSimplePlatformFromRunTime(); // 0x0000000180A98650-0x0000000180A98790
	protected void ResetDeviceQualitySettings(); // 0x0000000180A98DB0-0x0000000180A98DD0
	protected virtual void SetDeviceQualitySettingsMap(); // 0x0000000180A98DD0-0x0000000180A99280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <UpdateDynamicResolution>g__DetermineResolution|67_0(ref <>c__DisplayClass67_0 param_0001521a); // 0x0000000180A996D0-0x0000000180A99880
}

