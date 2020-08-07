/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public static class ReInput // TypeDefIndex: 6841
	{
		// Fields
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const int programVersion1 = 1; // Metadata: 0x00765F48
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const int programVersion2 = 1; // Metadata: 0x00765F4C
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const int programVersion3 = 28; // Metadata: 0x00765F50
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const int programVersion4 = 0; // Metadata: 0x00765F54
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const int dataVersion = 1; // Metadata: 0x00765F58
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const bool isTrial = false; // Metadata: 0x00765F5C
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal const string majorBranch = "U2019"; // Metadata: 0x00765F5D
		private static InputManager_Base oFYnOYsjzEbwrRoTPnKvJqNcwRl; // 0x00
		private static PlatformInputManager fQQNIagNVuOKadSDWHeEIZdVPZxe; // 0x08
		internal static QkhKmYTysnOGbFdkisIvKlGHgmRI fETtoFyFnmAdbitoXqJrwqEczvg; // 0x10
		internal static GOCsEdcRqIdaMQpgFWoBujLBrvX aWRGaPqZiDDZWmxLZIpMObKfuUE; // 0x18
		internal static gIVsJAuBATHUFwUPFjPhfTSOtxbQ GUzLpgyjvoltNWCZmJDrRsDyjAG; // 0x20
		private static ControllerDataFiles YjIJJmKufbDIGVXkGMfwsJMhhkr; // 0x28
		private static UserData BETvUcESIyhlYfnSPWFCYQeCTOO; // 0x30
		private static bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x38
		private static ConfigVars xiOZvoVvSktrTBfiDHJhhmspqpMf; // 0x40
		private static UpdateLoopType gIfBHpchbnBJamaqwWFVaTvvjvQ; // 0x48
		private static bool RLrEBJjXsxqUJVnnkrWRlPfOAK; // 0x4C
		private static Rewired.Platforms.Platform NyYLSoquiyWEcVsijMhDGCnVjYo; // 0x50
		private static WebplayerPlatform joqpgIglPlFLIGGPWHJKGdlmQLSg; // 0x54
		private static EditorPlatform TxfhmBGIgnWLQaApsgqLFjQQowUY; // 0x58
		private static bool HoPBazBdCFoxRQELOgsIoujIMID; // 0x5C
		private static TimerAbs oWwTDCQnoHqCIakMkjfIXaPGgdDE; // 0x60
		private static MPmBDkxdnNggWgQnkGyTossZItbb zAiVCOmThlMmXITYmQRmgSFUmNp; // 0x68
		private static string VJvzpGdUzVSnnNLHZIBkuyHsZio; // 0x70
		private static bool GaFZXIGeMeniNUvPjlsNAiVdspo; // 0x78
		private static bool tTXfJUNRfcGJLEweaAqwOlqtNOX; // 0x79
		private static bool HZFbWJedKsFMWOygHDsmIQfogFG; // 0x7A
		private static int hWaROJysncyQiXvEwTudAHBAspi; // 0x7C
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static int _id; // 0x80
		private static int DcqKmvVPzsDewdOtjYUEaVXAlzm; // 0x84
		private static int txeQkhdpWzDwcJYhxCtafxAgcCO; // 0x88
		private static bool iiCZuHeamndoJorNHKiAVviAFfP; // 0x8C
		private static readonly UnityTouch BRsIJTtBuPdvOPkpXDMoAPkjuTkP; // 0x90
		private static readonly PlayerHelper fcPFHbHffmDaVNpKmIJTMwlrTlB; // 0x98
		private static readonly ControllerHelper xAnIGGFCVuaxQBJLyeaCMWdqUdy; // 0xA0
		private static readonly MappingHelper VwETmklDnvfGIxyMivgyqdqdJxd; // 0xA8
		private static readonly TimeHelper PbUKpkQaXlCzQkAnyLnJlJiBDRb; // 0xB0
		private static readonly ConfigHelper MzGrNpOxDkvyJULNGcfxFvkMXDB; // 0xB8
		private static tZlePwusXDDMirYvopCuiueCHfi LqtSWzHAdIrgwAdFEjBXUMiIRrv; // 0xC0
		private static UserDataStore klUAyuIqCekDmJtSXlPbraapIhU; // 0xC8
		private static IControllerAssigner rZZfDIzCqZTEQeasbOTqjWkyQpZ; // 0xD0
		private static ptveCNmVZXCKQBRQPTFtDMcYzpD teWYrjpJazyCntdpVwPCjYfYjiq; // 0xD8
		private static SafeAction<ControllerStatusChangedEventArgs> HDrtKCbCFrjwxeoEjMiyBCNexbip; // 0xE0
		private static SafeAction<ControllerStatusChangedEventArgs> kQdAPeerTUySLlCrgGIhzrbJqGCe; // 0xE8
		private static SafeAction<ControllerStatusChangedEventArgs> mkqyXGQnpEBucURdzydWuteuGcA; // 0xF0
		private static SafeAction sclXQebFoGCjsmKAZuPBkpCAZrA; // 0xF8
		private static SafeAction ipgLxqCrzyKhmsZZXuYQFCAOVEc; // 0x100
		private static SafeAction enciIUBKVgMlZQweYuYwpYrunFt; // 0x108
		private static SafeAction sHHenKlyyPsuebJgsfVkzOJZTAK; // 0x110
		private static SafeAction ErpntPYkRdQazvZUyDLWpxZsGrW; // 0x118
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private static Action<bool> _ApplicationFocusChangedEvent; // 0x120
		private static Action nJoMWqNHwQzUezCyFhYciOyUksE; // 0x128
		private static Action<UpdateLoopType> sNfnBdIEnoHZPLRDjjDwVpBJvXD; // 0x130
		private static Action<UpdateLoopType> yApuGXhRIpWwQKSuJARpwpcijjw; // 0x138
		private static Action<UpdateLoopType> sltQjSiHzZeIHyvBpuWLkMyybTU; // 0x140
		private static Action AgHesbFZbWmTJpRyeqsHwPsxbbii; // 0x148
		private static Action<bool> DNAwTwwxWrYcCbSjWlkqLSaRZWm; // 0x150
		private static Action<bool> gqCPDWFouFlgLWbdLAIlGLdGKh; // 0x158
		private static Action<bool> dWwdNogeEWyFtbXaXWnhRQjrFLx; // 0x160
		private static Action<FullScreenMode> lMwzbqBNwstFuQqAthkZMjxCboX; // 0x168
		private static Action LmuMGoNOPLtQsWIfOQaHBjrbfIi; // 0x170
		private static Action<bool> cZQvepBqAIVsWmbiGvJJoWfrjeX; // 0x178
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float unscaledDeltaTime; // 0x180
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float unscaledTime; // 0x184
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float unscaledTimePrev; // 0x188
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static uint currentFrame; // 0x18C
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static uint previousFrame; // 0x190
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static uint absFrame; // 0x194
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg; // 0x198
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK; // 0x1A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x1A8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI; // 0x1B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x1B8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb; // 0x1C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> oGJrVKpLnrEZvcckdTDrxcRcoPE; // 0x1C8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc; // 0x1D0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> LMEVXjUqLtOuqZTxhWxWORZbBET; // 0x1D8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<bool> mFkzNHGAqcCSXMLnBgAxEdkqCHul; // 0x1E0
	
		// Properties
		private static tZlePwusXDDMirYvopCuiueCHfi unityInputBuffer { get; } // 0x0000000180B3E9C0-0x0000000180B3EAA0 
		public static PlayerHelper players { get; } // 0x0000000180B3E020-0x0000000180B3E0F0 
		public static ControllerHelper controllers { get; } // 0x0000000180B3D1F0-0x0000000180B3D2F0 
		public static MappingHelper mapping { get; } // 0x0000000180B3DF50-0x0000000180B3E020 
		public static UnityTouch touch { get; } // 0x0000000180B3E8C0-0x0000000180B3E9C0 
		public static TimeHelper time { get; } // 0x0000000180B3E7F0-0x0000000180B3E8C0 
		public static IUserDataStore userDataStore { get; } // 0x0000000180B3ED80-0x0000000180B3EE50 
		public static ConfigHelper configuration { get; } // 0x0000000180B3D090-0x0000000180B3D190 
		public static string programVersion { get; } // 0x0000000180B3E1E0-0x0000000180B3E570 
		public static bool usingUnityInput { get; } // 0x0000000180B3EE50-0x0000000180B3EEB0 
		public static bool unityJoystickIdentificationRequired { get; } // 0x0000000180B3EAA0-0x0000000180B3ECA0 
		public static bool isReady { get; } // 0x0000000180B3DC70-0x0000000180B3DCD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static int id { get; } // 0x0000000180B3D5A0-0x0000000180B3D600 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool initialized { get; } // 0x0000000180B3D600-0x0000000180B3D660 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static UpdateLoopType currentUpdateLoop { get; } // 0x0000000180B3D3F0-0x0000000180B3D450 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static ConfigVars configVars { get; } // 0x0000000180B3D030-0x0000000180B3D090 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static UserData UserData { get; } // 0x0000000180B3CA80-0x0000000180B3CAE0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static Rewired.Platforms.Platform currentPlatform { get; } // 0x0000000180B3D2F0-0x0000000180B3D350 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static WebplayerPlatform webplayerPlatform { get; } // 0x0000000180B3EEB0-0x0000000180B3EF10 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static EditorPlatform editorPlatform { get; } // 0x0000000180B3D540-0x0000000180B3D5A0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool checkNeverPressed { get; } // 0x0000000180B3CCF0-0x0000000180B3D030 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isEditor { get; } // 0x0000000180B3DC10-0x0000000180B3DC70 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static Guid defaultHardwareJoystickMapGuid { get; } // 0x0000000180B3D450-0x0000000180B3D540 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isRunningInEditMode { get; } // 0x0000000180B3DCD0-0x0000000180B3DD30 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isEditorPaused { get; } // 0x0000000180B3DBA0-0x0000000180B3DC10 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float unityUnscaledDeltaTime { get; } // 0x0000000180B3ED10-0x0000000180B3ED80 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float unityUnscaledDeltaTimePrev { get; } // 0x0000000180B3ECA0-0x0000000180B3ED10 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static float realTime { get; } // 0x0000000180B3E570-0x0000000180B3E610 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static int currentUnityFrame { get; } // 0x0000000180B3D350-0x0000000180B3D3F0 
		private static bool isEditorGameViewFocused { get; } // 0x0000000180B3DAE0-0x0000000180B3DBA0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isAllowedEditorWindowFocused { get; } // 0x0000000180B3D860-0x0000000180B3DAE0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isUnityEditorFocused { get; } // 0x0000000180B3DD30-0x0000000180B3DDE0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform { get; } // 0x0000000180B3DDE0-0x0000000180B3DF50 
		private static bool inputAllowed { get; } // 0x0000000180B3D660-0x0000000180B3D860 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool applicationIsFocused { get; } // 0x0000000180B3CAE0-0x0000000180B3CB90 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool applicationIsFullScreen { get; } // 0x0000000180B3CB90-0x0000000180B3CC40 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool applicationRunInBackground { get; } // 0x0000000180B3CC40-0x0000000180B3CCF0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool timeScaleIsPaused { get; } // 0x0000000180B3E6E0-0x0000000180B3E790 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static InputManager_Base rewiredInputManager { get; } // 0x0000000180B3E610-0x0000000180B3E670 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static PlatformInputManager primaryInputManager { get; } // 0x0000000180B3E0F0-0x0000000180B3E1E0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static IControllerAssigner controllerAssigner { get; set; } // 0x0000000180B3D190-0x0000000180B3D1F0 0x0000000180B3FE80-0x0000000180B3FEE0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static RewiredVersion rewiredVersion { get; } // 0x0000000180B3E670-0x0000000180B3E6E0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static int timeScalePauseChangedCount { get; } // 0x0000000180B3E790-0x0000000180B3E7F0 
	
		// Events
		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent {
			add; // 0x0000000180B3BD10-0x0000000180B3BDA0
			remove; // 0x0000000180B3F580-0x0000000180B3F610
		}
		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent {
			add; // 0x0000000180B3BE30-0x0000000180B3BEC0
			remove; // 0x0000000180B3F6A0-0x0000000180B3F730
		}
		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent {
			add; // 0x0000000180B3BDA0-0x0000000180B3BE30
			remove; // 0x0000000180B3F610-0x0000000180B3F6A0
		}
		public static event Action InputSourceUpdateEvent {
			add; // 0x0000000180B3C120-0x0000000180B3C1A0
			remove; // 0x0000000180B3F990-0x0000000180B3FA10
		}
		public static event Action EditorRecompileEvent {
			add; // 0x0000000180B3C020-0x0000000180B3C0A0
			remove; // 0x0000000180B3F890-0x0000000180B3F910
		}
		public static event Action PreShutDownEvent {
			add; // 0x0000000180B3C250-0x0000000180B3C2D0
			remove; // 0x0000000180B3FAC0-0x0000000180B3FB40
		}
		public static event Action ShutDownEvent {
			add; // 0x0000000180B3C380-0x0000000180B3C400
			remove; // 0x0000000180B3FBF0-0x0000000180B3FC70
		}
		public static event Action InitializedEvent {
			add; // 0x0000000180B3C0A0-0x0000000180B3C120
			remove; // 0x0000000180B3F910-0x0000000180B3F990
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<bool> ApplicationFocusChangedEvent {
			add; // 0x0000000180B3B9A0-0x0000000180B3BA50
			remove; // 0x0000000180B3F210-0x0000000180B3F2C0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action EarlyUpdateEvent {
			add; // 0x0000000180B3BEC0-0x0000000180B3BF70
			remove; // 0x0000000180B3F730-0x0000000180B3F7E0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent {
			add; // 0x0000000180B3BC60-0x0000000180B3BD10
			remove; // 0x0000000180B3F4D0-0x0000000180B3F580
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<UpdateLoopType> UpdateStartedEvent {
			add; // 0x0000000180B3C560-0x0000000180B3C610
			remove; // 0x0000000180B3FDD0-0x0000000180B3FE80
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<UpdateLoopType> UpdateEndedEvent {
			add; // 0x0000000180B3C4B0-0x0000000180B3C560
			remove; // 0x0000000180B3FD20-0x0000000180B3FDD0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action LateUpdateEvent {
			add; // 0x0000000180B3C1A0-0x0000000180B3C250
			remove; // 0x0000000180B3FA10-0x0000000180B3FAC0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<bool> ApplicationIsFullScreenChangedEvent {
			add; // 0x0000000180B3BB00-0x0000000180B3BBB0
			remove; // 0x0000000180B3F370-0x0000000180B3F420
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<bool> ApplicationRunInBackgroundChangedEvent {
			add; // 0x0000000180B3BBB0-0x0000000180B3BC60
			remove; // 0x0000000180B3F420-0x0000000180B3F4D0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<bool> TimeScalePauseChangedEvent {
			add; // 0x0000000180B3C400-0x0000000180B3C4B0
			remove; // 0x0000000180B3FC70-0x0000000180B3FD20
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<FullScreenMode> ApplicationFullScreenModeChangedEvent {
			add; // 0x0000000180B3BA50-0x0000000180B3BB00
			remove; // 0x0000000180B3F2C0-0x0000000180B3F370
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action SceneLoadedEvent {
			add; // 0x0000000180B3C2D0-0x0000000180B3C380
			remove; // 0x0000000180B3FB40-0x0000000180B3FBF0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static event Action<bool> EditorPauseChangedEvent {
			add; // 0x0000000180B3BF70-0x0000000180B3C020
			remove; // 0x0000000180B3F7E0-0x0000000180B3F890
		}
	
		// Nested types
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class ConfigHelper : CodeHelper // TypeDefIndex: 6842
		{
			// Fields
			private static ConfigHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static ConfigHelper Instance { get; } // 0x0000000180B20E90-0x0000000180B20F00 
			public bool useXInput { get; set; } // 0x0000000180B21F80-0x0000000180B22210 0x0000000180B24880-0x0000000180B24D60
			public UpdateLoopSetting updateLoop { get; set; } // 0x0000000180B21ED0-0x0000000180B21F80 0x0000000180B24650-0x0000000180B24880
			public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource { get; set; } // 0x0000000180B222C0-0x0000000180B22370 0x0000000180B24FA0-0x0000000180B25250
			public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource { get; set; } // 0x0000000180B21C10-0x0000000180B21CC0 0x0000000180B24030-0x0000000180B24220
			public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource { get; set; } // 0x0000000180B218A0-0x0000000180B21950 0x0000000180B23820-0x0000000180B23A50
			public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource { get; set; } // 0x0000000180B22370-0x0000000180B22420 0x0000000180B25250-0x0000000180B25440
			public bool windowsUWPSupportHIDDevices { get; set; } // 0x0000000180B22420-0x0000000180B22530 0x0000000180B25440-0x0000000180B25670
			public XboxOnePrimaryInputSource xboxOnePrimaryInputSource { get; set; } // 0x0000000180B22530-0x0000000180B225E0 0x0000000180B25670-0x0000000180B25840
			public PS4PrimaryInputSource ps4PrimaryInputSource { get; set; } // 0x0000000180B21CC0-0x0000000180B21D70 0x0000000180B24220-0x0000000180B243F0
			public WebGLPrimaryInputSource webGLPrimaryInputSource { get; set; } // 0x0000000180B22210-0x0000000180B222C0 0x0000000180B24D60-0x0000000180B24FA0
			public bool alwaysUseUnityInput { get; set; } // 0x0000000180B20FB0-0x0000000180B21060 0x0000000180B226E0-0x0000000180B228F0
			public bool disableNativeInput { get; set; } // 0x0000000180B20FB0-0x0000000180B21060 0x0000000180B23160-0x0000000180B23170
			public bool nativeMouseSupport { get; set; } // 0x0000000180B21B60-0x0000000180B21C10 0x0000000180B23E80-0x0000000180B24030
			public bool nativeKeyboardSupport { get; set; } // 0x0000000180B21AB0-0x0000000180B21B60 0x0000000180B23CD0-0x0000000180B23E80
			public bool enhancedDeviceSupport { get; set; } // 0x0000000180B215E0-0x0000000180B21690 0x0000000180B232A0-0x0000000180B23460
			public int joystickRefreshRate { get; set; } // 0x0000000180B217F0-0x0000000180B218A0 0x0000000180B23700-0x0000000180B23820
			public bool ignoreInputWhenAppNotInFocus { get; set; } // 0x0000000180B21740-0x0000000180B217F0 0x0000000180B235A0-0x0000000180B23700
			public bool android_supportUnknownGamepads { get; set; } // 0x0000000180B21060-0x0000000180B21110 0x0000000180B228F0-0x0000000180B22AE0
			public DeadZone2DType defaultJoystickAxis2DDeadZoneType { get; set; } // 0x0000000180B21320-0x0000000180B213D0 0x0000000180B22E30-0x0000000180B22F60
			public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType { get; set; } // 0x0000000180B213D0-0x0000000180B21480 0x0000000180B22F60-0x0000000180B23060
			public AxisSensitivityType defaultAxisSensitivityType { get; set; } // 0x0000000180B21270-0x0000000180B21320 0x0000000180B22CF0-0x0000000180B22E30
			public bool force4WayHats { get; set; } // 0x0000000180B21690-0x0000000180B21740 0x0000000180B23460-0x0000000180B235A0
			public bool activateActionButtonsOnNegativeValue { get; set; } // 0x0000000180B20F00-0x0000000180B20FB0 0x0000000180B225E0-0x0000000180B226E0
			public ThrottleCalibrationMode throttleCalibrationMode { get; set; } // 0x0000000180B21E20-0x0000000180B21ED0 0x0000000180B244F0-0x0000000180B24650
			public bool deferControllerConnectedEventsOnStart { get; set; } // 0x0000000180B21480-0x0000000180B21530 0x0000000180B23060-0x0000000180B23160
			public bool autoAssignJoysticks { get; set; } // 0x0000000180B211C0-0x0000000180B21270 0x0000000180B22BF0-0x0000000180B22CF0
			public int maxJoysticksPerPlayer { get; set; } // 0x0000000180B21A00-0x0000000180B21AB0 0x0000000180B23B90-0x0000000180B23CD0
			public bool distributeJoysticksEvenly { get; set; } // 0x0000000180B21530-0x0000000180B215E0 0x0000000180B23170-0x0000000180B232A0
			public bool assignJoysticksToPlayingPlayersOnly { get; set; } // 0x0000000180B21110-0x0000000180B211C0 0x0000000180B22AE0-0x0000000180B22BF0
			public bool reassignJoystickToPreviousOwnerOnReconnect { get; set; } // 0x0000000180B21D70-0x0000000180B21E20 0x0000000180B243F0-0x0000000180B244F0
			public LogLevelFlags logLevel { get; set; } // 0x0000000180B21950-0x0000000180B21A00 0x0000000180B23A50-0x0000000180B23B90
	
			// Constructors
			private ConfigHelper(); // 0x00000001803F46D0-0x00000001803F46E0
		}
	
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class ControllerHelper : CodeHelper // TypeDefIndex: 6843
		{
			// Fields
			private static ControllerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
			public readonly PollingHelper polling; // 0x10
			public readonly ConflictCheckingHelper conflictChecking; // 0x18
	
			// Properties
			internal static ControllerHelper Instance { get; } // 0x0000000180B30770-0x0000000180B30850 
			public int controllerCount { get; } // 0x0000000180B30A40-0x0000000180B30AE0 
			public IList<Controller> Controllers { get; } // 0x0000000180B30620-0x0000000180B306C0 
			public Mouse Mouse { get; } // 0x0000000180B309A0-0x0000000180B30A40 
			public Keyboard Keyboard { get; } // 0x0000000180B30900-0x0000000180B309A0 
			[Obsolete] // 0x0000000180268F20-0x0000000180268F50
			public bool keyboardEnabled { get; set; } // 0x0000000180B30C20-0x0000000180B30CA0 0x0000000180B30CA0-0x0000000180B30E10
			public int joystickCount { get; } // 0x0000000180B30B80-0x0000000180B30C20 
			public IList<Joystick> Joysticks { get; } // 0x0000000180B30850-0x0000000180B30900 
			public int customControllerCount { get; } // 0x0000000180B30AE0-0x0000000180B30B80 
			public IList<CustomController> CustomControllers { get; } // 0x0000000180B306C0-0x0000000180B30770 
	
			// Nested types
			[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
			[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 6844
			{
				// Fields
				private static PollingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
				// Properties
				internal static PollingHelper Instance { get; } // 0x0000000180EF70F0-0x0000000180EF7160 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class YBvNVzmKvmAGZDUUUdluAtbPIcR : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6845
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public ControllerPollingInfo epmFtbSGFAjThVVGQgELhRuRXoKD; // 0x58
					public ControllerPollingInfo LNeUMYExnqtKbyFuydlCdNmCLpH; // 0x90
					public ControllerPollingInfo ICjBndxIHNoVpkbUzyrGUkyHLpd; // 0xC8
					public ControllerPollingInfo abUUUemyNWvThdkXwJBOyQMWZNh; // 0x100
					public IEnumerator<ControllerPollingInfo> langcIztTbIcqzxDOhkhhwoqTJF; // 0x138
					public IEnumerator<ControllerPollingInfo> sXVymdJzVelbmPJdFTZMlfmRwnF; // 0x140
					public IEnumerator<ControllerPollingInfo> AwWJAPnxnoSvrbtfDATUiTJaezj; // 0x148
					public IEnumerator<ControllerPollingInfo> hgCoEbgLJdHBAKZiiAAENdJCkfv; // 0x150
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFA280-0x0000000180EFA2F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public YBvNVzmKvmAGZDUUUdluAtbPIcR(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFA100-0x0000000180EFA230
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFA100-0x0000000180EFA230
					private bool MoveNext(); // 0x0000000180EF9A10-0x0000000180EFA100
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFA230-0x0000000180EFA280
					void IDisposable.Dispose(); // 0x0000000180EFA2F0-0x0000000180EFA510
					private void xcAVusbXlUDusmCdbvVNsTYvMHV(); // 0x0000000180EFA600-0x0000000180EFA650
					private void CTKvuRyfNrGDqADDcjYPtneKpvD(); // 0x0000000180EF98C0-0x0000000180EF9910
					private void MWiHpoXIdJXsGxpGiKFwWBQTFDI(); // 0x0000000180EF9910-0x0000000180EF9A10
					private void qcHCBHNxIuILBVLsQbguTakmKeA(); // 0x0000000180EFA510-0x0000000180EFA600
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class clGswvEugVdyOXIvPfpdNWrovDx : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6846
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public ControllerPollingInfo kbTkIXZYNhQRIwYbYgBPjCsjLos; // 0x58
					public ControllerPollingInfo bCIqmsyWEHDPLsGgzJjKZikxJtS; // 0x90
					public ControllerPollingInfo SrQxOqUswPbKqLwvFwycXCFOFVg; // 0xC8
					public ControllerPollingInfo opdyUWgvvJMkcVdTirbjwhRjfWZ; // 0x100
					public IEnumerator<ControllerPollingInfo> gsoanFoLvXACPUgHGZDWQCPIKDs; // 0x138
					public IEnumerator<ControllerPollingInfo> JDBYFtMfcBjsdwnrdwDcMqmRzBY; // 0x140
					public IEnumerator<ControllerPollingInfo> uXUyVOvrUJBiqaSzqHjixjGjexm; // 0x148
					public IEnumerator<ControllerPollingInfo> LHyvpjjNldiyTOkTJqhmtKgpdpUJ; // 0x150
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFCBD0-0x0000000180EFCC40 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public clGswvEugVdyOXIvPfpdNWrovDx(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFCA50-0x0000000180EFCB80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFCA50-0x0000000180EFCB80
					private bool MoveNext(); // 0x0000000180EFBE40-0x0000000180EFCA50
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFCB80-0x0000000180EFCBD0
					void IDisposable.Dispose(); // 0x0000000180EFCC40-0x0000000180EFCE00
					private void jcEIcthBJsjSMVZVjlgGNCAnzWM(); // 0x0000000180EFD130-0x0000000180EFD260
					private void glJLgprOseifKJIWboOdAUcyPzw(); // 0x0000000180EFD040-0x0000000180EFD130
					private void dtbOvYPynYurhkKfWvWVrRXZTfI(); // 0x0000000180EFCF20-0x0000000180EFD040
					private void ZEIcKoIKIgVtaQCVPHvtOQlxcdu(); // 0x0000000180EFCE00-0x0000000180EFCF20
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class jdUzyaeuSjRATfBzsdcgkgsnfUKz : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6847
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public ControllerPollingInfo UwNEGCptpdQsxrkeUqvWTbvdMsI; // 0x58
					public ControllerPollingInfo rvbdEudaDsUfLgDaGNIaEVxvleIp; // 0x90
					public ControllerPollingInfo RcQiXeABQKCFjsIUMqlLcScdrW; // 0xC8
					public ControllerPollingInfo CqeAsdFUCRfKdAgFJCxfMCOOSMaA; // 0x100
					public IEnumerator<ControllerPollingInfo> TMMylRdNmhNoxOGMiCRycFXMlrZi; // 0x138
					public IEnumerator<ControllerPollingInfo> wUKVEbaSfpjAHdCahRBxUAhlXYXS; // 0x140
					public IEnumerator<ControllerPollingInfo> UMMIMIvleOTddkxnjVbBrLWMiQf; // 0x148
					public IEnumerator<ControllerPollingInfo> RezkdFOopsWXtWHtrnMjSGaNoiM; // 0x150
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F00CA0-0x0000000180F00D10 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public jdUzyaeuSjRATfBzsdcgkgsnfUKz(int <>1__state); // 0x0000000180F00F70-0x0000000180F00FE0
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180F00B40-0x0000000180F00C50
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F00B40-0x0000000180F00C50
					private bool MoveNext(); // 0x0000000180F00440-0x0000000180F00AF0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F00C50-0x0000000180F00CA0
					void IDisposable.Dispose(); // 0x0000000180F00D10-0x0000000180F00F70
					private void RtDWPvdRDkVwZrYKbiVubzAGyMi(); // 0x0000000180F00AF0-0x0000000180F00B40
					private void EuqoCsxJgbyLTLQWQWXqAlploEj(); // 0x0000000180F00320-0x0000000180F00440
					private void ABMyiPKeMqGqXIllpGvshnvqBZlT(); // 0x0000000180F00230-0x0000000180F00320
					private void xfYseRgskGwCGumdDZbIcrZKBcL(); // 0x0000000180F00FE0-0x0000000180F01030
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class soszkmCgISDFJChNpYGyUVmbUFa : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6848
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public ControllerPollingInfo mWlrpXpugVzOURxVxCFhHYtTWZs; // 0x58
					public ControllerPollingInfo bOzBTwdMlCTafWqBLtfgLazZbPJ; // 0x90
					public ControllerPollingInfo OhiYEabwoyJUybcBHfvmxXqmYWn; // 0xC8
					public ControllerPollingInfo xtaGUSMDwsvPydfUfDuJevYWoaBB; // 0x100
					public IEnumerator<ControllerPollingInfo> kOSstZFdFzCRTXHJAvdzLNUkEtKa; // 0x138
					public IEnumerator<ControllerPollingInfo> gMVbrJihgqVVLgbGgjprrvDfDOZ; // 0x140
					public IEnumerator<ControllerPollingInfo> CJiMMIpIhtEwziChztjIobHLvdi; // 0x148
					public IEnumerator<ControllerPollingInfo> KzDaDuIxAFJVJeTGDfETLMPcbIs; // 0x150
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F03050-0x0000000180F030C0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public soszkmCgISDFJChNpYGyUVmbUFa(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180F02F10-0x0000000180F03000
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F02F10-0x0000000180F03000
					private bool MoveNext(); // 0x0000000180F02220-0x0000000180F02DF0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F03000-0x0000000180F03050
					void IDisposable.Dispose(); // 0x0000000180F030C0-0x0000000180F032E0
					private void XrTNlrZKkzbeghzEFzyyKgnduvTc(); // 0x0000000180F032E0-0x0000000180F03330
					private void NhNoMKZGnYhnyhujRMnRFTfrqJvB(); // 0x0000000180F02DF0-0x0000000180F02F10
					private void qouiGGrfkPSMgpTOAJiRgbRZGLj(); // 0x0000000180F03330-0x0000000180F03380
					private void JjOFXsGbvLkmSSrWFYVkQsjwvAl(); // 0x0000000180F02100-0x0000000180F02220
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ZfUtVJTOmhcoSZZlRIRuFmYbNRp : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6849
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x50
					public ControllerPollingInfo ylJFfnVZUIOSllknkliIHrVWFYj; // 0x58
					public ControllerPollingInfo PvtfbUoIAEpxZhKBjqlWkCxvfcSH; // 0x90
					public ControllerPollingInfo ONKEmlhcScyYICtRPshvWqwrQhh; // 0xC8
					public IEnumerator<ControllerPollingInfo> JAMgVrOdqZjCyRKutWYwxsNXFwE; // 0x100
					public IEnumerator<ControllerPollingInfo> DRFWmqaticYPlNyzAqFnFKyqisS; // 0x108
					public IEnumerator<ControllerPollingInfo> AXjXUVFJJGbGVcxqFICruLpzFwrO; // 0x110
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFB360-0x0000000180EFB3D0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ZfUtVJTOmhcoSZZlRIRuFmYbNRp(int <>1__state); // 0x0000000180EFB560-0x0000000180EFB5D0
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFB1E0-0x0000000180EFB310
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFB1E0-0x0000000180EFB310
					private bool MoveNext(); // 0x0000000180EFAC30-0x0000000180EFB1E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFB310-0x0000000180EFB360
					void IDisposable.Dispose(); // 0x0000000180EFB3D0-0x0000000180EFB560
					private void uVeNaeqOpXRVTXSaCxnCXMTefyS(); // 0x0000000180EFB740-0x0000000180EFB860
					private void kvnimodFsmAzSDbYHVGVuVLUTcl(); // 0x0000000180EFB620-0x0000000180EFB740
					private void aOozVxRKFKIVhjtboisRxdjRQrj(); // 0x0000000180EFB5D0-0x0000000180EFB620
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class bgXjYvqqakiXDUkhbeKAebzKPEQc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6850
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<Joystick> aljqEohuLSPPUGzbyRnJxOVbpJv; // 0x50
					public int bnntBoMnnocJPKZYsMOzryCzGpm; // 0x58
					public ControllerPollingInfo IvHDCPBjQEbyJbAGlYiVlBWrvt; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> ZBZqVTUjIIxffaqvVAYaapWTbeo; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFBCD0-0x0000000180EFBD40 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public bgXjYvqqakiXDUkhbeKAebzKPEQc(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFBB90-0x0000000180EFBC80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFBB90-0x0000000180EFBC80
					private bool MoveNext(); // 0x0000000180EFB860-0x0000000180EFBB90
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFBC80-0x0000000180EFBCD0
					void IDisposable.Dispose(); // 0x0000000180EFBD40-0x0000000180EFBDF0
					private void zzYHBLePDvCeNCLsmAfliTkxCwS(); // 0x0000000180EFBDF0-0x0000000180EFBE40
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class pmJjyzYbblIPEbZmpykFuUNHxuNE : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6851
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<Joystick> dYyJKwXvOfUwIALSgRRTqcwZxsE; // 0x50
					public int VzygpAKOPysWZIBrbnyvNDlZDwxc; // 0x58
					public ControllerPollingInfo MrxOyyGzkJMkvxDKvqojCsUPJzc; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> XgLpIkyIIVciobKMxOWCFNgokmMf; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F016A0-0x0000000180F01710 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public pmJjyzYbblIPEbZmpykFuUNHxuNE(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180F01560-0x0000000180F01650
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F01560-0x0000000180F01650
					private bool MoveNext(); // 0x0000000180F01030-0x0000000180F01560
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F01650-0x0000000180F016A0
					void IDisposable.Dispose(); // 0x0000000180F01710-0x0000000180F017C0
					private void dndDICppvIXFaOjYHiHsRpVXZFO(); // 0x0000000180F017C0-0x0000000180F01810
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class feVMVkzXgdxbLQhQnHgiNmxsuxP : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6852
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<Joystick> eZgOsLXrbuEgkGPDskyclvtttyC; // 0x50
					public int jOsEvROrKOHsSsVpiGSeVsByZKM; // 0x58
					public ControllerPollingInfo zhpLjuKRnpkYZqiibkGySpUaiml; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> YHcKqzURRSeWowxotZXOtIpkFHd; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFEC80-0x0000000180EFECF0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public feVMVkzXgdxbLQhQnHgiNmxsuxP(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFEB20-0x0000000180EFEC30
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFEB20-0x0000000180EFEC30
					private bool MoveNext(); // 0x0000000180EFE5E0-0x0000000180EFEB20
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFEC30-0x0000000180EFEC80
					void IDisposable.Dispose(); // 0x0000000180EFECF0-0x0000000180EFEDA0
					private void whtZcuvsrbilFSJsuqkwtIKMLEV(); // 0x0000000180EFEDA0-0x0000000180EFEDF0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class gEmyRrkltNUUUGpMAFWCHapMQlCM : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6853
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<Joystick> jnigZAEtYtabSpbGHkOPsrjSkgx; // 0x50
					public int EnTeAeDIIwKwBBGXeJlCOqudJhre; // 0x58
					public ControllerPollingInfo bjTkgVIXNtIBStsSuQfYlErFfmFA; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> JXbsBFYUOlInkWOUSdKfptovgmnE; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFF2C0-0x0000000180EFF330 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public gEmyRrkltNUUUGpMAFWCHapMQlCM(int <>1__state); // 0x0000000180EFF3E0-0x0000000180EFF450
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFF140-0x0000000180EFF270
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFF140-0x0000000180EFF270
					private bool MoveNext(); // 0x0000000180EFEDF0-0x0000000180EFF0F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFF270-0x0000000180EFF2C0
					void IDisposable.Dispose(); // 0x0000000180EFF330-0x0000000180EFF3E0
					private void RzKKwzuehSPRVDkjOnbesdzQOGk(); // 0x0000000180EFF0F0-0x0000000180EFF140
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class CSuZeoWpOZvfMcVhlnGGKMADQUw : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6854
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<Joystick> lrrFLwRwEiENkjqPCOpLLuzxIgf; // 0x50
					public int GrOYznvWfNTvOgBxDxxoyOyfebZ; // 0x58
					public ControllerPollingInfo WNlmuIcyCsrzJsvIjpnuEurOGcZ; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> gCYjDVCJSdkpuQLaTQlIDmSmucRY; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7040-0x0000000180EE70B0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public CSuZeoWpOZvfMcVhlnGGKMADQUw(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EE6F00-0x0000000180EE6FF0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EE6F00-0x0000000180EE6FF0
					private bool MoveNext(); // 0x0000000180EE6BF0-0x0000000180EE6F00
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EE6FF0-0x0000000180EE7040
					void IDisposable.Dispose(); // 0x0000000180EE70B0-0x0000000180EE7120
					private void rEKFFmlglcIRsICsUpCYURVyisL(); // 0x0000000180EE7120-0x0000000180EE7240
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class RmiDKpUOeEUEAmvgnhIxSJnYhri : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6855
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<CustomController> QnqGERoRtKgFWXdryjvhlyybUqj; // 0x50
					public int yDPtboNsLbSvDeRGDVMXnUHWhcu; // 0x58
					public ControllerPollingInfo ddsAgSlKiaidqOLebhRbfXTeEdOf; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> RvGhAeEXwdDiztlOlCisAIDtYSXl; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EF8570-0x0000000180EF85E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public RmiDKpUOeEUEAmvgnhIxSJnYhri(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EF8420-0x0000000180EF8520
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EF8420-0x0000000180EF8520
					private bool MoveNext(); // 0x0000000180EF80B0-0x0000000180EF8420
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EF8520-0x0000000180EF8570
					void IDisposable.Dispose(); // 0x0000000180EF85E0-0x0000000180EF8650
					private void BgmNXymAWDyexfsliSdIjIOXGDU(); // 0x0000000180EF7F90-0x0000000180EF80B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class UZzVPGJjSaaXWbrGqAhpBYkVXDIC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6856
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<CustomController> JIloORhFlqeuquWHeIIkDgMttmz; // 0x50
					public int LWfKZWxFCgTeKQePRCfOkHBfIgie; // 0x58
					public ControllerPollingInfo dBKnnUmKDSENvNgcaedbAWYRPAk; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> HIMCZgBpfxhTYZGZZanGutmkxXkd; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EF8DA0-0x0000000180EF8E10 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public UZzVPGJjSaaXWbrGqAhpBYkVXDIC(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EF8C30-0x0000000180EF8D50
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EF8C30-0x0000000180EF8D50
					private bool MoveNext(); // 0x0000000180EF8920-0x0000000180EF8C30
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EF8D50-0x0000000180EF8DA0
					void IDisposable.Dispose(); // 0x0000000180EF8E10-0x0000000180EF8EC0
					private void BcOzBDpAlqoazmiSMgLqzSuBoHg(); // 0x0000000180EF88D0-0x0000000180EF8920
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class twSmFirlKKhETHgPwZJPjpaQrlKM : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6857
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<CustomController> ZcwszEeEqtYQotEhjZPBErKCUvN; // 0x50
					public int tAYngTCvCIvLXwzqYalOjYMmmQg; // 0x58
					public ControllerPollingInfo UIylkLZjfLgTsOTllqVmHDjhhOU; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> DZfgImfAIYqyAQwSmbKCWHSOmpl; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F04120-0x0000000180F04190 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public twSmFirlKKhETHgPwZJPjpaQrlKM(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180F03FD0-0x0000000180F040D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F03FD0-0x0000000180F040D0
					private bool MoveNext(); // 0x0000000180F03CD0-0x0000000180F03FD0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F040D0-0x0000000180F04120
					void IDisposable.Dispose(); // 0x0000000180F04190-0x0000000180F04200
					private void gUVgUNzFmaksPiNSaTTLOZWacEU(); // 0x0000000180F04200-0x0000000180F04320
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class hbgPcoVcACaGVcSetcWaNQJvwrcH : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6858
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<CustomController> pyhVPXKEUlypTtdZDdrQFEmZfoe; // 0x50
					public int oMeqlnyOjEGwrvoWldrUBuuIaII; // 0x58
					public ControllerPollingInfo AhUpSnzqfvXgxyAcGGVcBipYSlH; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> yMJnBgJLLouiDpdoabnqDKAFEew; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F000E0-0x0000000180F00150 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public hbgPcoVcACaGVcSetcWaNQJvwrcH(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFFF50-0x0000000180F00090
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFFF50-0x0000000180F00090
					private bool MoveNext(); // 0x0000000180EFFC70-0x0000000180EFFF50
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F00090-0x0000000180F000E0
					void IDisposable.Dispose(); // 0x0000000180F00150-0x0000000180F00230
					private void IXDhgXHLNsdHNIsnpxszsGOWDtp(); // 0x0000000180EFFC20-0x0000000180EFFC70
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ZTjoOlHofdHJicziNMgErvsNzJl : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6859
				{
					// Fields
					private ControllerPollingInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x48
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x4C
					public IList<CustomController> elaLPybaKfILIkawmbTwGovcGLrA; // 0x50
					public int xBRHnOVlAEABIFixXHpDHHIcCRLL; // 0x58
					public ControllerPollingInfo bKhmryNIKzLjTghCokMHHwJTWIy; // 0x60
					public PollingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x98
					public IEnumerator<ControllerPollingInfo> BYNLcuNjxoyzBdhNiozlZnoDpJz; // 0xA0
	
					// Properties
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFAAC0-0x0000000180EFAB30 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ZTjoOlHofdHJicziNMgErvsNzJl(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EFA950-0x0000000180EFAA70
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFA950-0x0000000180EFAA70
					private bool MoveNext(); // 0x0000000180EFA650-0x0000000180EFA950
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFAA70-0x0000000180EFAAC0
					void IDisposable.Dispose(); // 0x0000000180EFAB30-0x0000000180EFABE0
					private void WCSRaCEWzrLzjXEPiGyAwEjZbFB(); // 0x0000000180EFABE0-0x0000000180EFAC30
				}
	
				// Constructors
				private PollingHelper(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public ControllerPollingInfo PollAllControllersForFirstElement(); // 0x0000000180EF3FA0-0x0000000180EF4190
				public ControllerPollingInfo PollAllControllersForFirstElementDown(); // 0x0000000180EF3E40-0x0000000180EF3FA0
				public ControllerPollingInfo PollAllControllersForFirstButton(); // 0x0000000180EF3C70-0x0000000180EF3E40
				public ControllerPollingInfo PollAllControllersForFirstButtonDown(); // 0x0000000180EF3AA0-0x0000000180EF3C70
				public ControllerPollingInfo PollAllControllersForFirstAxis(); // 0x0000000180EF3910-0x0000000180EF3AA0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType); // 0x0000000180EF47C0-0x0000000180EF4960
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(ControllerType controllerType); // 0x0000000180EF4620-0x0000000180EF47C0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType); // 0x0000000180EF4480-0x0000000180EF4620
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType); // 0x0000000180EF42E0-0x0000000180EF4480
				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType); // 0x0000000180EF4190-0x0000000180EF42E0
				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId); // 0x0000000180EF5DC0-0x0000000180EF6060
				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId); // 0x0000000180EF5B20-0x0000000180EF5DC0
				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId); // 0x0000000180EF58E0-0x0000000180EF5B20
				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId); // 0x0000000180EF5660-0x0000000180EF58E0
				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId); // 0x0000000180EF5420-0x0000000180EF5660
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements(); // 0x0000000180EF3890-0x0000000180EF3910
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown(); // 0x0000000180EF3810-0x0000000180EF3890
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons(); // 0x0000000180EF3760-0x0000000180EF3810
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown(); // 0x0000000180EF36E0-0x0000000180EF3760
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes(); // 0x0000000180EF3630-0x0000000180EF36E0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId); // 0x0000000180EF5200-0x0000000180EF5420
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId); // 0x0000000180EF4FC0-0x0000000180EF5200
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId); // 0x0000000180EF4DA0-0x0000000180EF4FC0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId); // 0x0000000180EF4B80-0x0000000180EF4DA0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId); // 0x0000000180EF4960-0x0000000180EF4B80
				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY(); // 0x0000000180EF6B70-0x0000000180EF6EC0
				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE(); // 0x0000000180EF6EC0-0x0000000180EF70F0
				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn(); // 0x0000000180EF6890-0x0000000180EF6A70
				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf(); // 0x0000000180EF34B0-0x0000000180EF3630
				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq(); // 0x0000000180EF62A0-0x0000000180EF6500
				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int param_0000e859); // 0x0000000180EF6A70-0x0000000180EF6B00
				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int param_0000e85a); // 0x0000000180EF7A20-0x0000000180EF7AD0
				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int param_0000e85b); // 0x0000000180EF3230-0x0000000180EF32C0
				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int param_0000e85c); // 0x0000000180EF32C0-0x0000000180EF3350
				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int param_0000e85d); // 0x0000000180EF7450-0x0000000180EF74D0
				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo(); // 0x0000000180EF2EC0-0x0000000180EF2F30
				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA(); // 0x0000000180EF6B00-0x0000000180EF6B70
				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi(); // 0x0000000180EF73D0-0x0000000180EF7450
				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk(); // 0x0000000180EF79A0-0x0000000180EF7A20
				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh(); // 0x0000000180EF71B0-0x0000000180EF7230
				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO(); // 0x0000000180EF6060-0x0000000180EF60E0
				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp(); // 0x0000000180EF7AD0-0x0000000180EF7B40
				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB(); // 0x0000000180EF74D0-0x0000000180EF76B0
				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC(); // 0x0000000180EF2C10-0x0000000180EF2DC0
				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI(); // 0x0000000180EF7770-0x0000000180EF79A0
				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL(); // 0x0000000180EF6500-0x0000000180EF66A0
				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx(); // 0x0000000180EF7B40-0x0000000180EF7CB0
				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int param_0000e85e); // 0x0000000180EF7D60-0x0000000180EF7DF0
				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int param_0000e85f); // 0x0000000180EF6170-0x0000000180EF6220
				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int param_0000e860); // 0x0000000180EF2FC0-0x0000000180EF3050
				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int param_0000e861); // 0x0000000180EF2F30-0x0000000180EF2FC0
				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int param_0000e862); // 0x0000000180EF7330-0x0000000180EF73D0
				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC(); // 0x0000000180EF2B00-0x0000000180EF2B80
				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi(); // 0x0000000180EF7230-0x0000000180EF72B0
				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn(); // 0x0000000180EF2DC0-0x0000000180EF2E40
				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq(); // 0x0000000180EF7CB0-0x0000000180EF7D60
				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk(); // 0x0000000180EF2E40-0x0000000180EF2EC0
				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int param_0000e863); // 0x0000000180EF6800-0x0000000180EF6890
				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int param_0000e864); // 0x0000000180EF60E0-0x0000000180EF6170
				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int param_0000e865); // 0x0000000180EF7F00-0x0000000180EF7F90
				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int param_0000e866); // 0x0000000180EF31A0-0x0000000180EF3230
				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int param_0000e867); // 0x0000000180EF3350-0x0000000180EF33D0
				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX(); // 0x0000000180EF76B0-0x0000000180EF76F0
				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI(); // 0x0000000180EF3160-0x0000000180EF31A0
				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp(); // 0x0000000180EF3090-0x0000000180EF30E0
				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj(); // 0x0000000180EF67B0-0x0000000180EF6800
				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC(); // 0x0000000180EF7160-0x0000000180EF71B0
				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS(); // 0x0000000180EF3460-0x0000000180EF34B0
				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb(); // 0x0000000180EF3050-0x0000000180EF3090
				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii(); // 0x0000000180EF76F0-0x0000000180EF7770
				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ(); // 0x0000000180EF66A0-0x0000000180EF6720
				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf(); // 0x0000000180EF30E0-0x0000000180EF3160
				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo(); // 0x0000000180EF7E80-0x0000000180EF7F00
				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH(); // 0x0000000180EF72B0-0x0000000180EF7330
				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int param_0000e868); // 0x0000000180EF7DF0-0x0000000180EF7E80
				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int param_0000e869); // 0x0000000180EF2B80-0x0000000180EF2C10
				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int param_0000e86a); // 0x0000000180EF6720-0x0000000180EF67B0
				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int param_0000e86b); // 0x0000000180EF33D0-0x0000000180EF3460
				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int param_0000e86c); // 0x0000000180EF6220-0x0000000180EF62A0
			}
	
			[Browsable] // 0x0000000180210FD0-0x0000000180211010
			[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 6860
			{
				// Fields
				private static ConflictCheckingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
				// Properties
				internal static ConflictCheckingHelper Instance { get; } // 0x0000000180B2AF80-0x0000000180B2AFF0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class eQSqakoijAgcRcxbjSpZPpyogjDe : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6861
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x44
					public int iNcDOYyUmQvPyqBrczulqnyMWQv; // 0x48
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x4C
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x50
					public JoystickMap rwXPIhaGJmyGraOwfLwocOygkZp; // 0x58
					public JoystickMap cPOeTCjdtzrMyQdUohGYjHxDEbFE; // 0x60
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x68
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x70
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x78
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x79
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x7A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x7B
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0x7C
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0x7D
					public IList<Player> MKWEziWmyXIMvLxMPmgCoSKQnGX; // 0x80
					public int RFUCYxbVnpcLKdAMBMeUYDqcwqOS; // 0x88
					public ElementAssignmentConflictInfo CThaXNdYpfbgnEXKSAPYbfQkHcjj; // 0x8C
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xB8
					public IEnumerator<ElementAssignmentConflictInfo> XWSgvyeYnfBpiLrvJJeizLkTBaT; // 0xC0
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFDAB0-0x0000000180EFDB10 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public eQSqakoijAgcRcxbjSpZPpyogjDe(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EFD8C0-0x0000000180EFDA60
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFD8C0-0x0000000180EFDA60
					private bool MoveNext(); // 0x0000000180EFD2B0-0x0000000180EFD8C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFDA60-0x0000000180EFDAB0
					void IDisposable.Dispose(); // 0x0000000180EFDB10-0x0000000180EFDBC0
					private void DWYcgIgATSXzXIBhRgXjqjjtQTAo(); // 0x0000000180EFD260-0x0000000180EFD2B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class DsUXpicJWUrxlzCiIWLlWqvUwUa : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6862
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x44
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x7C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xB4
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xB5
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xB6
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xB7
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0xB8
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0xB9
					public IList<Player> MOJBVmebMXnfAsQcLdLejASAsUeG; // 0xC0
					public int cocTJppJUjlokeHinejgMgYfnxL; // 0xC8
					public ElementAssignmentConflictInfo AbbggonPlMpJlowLXJoBXlXtLjC; // 0xCC
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xF8
					public IEnumerator<ElementAssignmentConflictInfo> bMjgihChGcenDgJcgQrXYNUwoge; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7A10-0x0000000180EE7A70 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public DsUXpicJWUrxlzCiIWLlWqvUwUa(int <>1__state); // 0x0000000180EE7C00-0x0000000180EE7C70
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EE7820-0x0000000180EE7990
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EE7820-0x0000000180EE7990
					private bool MoveNext(); // 0x0000000180EE7240-0x0000000180EE7820
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EE79C0-0x0000000180EE7A10
					void IDisposable.Dispose(); // 0x0000000180EE7A70-0x0000000180EE7AE0
					private void TTIfIQDzpMQovzlZXLjhQABEygl(); // 0x0000000180EE7AE0-0x0000000180EE7C00
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class svIeuOlqdIdgMJVRVMPqBBMdRLm : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6863
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x44
					public int iNcDOYyUmQvPyqBrczulqnyMWQv; // 0x48
					public KeyboardMap XdIYfVrgKcllppugvSUQMnVAFTy; // 0x50
					public KeyboardMap YSfTPrMnCqIOkIdznriDDNuQQNO; // 0x58
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x60
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x68
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x70
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x71
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x72
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x73
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0x74
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0x75
					public IList<Player> WRcDdAVryAZnfmGIZisrJpoQhvSi; // 0x78
					public int HtHGagdTpReXvhzrrdEtSwYuHLSw; // 0x80
					public ElementAssignmentConflictInfo olYnOgaRKTqLdTUVNPJDQDhAaiBK; // 0x84
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xB0
					public IEnumerator<ElementAssignmentConflictInfo> yJdyNVZoDjnBLiBszvAnXRQQGwl; // 0xB8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F03B70-0x0000000180F03BD0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public svIeuOlqdIdgMJVRVMPqBBMdRLm(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180F039B0-0x0000000180F03B20
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F039B0-0x0000000180F03B20
					private bool MoveNext(); // 0x0000000180F03380-0x0000000180F039B0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F03B20-0x0000000180F03B70
					void IDisposable.Dispose(); // 0x0000000180F03BD0-0x0000000180F03C80
					private void jTVXPDMpitAfwQxWarWcsTKpHmk(); // 0x0000000180F03C80-0x0000000180F03CD0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class HnFiMdnMRJFfGCHzJZKkxgcbjFUF : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6864
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x44
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x7C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xB4
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xB5
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xB6
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xB7
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0xB8
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0xB9
					public IList<Player> SULgmEmCyKAvgCNgcxRlWmcronCV; // 0xC0
					public int DefKpkNNhraDDhHjIsSZQuRkjqrR; // 0xC8
					public ElementAssignmentConflictInfo WWeCvpmYIZVckVmWgBiIhCokaJz; // 0xCC
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xF8
					public IEnumerator<ElementAssignmentConflictInfo> ngHzBAMfApJbkqmlynJnzAMoAah; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE86D0-0x0000000180EE8730 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public HnFiMdnMRJFfGCHzJZKkxgcbjFUF(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EE84E0-0x0000000180EE8680
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EE84E0-0x0000000180EE8680
					private bool MoveNext(); // 0x0000000180EE7EB0-0x0000000180EE84E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EE8680-0x0000000180EE86D0
					void IDisposable.Dispose(); // 0x0000000180EE8730-0x0000000180EE87E0
					private void uYCbFxJgUPfIUiVCKDgjPfcnROFa(); // 0x0000000180EE8830-0x0000000180EE8880
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class WohwyXsENoFMCTBIKyRBwvQQdZy : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6865
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x44
					public int iNcDOYyUmQvPyqBrczulqnyMWQv; // 0x48
					public MouseMap PbIBOGnzmPGkfSUYzFIVHNRBbGW; // 0x50
					public MouseMap jQwEfiUdYOEYTrLptnAoLEOZCFO; // 0x58
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x60
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x68
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x70
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x71
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x72
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x73
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0x74
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0x75
					public IList<Player> yjnnbwqkKRtnqpRDvlZLsNkOFOV; // 0x78
					public int MpvNDUHagIsoJmhfYyWJfMTuLvQ; // 0x80
					public ElementAssignmentConflictInfo MGSglAEVZsqHKVvUrAcPehuiBbr; // 0x84
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xB0
					public IEnumerator<ElementAssignmentConflictInfo> LaXhSwWgVLSsXaCxjuydKkXQgrD; // 0xB8
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EF97F0-0x0000000180EF9850 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public WohwyXsENoFMCTBIKyRBwvQQdZy(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EF9630-0x0000000180EF97A0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EF9630-0x0000000180EF97A0
					private bool MoveNext(); // 0x0000000180EF9080-0x0000000180EF9630
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EF97A0-0x0000000180EF97F0
					void IDisposable.Dispose(); // 0x0000000180EF9850-0x0000000180EF98C0
					private void DxBrZWLmABsZfntVITVZAupiECp(); // 0x0000000180EF8F80-0x0000000180EF9080
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class hTDxbowqJEakwFsHmMdeWCTxRen : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6866
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x44
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x7C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xB4
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xB5
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xB6
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xB7
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0xB8
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0xB9
					public IList<Player> SpmEcYsWByikWcnDVrIUeiqhFYr; // 0xC0
					public int NkTdbdphEqzrNISNmlAEmUbdixH; // 0xC8
					public ElementAssignmentConflictInfo bmJyueBGwjvgfztUaLxWSjNeOTY; // 0xCC
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xF8
					public IEnumerator<ElementAssignmentConflictInfo> QsioNNypxZnEVudLIYnmprfzifk; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFFB10-0x0000000180EFFB70 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public hTDxbowqJEakwFsHmMdeWCTxRen(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EFF910-0x0000000180EFFAC0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFF910-0x0000000180EFFAC0
					private bool MoveNext(); // 0x0000000180EFF550-0x0000000180EFF910
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFFAC0-0x0000000180EFFB10
					void IDisposable.Dispose(); // 0x0000000180EFFB70-0x0000000180EFFC20
					private void BlJcpSGMIJLNuLoYcagvHJvgeeni(); // 0x0000000180EFF450-0x0000000180EFF550
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class vXqtXTDOYVGRWkLMIpAnalYxhZG : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6867
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ; // 0x44
					public int iNcDOYyUmQvPyqBrczulqnyMWQv; // 0x48
					public int AkkOxeFFauQvLEuBcHkzXcxVDoLa; // 0x4C
					public int HiUejrNlCkcqLEXEYrOZVhlGqJDR; // 0x50
					public CustomControllerMap hjJeeldXugdVafyVnLNjHwybuBz; // 0x58
					public CustomControllerMap KqceBBRVZFmWfODIxIwCbgtYGZR; // 0x60
					public ActionElementMap fltxxhyRZfQdEoMAlCOVFHsvVnlJ; // 0x68
					public ActionElementMap vSfdRccImBdXghlwRdvRgMCkGBN; // 0x70
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x78
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x79
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0x7A
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0x7B
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0x7C
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0x7D
					public IList<Player> flGDPcYipGWKpLljeFYuisJwvcrA; // 0x80
					public int PqDxxDmVgzeEZCiQpdGEVhbtSWi; // 0x88
					public ElementAssignmentConflictInfo TWZzVBcBmKQdhPeedClquDEsoSs; // 0x8C
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xB8
					public IEnumerator<ElementAssignmentConflictInfo> xkMxvFnCpxJNaodZHyNMWIyMELC; // 0xC0
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F04B70-0x0000000180F04BD0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public vXqtXTDOYVGRWkLMIpAnalYxhZG(int <>1__state); // 0x0000000180F04C40-0x0000000180F04CB0
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180F04960-0x0000000180F04B20
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180F04960-0x0000000180F04B20
					private bool MoveNext(); // 0x0000000180F04320-0x0000000180F04960
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180F04B20-0x0000000180F04B70
					void IDisposable.Dispose(); // 0x0000000180F04BD0-0x0000000180F04C40
					private void wbuKNZGgaeBjYLLTrIThwBwtRUS(); // 0x0000000180F04CB0-0x0000000180F04DE0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ebpbEyyjLqhAWKulViKLDyqJCsH : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6868
				{
					// Fields
					private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
					public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x44
					public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x7C
					public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xB4
					public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xB5
					public bool QDPvbaEgNxDSgMneXlUSbgRPbJqg; // 0xB6
					public bool zvtRiMruKwJnFepPguqIcMMwcWL; // 0xB7
					public bool qjrsWyTDRtOHepqtxWyRngJiyMC; // 0xB8
					public bool hpaAOCsFFRcorWrOwXvQxgvgUxn; // 0xB9
					public IList<Player> qlffIENDDCBGTWGYCbiODvIzNAVi; // 0xC0
					public int hiYinasmijdeojjkseAoSyierbv; // 0xC8
					public ElementAssignmentConflictInfo hzElOCsGjiAFfhaJcTKVtpSYjJn; // 0xCC
					public ConflictCheckingHelper gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0xF8
					public IEnumerator<ElementAssignmentConflictInfo> bCIXzOavJiJvFAKnLOGgUIdxVcg; // 0x100
	
					// Properties
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EFE510-0x0000000180EFE570 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ebpbEyyjLqhAWKulViKLDyqJCsH(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180EFE310-0x0000000180EFE4C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EFE310-0x0000000180EFE4C0
					private bool MoveNext(); // 0x0000000180EFDCE0-0x0000000180EFE310
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000180EFE4C0-0x0000000180EFE510
					void IDisposable.Dispose(); // 0x0000000180EFE570-0x0000000180EFE5E0
					private void KHobgYkougjDJTFYscrlKfAVaQjM(); // 0x0000000180EFDBC0-0x0000000180EFDCE0
				}
	
				// Constructors
				private ConflictCheckingHelper(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public bool DoesAnyElementAssignmentConflict(); // 0x0000000180B27710-0x0000000180B27730
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps); // 0x0000000180B26510-0x0000000180B26530
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B27730-0x0000000180B27750
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B26530-0x0000000180B27710
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180B279F0-0x0000000180B27A30
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180B27DA0-0x0000000180B27DF0
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B27D00-0x0000000180B27D50
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B27A30-0x0000000180B27CB0
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180B27750-0x0000000180B277A0
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180B27CB0-0x0000000180B27D00
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B27D50-0x0000000180B27DA0
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B277A0-0x0000000180B279F0
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000e8a6, int param_0000e8a7, JoystickMap param_0000e8a8, ActionElementMap param_0000e8a9, bool param_0000e8aa = false /* Metadata: 0x00765F6C */, bool param_0000e8ab = false /* Metadata: 0x00765F6D */, bool param_0000e8ac = true /* Metadata: 0x00765F6E */); // 0x0000000180B27DF0-0x0000000180B28110
				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck param_0000e8ad, bool param_0000e8ae = false /* Metadata: 0x00765F6F */, bool param_0000e8af = false /* Metadata: 0x00765F70 */, bool param_0000e8b0 = true /* Metadata: 0x00765F71 */); // 0x0000000180B28110-0x0000000180B28390
				private bool wXcueicCklSRvlxEnukgGZLyfpI(int param_0000e8b1, KeyboardMap param_0000e8b2, ActionElementMap param_0000e8b3, bool param_0000e8b4 = false /* Metadata: 0x00765F72 */, bool param_0000e8b5 = false /* Metadata: 0x00765F73 */, bool param_0000e8b6 = true /* Metadata: 0x00765F74 */); // 0x0000000180B2C9C0-0x0000000180B2CC20
				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck param_0000e8b7, bool param_0000e8b8 = false /* Metadata: 0x00765F75 */, bool param_0000e8b9 = false /* Metadata: 0x00765F76 */, bool param_0000e8ba = true /* Metadata: 0x00765F77 */); // 0x0000000180B2CC20-0x0000000180B2CF50
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(int param_0000e8bb, MouseMap param_0000e8bc, ActionElementMap param_0000e8bd, bool param_0000e8be = false /* Metadata: 0x00765F78 */, bool param_0000e8bf = false /* Metadata: 0x00765F79 */, bool param_0000e8c0 = true /* Metadata: 0x00765F7A */); // 0x0000000180B2AD20-0x0000000180B2AF80
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck param_0000e8c1, bool param_0000e8c2 = false /* Metadata: 0x00765F7B */, bool param_0000e8c3 = false /* Metadata: 0x00765F7C */, bool param_0000e8c4 = true /* Metadata: 0x00765F7D */); // 0x0000000180B2AA40-0x0000000180B2AD20
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000e8c5, int param_0000e8c6, CustomControllerMap param_0000e8c7, ActionElementMap param_0000e8c8, bool param_0000e8c9 = false /* Metadata: 0x00765F7E */, bool param_0000e8ca = false /* Metadata: 0x00765F7F */, bool param_0000e8cb = true /* Metadata: 0x00765F80 */); // 0x0000000180B29810-0x0000000180B29A80
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck param_0000e8cc, bool param_0000e8cd = false /* Metadata: 0x00765F81 */, bool param_0000e8ce = false /* Metadata: 0x00765F82 */, bool param_0000e8cf = true /* Metadata: 0x00765F83 */); // 0x0000000180B29A80-0x0000000180B29DA0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180B28DA0-0x0000000180B28DE0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180B28390-0x0000000180B283E0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B28CB0-0x0000000180B28D00
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B28430-0x0000000180B288F0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180B283E0-0x0000000180B28430
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180B28D00-0x0000000180B28D50
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B28D50-0x0000000180B28DA0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B288F0-0x0000000180B28CB0
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000e8f4, int param_0000e8f5, JoystickMap param_0000e8f6, ActionElementMap param_0000e8f7, bool param_0000e8f8 = false /* Metadata: 0x00765F84 */, bool param_0000e8f9 = false /* Metadata: 0x00765F85 */, bool param_0000e8fa = true /* Metadata: 0x00765F86 */); // 0x0000000180B28FE0-0x0000000180B290C0
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck param_0000e8fb, bool param_0000e8fc = false /* Metadata: 0x00765F87 */, bool param_0000e8fd = false /* Metadata: 0x00765F88 */, bool param_0000e8fe = true /* Metadata: 0x00765F89 */); // 0x0000000180B290C0-0x0000000180B291C0
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(int param_0000e8ff, KeyboardMap param_0000e900, ActionElementMap param_0000e901, bool param_0000e902 = false /* Metadata: 0x00765F8A */, bool param_0000e903 = false /* Metadata: 0x00765F8B */, bool param_0000e904 = true /* Metadata: 0x00765F8C */); // 0x0000000180B2C280-0x0000000180B2C360
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck param_0000e905, bool param_0000e906 = false /* Metadata: 0x00765F8D */, bool param_0000e907 = false /* Metadata: 0x00765F8E */, bool param_0000e908 = true /* Metadata: 0x00765F8F */); // 0x0000000180B2C360-0x0000000180B2C460
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(int param_0000e909, MouseMap param_0000e90a, ActionElementMap param_0000e90b, bool param_0000e90c = false /* Metadata: 0x00765F90 */, bool param_0000e90d = false /* Metadata: 0x00765F91 */, bool param_0000e90e = true /* Metadata: 0x00765F92 */); // 0x0000000180B28EF0-0x0000000180B28FE0
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck param_0000e90f, bool param_0000e910 = false /* Metadata: 0x00765F93 */, bool param_0000e911 = false /* Metadata: 0x00765F94 */, bool param_0000e912 = true /* Metadata: 0x00765F95 */); // 0x0000000180B28DE0-0x0000000180B28EF0
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000e913, int param_0000e914, CustomControllerMap param_0000e915, ActionElementMap param_0000e916, bool param_0000e917 = false /* Metadata: 0x00765F96 */, bool param_0000e918 = false /* Metadata: 0x00765F97 */, bool param_0000e919 = true /* Metadata: 0x00765F98 */); // 0x0000000180B2AFF0-0x0000000180B2B100
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck param_0000e91a, bool param_0000e91b = false /* Metadata: 0x00765F99 */, bool param_0000e91c = false /* Metadata: 0x00765F9A */, bool param_0000e91d = true /* Metadata: 0x00765F9B */); // 0x0000000180B2B100-0x0000000180B2B1E0
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180B29DF0-0x0000000180B29E30
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180B2A150-0x0000000180B2A1A0
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B2A100-0x0000000180B2A150
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B2A1A0-0x0000000180B2A440
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180B2A0B0-0x0000000180B2A100
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180B29DA0-0x0000000180B29DF0
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B29E30-0x0000000180B29E80
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B29E80-0x0000000180B2A0B0
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000e942, int param_0000e943, JoystickMap param_0000e944, ActionElementMap param_0000e945, bool param_0000e946 = false /* Metadata: 0x00765F9C */, bool param_0000e947 = false /* Metadata: 0x00765F9D */, bool param_0000e948 = true /* Metadata: 0x00765F9E */); // 0x0000000180B2CF50-0x0000000180B2D290
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck param_0000e949, bool param_0000e94a = false /* Metadata: 0x00765F9F */, bool param_0000e94b = false /* Metadata: 0x00765FA0 */, bool param_0000e94c = true /* Metadata: 0x00765FA1 */); // 0x0000000180B2D290-0x0000000180B2D5D0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(int param_0000e94d, KeyboardMap param_0000e94e, ActionElementMap param_0000e94f, bool param_0000e950 = false /* Metadata: 0x00765FA2 */, bool param_0000e951 = false /* Metadata: 0x00765FA3 */, bool param_0000e952 = true /* Metadata: 0x00765FA4 */); // 0x0000000180B25840-0x0000000180B25B70
				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck param_0000e953, bool param_0000e954 = false /* Metadata: 0x00765FA5 */, bool param_0000e955 = false /* Metadata: 0x00765FA6 */, bool param_0000e956 = true /* Metadata: 0x00765FA7 */); // 0x0000000180B25B70-0x0000000180B25EA0
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(int param_0000e957, MouseMap param_0000e958, ActionElementMap param_0000e959, bool param_0000e95a = false /* Metadata: 0x00765FA8 */, bool param_0000e95b = false /* Metadata: 0x00765FA9 */, bool param_0000e95c = true /* Metadata: 0x00765FAA */); // 0x0000000180B2C740-0x0000000180B2C9C0
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck param_0000e95d, bool param_0000e95e = false /* Metadata: 0x00765FAB */, bool param_0000e95f = false /* Metadata: 0x00765FAC */, bool param_0000e960 = true /* Metadata: 0x00765FAD */); // 0x0000000180B2C460-0x0000000180B2C740
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000e961, int param_0000e962, CustomControllerMap param_0000e963, ActionElementMap param_0000e964, bool param_0000e965 = false /* Metadata: 0x00765FAE */, bool param_0000e966 = false /* Metadata: 0x00765FAF */, bool param_0000e967 = true /* Metadata: 0x00765FB0 */); // 0x0000000180B2B480-0x0000000180B2B750
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck param_0000e968, bool param_0000e969 = false /* Metadata: 0x00765FB1 */, bool param_0000e96a = false /* Metadata: 0x00765FB2 */, bool param_0000e96b = true /* Metadata: 0x00765FB3 */); // 0x0000000180B2B1E0-0x0000000180B2B480
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180B25EA0-0x0000000180B25EE0
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180B26280-0x0000000180B262D0
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B25F80-0x0000000180B25FD0
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B26020-0x0000000180B26280
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180B25FD0-0x0000000180B26020
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180B25EE0-0x0000000180B25F30
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180B25F30-0x0000000180B25F80
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180B262D0-0x0000000180B26510
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000e990, int param_0000e991, JoystickMap param_0000e992, ActionElementMap param_0000e993, bool param_0000e994 = false /* Metadata: 0x00765FB4 */, bool param_0000e995 = false /* Metadata: 0x00765FB5 */, bool param_0000e996 = true /* Metadata: 0x00765FB6 */); // 0x0000000180B29540-0x0000000180B29810
				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck param_0000e997, bool param_0000e998 = false /* Metadata: 0x00765FB7 */, bool param_0000e999 = false /* Metadata: 0x00765FB8 */, bool param_0000e99a = true /* Metadata: 0x00765FB9 */); // 0x0000000180B291C0-0x0000000180B29540
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(int param_0000e99b, KeyboardMap param_0000e99c, ActionElementMap param_0000e99d, bool param_0000e99e = false /* Metadata: 0x00765FBA */, bool param_0000e99f = false /* Metadata: 0x00765FBB */, bool param_0000e9a0 = true /* Metadata: 0x00765FBC */); // 0x0000000180B2A440-0x0000000180B2A790
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck param_0000e9a1, bool param_0000e9a2 = false /* Metadata: 0x00765FBD */, bool param_0000e9a3 = false /* Metadata: 0x00765FBE */, bool param_0000e9a4 = true /* Metadata: 0x00765FBF */); // 0x0000000180B2A790-0x0000000180B2AA40
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(int param_0000e9a5, MouseMap param_0000e9a6, ActionElementMap param_0000e9a7, bool param_0000e9a8 = false /* Metadata: 0x00765FC0 */, bool param_0000e9a9 = false /* Metadata: 0x00765FC1 */, bool param_0000e9aa = true /* Metadata: 0x00765FC2 */); // 0x0000000180B2BA00-0x0000000180B2BC60
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck param_0000e9ab, bool param_0000e9ac = false /* Metadata: 0x00765FC3 */, bool param_0000e9ad = false /* Metadata: 0x00765FC4 */, bool param_0000e9ae = true /* Metadata: 0x00765FC5 */); // 0x0000000180B2B750-0x0000000180B2BA00
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000e9af, int param_0000e9b0, CustomControllerMap param_0000e9b1, ActionElementMap param_0000e9b2, bool param_0000e9b3 = false /* Metadata: 0x00765FC6 */, bool param_0000e9b4 = false /* Metadata: 0x00765FC7 */, bool param_0000e9b5 = true /* Metadata: 0x00765FC8 */); // 0x0000000180B2BF90-0x0000000180B2C280
				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck param_0000e9b6, bool param_0000e9b7 = false /* Metadata: 0x00765FC9 */, bool param_0000e9b8 = false /* Metadata: 0x00765FCA */, bool param_0000e9b9 = true /* Metadata: 0x00765FCB */); // 0x0000000180B2BC60-0x0000000180B2BF90
			}
	
			// Constructors
			private ControllerHelper(); // 0x0000000180B30590-0x0000000180B30620
	
			// Methods
			public T GetController<T>(int controllerId)
				where T : Controller;
			public int GetControllerCount(ControllerType controllerType); // 0x0000000180B2E520-0x0000000180B2E6A0
			public Controller GetController(ControllerType controllerType, int controllerId); // 0x0000000180B2E820-0x0000000180B2E8E0
			public Controller GetController(ControllerIdentifier controllerIdentifier); // 0x0000000180B2E750-0x0000000180B2E820
			public Controller[] GetControllers(ControllerType controllerType); // 0x0000000180B2E8E0-0x0000000180B2E990
			public string[] GetControllerNames(ControllerType controllerType); // 0x0000000180B2E6A0-0x0000000180B2E750
			public bool IsControllerAssigned(ControllerType controllerType, Controller controller); // 0x0000000180B2F5C0-0x0000000180B2F670
			public bool IsControllerAssigned(ControllerType controllerType, int controllerId); // 0x0000000180B2F670-0x0000000180B2F730
			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId); // 0x0000000180B2F4F0-0x0000000180B2F5C0
			public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = true /* Metadata: 0x00765F66 */); // 0x0000000180B2FB70-0x0000000180B2FC20
			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true /* Metadata: 0x00765F67 */); // 0x0000000180B2FC20-0x0000000180B2FCF0
			public Joystick GetJoystick(int joystickId); // 0x0000000180B2EDB0-0x0000000180B2EE60
			public Joystick[] GetJoysticks(); // 0x0000000180B2EE60-0x0000000180B2EED0
			public string[] GetJoystickNames(); // 0x0000000180B2ED00-0x0000000180B2EDB0
			public bool IsJoystickAssigned(Joystick joystick); // 0x0000000180B2FAC0-0x0000000180B2FB70
			public bool IsJoystickAssigned(int joystickId); // 0x0000000180B2FA10-0x0000000180B2FAC0
			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId); // 0x0000000180B2F950-0x0000000180B2FA10
			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true /* Metadata: 0x00765F68 */); // 0x0000000180B2FF40-0x0000000180B30010
			public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = true /* Metadata: 0x00765F69 */); // 0x0000000180B2FE90-0x0000000180B2FF40
			public int GetUnityJoystickIdFromAnyButtonPress(); // 0x0000000180B2F320-0x0000000180B2F4F0
			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly); // 0x0000000180B2F0C0-0x0000000180B2F320
			public void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x0000000180B30470-0x0000000180B30590
			public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId); // 0x0000000180B30240-0x0000000180B30470
			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly); // 0x0000000180B30190-0x0000000180B30240
			public CustomController GetCustomController(int customControllerId); // 0x0000000180B2EA40-0x0000000180B2EAF0
			public CustomController[] GetCustomControllers(); // 0x0000000180B2EAF0-0x0000000180B2EBA0
			public string[] GetCustomControllerNames(); // 0x0000000180B2E990-0x0000000180B2EA40
			public bool IsCustomControllerAssigned(CustomController customController); // 0x0000000180B2F7F0-0x0000000180B2F8A0
			public bool IsCustomControllerAssigned(int customControllerId); // 0x0000000180B2F8A0-0x0000000180B2F950
			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId); // 0x0000000180B2F730-0x0000000180B2F7F0
			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true /* Metadata: 0x00765F6A */); // 0x0000000180B2FDC0-0x0000000180B2FE90
			public void RemoveCustomControllerFromAllPlayers(int customControllerId, bool includeSystemPlayer = true /* Metadata: 0x00765F6B */); // 0x0000000180B2FCF0-0x0000000180B2FDC0
			public CustomController CreateCustomController(int sourceControllerId); // 0x0000000180B2DA40-0x0000000180B2DAF0
			public CustomController CreateCustomController(int sourceControllerId, string tag); // 0x0000000180B2DAF0-0x0000000180B2DBC0
			public bool DestroyCustomController(CustomController customController); // 0x0000000180B2DD20-0x0000000180B2DE90
			public CustomController GetFirstCustomControllerWithSourceId(int sourceId); // 0x0000000180B2EBA0-0x0000000180B2EC50
			public CustomController GetFirstCustomControllerWithTag(string tag); // 0x0000000180B2EC50-0x0000000180B2ED00
			public IEnumerable<CustomController> CustomControllersWithSourceId(int sourceId); // 0x0000000180B2DBC0-0x0000000180B2DC70
			public IEnumerable<CustomController> CustomControllersWithTag(string tag); // 0x0000000180B2DC70-0x0000000180B2DD20
			public IList<TInterface> GetControllerTemplates<TInterface>()
				where TInterface : IControllerTemplate;
			public Controller GetLastActiveController(); // 0x0000000180B2F020-0x0000000180B2F0C0
			public Controller GetLastActiveController(ControllerType controllerType); // 0x0000000180B2EF70-0x0000000180B2F020
			public T GetLastActiveController<T>()
				where T : Controller;
			public ControllerType GetLastActiveControllerType(); // 0x0000000180B2EED0-0x0000000180B2EF70
			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback); // 0x0000000180B2D5D0-0x0000000180B2D680
			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000180B2D680-0x0000000180B2D730
			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback); // 0x0000000180B30010-0x0000000180B300D0
			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000180B300D0-0x0000000180B30190
			public void ClearLastActiveControllerChangedDelegates(); // 0x0000000180B2D9A0-0x0000000180B2DA40
			public bool GetAnyButton(); // 0x0000000180B2E3D0-0x0000000180B2E470
			public bool GetAnyButton(ControllerType controllerType); // 0x0000000180B2E470-0x0000000180B2E520
			public bool GetAnyButtonDown(); // 0x0000000180B2DFE0-0x0000000180B2E080
			public bool GetAnyButtonDown(ControllerType controllerType); // 0x0000000180B2E080-0x0000000180B2E130
			public bool GetAnyButtonUp(); // 0x0000000180B2E330-0x0000000180B2E3D0
			public bool GetAnyButtonUp(ControllerType controllerType); // 0x0000000180B2E280-0x0000000180B2E330
			public bool GetAnyButtonChanged(); // 0x0000000180B2DF40-0x0000000180B2DFE0
			public bool GetAnyButtonChanged(ControllerType controllerType); // 0x0000000180B2DE90-0x0000000180B2DF40
			public bool GetAnyButtonPrev(); // 0x0000000180B2E1E0-0x0000000180B2E280
			public bool GetAnyButtonPrev(ControllerType controllerType); // 0x0000000180B2E130-0x0000000180B2E1E0
			public bool AutoAssignJoystick(Joystick joystick); // 0x0000000180B2D730-0x0000000180B2D820
			public void AutoAssignJoysticks(); // 0x0000000180B2D820-0x0000000180B2D9A0
		}
	
		[Browsable] // 0x0000000180210FD0-0x0000000180211010
		[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
		public sealed class MappingHelper : CodeHelper // TypeDefIndex: 6869
		{
			// Fields
			private static MappingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static MappingHelper Instance { get; } // 0x0000000180EF19D0-0x0000000180EF1A40 
			public IList<InputMapCategory> MapCategories { get; } // 0x0000000180EF1BA0-0x0000000180EF1C50 
			public IEnumerable<InputMapCategory> UserAssignableMapCategories { get; } // 0x0000000180EF1E60-0x0000000180EF1F10 
			public IList<InputCategory> ActionCategories { get; } // 0x0000000180EF17D0-0x0000000180EF1880 
			public IEnumerable<InputCategory> UserAssignableActionCategories { get; } // 0x0000000180EF1D00-0x0000000180EF1DB0 
			public IList<InputLayout> JoystickLayouts { get; } // 0x0000000180EF1A40-0x0000000180EF1AF0 
			public IList<InputLayout> KeyboardLayouts { get; } // 0x0000000180EF1AF0-0x0000000180EF1BA0 
			public IList<InputLayout> MouseLayouts { get; } // 0x0000000180EF1C50-0x0000000180EF1D00 
			public IList<InputLayout> CustomControllerLayouts { get; } // 0x0000000180EF1920-0x0000000180EF19D0 
			public IList<InputAction> Actions { get; } // 0x0000000180EF1880-0x0000000180EF1920 
			public IEnumerable<InputAction> UserAssignableActions { get; } // 0x0000000180EF1DB0-0x0000000180EF1E60 
	
			// Constructors
			private MappingHelper(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			public InputMapCategory GetMapCategory(int mapCategoryId); // 0x0000000180EEFEB0-0x0000000180EEFF60
			public InputMapCategory GetMapCategory(string name); // 0x0000000180EEFF60-0x0000000180EF0010
			public int GetMapCategoryId(string name); // 0x0000000180EEFE00-0x0000000180EEFEB0
			public IEnumerable<InputMapCategory> MapCategoriesWithTag(string tag); // 0x0000000180EF0ED0-0x0000000180EF0F80
			public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(string tag); // 0x0000000180EF1630-0x0000000180EF16E0
			public bool IsMapCategoryUserAssignable(int mapCategoryId); // 0x0000000180EF0DD0-0x0000000180EF0ED0
			public InputCategory GetActionCategory(int mapCategoryId); // 0x0000000180EE94B0-0x0000000180EE9560
			public InputCategory GetActionCategory(string name); // 0x0000000180EE9560-0x0000000180EE9610
			public int GetActionCategoryId(string name); // 0x0000000180EE9400-0x0000000180EE94B0
			public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag); // 0x0000000180EE8FB0-0x0000000180EE9060
			public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(string tag); // 0x0000000180EF1290-0x0000000180EF1340
			public bool IsActionCategoryUserAssignable(int mapCategoryId); // 0x0000000180EF0CB0-0x0000000180EF0DD0
			public InputLayout GetLayout(ControllerType controllerType, int layoutId); // 0x0000000180EEF9E0-0x0000000180EEFBF0
			public InputLayout GetLayout(ControllerType controllerType, string name); // 0x0000000180EEFBF0-0x0000000180EEFE00
			public int GetLayoutId(ControllerType controllerType, string name); // 0x0000000180EEF7D0-0x0000000180EEF9E0
			public InputLayout GetJoystickLayout(int layoutId); // 0x0000000180EED1E0-0x0000000180EED290
			public InputLayout GetJoystickLayout(string name); // 0x0000000180EED290-0x0000000180EED340
			public int GetJoystickLayoutId(string name); // 0x0000000180EED130-0x0000000180EED1E0
			public InputLayout GetKeyboardLayout(int layoutId); // 0x0000000180EEF010-0x0000000180EEF0C0
			public InputLayout GetKeyboardLayout(string name); // 0x0000000180EEEF60-0x0000000180EEF010
			public int GetKeyboardLayoutId(string name); // 0x0000000180EEEEB0-0x0000000180EEEF60
			public InputLayout GetMouseLayout(int layoutId); // 0x0000000180EF00C0-0x0000000180EF0170
			public InputLayout GetMouseLayout(string name); // 0x0000000180EF0170-0x0000000180EF0220
			public int GetMouseLayoutId(string name); // 0x0000000180EF0010-0x0000000180EF00C0
			public InputLayout GetCustomControllerLayout(int layoutId); // 0x0000000180EEB320-0x0000000180EEB3D0
			public InputLayout GetCustomControllerLayout(string name); // 0x0000000180EEB3D0-0x0000000180EEB480
			public int GetCustomControllerLayoutId(string name); // 0x0000000180EEB270-0x0000000180EEB320
			public IList<InputLayout> MapLayouts(ControllerType controllerType); // 0x0000000180EF0F80-0x0000000180EF1290
			public InputAction GetAction(int actionId); // 0x0000000180EE98B0-0x0000000180EE9960
			public InputAction GetAction(string name); // 0x0000000180EE9960-0x0000000180EE9A10
			public int GetActionId(string name); // 0x0000000180EE9800-0x0000000180EE98B0
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName); // 0x0000000180EE91D0-0x0000000180EE9280
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName, bool sort); // 0x0000000180EE9280-0x0000000180EE9350
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId); // 0x0000000180EE9350-0x0000000180EE9400
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId, bool sort); // 0x0000000180EE9110-0x0000000180EE91D0
			public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag); // 0x0000000180EE9060-0x0000000180EE9110
			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId); // 0x0000000180EF1580-0x0000000180EF1630
			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId, bool sort); // 0x0000000180EF1410-0x0000000180EF14D0
			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName); // 0x0000000180EF14D0-0x0000000180EF1580
			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName, bool sort); // 0x0000000180EF1340-0x0000000180EF1410
			public IList<InputBehavior> GetInputBehaviors(int playerId); // 0x0000000180EED080-0x0000000180EED130
			public IList<InputBehavior> GetSystemPlayerInputBehaviors(); // 0x0000000180EF0C00-0x0000000180EF0CB0
			public InputBehavior GetInputBehavior(int playerId, int behaviorId); // 0x0000000180EECFC0-0x0000000180EED080
			public InputBehavior GetInputBehavior(int playerId, string behaviorName); // 0x0000000180EECF00-0x0000000180EECFC0
			public InputBehavior GetSystemPlayerInputBehavior(int behaviorId); // 0x0000000180EF0B10-0x0000000180EF0C00
			public InputBehavior GetSystemPlayerInputBehavior(string behaviorName); // 0x0000000180EF0A20-0x0000000180EF0B10
			public int GetInputBehaviorId(string behaviorName); // 0x0000000180EECE50-0x0000000180EECF00
			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(int param_0000e9f9); // 0x0000000180EF1760-0x0000000180EF17D0
			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(string param_0000e9fa); // 0x0000000180EF16E0-0x0000000180EF1760
			public ControllerMap GetControllerMap(int id); // 0x0000000180EEADD0-0x0000000180EEAFB0
			public ActionElementMap GetActionElementMap(int id); // 0x0000000180EE9610-0x0000000180EE9800
			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId); // 0x0000000180EEAA20-0x0000000180EEABD0
			public ControllerMap GetControllerMapInstance(Controller controller, string mapCategoryName, string layoutName); // 0x0000000180EEA490-0x0000000180EEA560
			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EEA780-0x0000000180EEAA20
			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EEA560-0x0000000180EEA780
			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId); // 0x0000000180EEEDA0-0x0000000180EEEEB0
			public JoystickMap GetJoystickMapInstance(Joystick joystick, string mapCategoryName, string layoutName); // 0x0000000180EEE1E0-0x0000000180EEE360
			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId); // 0x0000000180EEE530-0x0000000180EEE920
			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, string mapCategoryName, string layoutName); // 0x0000000180EEE920-0x0000000180EEEB30
			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EEEB30-0x0000000180EEEDA0
			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EEE360-0x0000000180EEE530
			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId); // 0x0000000180EEF5B0-0x0000000180EEF710
			public KeyboardMap GetKeyboardMapInstance(string mapCategoryName, string layoutName); // 0x0000000180EEF710-0x0000000180EEF7D0
			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId); // 0x0000000180EF08E0-0x0000000180EF0A20
			public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName); // 0x0000000180EF0780-0x0000000180EF08E0
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId); // 0x0000000180EEC940-0x0000000180EECA80
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, string mapCategoryName, string layoutName); // 0x0000000180EECA80-0x0000000180EECD20
			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EEC330-0x0000000180EEC940
			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EEC1C0-0x0000000180EEC330
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, int mapCategoryId, int layoutId); // 0x0000000180EE9C10-0x0000000180EE9FA0
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, string mapCategoryName, string layoutName); // 0x0000000180EE9FA0-0x0000000180EEA080
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EEA080-0x0000000180EEA220
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EEA220-0x0000000180EEA490
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, int mapCategoryId, int layoutId); // 0x0000000180EED340-0x0000000180EED400
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, string mapCategoryName, string layoutName); // 0x0000000180EED400-0x0000000180EED5A0
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EED710-0x0000000180EEE1E0
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EED5A0-0x0000000180EED710
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, int mapCategoryId, int layoutId); // 0x0000000180EEB640-0x0000000180EEB6D0
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, string mapCategoryName, string layoutName); // 0x0000000180EEB6D0-0x0000000180EEB820
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x0000000180EEB820-0x0000000180EEC1C0
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x0000000180EEB480-0x0000000180EEB640
			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId); // 0x0000000180EEF0C0-0x0000000180EEF4F0
			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName); // 0x0000000180EEF4F0-0x0000000180EEF5B0
			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId); // 0x0000000180EF0220-0x0000000180EF0600
			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName); // 0x0000000180EF0600-0x0000000180EF0780
			[Obsolete] // 0x00000001802802B0-0x00000001802802E0
			public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(Joystick joystick, int joystickElementIdentifierId); // 0x0000000180EECD20-0x0000000180EECE50
			private ControllerElementIdentifier vjwEhCZEZHlszoNSLRdwLzibmvc(Guid param_0000ea6d, int param_0000ea6e); // 0x0000000180EF1F10-0x0000000180EF1FC0
			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, int mapCategoryId, int layoutId); // 0x0000000180EEAFB0-0x0000000180EEB090
			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, string mapCategoryName, string layoutName); // 0x0000000180EEB090-0x0000000180EEB270
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id); // 0x0000000180EEABD0-0x0000000180EEAC80
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(string name); // 0x0000000180EEAC80-0x0000000180EEADD0
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id); // 0x0000000180EE9A10-0x0000000180EE9AC0
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(string name); // 0x0000000180EE9AC0-0x0000000180EE9C10
		}
	
		[Browsable] // 0x0000000180210FD0-0x0000000180211010
		[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
		public sealed class PlayerHelper : CodeHelper // TypeDefIndex: 6870
		{
			// Fields
			private static PlayerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static PlayerHelper Instance { get; } // 0x0000000180EF2810-0x0000000180EF2880 
			public int playerCount { get; } // 0x0000000180EF2A60-0x0000000180EF2B00 
			public int allPlayerCount { get; } // 0x0000000180EF29C0-0x0000000180EF2A60 
			public IList<Player> Players { get; } // 0x0000000180EF2880-0x0000000180EF2920 
			public IList<Player> AllPlayers { get; } // 0x0000000180EF2770-0x0000000180EF2810 
			public Player SystemPlayer { get; } // 0x0000000180EF2920-0x0000000180EF29C0 
	
			// Constructors
			private PlayerHelper(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			public IList<Player> GetPlayers(bool includeSystemPlayer = false /* Metadata: 0x00765FCC */); // 0x0000000180EF25E0-0x0000000180EF26D0
			public Player GetPlayer(int playerId); // 0x0000000180EF2530-0x0000000180EF25E0
			public Player GetPlayer(string name); // 0x0000000180EF2480-0x0000000180EF2530
			public Player GetSystemPlayer(); // 0x0000000180EF26D0-0x0000000180EF2770
			public int GetPlayerId(string playerName); // 0x0000000180EF2270-0x0000000180EF2320
			public string[] GetPlayerNames(bool includeSystemPlayer = false /* Metadata: 0x00765FCD */); // 0x0000000180EF23D0-0x0000000180EF2480
			public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = false /* Metadata: 0x00765FCE */); // 0x0000000180EF21C0-0x0000000180EF2270
			public int[] GetPlayerIds(bool includeSystemPlayer = false /* Metadata: 0x00765FCF */); // 0x0000000180EF2320-0x0000000180EF23D0
		}
	
		[Browsable] // 0x0000000180210FD0-0x0000000180211010
		[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
		public sealed class TimeHelper : CodeHelper // TypeDefIndex: 6871
		{
			// Fields
			private static TimeHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static TimeHelper Instance { get; } // 0x0000000180EF8650-0x0000000180EF86C0 
			public float unscaledDeltaTime { get; } // 0x0000000180EF8770-0x0000000180EF8820 
			public float unscaledTime { get; } // 0x0000000180EF8820-0x0000000180EF88D0 
			public uint currentFrame { get; } // 0x0000000180EF86C0-0x0000000180EF8770 
	
			// Constructors
			private TimeHelper(); // 0x00000001803F46D0-0x00000001803F46E0
		}
	
		private class MPmBDkxdnNggWgQnkGyTossZItbb // TypeDefIndex: 6872
		{
			// Fields
			private StopwatchBase GcGMIVuBupFgRPpaUfXCcWsCyhK; // 0x10
			private float NyfpdpWceDuDtKKcqIcqrFZaZDk; // 0x18
			private NIMpESYenqcobEuRNuJIVWgBWKG hclpymcDtGBEMxZtqcadqiSrnKW; // 0x20
			private ADictionary<int, NIMpESYenqcobEuRNuJIVWgBWKG> EPsaxebuJgDuzXDToniUIUhlSrCu; // 0x28
			private uint tGJKVwrcRdmchlBMOqvPldsSKLg; // 0x30
	
			// Properties
			public float mvVqIzXhXGYlUhKStsZFaHkcgtP { get; } // 0x0000000180EE8F90-0x0000000180EE8FB0 
			public float EVVDxzguWHQDvWvgDUhVHBmQPkLi { get; } // 0x0000000180EE8F70-0x0000000180EE8F90 
			public float FfCgIRKtWTmYBEcpkONhoXkhUlk { get; } // 0x0000000180EE8F50-0x0000000180EE8F70 
			public float ljlgJtHKJJMJBJdDcshinawGVsGK { get; } // 0x0000000180EE8F30-0x0000000180EE8F50 
			public float BDYwGXKPNXUpWCSHttDxCVFljrv { get; } // 0x0000000180EE8F10-0x0000000180EE8F30 
			public float XgHDcEjUvQpuRrECxetxmajRXulN { get; } // 0x0000000180EE8ED0-0x0000000180EE8F10 
			public uint eupkLNYHupbKxOgCHbqidLtXZAwi { get; } // 0x0000000180EE8EB0-0x0000000180EE8ED0 
			public uint CHOCNYDOKokOAieAfEYuhwIXqJOv { get; } // 0x0000000180EE8E90-0x0000000180EE8EB0 
			public uint gjDADGoAsnfIVCcCovIDYiFadpH { get; } // 0x00000001804AA650-0x00000001804AA660 
	
			// Nested types
			private class NIMpESYenqcobEuRNuJIVWgBWKG // TypeDefIndex: 6873
			{
				// Fields
				public readonly UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk; // 0x10
				private float iAvcJHXqbXGaZCjAQGWtPtloWXJ; // 0x14
				private float sizJIDsizjlWdnyZAPJDftNRnEY; // 0x18
				private float ZAmYVwvwouIZAGAQVYIoEQUhPhN; // 0x1C
				private float ocKWBHJTwlBpUApjjfEVBkOXzGu; // 0x20
				private uint sSfduAgFrdpJfGpZpatYjOZzLinV; // 0x24
				private uint bSGBvpLPSOoGlRIKIDPbQVGHshS; // 0x28
				private float KtDAqaSmMRlfYHXKDsduAtBuAdl; // 0x2C
				private float hqvabEHfItRYQIWkHBAgxLvFmJP; // 0x30
	
				// Properties
				public float mvVqIzXhXGYlUhKStsZFaHkcgtP { get; } // 0x000000018094A320-0x000000018094A330 
				public float EVVDxzguWHQDvWvgDUhVHBmQPkLi { get; } // 0x000000018049DFC0-0x000000018049DFD0 
				public float FfCgIRKtWTmYBEcpkONhoXkhUlk { get; } // 0x0000000180918C20-0x0000000180918C30 
				public uint eupkLNYHupbKxOgCHbqidLtXZAwi { get; } // 0x0000000180491DB0-0x0000000180491DC0 
				public uint CHOCNYDOKokOAieAfEYuhwIXqJOv { get; } // 0x000000018043C680-0x000000018043C690 
				public float ljlgJtHKJJMJBJdDcshinawGVsGK { get; } // 0x00000001807DDA30-0x00000001807DDA40 
				public float BDYwGXKPNXUpWCSHttDxCVFljrv { get; } // 0x00000001806757B0-0x00000001806757C0 
	
				// Constructors
				public NIMpESYenqcobEuRNuJIVWgBWKG(UpdateLoopType updateLoop); // 0x0000000180EF2180-0x0000000180EF21C0
	
				// Methods
				public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x0000000180EF1FC0-0x0000000180EF2180
			}
	
			private static class GFEsypbXOzjblWUKhucUcNKZvaR // TypeDefIndex: 6874
			{
				// Properties
				public static StopwatchBase OMmnejZDVQLniULQgbPlHRIjfE { get; } // 0x0000000180EE7D40-0x0000000180EE7E00 
	
				// Methods
				public static StopwatchBase AQMpZVIIXTyemnHtIDPtxhINdLN(); // 0x0000000180EE7C70-0x0000000180EE7D40
				public static StopwatchBase wyCjNuqsWjGtSUFEElHBnTNnQLS(); // 0x0000000180EE7E00-0x0000000180EE7EB0
			}
	
			// Constructors
			public MPmBDkxdnNggWgQnkGyTossZItbb(); // 0x0000000180EE8DC0-0x0000000180EE8E90
	
			// Methods
			public void KBPXdDXgvchYOmaFpDETYNhRqLD(); // 0x0000000180EE8880-0x0000000180EE88A0
			public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x0000000180EE8B70-0x0000000180EE8DC0
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000ea80); // 0x0000000180EE88A0-0x0000000180EE8B70
		}
	
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class UnityTouch : CodeHelper // TypeDefIndex: 6875
		{
			// Fields
			private static UnityTouch wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static UnityTouch Instance { get; } // 0x0000000180EF8EC0-0x0000000180EF8F30 
			public int touchCount { get; } // 0x0000000180DA9D80-0x0000000180DA9D90 
			public Touch[] touches { get; } // 0x0000000180EF8F50-0x0000000180EF8F60 
			public bool simulateMouseWithTouches { get; set; } // 0x0000000180EF8F40-0x0000000180EF8F50 0x0000000180EF8F70-0x0000000180EF8F80
			public bool multiTouchEnabled { get; set; } // 0x0000000180EF8F30-0x0000000180EF8F40 0x0000000180EF8F60-0x0000000180EF8F70
	
			// Constructors
			private UnityTouch(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			public Touch GetTouch(int index); // 0x0000000180DA9CD0-0x0000000180DA9D20
		}
	
		internal class ptveCNmVZXCKQBRQPTFtDMcYzpD // TypeDefIndex: 6876
		{
			// Fields
			public readonly ValueWatcher<bool> nktPOWSPXbiSRsHEeOsPxClsfxfE; // 0x10
			public readonly ValueWatcher<bool> tiHWDDxEFtzUpkEkyEBAHEDsPFDC; // 0x18
			public readonly ValueWatcher<bool> IFrejARSLImRLdwfdDPLhIdmQuy; // 0x20
			public readonly ValueWatcher<int> AlTSMUepmkgBJHJOfQTSTbRucSqf; // 0x28
			public readonly ValueWatcher<float> FfCgIRKtWTmYBEcpkONhoXkhUlk; // 0x30
			public readonly ValueWatcher<string> fSLTdUoIfrkiHYrkbcmyCkpbUSx; // 0x38
			public readonly ValueWatcher<bool> PwbdpHSvkrTxwLXydCkIUcGWEdKa; // 0x40
			private int oNPggxRFfiaamrjlYkrLxncjhQm; // 0x48
			private readonly ValueWatcher[] rfxSyrIDszvdfUkQJgnQfICmGaOH; // 0x50
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<bool> mhIoohQKHLtRvnOkGOyhEaVZzEI; // 0x00
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<bool> xLsnLVMSdomUJlraUjoaaJurhHn; // 0x08
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<int> LqpbqWhYLnPlrmeWYhUGvnoFNkYM; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<float> KSctgEtbfpMomXNHtoTyKVtwYdL; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<bool> nnpRHVINhHOVQHcgAExuBWHPHnOo; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<string> zxFEUXSbZKUDkCYPKPrDQPuLYa; // 0x28
	
			// Properties
			public int FQTGxzXqRPJAshSJnXqTZxHMxHI { get; } // 0x0000000180379ED0-0x0000000180379EE0 
	
			// Constructors
			public ptveCNmVZXCKQBRQPTFtDMcYzpD(); // 0x0000000180F01A00-0x0000000180F02070
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x0000000180F01840-0x0000000180F01910
			public void NoDuTeAvSQJdmCqMOdLbwQahaKY(); // 0x0000000180F01910-0x0000000180F019F0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static bool PoAQZUDaExIpnInliWEtfKfdTHa(); // 0x0000000180F019F0-0x0000000180F01A00
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static bool JmTKlkertXqrKlYerpRBRaythRj(); // 0x0000000180F01820-0x0000000180F01830
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int KEgqyXXRmHNFhEKlnChuTefKlow(); // 0x0000000180F01830-0x0000000180F01840
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static float HzfFxSBABnlOZCrpvMtPGvPHUzfW(); // 0x0000000180F01810-0x0000000180F01820
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static bool psSvwMhRMUVndaclooBCVmmUEhN(); // 0x0000000180F02070-0x0000000180F02090
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string vgAUbxLblEVuBCHukgGuKwPkixt(); // 0x0000000180F02090-0x0000000180F02100
		}
	
		// Constructors
		static ReInput(); // 0x0000000180B3AF60-0x0000000180B3B840
	
		// Methods
		public static void Reset(); // 0x0000000180B3A440-0x0000000180B3A580
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool IsInputAllowed(ControllerType controllerType); // 0x0000000180B38560-0x0000000180B38730
		internal static void ItdhavHGXcUkAhyjaCFbIXENJheh(InputManager_Base param_0000e7b2, Func<ConfigVars, object> param_0000e7b3, ConfigVars param_0000e7b4, ControllerDataFiles param_0000e7b5, UserData param_0000e7b6); // 0x0000000180B38730-0x0000000180B39940
		internal static void JHzUZUsFQTvSmWjmIewXSnYsiSq(); // 0x0000000180B39A20-0x0000000180B39D80
		internal static void czYodqxgdcIwdElMkyegUEfPyfS(UpdateLoopType param_0000e7b7); // 0x0000000180B3C860-0x0000000180B3C950
		private static void WtfzmRcJkpzskEdOCFPheCSULzaC(UpdateLoopType param_0000e7b8); // 0x0000000180B3A860-0x0000000180B3AA50
		private static void aLjDyaCCxjAPHdAQcpOppSlVkLmE(); // 0x0000000180B3B840-0x0000000180B3B9A0
		internal static void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000e7b9); // 0x0000000180B39E40-0x0000000180B3A3E0
		internal static void YXPwgQXmKLEoGBmBdjMvbzFLpnmw(); // 0x0000000180B3AA50-0x0000000180B3AB30
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static void EditorUpdate(); // 0x0000000180B37BC0-0x0000000180B37E20
		internal static void cozuwinUKQpqyFkBMspLZBpsgZx(); // 0x0000000180B3C610-0x0000000180B3C820
		internal static void CihfeCOLgmPrJRnRPoaeejEWizEf(); // 0x0000000180B37980-0x0000000180B37A20
		internal static void ARSkBchNZoCnEalDDuBpuIFdqwp(bool param_0000e7ba); // 0x0000000180B373A0-0x0000000180B37540
		internal static void ClVLoPPfUviCWYBLLDoDisJmYPc(); // 0x0000000180B37A20-0x0000000180B37B00
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController); // 0x0000000180B37EA0-0x0000000180B37F20
		internal static HardwareJoystickMap GcBIiOdyTQzggNpeAanbphqNHTo(Guid param_0000e7bc); // 0x0000000180B37E20-0x0000000180B37EA0
		internal static HardwareJoystickTemplateMap CgDjzNHGwPDmghWwPZmlMDMkyXF(Guid param_0000e7bd); // 0x0000000180B37700-0x0000000180B37780
		internal static IHardwareControllerTemplateMap vJYIYfBwdUOpGFkPnpFNkRYssPG(Guid param_0000e7be); // 0x0000000180B413D0-0x0000000180B41450
		internal static IList<HardwareJoystickTemplateMap> wjdeIRdNjPOyAgaohSPOaXpVswuY(Guid param_0000e7bf); // 0x0000000180B41520-0x0000000180B418C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static int GetNewJoystickId(); // 0x0000000180B37F20-0x0000000180B37F90
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static void HandleCallbackException(string source, Exception exception); // 0x0000000180B380F0-0x0000000180B38300
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static void HandleExternException(string source, Exception exception); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static void HandleExternalInterfaceException(string source, Exception exception); // 0x0000000180B38300-0x0000000180B38500
		internal static void ZJiVzFiamhXWJiEaoqsHhYSmrpk(); // 0x0000000180B3AC40-0x0000000180B3ACC0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static void CheckRewiredVersionCompatibility(); // 0x0000000180B378A0-0x0000000180B37980
		internal static float gOwEjOBAnElHMdCPMXqWzFbEyII(); // 0x0000000180B3CA00-0x0000000180B3CA80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool CheckInitialized(); // 0x0000000180B37830-0x0000000180B378A0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool CheckInitialized(int reInputId); // 0x0000000180B37780-0x0000000180B37830
		private static void ACxMnYVUvcAyDDIzgwIKJklrBJr(); // 0x0000000180B36E30-0x0000000180B36F60
		private static void xbNIgpPTtLbPHTlmmHCRmhjXJri(); // 0x0000000180B41940-0x0000000180B422F0
		private static void jaWlNYsvYwfyhnyIPFoJHebdAdah(string param_0000e7c7 = null); // 0x0000000180B3F120-0x0000000180B3F1B0
		private static void GgEJvrkhnkpoSrnymeVJMKKKgDy(); // 0x0000000180B37F90-0x0000000180B38090
		private static void ctaxpqhtkFbLIhJlHhEeUanHRkf(); // 0x0000000180B3C820-0x0000000180B3C860
		private static void ZjLUjUuRFWofLJwnZpIlgLMrRXo(BridgedController param_0000e7c8); // 0x0000000180B3ACC0-0x0000000180B3AF60
		private static void idUTwhlvoGWmxtXkHdgaCohAfqt(ControllerDisconnectedEventArgs param_0000e7c9); // 0x0000000180B3EF10-0x0000000180B3F120
		private static void eQTXJZPHXrmQIErbgNHRGjesfXpg(ControllerStatusChangedEventArgs param_0000e7ca); // 0x0000000180B3C950-0x0000000180B3CA00
		private static void BvHwccPfrHUFcpcPIygMLRubGwt(ControllerStatusChangedEventArgs param_0000e7cb); // 0x0000000180B37620-0x0000000180B37700
		private static void IyiZLQpuMCDajwliXvGjQjSEwTv(ControllerStatusChangedEventArgs param_0000e7cc); // 0x0000000180B39940-0x0000000180B39A20
		private static void wpXzZTjUfZJCSxmuaZcKtEujgiW(UpdateControllerInfoEventArgs param_0000e7cd); // 0x0000000180B418C0-0x0000000180B41940
		private static void YXaERQllkGCuyBHgnojbfAfAhwpJ(bool param_0000e7ce); // 0x0000000180B3AB30-0x0000000180B3AC40
		private static void DPWTEFhSmOrDBmHhxCEvvIttcpy(bool param_0000e7cf); // 0x0000000180B37B00-0x0000000180B37BC0
		private static void RhaFTWKlzuDUhQOZTFjOktfeFrz(int param_0000e7d0); // 0x0000000180B3A580-0x0000000180B3A680
		private static void VeJROhQFjuOiuGnhGoIiTxAozOL(bool param_0000e7d1); // 0x0000000180B3A6E0-0x0000000180B3A7A0
		private static void vQSGogEDYoNdYcdUKBuyEXfgcaJm(bool param_0000e7d2); // 0x0000000180B41450-0x0000000180B41520
		private static void yBMPtlETbMyFNpxEJpKyiwylIHq(); // 0x0000000180B42600-0x0000000180B42950
		private static void xcSbHFyvsKOdbzkSRAioGmIwKzs(); // 0x0000000180B422F0-0x0000000180B42600
		private static void JZZDkvIKTiCvpsFsmhxPPMgCkMRC(bool param_0000e7d3); // 0x0000000180B39D80-0x0000000180B39E40
		private static void toDAwKEZKpnEZPCkeFNrIPAvDLcC(Func<ConfigVars, object> param_0000e7d4); // 0x0000000180B3FEE0-0x0000000180B413D0
		private static void BWjrCznwcgjVJTeRHmTNILudaZn(); // 0x0000000180B37540-0x0000000180B37620
		private static void AJdGwTsaQxxBMwQQMglszXwCgc(); // 0x0000000180B36FC0-0x0000000180B373A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void SHhkYQoZOcOvJaWepRTLupkJhxaf(Exception param_0000e7d5); // 0x0000000180B3A680-0x0000000180B3A6E0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void zyjcYRapgfnlEbfnXogwbFUcPyiy(Exception param_0000e7d6); // 0x0000000180B429D0-0x0000000180B42A30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void WMjiGVYNTwahDyfALkkAnsuilfh(Exception param_0000e7d7); // 0x0000000180B3A7A0-0x0000000180B3A800
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void lnjopNOBhuaRKiVQFMcqAgQPFJN(Exception param_0000e7d8); // 0x0000000180B3F1B0-0x0000000180B3F210
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void HBDhQkuzifPZriThEpKvTAUIOJs(Exception param_0000e7d9); // 0x0000000180B38090-0x0000000180B380F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void WfJqObvMclFMRCKCczMhnQXSand(Exception param_0000e7da); // 0x0000000180B3A800-0x0000000180B3A860
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void IKjuwUUlRDnScUiUdfOaCwquUts(Exception param_0000e7db); // 0x0000000180B38500-0x0000000180B38560
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void OoUyvPYFKXXtxclqQWxQnwNfNRS(Exception param_0000e7dc); // 0x0000000180B3A3E0-0x0000000180B3A440
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void ADiipXCZmdRaXOJTswlCTxGhonwD(Exception param_0000e7dd); // 0x0000000180B36F60-0x0000000180B36FC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool ysDyOMuGptHqmlSZXAOdikDwkxRC(); // 0x0000000180B42950-0x0000000180B429D0
	}
}
