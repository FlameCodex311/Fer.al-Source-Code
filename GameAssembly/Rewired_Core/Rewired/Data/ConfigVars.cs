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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
	public sealed class ConfigVars // TypeDefIndex: 6185
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
		private Dictionary<int, rpTrAwsXAJRPMDqARIyyMgKlojJ> platformVarsDict { get; } // 0x0000000180D7C160-0x0000000180D7CA10 
		private Dictionary<int, wuYFmVhjyhdZUrKTNYBnEqPefCs> getSetPlatformVariableDict { get; } // 0x0000000180D7BFB0-0x0000000180D7C160 
	
		// Nested types
		[Serializable]
		public class PlatformVars // TypeDefIndex: 6186
		{
			// Fields
			public bool disableKeyboard; // 0x10
			public bool ignoreInputWhenAppNotInFocus; // 0x11
	
			// Constructors
			public PlatformVars(); // 0x0000000180D8E3F0-0x0000000180D8E400
		}
	
		[Serializable]
		public class PlatformVars_WindowsStandalone : PlatformVars // TypeDefIndex: 6187
		{
			// Fields
			public bool useNativeKeyboard; // 0x18
			public int joystickRefreshRate; // 0x1C
	
			// Constructors
			public PlatformVars_WindowsStandalone(); // 0x0000000180D8E3B0-0x0000000180D8E3D0
		}
	
		[Serializable]
		public class PlatformVars_WindowsUWP : PlatformVars // TypeDefIndex: 6188
		{
			// Fields
			public bool useGamepadAPI; // 0x18
			public bool useHIDAPI; // 0x19
	
			// Constructors
			public PlatformVars_WindowsUWP(); // 0x0000000180D8E3D0-0x0000000180D8E3F0
		}
	
		[Serializable]
		public sealed class EditorVars // TypeDefIndex: 6189
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
			public EditorVars(); // 0x0000000180D88340-0x0000000180D88430
		}
	
		private class rpTrAwsXAJRPMDqARIyyMgKlojJ // TypeDefIndex: 6190
		{
			// Fields
			public Func<PlatformVars> bjvrYZcAaacSMKpeNuSKsmlSdeK; // 0x10
			public string BxhlzowUFEhJSiHyyFQttiYrjxH; // 0x18
	
			// Constructors
			public rpTrAwsXAJRPMDqARIyyMgKlojJ(Func<PlatformVars> getDelegate, string dataPath); // 0x0000000180372010-0x00000001803720F0
		}
	
		private class wuYFmVhjyhdZUrKTNYBnEqPefCs // TypeDefIndex: 6191
		{
			// Fields
			public Func<Rewired.Platforms.Platform, object> bjvrYZcAaacSMKpeNuSKsmlSdeK; // 0x10
			public Action<Rewired.Platforms.Platform, object> vGMIYREICcYrjibzOuyHxSPUVBY; // 0x18
	
			// Constructors
			public wuYFmVhjyhdZUrKTNYBnEqPefCs(Func<Rewired.Platforms.Platform, object> getDelegate, Action<Rewired.Platforms.Platform, object> setDelegate); // 0x0000000180372010-0x00000001803720F0
		}
	
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal enum AllPlatformVar // TypeDefIndex: 6192
		{
			DisableKeyboard = 0,
			IgnoreInputWhenAppNotInFocus = 1
		}
	
		// Constructors
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ConfigVars(); // 0x0000000180D7BF60-0x0000000180D7BFB0
	
		// Methods
		internal bool DoesPlatformUseFallback(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor); // 0x0000000180D791D0-0x0000000180D792A0
		internal bool DoesPlatformUseSDL2(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor); // 0x0000000180D792A0-0x0000000180D792F0
		internal string GetDebugConfigSettings(); // 0x0000000180D798D0-0x0000000180D7ABD0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal string GetPlatformVarsRelPath(Rewired.Platforms.Platform platform); // 0x0000000180D7AFF0-0x0000000180D7B0B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal PlatformVars GetPlatformVars(Rewired.Platforms.Platform platform); // 0x0000000180D7B150-0x0000000180D7B280
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal T Editor_GetAllSerializedPlatformVar<T>(AllPlatformVar var);
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal void Editor_SetAllSerializedPlatformVar(AllPlatformVar var, object value); // 0x0000000180D792F0-0x0000000180D79530
		internal bool GetPlatformVar_disableKeyboard(); // 0x0000000180D7ABD0-0x0000000180D7ABF0
		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus(); // 0x0000000180D7ABF0-0x0000000180D7AC10
		internal bool GetPlatformVar_useEnhancedDeviceSupport(); // 0x0000000180D7AD80-0x0000000180D7AE00
		internal bool GetPlatformVar_useNativeMouse(); // 0x0000000180D7AF50-0x0000000180D7AFF0
		internal bool GetPlatformVar_useNativeKeyboard(); // 0x0000000180D7AE00-0x0000000180D7AF50
		internal int GetPlatformVar_joystickRefreshRate(); // 0x0000000180D7AC10-0x0000000180D7AD80
		internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value); // 0x0000000180D7B380-0x0000000180D7B3E0
		internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value); // 0x0000000180D7B590-0x0000000180D7B640
		internal bool SetPlatformVar_useNativeMouse(bool value); // 0x0000000180D7B7C0-0x0000000180D7B840
		internal bool SetPlatformVar_useNativeKeyboard(bool value); // 0x0000000180D7B640-0x0000000180D7B7C0
		internal bool SetPlatformVar_joystickRefreshRate(int value); // 0x0000000180D7B3E0-0x0000000180D7B590
		private PlatformVars GetPlatformVars(); // 0x0000000180D7B0B0-0x0000000180D7B150
		private T GetOrCreatePlatformVars<T>(ref T var)
			where T : PlatformVars, new();
		private MultiBoolValue GetAllSerializedPlatformVar_multiBool(AllPlatformVar var); // 0x0000000180D79530-0x0000000180D798D0
		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform); // 0x0000000180D7B280-0x0000000180D7B380
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__1(); // 0x0000000180D7BBA0-0x0000000180D7BBE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__2(); // 0x0000000180D7BBE0-0x0000000180D7BC20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__3(); // 0x0000000180D7BC20-0x0000000180D7BC60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__4(); // 0x0000000180D7BC60-0x0000000180D7BCA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__5(); // 0x0000000180D7BCA0-0x0000000180D7BCE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__6(); // 0x0000000180D7BCE0-0x0000000180D7BD20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__7(); // 0x0000000180D7BD20-0x0000000180D7BD60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__8(); // 0x0000000180D7BD60-0x0000000180D7BDA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__9(); // 0x0000000180D7BDA0-0x0000000180D7BDE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__a(); // 0x0000000180D7BDE0-0x0000000180D7BE20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__b(); // 0x0000000180D7BE20-0x0000000180D7BE60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__c(); // 0x0000000180D7BE60-0x0000000180D7BEA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__d(); // 0x0000000180D7BEA0-0x0000000180D7BEE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__e(); // 0x0000000180D7BEE0-0x0000000180D7BF20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__f(); // 0x0000000180D7BF20-0x0000000180D7BF60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__10(); // 0x0000000180D7BA60-0x0000000180D7BAA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__11(); // 0x0000000180D7BAA0-0x0000000180D7BAE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__12(); // 0x0000000180D7BAE0-0x0000000180D7BB20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__13(); // 0x0000000180D7BB20-0x0000000180D7BB60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PlatformVars <get_platformVarsDict>b__14(); // 0x0000000180D7BB60-0x0000000180D7BBA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <get_getSetPlatformVariableDict>b__16(Rewired.Platforms.Platform p); // 0x0000000180D7B840-0x0000000180D7B8B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <get_getSetPlatformVariableDict>b__17(Rewired.Platforms.Platform platform, object value); // 0x0000000180D7B8B0-0x0000000180D7B950
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <get_getSetPlatformVariableDict>b__18(Rewired.Platforms.Platform platform); // 0x0000000180D7B950-0x0000000180D7B9C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <get_getSetPlatformVariableDict>b__19(Rewired.Platforms.Platform platform, object value); // 0x0000000180D7B9C0-0x0000000180D7BA60
	}
}
