/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Platforms;
using Rewired.Utils.Attributes;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
	public sealed class ConfigVars // TypeDefIndex: 6026
	{
		// Fields
		public UpdateLoopSetting updateLoop; // 0x10
		public bool alwaysUseUnityInput; // 0x14
		public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource; // 0x18
		public OSXStandalonePrimaryInputSource osx_primaryInputSource; // 0x1C
		public LinuxStandalonePrimaryInputSource linux_primaryInputSource; // 0x20
		public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource; // 0x24
		public XboxOnePrimaryInputSource xboxOne_primaryInputSource; // 0x28
		public PS4PrimaryInputSource ps4_primaryInputSource; // 0x2C
		public WebGLPrimaryInputSource webGL_primaryInputSource; // 0x30
		public StadiaPrimaryInputSource stadia_primaryInputSource; // 0x34
		public bool useXInput; // 0x38
		public bool useNativeMouse; // 0x39
		public bool useEnhancedDeviceSupport; // 0x3A
		public bool windowsStandalone_useSteamRawInputControllerWorkaround; // 0x3B
		public bool osxStandalone_useEnhancedDeviceSupport; // 0x3C
		public bool android_supportUnknownGamepads; // 0x3D
		public bool ps4_assignJoysticksByPS4JoyId; // 0x3E
		public bool useSteamControllerSupport; // 0x3F
		public bool logToScreen; // 0x40
		public bool runInEditMode; // 0x41
		public bool allowInputInEditorSceneView; // 0x42
		public PlatformVars_WindowsStandalone platformVars_windowsStandalone; // 0x48
		public PlatformVars platformVars_linuxStandalone; // 0x50
		public PlatformVars platformVars_osxStandalone; // 0x58
		public PlatformVars platformVars_windows8Store; // 0x60
		public PlatformVars_WindowsUWP platformVars_windowsUWP; // 0x68
		public PlatformVars platformVars_iOS; // 0x70
		public PlatformVars platformVars_tvOS; // 0x78
		public PlatformVars platformVars_android; // 0x80
		public PlatformVars platformVars_ps3; // 0x88
		public PlatformVars platformVars_ps4; // 0x90
		public PlatformVars platformVars_psVita; // 0x98
		public PlatformVars platformVars_xbox360; // 0xA0
		public PlatformVars platformVars_xboxOne; // 0xA8
		public PlatformVars platformVars_wii; // 0xB0
		public PlatformVars platformVars_wiiu; // 0xB8
		public PlatformVars platformVars_switch; // 0xC0
		public PlatformVars platformVars_webGL; // 0xC8
		public PlatformVars platformVars_stadia; // 0xD0
		[NonSerialized]
		private PlatformVars platformVars_unknown; // 0xD8
		public int maxJoysticksPerPlayer; // 0xE0
		public bool autoAssignJoysticks; // 0xE4
		public bool assignJoysticksToPlayingPlayersOnly; // 0xE5
		public bool distributeJoysticksEvenly; // 0xE6
		public bool reassignJoystickToPreviousOwnerOnReconnect; // 0xE7
		public DeadZone2DType defaultJoystickAxis2DDeadZoneType; // 0xE8
		public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType; // 0xEC
		public AxisSensitivityType defaultAxisSensitivityType; // 0xF0
		public bool force4WayHats; // 0xF4
		public ThrottleCalibrationMode throttleCalibrationMode; // 0xF8
		public bool activateActionButtonsOnNegativeValue; // 0xFC
		public bool deferControllerConnectedEventsOnStart; // 0xFD
		public LogLevelFlags logLevel; // 0x100
		public EditorVars editorSettings; // 0x108
		private Dictionary<int, rpTrAwsXAJRPMDqARIyyMgKlojJ> __platformVarsDict; // 0x110
		private Dictionary<int, wuYFmVhjyhdZUrKTNYBnEqPefCs> __getSetPlatformVariableDict; // 0x118
	
		// Properties
		private Dictionary<int, rpTrAwsXAJRPMDqARIyyMgKlojJ> platformVarsDict { get; } // 0x00000001805DD020-0x00000001805DD8D0 
		private Dictionary<int, wuYFmVhjyhdZUrKTNYBnEqPefCs> getSetPlatformVariableDict { get; } // 0x00000001805DCE70-0x00000001805DD020 
	
		// Nested types
		[Serializable]
		public class PlatformVars // TypeDefIndex: 6027
		{
			// Fields
			public bool disableKeyboard; // 0x10
			public bool ignoreInputWhenAppNotInFocus; // 0x11
	
			// Constructors
			public PlatformVars(); // 0x00000001805EF450-0x00000001805EF460
		}
	
		[Serializable]
		public class PlatformVars_WindowsStandalone : PlatformVars // TypeDefIndex: 6028
		{
			// Fields
			public bool useNativeKeyboard; // 0x18
			public int joystickRefreshRate; // 0x1C
	
			// Constructors
			public PlatformVars_WindowsStandalone(); // 0x00000001805EF410-0x00000001805EF430
		}
	
		[Serializable]
		public class PlatformVars_WindowsUWP : PlatformVars // TypeDefIndex: 6029
		{
			// Fields
			public bool useGamepadAPI; // 0x18
			public bool useHIDAPI; // 0x19
	
			// Constructors
			public PlatformVars_WindowsUWP(); // 0x00000001805EF430-0x00000001805EF450
		}
	
		[Serializable]
		public sealed class EditorVars // TypeDefIndex: 6030
		{
			// Fields
			public bool exportConsts_useParentClass; // 0x10
			public string exportConsts_parentClassName; // 0x18
			public bool exportConsts_useNamespace; // 0x20
			public string exportConsts_namespace; // 0x28
			public bool exportConsts_actions; // 0x30
			public string exportConsts_actionsClassName; // 0x38
			public bool exportConsts_actionsIncludeActionCategory; // 0x40
			public bool exportConsts_actionsCreateClassesForActionCategories; // 0x41
			public bool exportConsts_mapCategories; // 0x42
			public string exportConsts_mapCategoriesClassName; // 0x48
			public bool exportConsts_layouts; // 0x50
			public string exportConsts_layoutsClassName; // 0x58
			public bool exportConsts_players; // 0x60
			public string exportConsts_playersClassName; // 0x68
			public bool exportConsts_inputBehaviors; // 0x70
			public string exportConsts_inputBehaviorsClassName; // 0x78
			public bool exportConsts_customControllers; // 0x80
			public string exportConsts_customControllersClassName; // 0x88
			public string exportConsts_customControllersAxesClassName; // 0x90
			public string exportConsts_customControllersButtonsClassName; // 0x98
			public bool exportConsts_layoutManagerRuleSets; // 0xA0
			public string exportConsts_layoutManagerRuleSetsClassName; // 0xA8
			public bool exportConsts_mapEnablerRuleSets; // 0xB0
			public string exportConsts_mapEnablerRuleSetsClassName; // 0xB8
			public bool exportConsts_allCapsConstantNames; // 0xC0
	
			// Constructors
			public EditorVars(); // 0x00000001805E9260-0x00000001805E9350
		}
	
		private class rpTrAwsXAJRPMDqARIyyMgKlojJ // TypeDefIndex: 6031
		{
			// Fields
			public Func<PlatformVars> bjvrYZcAaacSMKpeNuSKsmlSdeK; // 0x10
			public string BxhlzowUFEhJSiHyyFQttiYrjxH; // 0x18
	
			// Constructors
			public rpTrAwsXAJRPMDqARIyyMgKlojJ(Func<PlatformVars> getDelegate, string dataPath); // 0x00000001803DA900-0x00000001803DA940
		}
	
		private class wuYFmVhjyhdZUrKTNYBnEqPefCs // TypeDefIndex: 6032
		{
			// Fields
			public Func<Rewired.Platforms.Platform, object> bjvrYZcAaacSMKpeNuSKsmlSdeK; // 0x10
			public Action<Rewired.Platforms.Platform, object> vGMIYREICcYrjibzOuyHxSPUVBY; // 0x18
	
			// Constructors
			public wuYFmVhjyhdZUrKTNYBnEqPefCs(Func<Rewired.Platforms.Platform, object> getDelegate, Action<Rewired.Platforms.Platform, object> setDelegate); // 0x00000001803DA900-0x00000001803DA940
		}
	
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal enum AllPlatformVar // TypeDefIndex: 6033
		{
			DisableKeyboard = 0,
			IgnoreInputWhenAppNotInFocus = 1
		}
	
		// Constructors
		[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
		public ConfigVars(); // 0x00000001805DCE20-0x00000001805DCE70
	
		// Methods
		internal bool DoesPlatformUseFallback(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor); // 0x00000001805D9F10-0x00000001805D9FE0
		internal bool DoesPlatformUseSDL2(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor); // 0x00000001805D9FE0-0x00000001805DA030
		internal string GetDebugConfigSettings(); // 0x00000001805DA630-0x00000001805DBA40
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal string GetPlatformVarsRelPath(Rewired.Platforms.Platform platform); // 0x00000001805DBE80-0x00000001805DBF50
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal PlatformVars GetPlatformVars(Rewired.Platforms.Platform platform); // 0x00000001805DBFF0-0x00000001805DC120
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal T Editor_GetAllSerializedPlatformVar<T>(AllPlatformVar var);
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal void Editor_SetAllSerializedPlatformVar(AllPlatformVar var, object value); // 0x00000001805DA030-0x00000001805DA280
		internal bool GetPlatformVar_disableKeyboard(); // 0x00000001805DBA40-0x00000001805DBA70
		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus(); // 0x00000001805DBA70-0x00000001805DBAA0
		internal bool GetPlatformVar_useEnhancedDeviceSupport(); // 0x00000001805DBC10-0x00000001805DBC90
		internal bool GetPlatformVar_useNativeMouse(); // 0x00000001805DBDE0-0x00000001805DBE80
		internal bool GetPlatformVar_useNativeKeyboard(); // 0x00000001805DBC90-0x00000001805DBDE0
		internal int GetPlatformVar_joystickRefreshRate(); // 0x00000001805DBAA0-0x00000001805DBC10
		internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value); // 0x00000001805DC230-0x00000001805DC290
		internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value); // 0x00000001805DC440-0x00000001805DC4F0
		internal bool SetPlatformVar_useNativeMouse(bool value); // 0x00000001805DC680-0x00000001805DC700
		internal bool SetPlatformVar_useNativeKeyboard(bool value); // 0x00000001805DC4F0-0x00000001805DC680
		internal bool SetPlatformVar_joystickRefreshRate(int value); // 0x00000001805DC290-0x00000001805DC440
		private PlatformVars GetPlatformVars(); // 0x00000001805DBF50-0x00000001805DBFF0
		private T GetOrCreatePlatformVars<T>(ref T var)
			where T : PlatformVars, new();
		private MultiBoolValue GetAllSerializedPlatformVar_multiBool(AllPlatformVar var); // 0x00000001805DA280-0x00000001805DA630
		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform); // 0x00000001805DC120-0x00000001805DC230
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__1(); // 0x00000001805DCA60-0x00000001805DCAA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__2(); // 0x00000001805DCAA0-0x00000001805DCAE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__3(); // 0x00000001805DCAE0-0x00000001805DCB20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__4(); // 0x00000001805DCB20-0x00000001805DCB60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__5(); // 0x00000001805DCB60-0x00000001805DCBA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__6(); // 0x00000001805DCBA0-0x00000001805DCBE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__7(); // 0x00000001805DCBE0-0x00000001805DCC20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__8(); // 0x00000001805DCC20-0x00000001805DCC60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__9(); // 0x00000001805DCC60-0x00000001805DCCA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__a(); // 0x00000001805DCCA0-0x00000001805DCCE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__b(); // 0x00000001805DCCE0-0x00000001805DCD20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__c(); // 0x00000001805DCD20-0x00000001805DCD60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__d(); // 0x00000001805DCD60-0x00000001805DCDA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__e(); // 0x00000001805DCDA0-0x00000001805DCDE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__f(); // 0x00000001805DCDE0-0x00000001805DCE20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__10(); // 0x00000001805DC920-0x00000001805DC960
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__11(); // 0x00000001805DC960-0x00000001805DC9A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__12(); // 0x00000001805DC9A0-0x00000001805DC9E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__13(); // 0x00000001805DC9E0-0x00000001805DCA20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PlatformVars <get_platformVarsDict>b__14(); // 0x00000001805DCA20-0x00000001805DCA60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object <get_getSetPlatformVariableDict>b__16(Rewired.Platforms.Platform p); // 0x00000001805DC700-0x00000001805DC770
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <get_getSetPlatformVariableDict>b__17(Rewired.Platforms.Platform platform, object value); // 0x00000001805DC770-0x00000001805DC810
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object <get_getSetPlatformVariableDict>b__18(Rewired.Platforms.Platform platform); // 0x00000001805DC810-0x00000001805DC880
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <get_getSetPlatformVariableDict>b__19(Rewired.Platforms.Platform platform, object value); // 0x00000001805DC880-0x00000001805DC920
	}
}
