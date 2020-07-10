/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C0950-0x00000001800C09B0
	[CustomObfuscation] // 0x00000001800C0950-0x00000001800C09B0
	[EditorBrowsable] // 0x00000001800C0950-0x00000001800C09B0
	public static class Consts // TypeDefIndex: 5889
	{
		// Fields
		public const int systemPlayerId = 9999999; // Metadata: 0x0072ED64
		public const string menuRoot = "Window/Rewired"; // Metadata: 0x0072ED68
		internal const int programVersion1 = 1; // Metadata: 0x0072ED7A
		internal const int programVersion2 = 1; // Metadata: 0x0072ED7E
		internal const int programVersion3 = 28; // Metadata: 0x0072ED82
		internal const int programVersion4 = 0; // Metadata: 0x0072ED86
		internal const int dataVersion = 1; // Metadata: 0x0072ED8A
		internal const int unityMajorVersion = 2019; // Metadata: 0x0072ED8E
		internal const string unityMajorVersionIdentifier = "U2019"; // Metadata: 0x0072ED92
		internal const bool isTrial = false; // Metadata: 0x0072ED9B
		internal const string copyrightYear = "2019"; // Metadata: 0x0072ED9C
		internal const string defaultNamespace = "Rewired"; // Metadata: 0x0072EDA4
		internal const LogLevelFlags defaultLogLevel = LogLevelFlags.Off | LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error; // Metadata: 0x0072EDAF
		internal const bool allowInputWhenEditorPaused = true; // Metadata: 0x0072EDB3
		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]"; // Metadata: 0x0072EDB4
		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]"; // Metadata: 0x0072EDC7
		internal const float editorGUIUpdateInterval = 0.5f; // Metadata: 0x0072EDDD
		internal const float joystickRefreshPollCheckTimeout = 1f; // Metadata: 0x0072EDE1
		internal const float controllerRefreshWaitTimeout = 0.5f; // Metadata: 0x0072EDE5
		internal const int buttonsPerHat = 8; // Metadata: 0x0072EDE9
		internal const int keyboardKeyCount = 132; // Metadata: 0x0072EDED
		internal const int keyboardModifierKeyCount = 8; // Metadata: 0x0072EDF1
		internal const int unityMouseButtonCount = 7; // Metadata: 0x0072EDF5
		internal const int unityMouseAxisCount = 3; // Metadata: 0x0072EDF9
		internal const int unityMaxJoysticks = 16; // Metadata: 0x0072EDFD
		internal const int unityJoystickButtonCount = 20; // Metadata: 0x0072EE01
		internal const int unityJoystickStartingButtonKeycodeValue = 350; // Metadata: 0x0072EE05
		internal const int unityJoystickAxisCount = 29; // Metadata: 0x0072EE09
		internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16; // Metadata: 0x0072EE0D
		internal const string unityJoystickPrefix = "Joy"; // Metadata: 0x0072EE11
		internal const string unityJoystickAxisSuffix = "Axis"; // Metadata: 0x0072EE18
		internal const string unityJoystickButtonSuffix = "Button"; // Metadata: 0x0072EE20
		internal const int directInputMaxButtons = 128; // Metadata: 0x0072EE2A
		internal const int directInputMaxAxes = 32; // Metadata: 0x0072EE2E
		internal const int directInputMaxHats = 4; // Metadata: 0x0072EE32
		internal const int directInputMaxSliders = 2; // Metadata: 0x0072EE36
		internal const int directInputMaxAxisValue = 65535; // Metadata: 0x0072EE3A
		internal const int directInputMinAxisValue = -65535; // Metadata: 0x0072EE3E
		internal const int directInputMaxHatValue = 36000; // Metadata: 0x0072EE42
		internal const int directInputHatZeroValue = -1; // Metadata: 0x0072EE46
		internal const int directInputHatSpan = 4500; // Metadata: 0x0072EE4A
		internal const int directInputHatSpan4Way = 9000; // Metadata: 0x0072EE4E
		internal const int directInput_hatValue_up = 0; // Metadata: 0x0072EE52
		internal const int directInput_hatValue_right = 9000; // Metadata: 0x0072EE56
		internal const int directInput_hatValue_down = 18000; // Metadata: 0x0072EE5A
		internal const int directInput_hatValue_left = 27000; // Metadata: 0x0072EE5E
		internal const int directInputLastDirectionValue = 31500; // Metadata: 0x0072EE62
		internal const int directInputLastDirectionValue4Way = 27000; // Metadata: 0x0072EE66
		internal const int directInputUnknownJoystickHatCount = 2; // Metadata: 0x0072EE6A
		internal const int directInputUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072EE6E
		internal const int directInputJoystickStateByteSize = 264; // Metadata: 0x0072EE72
		internal const int rawInputMaxButtons = 256; // Metadata: 0x0072EE76
		internal const int rawInputMaxAxes = 56; // Metadata: 0x0072EE7A
		internal const int rawInputMaxHats = 4; // Metadata: 0x0072EE7E
		internal const int rawInputMaxSliders = 2; // Metadata: 0x0072EE82
		internal const int rawInputMaxAxisValue = 65535; // Metadata: 0x0072EE86
		internal const int rawInputMinAxisValue = -65535; // Metadata: 0x0072EE8A
		internal const int rawInputMaxHatValue = 36000; // Metadata: 0x0072EE8E
		internal const int rawInputHatZeroValue = -1; // Metadata: 0x0072EE92
		internal const int rawInputHatSpan = 4500; // Metadata: 0x0072EE96
		internal const int rawInputHatSpan4Way = 9000; // Metadata: 0x0072EE9A
		internal const int rawInput_hatValue_up = 0; // Metadata: 0x0072EE9E
		internal const int rawInput_hatValue_right = 9000; // Metadata: 0x0072EEA2
		internal const int rawInput_hatValue_down = 18000; // Metadata: 0x0072EEA6
		internal const int rawInput_hatValue_left = 27000; // Metadata: 0x0072EEAA
		internal const int rawInputLastDirectionValue = 31500; // Metadata: 0x0072EEAE
		internal const int rawInputLastDirectionValue4Way = 27000; // Metadata: 0x0072EEB2
		internal const int rawInputUnknownJoystickHatCount = 2; // Metadata: 0x0072EEB6
		internal const int rawInputUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072EEBA
		internal const int rawInputUnifiedMouseButtonCount = 5; // Metadata: 0x0072EEBE
		internal const int rawInputUnifiedMouseAxisCount = 3; // Metadata: 0x0072EEC2
		internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x0072EEC6
		internal const int rawInputUnifiedKeyboardButtonCount = 132; // Metadata: 0x0072EECA
		internal const int osxMaxSticks = 4; // Metadata: 0x0072EECE
		internal const int osxMaxButtons = 128; // Metadata: 0x0072EED2
		internal const int osxMaxAxesPerStick = 14; // Metadata: 0x0072EED6
		internal const int osxMaxHatsPerStick = 4; // Metadata: 0x0072EEDA
		internal const int osxMaxAxisValue = 65536; // Metadata: 0x0072EEDE
		internal const int osxMinAxisValue = -65536; // Metadata: 0x0072EEE2
		internal const int osxMaxPressureSensitiveButtonValue = 65536; // Metadata: 0x0072EEE6
		internal const int osxMinPressureSensitiveButtonValue = 0; // Metadata: 0x0072EEEA
		internal const int osxMaxHatValue = 36000; // Metadata: 0x0072EEEE
		internal const int osxInputHatZeroValue = -1; // Metadata: 0x0072EEF2
		internal const int osxHatSpan = 4500; // Metadata: 0x0072EEF6
		internal const int osxHatSpan4Way = 9000; // Metadata: 0x0072EEFA
		internal const int osx_hatValue_up = 0; // Metadata: 0x0072EEFE
		internal const int osx_hatValue_right = 9000; // Metadata: 0x0072EF02
		internal const int osx_hatValue_down = 18000; // Metadata: 0x0072EF06
		internal const int osx_hatValue_left = 27000; // Metadata: 0x0072EF0A
		internal const int osxLastDirectionValue = 31500; // Metadata: 0x0072EF0E
		internal const int osxLastDirectionValue4Way = 27000; // Metadata: 0x0072EF12
		internal const int osxUnknownJoystickHatCount = 16; // Metadata: 0x0072EF16
		internal const int osxUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072EF1A
		internal const int linuxMaxButtons = 256; // Metadata: 0x0072EF1E
		internal const int linuxMaxAxes = 56; // Metadata: 0x0072EF22
		internal const int linuxMaxHats = 4; // Metadata: 0x0072EF26
		internal const int linuxMaxSliders = 2; // Metadata: 0x0072EF2A
		internal const int linuxMaxAxisValue = 32767; // Metadata: 0x0072EF2E
		internal const int linuxMinAxisValue = -32768; // Metadata: 0x0072EF32
		internal const int linuxMaxHatValue = 36000; // Metadata: 0x0072EF36
		internal const int linuxHatZeroValue = -1; // Metadata: 0x0072EF3A
		internal const int linuxHatSpan = 4500; // Metadata: 0x0072EF3E
		internal const int linuxHatSpan4Way = 9000; // Metadata: 0x0072EF42
		internal const int linux_hatValue_up = 0; // Metadata: 0x0072EF46
		internal const int linux_hatValue_right = 9000; // Metadata: 0x0072EF4A
		internal const int linux_hatValue_down = 18000; // Metadata: 0x0072EF4E
		internal const int linux_hatValue_left = 27000; // Metadata: 0x0072EF52
		internal const int linuxLastDirectionValue = 31500; // Metadata: 0x0072EF56
		internal const int linuxLastDirectionValue4Way = 27000; // Metadata: 0x0072EF5A
		internal const int linuxUnknownJoystickHatCount = 2; // Metadata: 0x0072EF5E
		internal const int linuxUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072EF62
		internal const int linuxUnifiedMouseButtonCount = 5; // Metadata: 0x0072EF66
		internal const int linuxUnifiedMouseAxisCount = 3; // Metadata: 0x0072EF6A
		internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x0072EF6E
		internal const int sdl2MaxButtons = 256; // Metadata: 0x0072EF72
		internal const int sdl2MaxAxes = 56; // Metadata: 0x0072EF76
		internal const int sdl2MaxHats = 4; // Metadata: 0x0072EF7A
		internal const int sdl2MaxSliders = 2; // Metadata: 0x0072EF7E
		internal const int sdl2MaxAxisValue = 32768; // Metadata: 0x0072EF82
		internal const int sdl2MinAxisValue = -32767; // Metadata: 0x0072EF86
		internal const int sdl2AxisZeroValue = 0; // Metadata: 0x0072EF8A
		internal const int sdl2MaxHatValue = 36000; // Metadata: 0x0072EF8E
		internal const int sdl2HatZeroValue = -1; // Metadata: 0x0072EF92
		internal const int sdl2HatSpan = 4500; // Metadata: 0x0072EF96
		internal const int sdl2HatSpan4Way = 9000; // Metadata: 0x0072EF9A
		internal const int sdl2_hatValue_up = 0; // Metadata: 0x0072EF9E
		internal const int sdl2_hatValue_right = 9000; // Metadata: 0x0072EFA2
		internal const int sdl2_hatValue_down = 18000; // Metadata: 0x0072EFA6
		internal const int sdl2_hatValue_left = 27000; // Metadata: 0x0072EFAA
		internal const int sdl2LastDirectionValue = 31500; // Metadata: 0x0072EFAE
		internal const int sdl2LastDirectionValue4Way = 27000; // Metadata: 0x0072EFB2
		internal const int sdl2UnknownJoystickHatCount = 2; // Metadata: 0x0072EFB6
		internal const int sdl2UnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072EFBA
		internal const int sdl2UnifiedMouseButtonCount = 5; // Metadata: 0x0072EFBE
		internal const int sdl2UnifiedMouseAxisCount = 3; // Metadata: 0x0072EFC2
		internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x0072EFC6
		internal const int windowsUWPMaxButtons = 256; // Metadata: 0x0072EFCA
		internal const int windowsUWPMaxAxes = 56; // Metadata: 0x0072EFCE
		internal const int windowsUWPMaxHats = 4; // Metadata: 0x0072EFD2
		internal const int windowsUWPMaxSliders = 2; // Metadata: 0x0072EFD6
		internal const int windowsUWPMaxAxisValue = 32767; // Metadata: 0x0072EFDA
		internal const int windowsUWPMinAxisValue = -32768; // Metadata: 0x0072EFDE
		internal const int windowsUWPMaxHatValue = 36000; // Metadata: 0x0072EFE2
		internal const int windowsUWPHatZeroValue = -1; // Metadata: 0x0072EFE6
		internal const int windowsUWPDirectionsPerHat = 8; // Metadata: 0x0072EFEA
		internal const int windowsUWPHatSpan = 4500; // Metadata: 0x0072EFEE
		internal const int windowsUWPHatSpan4Way = 9000; // Metadata: 0x0072EFF2
		internal const int windowsUWPLastDirectionValue = 31500; // Metadata: 0x0072EFF6
		internal const int windowsUWPLastDirectionValue4Way = 27000; // Metadata: 0x0072EFFA
		internal const int windowsUWPUnknownJoystickHatCount = 2; // Metadata: 0x0072EFFE
		internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072F002
		internal const int windowsUWPUnifiedMouseButtonCount = 5; // Metadata: 0x0072F006
		internal const int windowsUWPUnifiedMouseAxisCount = 3; // Metadata: 0x0072F00A
		internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x0072F00E
		internal const int xInputMaxVibration = 65535; // Metadata: 0x0072F012
		internal const int xInputMinVibration = 0; // Metadata: 0x0072F016
		internal const float xInputAllowedVibrationInterval = 0.01f; // Metadata: 0x0072F01A
		internal const int customPlatformMaxButtons = 256; // Metadata: 0x0072F01E
		internal const int customPlatformMaxAxes = 128; // Metadata: 0x0072F022
		internal const int internalDriverMaxButtons = 256; // Metadata: 0x0072F026
		internal const int internalDriverMaxAxes = 56; // Metadata: 0x0072F02A
		internal const int internalDriverMaxHats = 4; // Metadata: 0x0072F02E
		internal const int internalDriverMaxSliders = 2; // Metadata: 0x0072F032
		internal const int internalDriverMaxAxisValue = 65535; // Metadata: 0x0072F036
		internal const int internalDriverMinAxisValue = -65535; // Metadata: 0x0072F03A
		internal const int internalDriverMaxHatValue = 36000; // Metadata: 0x0072F03E
		internal const int internalDriverHatZeroValue = -1; // Metadata: 0x0072F042
		internal const int internalDriverHatSpan = 4500; // Metadata: 0x0072F046
		internal const int internalDriverHatSpan4Way = 9000; // Metadata: 0x0072F04A
		internal const int internalDriver_hatValue_up = 0; // Metadata: 0x0072F04E
		internal const int internalDriver_hatValue_right = 9000; // Metadata: 0x0072F052
		internal const int internalDriver_hatValue_down = 18000; // Metadata: 0x0072F056
		internal const int internalDriver_hatValue_left = 27000; // Metadata: 0x0072F05A
		internal const int internalDriverLastDirectionValue = 31500; // Metadata: 0x0072F05E
		internal const int internalDriverLastDirectionValue4Way = 27000; // Metadata: 0x0072F062
		internal const int internalDriverUnknownJoystickHatCount = 2; // Metadata: 0x0072F066
		internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x0072F06A
		internal const int internalDriverUnifiedMouseButtonCount = 5; // Metadata: 0x0072F06E
		internal const int internalDriverUnifiedMouseAxisCount = 3; // Metadata: 0x0072F072
		internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x0072F076
		internal const int webGLMaxButtons = 256; // Metadata: 0x0072F07A
		internal const int webGLMaxAxes = 128; // Metadata: 0x0072F07E
		internal const int stadiaMaxButtons = 256; // Metadata: 0x0072F082
		internal const int stadiaMaxAxes = 128; // Metadata: 0x0072F086
		internal const float axisPollingDeadzone = 0.7f; // Metadata: 0x0072F08A
		internal const float mouseXYAxisPollingDeadzone = 100f; // Metadata: 0x0072F08E
		internal const float mouseOtherAxisPollingDeadzone = 2f; // Metadata: 0x0072F092
		internal const float defaultButtonDeadZone = 0.5f; // Metadata: 0x0072F096
		internal const float hardwareButtonDeadZone = 0.01f; // Metadata: 0x0072F09A
		internal const float axisDefaultSensitivity = 1f; // Metadata: 0x0072F09E
		internal const AxisSensitivityType axisDefaultSensitivityType = AxisSensitivityType.Multiplier; // Metadata: 0x0072F0A2
		internal const float defaultButtonDoublePressSpeed = 0.3f; // Metadata: 0x0072F0A6
		internal const float minDoubleButtonPressSpeed = 0.01f; // Metadata: 0x0072F0AA
		internal const float maxDoubleButtonPressSpeed = 10f; // Metadata: 0x0072F0AE
		internal const float defaultButtonShortPressTime = 0.25f; // Metadata: 0x0072F0B2
		internal const float minButtonShortPressTime = 0f; // Metadata: 0x0072F0B6
		internal const float maxButtonShortPressTime = 3.4028235E+38f; // Metadata: 0x0072F0BA
		internal const float defaultButtonShortPressExpiresIn = 0f; // Metadata: 0x0072F0BE
		internal const float minButtonShortPressExpiresIn = 0f; // Metadata: 0x0072F0C2
		internal const float maxButtonShortPressExpiresIn = 3.4028235E+38f; // Metadata: 0x0072F0C6
		internal const float defaultButtonLongPressTime = 1f; // Metadata: 0x0072F0CA
		internal const float minButtonLongPressTime = 0f; // Metadata: 0x0072F0CE
		internal const float maxButtonLongPressTime = 3.4028235E+38f; // Metadata: 0x0072F0D2
		internal const float defaultButtonLongPressExpiresIn = 0f; // Metadata: 0x0072F0D6
		internal const float minButtonLongPressExpiresIn = 0f; // Metadata: 0x0072F0DA
		internal const float maxButtonLongPressExpiresIn = 3.4028235E+38f; // Metadata: 0x0072F0DE
		internal const float defaultButtonRepeatDelay = 0f; // Metadata: 0x0072F0E2
		internal const float defaultButtonRepeatRate = 30f; // Metadata: 0x0072F0E6
		internal const float minButtonRepeatRate = 0.001f; // Metadata: 0x0072F0EA
		internal const float mouseAxisPollingTimerLength = 1f; // Metadata: 0x0072F0EE
		internal const float fallbackPollingTimeout = 1f; // Metadata: 0x0072F0F2
		internal const string unknownJoystickName = "Unknown Controller"; // Metadata: 0x0072F0F6
		internal const float xInputControllerVibrationRenewalInterval = 1.5f; // Metadata: 0x0072F10C
		internal const float stadiaControllerVibrationRenewalInterval = 1f; // Metadata: 0x0072F110
		internal const int defaultInputThreadUpdateRateFPS = 240; // Metadata: 0x0072F114
		internal const int maxInputThreadUpdateRateFPS = 2000; // Metadata: 0x0072F118
		internal const int osxXInputOutputReportRefreshRateFPS = 60; // Metadata: 0x0072F11C
		internal const int defaultOutputRefreshRateFPS = 100; // Metadata: 0x0072F120
		internal const int hidOutputReportRefreshRateFPS = 100; // Metadata: 0x0072F124
		internal const int hidOutputReportThreadKillTimeout = 10000; // Metadata: 0x0072F128
		internal const int joystickInputReportRingBufferCapacity = 25; // Metadata: 0x0072F12C
		internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows"; // Metadata: 0x0072F130
		internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX"; // Metadata: 0x0072F148
		internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux"; // Metadata: 0x0072F15C
		internal const float defaultInputBehaviorAxisSensitivity = 1f; // Metadata: 0x0072F172
		internal const float defaultInputBehaviorAxisSimulation_gravity = 3f; // Metadata: 0x0072F176
		internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3f; // Metadata: 0x0072F17A
		internal const bool defaultInputBehaviorAxisSmoothing_snap = true; // Metadata: 0x0072F17E
		internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = false; // Metadata: 0x0072F17F
		internal const bool defaultInputBehaviorAxisSimulation_enabled = true; // Metadata: 0x0072F180
		internal const int allFlagsIntEnum = -1; // Metadata: 0x0072F181
		internal const int lowLevelEventBuffers_buttonEventBufferSize = 16; // Metadata: 0x0072F185
		internal const string schemaNameSpace = "http://guavaman.com/rewired"; // Metadata: 0x0072F189
		internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/"; // Metadata: 0x0072F1A8
		internal const string schemaVersionControllerMap = "1.1"; // Metadata: 0x0072F1D0
		internal const string schemaVersionCalibrationMap = "1.3"; // Metadata: 0x0072F1D7
		internal const string schemaVersionInputBehavior = "1.4"; // Metadata: 0x0072F1DE
		internal const string schemaVersionControllerTemplateMap = "1.0"; // Metadata: 0x0072F1E5
		internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0"; // Metadata: 0x0072F1EC
		internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0"; // Metadata: 0x0072F1F3
		internal const int controllerMapDataVersion = 2; // Metadata: 0x0072F1FA
		internal const int calibrationMapDataVersion = 4; // Metadata: 0x0072F1FE
		internal const int inputBehaviorDataVersion = 5; // Metadata: 0x0072F202
		internal const int controllerTemplateMapDataVersion = 1; // Metadata: 0x0072F206
		internal const int playerMapEnablerDataVersion = 1; // Metadata: 0x0072F20A
		internal const int playerControllerMapLayoutManagerDataVersion = 1; // Metadata: 0x0072F20E
		internal const int controllerElementType_trueElements_minValue = 0; // Metadata: 0x0072F212
		internal const int controllerElementType_trueElements_maxValue = 99; // Metadata: 0x0072F216
		internal const float pressureSensitiveButtonDeadZone = 0.001f; // Metadata: 0x0072F21A
		internal const string rewiredEditorAssembly = "Rewired_Editor"; // Metadata: 0x0072F21E
		internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor"; // Metadata: 0x0072F230
		internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime"; // Metadata: 0x0072F24E
		internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager"; // Metadata: 0x0072F276
		internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1"; // Metadata: 0x0072F2AD
		internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204"; // Metadata: 0x0072F2D5
		internal const string stadiaPluginEditorRuntimeAssembly = "Rewired_Stadia_EditorRuntime"; // Metadata: 0x0072F2FD
		internal const string stadiaPluginInputManagerFullClassPath = "Rewired.Platforms.Stadia.StadiaInputManager"; // Metadata: 0x0072F31D
		internal const int updateLoopTypeCount = 3; // Metadata: 0x0072F34C
		internal static readonly PidVid[] questionablePidVids; // 0x00
		internal static readonly int[] questionableVIDs; // 0x08
		internal static Guid joystickGuid_appleMFiController; // 0x10
		internal static Guid joystickGuid_standardizedGamepad; // 0x20
		internal static Guid joystickGuid_SonyDualShock4; // 0x30
		internal static Guid hardwareTypeGuid_universalKeyboard; // 0x40
		internal static Guid hardwareTypeGuid_universalMouse; // 0x50
		internal static readonly IList<string> unityMouseElementNames; // 0x60
		private static readonly string[] BOOaLpAOcFOKJFZXRKWNMjsTeUUd; // 0x68
		internal static readonly IList<string> unityMouseAxisPositiveNames; // 0x70
		private static readonly string[] TwqGhFsJdtNBwABBMdyRSxgklWg; // 0x78
		internal static readonly IList<string> unityMouseAxisNegativeNames; // 0x80
		private static readonly string[] iKTWMUXyvBBUbDvoapYbTAgCQsk; // 0x88
		internal static readonly IList<string> rawInputUnifiedMouseElementNames; // 0x90
		private static readonly string[] yyShHiILDIOIKFEBWDgFvGUKCwD; // 0x98
		internal static readonly IList<string> rawInputUnifiedMouseAxisPositiveNames; // 0xA0
		private static readonly string[] bkvTOItFUXRJwOOneKsslywIcoZ; // 0xA8
		internal static readonly IList<string> rawInputUnifiedMouseAxisNegativeNames; // 0xB0
		private static readonly string[] zJHgUHYyHiYRfAGmyxZiTVnjtRZ; // 0xB8
		internal static readonly IList<int> unityMouseElementIdentifierIds; // 0xC0
		private static readonly int[] IxhoRdFXZhJEOSTGdrLfSUOlEjj; // 0xC8
		internal static readonly IList<int> rawInputUnifiedMouseElementIdentifierIds; // 0xD0
		private static readonly int[] ALGaFTDgxQhFifdYbQOWyaRJPQiu; // 0xD8
		internal static readonly IList<string> mouseAxisUnityNames; // 0xE0
		private static readonly string[] bCVfPliCoIaqLJZlVDkzeqbWnuc; // 0xE8
		internal static readonly IList<string> mouseButtonUnityNames; // 0xF0
		private static readonly string[] YGwVQFpCupfRghrFHPflKATyRfLp; // 0xF8
		internal static readonly IList<string> keyboardKeyNames; // 0x100
		private static readonly string[] LdMJwhAglrGZuBscZXYJafYVaiJ; // 0x108
		internal static readonly IList<int> keyboardKeyValues; // 0x110
		internal static readonly int[] _keyboardKeyValues; // 0x118
		internal static readonly IList<string> modifierKeyShortNames; // 0x120
		private static readonly string[] kqoaXidMNvcErsLwAfmmEujhhOap; // 0x128
	
		// Properties
		internal static int nintendoSwitchPlugin_minPluginVersion { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		internal static int stadiaPlugin_minPluginVersion { get; } // 0x000000018042E670-0x000000018042E680 
	
		// Constructors
		static Consts(); // 0x0000000180437D90-0x000000018043D4B0
	}
}
