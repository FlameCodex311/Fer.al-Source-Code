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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001802209B0-0x0000000180220A10
	[CustomObfuscation] // 0x00000001802209B0-0x0000000180220A10
	[EditorBrowsable] // 0x00000001802209B0-0x0000000180220A10
	public static class Consts // TypeDefIndex: 6048
	{
		// Fields
		public const int systemPlayerId = 9999999; // Metadata: 0x00763A01
		public const string menuRoot = "Window/Rewired"; // Metadata: 0x00763A05
		internal const int programVersion1 = 1; // Metadata: 0x00763A17
		internal const int programVersion2 = 1; // Metadata: 0x00763A1B
		internal const int programVersion3 = 28; // Metadata: 0x00763A1F
		internal const int programVersion4 = 0; // Metadata: 0x00763A23
		internal const int dataVersion = 1; // Metadata: 0x00763A27
		internal const int unityMajorVersion = 2019; // Metadata: 0x00763A2B
		internal const string unityMajorVersionIdentifier = "U2019"; // Metadata: 0x00763A2F
		internal const bool isTrial = false; // Metadata: 0x00763A38
		internal const string copyrightYear = "2019"; // Metadata: 0x00763A39
		internal const string defaultNamespace = "Rewired"; // Metadata: 0x00763A41
		internal const LogLevelFlags defaultLogLevel = LogLevelFlags.Off | LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error; // Metadata: 0x00763A4C
		internal const bool allowInputWhenEditorPaused = true; // Metadata: 0x00763A50
		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]"; // Metadata: 0x00763A51
		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]"; // Metadata: 0x00763A64
		internal const float editorGUIUpdateInterval = 0.5f; // Metadata: 0x00763A7A
		internal const float joystickRefreshPollCheckTimeout = 1f; // Metadata: 0x00763A7E
		internal const float controllerRefreshWaitTimeout = 0.5f; // Metadata: 0x00763A82
		internal const int buttonsPerHat = 8; // Metadata: 0x00763A86
		internal const int keyboardKeyCount = 132; // Metadata: 0x00763A8A
		internal const int keyboardModifierKeyCount = 8; // Metadata: 0x00763A8E
		internal const int unityMouseButtonCount = 7; // Metadata: 0x00763A92
		internal const int unityMouseAxisCount = 3; // Metadata: 0x00763A96
		internal const int unityMaxJoysticks = 16; // Metadata: 0x00763A9A
		internal const int unityJoystickButtonCount = 20; // Metadata: 0x00763A9E
		internal const int unityJoystickStartingButtonKeycodeValue = 350; // Metadata: 0x00763AA2
		internal const int unityJoystickAxisCount = 29; // Metadata: 0x00763AA6
		internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16; // Metadata: 0x00763AAA
		internal const string unityJoystickPrefix = "Joy"; // Metadata: 0x00763AAE
		internal const string unityJoystickAxisSuffix = "Axis"; // Metadata: 0x00763AB5
		internal const string unityJoystickButtonSuffix = "Button"; // Metadata: 0x00763ABD
		internal const int directInputMaxButtons = 128; // Metadata: 0x00763AC7
		internal const int directInputMaxAxes = 32; // Metadata: 0x00763ACB
		internal const int directInputMaxHats = 4; // Metadata: 0x00763ACF
		internal const int directInputMaxSliders = 2; // Metadata: 0x00763AD3
		internal const int directInputMaxAxisValue = 65535; // Metadata: 0x00763AD7
		internal const int directInputMinAxisValue = -65535; // Metadata: 0x00763ADB
		internal const int directInputMaxHatValue = 36000; // Metadata: 0x00763ADF
		internal const int directInputHatZeroValue = -1; // Metadata: 0x00763AE3
		internal const int directInputHatSpan = 4500; // Metadata: 0x00763AE7
		internal const int directInputHatSpan4Way = 9000; // Metadata: 0x00763AEB
		internal const int directInput_hatValue_up = 0; // Metadata: 0x00763AEF
		internal const int directInput_hatValue_right = 9000; // Metadata: 0x00763AF3
		internal const int directInput_hatValue_down = 18000; // Metadata: 0x00763AF7
		internal const int directInput_hatValue_left = 27000; // Metadata: 0x00763AFB
		internal const int directInputLastDirectionValue = 31500; // Metadata: 0x00763AFF
		internal const int directInputLastDirectionValue4Way = 27000; // Metadata: 0x00763B03
		internal const int directInputUnknownJoystickHatCount = 2; // Metadata: 0x00763B07
		internal const int directInputUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763B0B
		internal const int directInputJoystickStateByteSize = 264; // Metadata: 0x00763B0F
		internal const int rawInputMaxButtons = 256; // Metadata: 0x00763B13
		internal const int rawInputMaxAxes = 56; // Metadata: 0x00763B17
		internal const int rawInputMaxHats = 4; // Metadata: 0x00763B1B
		internal const int rawInputMaxSliders = 2; // Metadata: 0x00763B1F
		internal const int rawInputMaxAxisValue = 65535; // Metadata: 0x00763B23
		internal const int rawInputMinAxisValue = -65535; // Metadata: 0x00763B27
		internal const int rawInputMaxHatValue = 36000; // Metadata: 0x00763B2B
		internal const int rawInputHatZeroValue = -1; // Metadata: 0x00763B2F
		internal const int rawInputHatSpan = 4500; // Metadata: 0x00763B33
		internal const int rawInputHatSpan4Way = 9000; // Metadata: 0x00763B37
		internal const int rawInput_hatValue_up = 0; // Metadata: 0x00763B3B
		internal const int rawInput_hatValue_right = 9000; // Metadata: 0x00763B3F
		internal const int rawInput_hatValue_down = 18000; // Metadata: 0x00763B43
		internal const int rawInput_hatValue_left = 27000; // Metadata: 0x00763B47
		internal const int rawInputLastDirectionValue = 31500; // Metadata: 0x00763B4B
		internal const int rawInputLastDirectionValue4Way = 27000; // Metadata: 0x00763B4F
		internal const int rawInputUnknownJoystickHatCount = 2; // Metadata: 0x00763B53
		internal const int rawInputUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763B57
		internal const int rawInputUnifiedMouseButtonCount = 5; // Metadata: 0x00763B5B
		internal const int rawInputUnifiedMouseAxisCount = 3; // Metadata: 0x00763B5F
		internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x00763B63
		internal const int rawInputUnifiedKeyboardButtonCount = 132; // Metadata: 0x00763B67
		internal const int osxMaxSticks = 4; // Metadata: 0x00763B6B
		internal const int osxMaxButtons = 128; // Metadata: 0x00763B6F
		internal const int osxMaxAxesPerStick = 14; // Metadata: 0x00763B73
		internal const int osxMaxHatsPerStick = 4; // Metadata: 0x00763B77
		internal const int osxMaxAxisValue = 65536; // Metadata: 0x00763B7B
		internal const int osxMinAxisValue = -65536; // Metadata: 0x00763B7F
		internal const int osxMaxPressureSensitiveButtonValue = 65536; // Metadata: 0x00763B83
		internal const int osxMinPressureSensitiveButtonValue = 0; // Metadata: 0x00763B87
		internal const int osxMaxHatValue = 36000; // Metadata: 0x00763B8B
		internal const int osxInputHatZeroValue = -1; // Metadata: 0x00763B8F
		internal const int osxHatSpan = 4500; // Metadata: 0x00763B93
		internal const int osxHatSpan4Way = 9000; // Metadata: 0x00763B97
		internal const int osx_hatValue_up = 0; // Metadata: 0x00763B9B
		internal const int osx_hatValue_right = 9000; // Metadata: 0x00763B9F
		internal const int osx_hatValue_down = 18000; // Metadata: 0x00763BA3
		internal const int osx_hatValue_left = 27000; // Metadata: 0x00763BA7
		internal const int osxLastDirectionValue = 31500; // Metadata: 0x00763BAB
		internal const int osxLastDirectionValue4Way = 27000; // Metadata: 0x00763BAF
		internal const int osxUnknownJoystickHatCount = 16; // Metadata: 0x00763BB3
		internal const int osxUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763BB7
		internal const int linuxMaxButtons = 256; // Metadata: 0x00763BBB
		internal const int linuxMaxAxes = 56; // Metadata: 0x00763BBF
		internal const int linuxMaxHats = 4; // Metadata: 0x00763BC3
		internal const int linuxMaxSliders = 2; // Metadata: 0x00763BC7
		internal const int linuxMaxAxisValue = 32767; // Metadata: 0x00763BCB
		internal const int linuxMinAxisValue = -32768; // Metadata: 0x00763BCF
		internal const int linuxMaxHatValue = 36000; // Metadata: 0x00763BD3
		internal const int linuxHatZeroValue = -1; // Metadata: 0x00763BD7
		internal const int linuxHatSpan = 4500; // Metadata: 0x00763BDB
		internal const int linuxHatSpan4Way = 9000; // Metadata: 0x00763BDF
		internal const int linux_hatValue_up = 0; // Metadata: 0x00763BE3
		internal const int linux_hatValue_right = 9000; // Metadata: 0x00763BE7
		internal const int linux_hatValue_down = 18000; // Metadata: 0x00763BEB
		internal const int linux_hatValue_left = 27000; // Metadata: 0x00763BEF
		internal const int linuxLastDirectionValue = 31500; // Metadata: 0x00763BF3
		internal const int linuxLastDirectionValue4Way = 27000; // Metadata: 0x00763BF7
		internal const int linuxUnknownJoystickHatCount = 2; // Metadata: 0x00763BFB
		internal const int linuxUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763BFF
		internal const int linuxUnifiedMouseButtonCount = 5; // Metadata: 0x00763C03
		internal const int linuxUnifiedMouseAxisCount = 3; // Metadata: 0x00763C07
		internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x00763C0B
		internal const int sdl2MaxButtons = 256; // Metadata: 0x00763C0F
		internal const int sdl2MaxAxes = 56; // Metadata: 0x00763C13
		internal const int sdl2MaxHats = 4; // Metadata: 0x00763C17
		internal const int sdl2MaxSliders = 2; // Metadata: 0x00763C1B
		internal const int sdl2MaxAxisValue = 32768; // Metadata: 0x00763C1F
		internal const int sdl2MinAxisValue = -32767; // Metadata: 0x00763C23
		internal const int sdl2AxisZeroValue = 0; // Metadata: 0x00763C27
		internal const int sdl2MaxHatValue = 36000; // Metadata: 0x00763C2B
		internal const int sdl2HatZeroValue = -1; // Metadata: 0x00763C2F
		internal const int sdl2HatSpan = 4500; // Metadata: 0x00763C33
		internal const int sdl2HatSpan4Way = 9000; // Metadata: 0x00763C37
		internal const int sdl2_hatValue_up = 0; // Metadata: 0x00763C3B
		internal const int sdl2_hatValue_right = 9000; // Metadata: 0x00763C3F
		internal const int sdl2_hatValue_down = 18000; // Metadata: 0x00763C43
		internal const int sdl2_hatValue_left = 27000; // Metadata: 0x00763C47
		internal const int sdl2LastDirectionValue = 31500; // Metadata: 0x00763C4B
		internal const int sdl2LastDirectionValue4Way = 27000; // Metadata: 0x00763C4F
		internal const int sdl2UnknownJoystickHatCount = 2; // Metadata: 0x00763C53
		internal const int sdl2UnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763C57
		internal const int sdl2UnifiedMouseButtonCount = 5; // Metadata: 0x00763C5B
		internal const int sdl2UnifiedMouseAxisCount = 3; // Metadata: 0x00763C5F
		internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x00763C63
		internal const int windowsUWPMaxButtons = 256; // Metadata: 0x00763C67
		internal const int windowsUWPMaxAxes = 56; // Metadata: 0x00763C6B
		internal const int windowsUWPMaxHats = 4; // Metadata: 0x00763C6F
		internal const int windowsUWPMaxSliders = 2; // Metadata: 0x00763C73
		internal const int windowsUWPMaxAxisValue = 32767; // Metadata: 0x00763C77
		internal const int windowsUWPMinAxisValue = -32768; // Metadata: 0x00763C7B
		internal const int windowsUWPMaxHatValue = 36000; // Metadata: 0x00763C7F
		internal const int windowsUWPHatZeroValue = -1; // Metadata: 0x00763C83
		internal const int windowsUWPDirectionsPerHat = 8; // Metadata: 0x00763C87
		internal const int windowsUWPHatSpan = 4500; // Metadata: 0x00763C8B
		internal const int windowsUWPHatSpan4Way = 9000; // Metadata: 0x00763C8F
		internal const int windowsUWPLastDirectionValue = 31500; // Metadata: 0x00763C93
		internal const int windowsUWPLastDirectionValue4Way = 27000; // Metadata: 0x00763C97
		internal const int windowsUWPUnknownJoystickHatCount = 2; // Metadata: 0x00763C9B
		internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763C9F
		internal const int windowsUWPUnifiedMouseButtonCount = 5; // Metadata: 0x00763CA3
		internal const int windowsUWPUnifiedMouseAxisCount = 3; // Metadata: 0x00763CA7
		internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x00763CAB
		internal const int xInputMaxVibration = 65535; // Metadata: 0x00763CAF
		internal const int xInputMinVibration = 0; // Metadata: 0x00763CB3
		internal const float xInputAllowedVibrationInterval = 0.01f; // Metadata: 0x00763CB7
		internal const int customPlatformMaxButtons = 256; // Metadata: 0x00763CBB
		internal const int customPlatformMaxAxes = 128; // Metadata: 0x00763CBF
		internal const int internalDriverMaxButtons = 256; // Metadata: 0x00763CC3
		internal const int internalDriverMaxAxes = 56; // Metadata: 0x00763CC7
		internal const int internalDriverMaxHats = 4; // Metadata: 0x00763CCB
		internal const int internalDriverMaxSliders = 2; // Metadata: 0x00763CCF
		internal const int internalDriverMaxAxisValue = 65535; // Metadata: 0x00763CD3
		internal const int internalDriverMinAxisValue = -65535; // Metadata: 0x00763CD7
		internal const int internalDriverMaxHatValue = 36000; // Metadata: 0x00763CDB
		internal const int internalDriverHatZeroValue = -1; // Metadata: 0x00763CDF
		internal const int internalDriverHatSpan = 4500; // Metadata: 0x00763CE3
		internal const int internalDriverHatSpan4Way = 9000; // Metadata: 0x00763CE7
		internal const int internalDriver_hatValue_up = 0; // Metadata: 0x00763CEB
		internal const int internalDriver_hatValue_right = 9000; // Metadata: 0x00763CEF
		internal const int internalDriver_hatValue_down = 18000; // Metadata: 0x00763CF3
		internal const int internalDriver_hatValue_left = 27000; // Metadata: 0x00763CF7
		internal const int internalDriverLastDirectionValue = 31500; // Metadata: 0x00763CFB
		internal const int internalDriverLastDirectionValue4Way = 27000; // Metadata: 0x00763CFF
		internal const int internalDriverUnknownJoystickHatCount = 2; // Metadata: 0x00763D03
		internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128; // Metadata: 0x00763D07
		internal const int internalDriverUnifiedMouseButtonCount = 5; // Metadata: 0x00763D0B
		internal const int internalDriverUnifiedMouseAxisCount = 3; // Metadata: 0x00763D0F
		internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f; // Metadata: 0x00763D13
		internal const int webGLMaxButtons = 256; // Metadata: 0x00763D17
		internal const int webGLMaxAxes = 128; // Metadata: 0x00763D1B
		internal const int stadiaMaxButtons = 256; // Metadata: 0x00763D1F
		internal const int stadiaMaxAxes = 128; // Metadata: 0x00763D23
		internal const float axisPollingDeadzone = 0.7f; // Metadata: 0x00763D27
		internal const float mouseXYAxisPollingDeadzone = 100f; // Metadata: 0x00763D2B
		internal const float mouseOtherAxisPollingDeadzone = 2f; // Metadata: 0x00763D2F
		internal const float defaultButtonDeadZone = 0.5f; // Metadata: 0x00763D33
		internal const float hardwareButtonDeadZone = 0.01f; // Metadata: 0x00763D37
		internal const float axisDefaultSensitivity = 1f; // Metadata: 0x00763D3B
		internal const AxisSensitivityType axisDefaultSensitivityType = AxisSensitivityType.Multiplier; // Metadata: 0x00763D3F
		internal const float defaultButtonDoublePressSpeed = 0.3f; // Metadata: 0x00763D43
		internal const float minDoubleButtonPressSpeed = 0.01f; // Metadata: 0x00763D47
		internal const float maxDoubleButtonPressSpeed = 10f; // Metadata: 0x00763D4B
		internal const float defaultButtonShortPressTime = 0.25f; // Metadata: 0x00763D4F
		internal const float minButtonShortPressTime = 0f; // Metadata: 0x00763D53
		internal const float maxButtonShortPressTime = 3.4028235E+38f; // Metadata: 0x00763D57
		internal const float defaultButtonShortPressExpiresIn = 0f; // Metadata: 0x00763D5B
		internal const float minButtonShortPressExpiresIn = 0f; // Metadata: 0x00763D5F
		internal const float maxButtonShortPressExpiresIn = 3.4028235E+38f; // Metadata: 0x00763D63
		internal const float defaultButtonLongPressTime = 1f; // Metadata: 0x00763D67
		internal const float minButtonLongPressTime = 0f; // Metadata: 0x00763D6B
		internal const float maxButtonLongPressTime = 3.4028235E+38f; // Metadata: 0x00763D6F
		internal const float defaultButtonLongPressExpiresIn = 0f; // Metadata: 0x00763D73
		internal const float minButtonLongPressExpiresIn = 0f; // Metadata: 0x00763D77
		internal const float maxButtonLongPressExpiresIn = 3.4028235E+38f; // Metadata: 0x00763D7B
		internal const float defaultButtonRepeatDelay = 0f; // Metadata: 0x00763D7F
		internal const float defaultButtonRepeatRate = 30f; // Metadata: 0x00763D83
		internal const float minButtonRepeatRate = 0.001f; // Metadata: 0x00763D87
		internal const float mouseAxisPollingTimerLength = 1f; // Metadata: 0x00763D8B
		internal const float fallbackPollingTimeout = 1f; // Metadata: 0x00763D8F
		internal const string unknownJoystickName = "Unknown Controller"; // Metadata: 0x00763D93
		internal const float xInputControllerVibrationRenewalInterval = 1.5f; // Metadata: 0x00763DA9
		internal const float stadiaControllerVibrationRenewalInterval = 1f; // Metadata: 0x00763DAD
		internal const int defaultInputThreadUpdateRateFPS = 240; // Metadata: 0x00763DB1
		internal const int maxInputThreadUpdateRateFPS = 2000; // Metadata: 0x00763DB5
		internal const int osxXInputOutputReportRefreshRateFPS = 60; // Metadata: 0x00763DB9
		internal const int defaultOutputRefreshRateFPS = 100; // Metadata: 0x00763DBD
		internal const int hidOutputReportRefreshRateFPS = 100; // Metadata: 0x00763DC1
		internal const int hidOutputReportThreadKillTimeout = 10000; // Metadata: 0x00763DC5
		internal const int joystickInputReportRingBufferCapacity = 25; // Metadata: 0x00763DC9
		internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows"; // Metadata: 0x00763DCD
		internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX"; // Metadata: 0x00763DE5
		internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux"; // Metadata: 0x00763DF9
		internal const float defaultInputBehaviorAxisSensitivity = 1f; // Metadata: 0x00763E0F
		internal const float defaultInputBehaviorAxisSimulation_gravity = 3f; // Metadata: 0x00763E13
		internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3f; // Metadata: 0x00763E17
		internal const bool defaultInputBehaviorAxisSmoothing_snap = true; // Metadata: 0x00763E1B
		internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = false; // Metadata: 0x00763E1C
		internal const bool defaultInputBehaviorAxisSimulation_enabled = true; // Metadata: 0x00763E1D
		internal const int allFlagsIntEnum = -1; // Metadata: 0x00763E1E
		internal const int lowLevelEventBuffers_buttonEventBufferSize = 16; // Metadata: 0x00763E22
		internal const string schemaNameSpace = "http://guavaman.com/rewired"; // Metadata: 0x00763E26
		internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/"; // Metadata: 0x00763E45
		internal const string schemaVersionControllerMap = "1.1"; // Metadata: 0x00763E6D
		internal const string schemaVersionCalibrationMap = "1.3"; // Metadata: 0x00763E74
		internal const string schemaVersionInputBehavior = "1.4"; // Metadata: 0x00763E7B
		internal const string schemaVersionControllerTemplateMap = "1.0"; // Metadata: 0x00763E82
		internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0"; // Metadata: 0x00763E89
		internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0"; // Metadata: 0x00763E90
		internal const int controllerMapDataVersion = 2; // Metadata: 0x00763E97
		internal const int calibrationMapDataVersion = 4; // Metadata: 0x00763E9B
		internal const int inputBehaviorDataVersion = 5; // Metadata: 0x00763E9F
		internal const int controllerTemplateMapDataVersion = 1; // Metadata: 0x00763EA3
		internal const int playerMapEnablerDataVersion = 1; // Metadata: 0x00763EA7
		internal const int playerControllerMapLayoutManagerDataVersion = 1; // Metadata: 0x00763EAB
		internal const int controllerElementType_trueElements_minValue = 0; // Metadata: 0x00763EAF
		internal const int controllerElementType_trueElements_maxValue = 99; // Metadata: 0x00763EB3
		internal const float pressureSensitiveButtonDeadZone = 0.001f; // Metadata: 0x00763EB7
		internal const string rewiredEditorAssembly = "Rewired_Editor"; // Metadata: 0x00763EBB
		internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor"; // Metadata: 0x00763ECD
		internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime"; // Metadata: 0x00763EEB
		internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager"; // Metadata: 0x00763F13
		internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1"; // Metadata: 0x00763F4A
		internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204"; // Metadata: 0x00763F72
		internal const string stadiaPluginEditorRuntimeAssembly = "Rewired_Stadia_EditorRuntime"; // Metadata: 0x00763F9A
		internal const string stadiaPluginInputManagerFullClassPath = "Rewired.Platforms.Stadia.StadiaInputManager"; // Metadata: 0x00763FBA
		internal const int updateLoopTypeCount = 3; // Metadata: 0x00763FE9
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
		internal static int nintendoSwitchPlugin_minPluginVersion { get; } // 0x00000001806C4390-0x00000001806C43A0 
		internal static int stadiaPlugin_minPluginVersion { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		static Consts(); // 0x00000001808BEF90-0x00000001808C41F0
	}
}
