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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public static class ReInput // TypeDefIndex: 6682
	{
		// Fields
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const int programVersion1 = 1; // Metadata: 0x007312AB
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const int programVersion2 = 1; // Metadata: 0x007312AF
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const int programVersion3 = 28; // Metadata: 0x007312B3
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const int programVersion4 = 0; // Metadata: 0x007312B7
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const int dataVersion = 1; // Metadata: 0x007312BB
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const bool isTrial = false; // Metadata: 0x007312BF
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal const string majorBranch = "U2019"; // Metadata: 0x007312C0
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float unscaledDeltaTime; // 0x180
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float unscaledTime; // 0x184
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float unscaledTimePrev; // 0x188
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static uint currentFrame; // 0x18C
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static uint previousFrame; // 0x190
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static uint absFrame; // 0x194
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg; // 0x198
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK; // 0x1A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x1A8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI; // 0x1B0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x1B8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb; // 0x1C0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> oGJrVKpLnrEZvcckdTDrxcRcoPE; // 0x1C8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc; // 0x1D0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> LMEVXjUqLtOuqZTxhWxWORZbBET; // 0x1D8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Func<bool> mFkzNHGAqcCSXMLnBgAxEdkqCHul; // 0x1E0
	
		// Properties
		private static tZlePwusXDDMirYvopCuiueCHfi unityInputBuffer { get; } // 0x00000001805168B0-0x0000000180516990 
		public static PlayerHelper players { get; } // 0x0000000180515EE0-0x0000000180515FB0 
		public static ControllerHelper controllers { get; } // 0x00000001805150B0-0x00000001805151B0 
		public static MappingHelper mapping { get; } // 0x0000000180515E10-0x0000000180515EE0 
		public static UnityTouch touch { get; } // 0x00000001805167B0-0x00000001805168B0 
		public static TimeHelper time { get; } // 0x00000001805166E0-0x00000001805167B0 
		public static IUserDataStore userDataStore { get; } // 0x0000000180516C70-0x0000000180516D40 
		public static ConfigHelper configuration { get; } // 0x0000000180514F50-0x0000000180515050 
		public static string programVersion { get; } // 0x00000001805160A0-0x0000000180516460 
		public static bool usingUnityInput { get; } // 0x0000000180516D40-0x0000000180516DA0 
		public static bool unityJoystickIdentificationRequired { get; } // 0x0000000180516990-0x0000000180516B90 
		public static bool isReady { get; } // 0x0000000180515B30-0x0000000180515B90 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static int id { get; } // 0x0000000180515460-0x00000001805154C0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool initialized { get; } // 0x00000001805154C0-0x0000000180515520 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static UpdateLoopType currentUpdateLoop { get; } // 0x00000001805152B0-0x0000000180515310 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static ConfigVars configVars { get; } // 0x0000000180514EF0-0x0000000180514F50 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static UserData UserData { get; } // 0x0000000180514940-0x00000001805149A0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static Rewired.Platforms.Platform currentPlatform { get; } // 0x00000001805151B0-0x0000000180515210 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static WebplayerPlatform webplayerPlatform { get; } // 0x0000000180516DA0-0x0000000180516E00 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static EditorPlatform editorPlatform { get; } // 0x0000000180515400-0x0000000180515460 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool checkNeverPressed { get; } // 0x0000000180514BB0-0x0000000180514EF0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isEditor { get; } // 0x0000000180515AD0-0x0000000180515B30 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static Guid defaultHardwareJoystickMapGuid { get; } // 0x0000000180515310-0x0000000180515400 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isRunningInEditMode { get; } // 0x0000000180515B90-0x0000000180515BF0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isEditorPaused { get; } // 0x0000000180515A60-0x0000000180515AD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float unityUnscaledDeltaTime { get; } // 0x0000000180516C00-0x0000000180516C70 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float unityUnscaledDeltaTimePrev { get; } // 0x0000000180516B90-0x0000000180516C00 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static float realTime { get; } // 0x0000000180516460-0x0000000180516500 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static int currentUnityFrame { get; } // 0x0000000180515210-0x00000001805152B0 
		private static bool isEditorGameViewFocused { get; } // 0x00000001805159A0-0x0000000180515A60 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isAllowedEditorWindowFocused { get; } // 0x0000000180515720-0x00000001805159A0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isUnityEditorFocused { get; } // 0x0000000180515BF0-0x0000000180515CA0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform { get; } // 0x0000000180515CA0-0x0000000180515E10 
		private static bool inputAllowed { get; } // 0x0000000180515520-0x0000000180515720 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool applicationIsFocused { get; } // 0x00000001805149A0-0x0000000180514A50 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool applicationIsFullScreen { get; } // 0x0000000180514A50-0x0000000180514B00 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool applicationRunInBackground { get; } // 0x0000000180514B00-0x0000000180514BB0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool timeScaleIsPaused { get; } // 0x00000001805165D0-0x0000000180516680 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static InputManager_Base rewiredInputManager { get; } // 0x0000000180516500-0x0000000180516560 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static PlatformInputManager primaryInputManager { get; } // 0x0000000180515FB0-0x00000001805160A0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static IControllerAssigner controllerAssigner { get; set; } // 0x0000000180515050-0x00000001805150B0 0x0000000180517D70-0x0000000180517DD0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static RewiredVersion rewiredVersion { get; } // 0x0000000180516560-0x00000001805165D0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static int timeScalePauseChangedCount { get; } // 0x0000000180516680-0x00000001805166E0 
	
		// Events
		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent {
			add; // 0x0000000180513BD0-0x0000000180513C60
			remove; // 0x0000000180517470-0x0000000180517500
		}
		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent {
			add; // 0x0000000180513CF0-0x0000000180513D80
			remove; // 0x0000000180517590-0x0000000180517620
		}
		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent {
			add; // 0x0000000180513C60-0x0000000180513CF0
			remove; // 0x0000000180517500-0x0000000180517590
		}
		public static event Action InputSourceUpdateEvent {
			add; // 0x0000000180513FE0-0x0000000180514060
			remove; // 0x0000000180517880-0x0000000180517900
		}
		public static event Action EditorRecompileEvent {
			add; // 0x0000000180513EE0-0x0000000180513F60
			remove; // 0x0000000180517780-0x0000000180517800
		}
		public static event Action PreShutDownEvent {
			add; // 0x0000000180514110-0x0000000180514190
			remove; // 0x00000001805179B0-0x0000000180517A30
		}
		public static event Action ShutDownEvent {
			add; // 0x0000000180514240-0x00000001805142C0
			remove; // 0x0000000180517AE0-0x0000000180517B60
		}
		public static event Action InitializedEvent {
			add; // 0x0000000180513F60-0x0000000180513FE0
			remove; // 0x0000000180517800-0x0000000180517880
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<bool> ApplicationFocusChangedEvent {
			add; // 0x0000000180513860-0x0000000180513910
			remove; // 0x0000000180517100-0x00000001805171B0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action EarlyUpdateEvent {
			add; // 0x0000000180513D80-0x0000000180513E30
			remove; // 0x0000000180517620-0x00000001805176D0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent {
			add; // 0x0000000180513B20-0x0000000180513BD0
			remove; // 0x00000001805173C0-0x0000000180517470
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<UpdateLoopType> UpdateStartedEvent {
			add; // 0x0000000180514420-0x00000001805144D0
			remove; // 0x0000000180517CC0-0x0000000180517D70
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<UpdateLoopType> UpdateEndedEvent {
			add; // 0x0000000180514370-0x0000000180514420
			remove; // 0x0000000180517C10-0x0000000180517CC0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action LateUpdateEvent {
			add; // 0x0000000180514060-0x0000000180514110
			remove; // 0x0000000180517900-0x00000001805179B0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<bool> ApplicationIsFullScreenChangedEvent {
			add; // 0x00000001805139C0-0x0000000180513A70
			remove; // 0x0000000180517260-0x0000000180517310
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<bool> ApplicationRunInBackgroundChangedEvent {
			add; // 0x0000000180513A70-0x0000000180513B20
			remove; // 0x0000000180517310-0x00000001805173C0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<bool> TimeScalePauseChangedEvent {
			add; // 0x00000001805142C0-0x0000000180514370
			remove; // 0x0000000180517B60-0x0000000180517C10
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<FullScreenMode> ApplicationFullScreenModeChangedEvent {
			add; // 0x0000000180513910-0x00000001805139C0
			remove; // 0x00000001805171B0-0x0000000180517260
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action SceneLoadedEvent {
			add; // 0x0000000180514190-0x0000000180514240
			remove; // 0x0000000180517A30-0x0000000180517AE0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static event Action<bool> EditorPauseChangedEvent {
			add; // 0x0000000180513E30-0x0000000180513EE0
			remove; // 0x00000001805176D0-0x0000000180517780
		}
	
		// Nested types
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class ConfigHelper : CodeHelper // TypeDefIndex: 6683
		{
			// Fields
			private static ConfigHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static ConfigHelper Instance { get; } // 0x00000001804F8920-0x00000001804F8990 
			public bool useXInput { get; set; } // 0x00000001804F9A10-0x00000001804F9CB0 0x00000001804FC370-0x00000001804FC860
			public UpdateLoopSetting updateLoop { get; set; } // 0x00000001804F9960-0x00000001804F9A10 0x00000001804FC130-0x00000001804FC370
			public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource { get; set; } // 0x00000001804F9D60-0x00000001804F9E10 0x00000001804FCAB0-0x00000001804FCD70
			public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource { get; set; } // 0x00000001804F96A0-0x00000001804F9750 0x00000001804FBB00-0x00000001804FBCF0
			public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource { get; set; } // 0x00000001804F9330-0x00000001804F93E0 0x00000001804FB2D0-0x00000001804FB510
			public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource { get; set; } // 0x00000001804F9E10-0x00000001804F9EC0 0x00000001804FCD70-0x00000001804FCF60
			public bool windowsUWPSupportHIDDevices { get; set; } // 0x00000001804F9EC0-0x00000001804F9FD0 0x00000001804FCF60-0x00000001804FD190
			public XboxOnePrimaryInputSource xboxOnePrimaryInputSource { get; set; } // 0x00000001804F9FD0-0x00000001804FA080 0x00000001804FD190-0x00000001804FD370
			public PS4PrimaryInputSource ps4PrimaryInputSource { get; set; } // 0x00000001804F9750-0x00000001804F9800 0x00000001804FBCF0-0x00000001804FBED0
			public WebGLPrimaryInputSource webGLPrimaryInputSource { get; set; } // 0x00000001804F9CB0-0x00000001804F9D60 0x00000001804FC860-0x00000001804FCAB0
			public bool alwaysUseUnityInput { get; set; } // 0x00000001804F8A40-0x00000001804F8AF0 0x00000001804FA180-0x00000001804FA3A0
			public bool disableNativeInput { get; set; } // 0x00000001804F8A40-0x00000001804F8AF0 0x00000001804FAC10-0x00000001804FAC20
			public bool nativeMouseSupport { get; set; } // 0x00000001804F95F0-0x00000001804F96A0 0x00000001804FB950-0x00000001804FBB00
			public bool nativeKeyboardSupport { get; set; } // 0x00000001804F9540-0x00000001804F95F0 0x00000001804FB7A0-0x00000001804FB950
			public bool enhancedDeviceSupport { get; set; } // 0x00000001804F9070-0x00000001804F9120 0x00000001804FAD50-0x00000001804FAF10
			public int joystickRefreshRate { get; set; } // 0x00000001804F9280-0x00000001804F9330 0x00000001804FB1B0-0x00000001804FB2D0
			public bool ignoreInputWhenAppNotInFocus { get; set; } // 0x00000001804F91D0-0x00000001804F9280 0x00000001804FB050-0x00000001804FB1B0
			public bool android_supportUnknownGamepads { get; set; } // 0x00000001804F8AF0-0x00000001804F8BA0 0x00000001804FA3A0-0x00000001804FA590
			public DeadZone2DType defaultJoystickAxis2DDeadZoneType { get; set; } // 0x00000001804F8DB0-0x00000001804F8E60 0x00000001804FA8E0-0x00000001804FAA10
			public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType { get; set; } // 0x00000001804F8E60-0x00000001804F8F10 0x00000001804FAA10-0x00000001804FAB10
			public AxisSensitivityType defaultAxisSensitivityType { get; set; } // 0x00000001804F8D00-0x00000001804F8DB0 0x00000001804FA7A0-0x00000001804FA8E0
			public bool force4WayHats { get; set; } // 0x00000001804F9120-0x00000001804F91D0 0x00000001804FAF10-0x00000001804FB050
			public bool activateActionButtonsOnNegativeValue { get; set; } // 0x00000001804F8990-0x00000001804F8A40 0x00000001804FA080-0x00000001804FA180
			public ThrottleCalibrationMode throttleCalibrationMode { get; set; } // 0x00000001804F98B0-0x00000001804F9960 0x00000001804FBFD0-0x00000001804FC130
			public bool deferControllerConnectedEventsOnStart { get; set; } // 0x00000001804F8F10-0x00000001804F8FC0 0x00000001804FAB10-0x00000001804FAC10
			public bool autoAssignJoysticks { get; set; } // 0x00000001804F8C50-0x00000001804F8D00 0x00000001804FA6A0-0x00000001804FA7A0
			public int maxJoysticksPerPlayer { get; set; } // 0x00000001804F9490-0x00000001804F9540 0x00000001804FB650-0x00000001804FB7A0
			public bool distributeJoysticksEvenly { get; set; } // 0x00000001804F8FC0-0x00000001804F9070 0x00000001804FAC20-0x00000001804FAD50
			public bool assignJoysticksToPlayingPlayersOnly { get; set; } // 0x00000001804F8BA0-0x00000001804F8C50 0x00000001804FA590-0x00000001804FA6A0
			public bool reassignJoystickToPreviousOwnerOnReconnect { get; set; } // 0x00000001804F9800-0x00000001804F98B0 0x00000001804FBED0-0x00000001804FBFD0
			public LogLevelFlags logLevel { get; set; } // 0x00000001804F93E0-0x00000001804F9490 0x00000001804FB510-0x00000001804FB650
	
			// Constructors
			private ConfigHelper(); // 0x000000018037E800-0x000000018037E810
		}
	
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class ControllerHelper : CodeHelper // TypeDefIndex: 6684
		{
			// Fields
			private static ControllerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
			public readonly PollingHelper polling; // 0x10
			public readonly ConflictCheckingHelper conflictChecking; // 0x18
	
			// Properties
			internal static ControllerHelper Instance { get; } // 0x0000000180508480-0x0000000180508560 
			public int controllerCount { get; } // 0x0000000180508750-0x00000001805087F0 
			public IList<Controller> Controllers { get; } // 0x0000000180508320-0x00000001805083D0 
			public Mouse Mouse { get; } // 0x00000001805086B0-0x0000000180508750 
			public Keyboard Keyboard { get; } // 0x0000000180508610-0x00000001805086B0 
			[Obsolete] // 0x0000000180106E60-0x0000000180106E90
			public bool keyboardEnabled { get; set; } // 0x0000000180508930-0x00000001805089B0 0x00000001805089B0-0x0000000180508B30
			public int joystickCount { get; } // 0x0000000180508890-0x0000000180508930 
			public IList<Joystick> Joysticks { get; } // 0x0000000180508560-0x0000000180508610 
			public int customControllerCount { get; } // 0x00000001805087F0-0x0000000180508890 
			public IList<CustomController> CustomControllers { get; } // 0x00000001805083D0-0x0000000180508480 
	
			// Nested types
			[Browsable] // 0x00000001800D5150-0x00000001800D5190
			[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 6685
			{
				// Fields
				private static PollingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
				// Properties
				internal static PollingHelper Instance { get; } // 0x0000000180657400-0x0000000180657470 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class YBvNVzmKvmAGZDUUUdluAtbPIcR : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6686
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065A680-0x000000018065A6F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public YBvNVzmKvmAGZDUUUdluAtbPIcR(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065A4F0-0x000000018065A630
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065A4F0-0x000000018065A630
					private bool MoveNext(); // 0x0000000180659DE0-0x000000018065A4F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065A630-0x000000018065A680
					void IDisposable.Dispose(); // 0x000000018065A6F0-0x000000018065A920
					private void xcAVusbXlUDusmCdbvVNsTYvMHV(); // 0x000000018065AA10-0x000000018065AA60
					private void CTKvuRyfNrGDqADDcjYPtneKpvD(); // 0x0000000180659C90-0x0000000180659CE0
					private void MWiHpoXIdJXsGxpGiKFwWBQTFDI(); // 0x0000000180659CE0-0x0000000180659DE0
					private void qcHCBHNxIuILBVLsQbguTakmKeA(); // 0x000000018065A920-0x000000018065AA10
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class clGswvEugVdyOXIvPfpdNWrovDx : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6687
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065D030-0x000000018065D0A0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public clGswvEugVdyOXIvPfpdNWrovDx(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065CEB0-0x000000018065CFE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065CEB0-0x000000018065CFE0
					private bool MoveNext(); // 0x000000018065C280-0x000000018065CEB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065CFE0-0x000000018065D030
					void IDisposable.Dispose(); // 0x000000018065D0A0-0x000000018065D260
					private void jcEIcthBJsjSMVZVjlgGNCAnzWM(); // 0x000000018065D590-0x000000018065D6C0
					private void glJLgprOseifKJIWboOdAUcyPzw(); // 0x000000018065D4A0-0x000000018065D590
					private void dtbOvYPynYurhkKfWvWVrRXZTfI(); // 0x000000018065D380-0x000000018065D4A0
					private void ZEIcKoIKIgVtaQCVPHvtOQlxcdu(); // 0x000000018065D260-0x000000018065D380
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class jdUzyaeuSjRATfBzsdcgkgsnfUKz : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6688
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806611B0-0x0000000180661220 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public jdUzyaeuSjRATfBzsdcgkgsnfUKz(int <>1__state); // 0x0000000180661490-0x0000000180661500
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180661050-0x0000000180661160
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180661050-0x0000000180661160
					private bool MoveNext(); // 0x0000000180660930-0x0000000180661000
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180661160-0x00000001806611B0
					void IDisposable.Dispose(); // 0x0000000180661220-0x0000000180661490
					private void RtDWPvdRDkVwZrYKbiVubzAGyMi(); // 0x0000000180661000-0x0000000180661050
					private void EuqoCsxJgbyLTLQWQWXqAlploEj(); // 0x0000000180660810-0x0000000180660930
					private void ABMyiPKeMqGqXIllpGvshnvqBZlT(); // 0x0000000180660720-0x0000000180660810
					private void xfYseRgskGwCGumdDZbIcrZKBcL(); // 0x0000000180661500-0x0000000180661550
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class soszkmCgISDFJChNpYGyUVmbUFa : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6689
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806635C0-0x0000000180663630 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public soszkmCgISDFJChNpYGyUVmbUFa(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180663480-0x0000000180663570
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180663480-0x0000000180663570
					private bool MoveNext(); // 0x0000000180662770-0x0000000180663360
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180663570-0x00000001806635C0
					void IDisposable.Dispose(); // 0x0000000180663630-0x0000000180663860
					private void XrTNlrZKkzbeghzEFzyyKgnduvTc(); // 0x0000000180663860-0x00000001806638B0
					private void NhNoMKZGnYhnyhujRMnRFTfrqJvB(); // 0x0000000180663360-0x0000000180663480
					private void qouiGGrfkPSMgpTOAJiRgbRZGLj(); // 0x00000001806638B0-0x0000000180663900
					private void JjOFXsGbvLkmSSrWFYVkQsjwvAl(); // 0x0000000180662650-0x0000000180662770
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ZfUtVJTOmhcoSZZlRIRuFmYbNRp : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6690
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065B790-0x000000018065B800 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ZfUtVJTOmhcoSZZlRIRuFmYbNRp(int <>1__state); // 0x000000018065B990-0x000000018065BA00
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065B610-0x000000018065B740
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065B610-0x000000018065B740
					private bool MoveNext(); // 0x000000018065B050-0x000000018065B610
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065B740-0x000000018065B790
					void IDisposable.Dispose(); // 0x000000018065B800-0x000000018065B990
					private void uVeNaeqOpXRVTXSaCxnCXMTefyS(); // 0x000000018065BB70-0x000000018065BC90
					private void kvnimodFsmAzSDbYHVGVuVLUTcl(); // 0x000000018065BA50-0x000000018065BB70
					private void aOozVxRKFKIVhjtboisRxdjRQrj(); // 0x000000018065BA00-0x000000018065BA50
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class bgXjYvqqakiXDUkhbeKAebzKPEQc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6691
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065C110-0x000000018065C180 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public bgXjYvqqakiXDUkhbeKAebzKPEQc(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065BFC0-0x000000018065C0C0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065BFC0-0x000000018065C0C0
					private bool MoveNext(); // 0x000000018065BC90-0x000000018065BFC0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065C0C0-0x000000018065C110
					void IDisposable.Dispose(); // 0x000000018065C180-0x000000018065C230
					private void zzYHBLePDvCeNCLsmAfliTkxCwS(); // 0x000000018065C230-0x000000018065C280
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class pmJjyzYbblIPEbZmpykFuUNHxuNE : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6692
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180661BD0-0x0000000180661C40 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public pmJjyzYbblIPEbZmpykFuUNHxuNE(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180661A90-0x0000000180661B80
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180661A90-0x0000000180661B80
					private bool MoveNext(); // 0x0000000180661550-0x0000000180661A90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180661B80-0x0000000180661BD0
					void IDisposable.Dispose(); // 0x0000000180661C40-0x0000000180661CF0
					private void dndDICppvIXFaOjYHiHsRpVXZFO(); // 0x0000000180661CF0-0x0000000180661D40
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class feVMVkzXgdxbLQhQnHgiNmxsuxP : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6693
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065F120-0x000000018065F190 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public feVMVkzXgdxbLQhQnHgiNmxsuxP(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065EFB0-0x000000018065F0D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065EFB0-0x000000018065F0D0
					private bool MoveNext(); // 0x000000018065EA60-0x000000018065EFB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065F0D0-0x000000018065F120
					void IDisposable.Dispose(); // 0x000000018065F190-0x000000018065F240
					private void whtZcuvsrbilFSJsuqkwtIKMLEV(); // 0x000000018065F240-0x000000018065F290
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class gEmyRrkltNUUUGpMAFWCHapMQlCM : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6694
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065F770-0x000000018065F7E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public gEmyRrkltNUUUGpMAFWCHapMQlCM(int <>1__state); // 0x000000018065F890-0x000000018065F900
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065F5F0-0x000000018065F720
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065F5F0-0x000000018065F720
					private bool MoveNext(); // 0x000000018065F290-0x000000018065F5A0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065F720-0x000000018065F770
					void IDisposable.Dispose(); // 0x000000018065F7E0-0x000000018065F890
					private void RzKKwzuehSPRVDkjOnbesdzQOGk(); // 0x000000018065F5A0-0x000000018065F5F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class CSuZeoWpOZvfMcVhlnGGKMADQUw : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6695
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647470-0x00000001806474E0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public CSuZeoWpOZvfMcVhlnGGKMADQUw(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180647330-0x0000000180647420
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180647330-0x0000000180647420
					private bool MoveNext(); // 0x0000000180647010-0x0000000180647330
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180647420-0x0000000180647470
					void IDisposable.Dispose(); // 0x00000001806474E0-0x0000000180647550
					private void rEKFFmlglcIRsICsUpCYURVyisL(); // 0x0000000180647550-0x0000000180647670
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class RmiDKpUOeEUEAmvgnhIxSJnYhri : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6696
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806588B0-0x0000000180658920 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public RmiDKpUOeEUEAmvgnhIxSJnYhri(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180658760-0x0000000180658860
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180658760-0x0000000180658860
					private bool MoveNext(); // 0x00000001806583E0-0x0000000180658760
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180658860-0x00000001806588B0
					void IDisposable.Dispose(); // 0x0000000180658920-0x0000000180658990
					private void BgmNXymAWDyexfsliSdIjIOXGDU(); // 0x00000001806582C0-0x00000001806583E0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class UZzVPGJjSaaXWbrGqAhpBYkVXDIC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6697
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806590F0-0x0000000180659160 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public UZzVPGJjSaaXWbrGqAhpBYkVXDIC(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180658F80-0x00000001806590A0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180658F80-0x00000001806590A0
					private bool MoveNext(); // 0x0000000180658C60-0x0000000180658F80
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001806590A0-0x00000001806590F0
					void IDisposable.Dispose(); // 0x0000000180659160-0x0000000180659210
					private void BcOzBDpAlqoazmiSMgLqzSuBoHg(); // 0x0000000180658C10-0x0000000180658C60
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class twSmFirlKKhETHgPwZJPjpaQrlKM : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6698
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806646D0-0x0000000180664740 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public twSmFirlKKhETHgPwZJPjpaQrlKM(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180664570-0x0000000180664680
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180664570-0x0000000180664680
					private bool MoveNext(); // 0x0000000180664260-0x0000000180664570
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180664680-0x00000001806646D0
					void IDisposable.Dispose(); // 0x0000000180664740-0x00000001806647B0
					private void gUVgUNzFmaksPiNSaTTLOZWacEU(); // 0x00000001806647B0-0x00000001806648D0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class hbgPcoVcACaGVcSetcWaNQJvwrcH : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6699
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001806605C0-0x0000000180660630 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public hbgPcoVcACaGVcSetcWaNQJvwrcH(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180660430-0x0000000180660570
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180660430-0x0000000180660570
					private bool MoveNext(); // 0x0000000180660140-0x0000000180660430
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180660570-0x00000001806605C0
					void IDisposable.Dispose(); // 0x0000000180660630-0x0000000180660720
					private void IXDhgXHLNsdHNIsnpxszsGOWDtp(); // 0x00000001806600F0-0x0000000180660140
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ZTjoOlHofdHJicziNMgErvsNzJl : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6700
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
					ControllerPollingInfo ZwivzDVzjeLFbxUrbSAFCRmusqX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065AEE0-0x000000018065AF50 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ZTjoOlHofdHJicziNMgErvsNzJl(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018065AD70-0x000000018065AE90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065AD70-0x000000018065AE90
					private bool MoveNext(); // 0x000000018065AA60-0x000000018065AD70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065AE90-0x000000018065AEE0
					void IDisposable.Dispose(); // 0x000000018065AF50-0x000000018065B000
					private void WCSRaCEWzrLzjXEPiGyAwEjZbFB(); // 0x000000018065B000-0x000000018065B050
				}
	
				// Constructors
				private PollingHelper(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public ControllerPollingInfo PollAllControllersForFirstElement(); // 0x0000000180654200-0x0000000180654400
				public ControllerPollingInfo PollAllControllersForFirstElementDown(); // 0x00000001806540A0-0x0000000180654200
				public ControllerPollingInfo PollAllControllersForFirstButton(); // 0x0000000180653ED0-0x00000001806540A0
				public ControllerPollingInfo PollAllControllersForFirstButtonDown(); // 0x0000000180653CF0-0x0000000180653ED0
				public ControllerPollingInfo PollAllControllersForFirstAxis(); // 0x0000000180653B60-0x0000000180653CF0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType); // 0x0000000180654A30-0x0000000180654BD0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(ControllerType controllerType); // 0x0000000180654890-0x0000000180654A30
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType); // 0x00000001806546F0-0x0000000180654890
				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType); // 0x0000000180654550-0x00000001806546F0
				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType); // 0x0000000180654400-0x0000000180654550
				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId); // 0x00000001806560B0-0x0000000180656360
				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId); // 0x0000000180655E10-0x00000001806560B0
				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId); // 0x0000000180655BC0-0x0000000180655E10
				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId); // 0x0000000180655930-0x0000000180655BC0
				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId); // 0x00000001806556E0-0x0000000180655930
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements(); // 0x0000000180653AE0-0x0000000180653B60
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown(); // 0x0000000180653A60-0x0000000180653AE0
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons(); // 0x00000001806539B0-0x0000000180653A60
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown(); // 0x0000000180653930-0x00000001806539B0
				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes(); // 0x0000000180653880-0x0000000180653930
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId); // 0x00000001806554B0-0x00000001806556E0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId); // 0x0000000180655260-0x00000001806554B0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId); // 0x0000000180655030-0x0000000180655260
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId); // 0x0000000180654E00-0x0000000180655030
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId); // 0x0000000180654BD0-0x0000000180654E00
				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY(); // 0x0000000180656E80-0x00000001806571D0
				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE(); // 0x00000001806571D0-0x0000000180657400
				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn(); // 0x0000000180656BA0-0x0000000180656D80
				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf(); // 0x0000000180653700-0x0000000180653880
				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq(); // 0x00000001806565A0-0x0000000180656800
				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int param_0000e5e9); // 0x0000000180656D80-0x0000000180656E10
				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int param_0000e5ea); // 0x0000000180657D40-0x0000000180657DF0
				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int param_0000e5eb); // 0x0000000180653480-0x0000000180653510
				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int param_0000e5ec); // 0x0000000180653510-0x00000001806535A0
				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int param_0000e5ed); // 0x0000000180657770-0x00000001806577F0
				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo(); // 0x0000000180653110-0x0000000180653180
				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA(); // 0x0000000180656E10-0x0000000180656E80
				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi(); // 0x00000001806576F0-0x0000000180657770
				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk(); // 0x0000000180657CC0-0x0000000180657D40
				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh(); // 0x00000001806574C0-0x0000000180657540
				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO(); // 0x0000000180656360-0x00000001806563E0
				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp(); // 0x0000000180657DF0-0x0000000180657E60
				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB(); // 0x00000001806577F0-0x00000001806579D0
				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC(); // 0x0000000180652E60-0x0000000180653010
				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI(); // 0x0000000180657A90-0x0000000180657CC0
				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL(); // 0x0000000180656800-0x00000001806569B0
				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx(); // 0x0000000180657E60-0x0000000180657FE0
				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int param_0000e5ee); // 0x0000000180658090-0x0000000180658120
				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int param_0000e5ef); // 0x0000000180656470-0x0000000180656520
				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int param_0000e5f0); // 0x0000000180653210-0x00000001806532A0
				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int param_0000e5f1); // 0x0000000180653180-0x0000000180653210
				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int param_0000e5f2); // 0x0000000180657640-0x00000001806576F0
				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC(); // 0x0000000180652D50-0x0000000180652DD0
				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi(); // 0x0000000180657540-0x00000001806575C0
				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn(); // 0x0000000180653010-0x0000000180653090
				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq(); // 0x0000000180657FE0-0x0000000180658090
				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk(); // 0x0000000180653090-0x0000000180653110
				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int param_0000e5f3); // 0x0000000180656B10-0x0000000180656BA0
				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int param_0000e5f4); // 0x00000001806563E0-0x0000000180656470
				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int param_0000e5f5); // 0x0000000180658230-0x00000001806582C0
				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int param_0000e5f6); // 0x00000001806533F0-0x0000000180653480
				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int param_0000e5f7); // 0x00000001806535A0-0x0000000180653620
				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX(); // 0x00000001806579D0-0x0000000180657A10
				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI(); // 0x00000001806533B0-0x00000001806533F0
				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp(); // 0x00000001806532E0-0x0000000180653330
				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj(); // 0x0000000180656AC0-0x0000000180656B10
				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC(); // 0x0000000180657470-0x00000001806574C0
				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS(); // 0x00000001806536B0-0x0000000180653700
				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb(); // 0x00000001806532A0-0x00000001806532E0
				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii(); // 0x0000000180657A10-0x0000000180657A90
				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ(); // 0x00000001806569B0-0x0000000180656A30
				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf(); // 0x0000000180653330-0x00000001806533B0
				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo(); // 0x00000001806581B0-0x0000000180658230
				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH(); // 0x00000001806575C0-0x0000000180657640
				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int param_0000e5f8); // 0x0000000180658120-0x00000001806581B0
				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int param_0000e5f9); // 0x0000000180652DD0-0x0000000180652E60
				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int param_0000e5fa); // 0x0000000180656A30-0x0000000180656AC0
				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int param_0000e5fb); // 0x0000000180653620-0x00000001806536B0
				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int param_0000e5fc); // 0x0000000180656520-0x00000001806565A0
			}
	
			[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
			[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 6701
			{
				// Fields
				private static ConflictCheckingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
				// Properties
				internal static ConflictCheckingHelper Instance { get; } // 0x0000000180502B90-0x0000000180502C00 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class eQSqakoijAgcRcxbjSpZPpyogjDe : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6702
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065DF20-0x000000018065DF80 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public eQSqakoijAgcRcxbjSpZPpyogjDe(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x000000018065DD30-0x000000018065DED0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065DD30-0x000000018065DED0
					private bool MoveNext(); // 0x000000018065D710-0x000000018065DD30
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065DED0-0x000000018065DF20
					void IDisposable.Dispose(); // 0x000000018065DF80-0x000000018065E030
					private void DWYcgIgATSXzXIBhRgXjqjjtQTAo(); // 0x000000018065D6C0-0x000000018065D710
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class DsUXpicJWUrxlzCiIWLlWqvUwUa : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6703
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647E50-0x0000000180647EB0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public DsUXpicJWUrxlzCiIWLlWqvUwUa(int <>1__state); // 0x0000000180648040-0x00000001806480B0
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180647C60-0x0000000180647DD0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180647C60-0x0000000180647DD0
					private bool MoveNext(); // 0x0000000180647670-0x0000000180647C60
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180647E00-0x0000000180647E50
					void IDisposable.Dispose(); // 0x0000000180647EB0-0x0000000180647F20
					private void TTIfIQDzpMQovzlZXLjhQABEygl(); // 0x0000000180647F20-0x0000000180648040
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class svIeuOlqdIdgMJVRVMPqBBMdRLm : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6704
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180664100-0x0000000180664160 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public svIeuOlqdIdgMJVRVMPqBBMdRLm(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180663F40-0x00000001806640B0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180663F40-0x00000001806640B0
					private bool MoveNext(); // 0x0000000180663900-0x0000000180663F40
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001806640B0-0x0000000180664100
					void IDisposable.Dispose(); // 0x0000000180664160-0x0000000180664210
					private void jTVXPDMpitAfwQxWarWcsTKpHmk(); // 0x0000000180664210-0x0000000180664260
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class HnFiMdnMRJFfGCHzJZKkxgcbjFUF : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6705
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180648B30-0x0000000180648B90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public HnFiMdnMRJFfGCHzJZKkxgcbjFUF(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180648940-0x0000000180648AE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180648940-0x0000000180648AE0
					private bool MoveNext(); // 0x00000001806482F0-0x0000000180648940
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180648AE0-0x0000000180648B30
					void IDisposable.Dispose(); // 0x0000000180648B90-0x0000000180648C40
					private void uYCbFxJgUPfIUiVCKDgjPfcnROFa(); // 0x0000000180648C90-0x0000000180648CE0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class WohwyXsENoFMCTBIKyRBwvQQdZy : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6706
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180659BC0-0x0000000180659C20 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public WohwyXsENoFMCTBIKyRBwvQQdZy(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001806599F0-0x0000000180659B70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806599F0-0x0000000180659B70
					private bool MoveNext(); // 0x0000000180659430-0x00000001806599F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180659B70-0x0000000180659BC0
					void IDisposable.Dispose(); // 0x0000000180659C20-0x0000000180659C90
					private void DxBrZWLmABsZfntVITVZAupiECp(); // 0x0000000180659330-0x0000000180659430
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class hTDxbowqJEakwFsHmMdeWCTxRen : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6707
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065FFE0-0x0000000180660040 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public hTDxbowqJEakwFsHmMdeWCTxRen(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x000000018065FDD0-0x000000018065FF90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065FDD0-0x000000018065FF90
					private bool MoveNext(); // 0x000000018065FA00-0x000000018065FDD0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065FF90-0x000000018065FFE0
					void IDisposable.Dispose(); // 0x0000000180660040-0x00000001806600F0
					private void BlJcpSGMIJLNuLoYcagvHJvgeeni(); // 0x000000018065F900-0x000000018065FA00
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class vXqtXTDOYVGRWkLMIpAnalYxhZG : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6708
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180665140-0x00000001806651A0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public vXqtXTDOYVGRWkLMIpAnalYxhZG(int <>1__state); // 0x0000000180665210-0x0000000180665280
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180664F20-0x00000001806650F0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180664F20-0x00000001806650F0
					private bool MoveNext(); // 0x00000001806648D0-0x0000000180664F20
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001806650F0-0x0000000180665140
					void IDisposable.Dispose(); // 0x00000001806651A0-0x0000000180665210
					private void wbuKNZGgaeBjYLLTrIThwBwtRUS(); // 0x0000000180665280-0x00000001806653B0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ebpbEyyjLqhAWKulViKLDyqJCsH : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6709
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
					ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018065E990-0x000000018065E9F0 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ebpbEyyjLqhAWKulViKLDyqJCsH(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x000000018065E790-0x000000018065E940
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018065E790-0x000000018065E940
					private bool MoveNext(); // 0x000000018065E150-0x000000018065E790
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x000000018065E940-0x000000018065E990
					void IDisposable.Dispose(); // 0x000000018065E9F0-0x000000018065EA60
					private void KHobgYkougjDJTFYscrlKfAVaQjM(); // 0x000000018065E030-0x000000018065E150
				}
	
				// Constructors
				private ConflictCheckingHelper(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public bool DoesAnyElementAssignmentConflict(); // 0x00000001804FF290-0x00000001804FF2B0
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps); // 0x00000001804FE050-0x00000001804FE070
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001804FF2B0-0x00000001804FF2D0
				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FE070-0x00000001804FF290
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001804FF570-0x00000001804FF5B0
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x00000001804FF920-0x00000001804FF970
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001804FF880-0x00000001804FF8D0
				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FF5B0-0x00000001804FF830
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x00000001804FF2D0-0x00000001804FF320
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001804FF830-0x00000001804FF880
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001804FF8D0-0x00000001804FF920
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FF320-0x00000001804FF570
				private bool DxUxCsinfAWFYpubKnmfntdUduK(int param_0000e636, int param_0000e637, JoystickMap param_0000e638, ActionElementMap param_0000e639, bool param_0000e63a = false /* Metadata: 0x007312CF */, bool param_0000e63b = false /* Metadata: 0x007312D0 */, bool param_0000e63c = true /* Metadata: 0x007312D1 */); // 0x00000001804FF970-0x00000001804FFC90
				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck param_0000e63d, bool param_0000e63e = false /* Metadata: 0x007312D2 */, bool param_0000e63f = false /* Metadata: 0x007312D3 */, bool param_0000e640 = true /* Metadata: 0x007312D4 */); // 0x00000001804FFC90-0x00000001804FFF20
				private bool wXcueicCklSRvlxEnukgGZLyfpI(int param_0000e641, KeyboardMap param_0000e642, ActionElementMap param_0000e643, bool param_0000e644 = false /* Metadata: 0x007312D5 */, bool param_0000e645 = false /* Metadata: 0x007312D6 */, bool param_0000e646 = true /* Metadata: 0x007312D7 */); // 0x0000000180504660-0x00000001805048D0
				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck param_0000e647, bool param_0000e648 = false /* Metadata: 0x007312D8 */, bool param_0000e649 = false /* Metadata: 0x007312D9 */, bool param_0000e64a = true /* Metadata: 0x007312DA */); // 0x00000001805048D0-0x0000000180504C10
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(int param_0000e64b, MouseMap param_0000e64c, ActionElementMap param_0000e64d, bool param_0000e64e = false /* Metadata: 0x007312DB */, bool param_0000e64f = false /* Metadata: 0x007312DC */, bool param_0000e650 = true /* Metadata: 0x007312DD */); // 0x0000000180502920-0x0000000180502B90
				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck param_0000e651, bool param_0000e652 = false /* Metadata: 0x007312DE */, bool param_0000e653 = false /* Metadata: 0x007312DF */, bool param_0000e654 = true /* Metadata: 0x007312E0 */); // 0x0000000180502640-0x0000000180502920
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int param_0000e655, int param_0000e656, CustomControllerMap param_0000e657, ActionElementMap param_0000e658, bool param_0000e659 = false /* Metadata: 0x007312E1 */, bool param_0000e65a = false /* Metadata: 0x007312E2 */, bool param_0000e65b = true /* Metadata: 0x007312E3 */); // 0x00000001805013E0-0x0000000180501660
				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck param_0000e65c, bool param_0000e65d = false /* Metadata: 0x007312E4 */, bool param_0000e65e = false /* Metadata: 0x007312E5 */, bool param_0000e65f = true /* Metadata: 0x007312E6 */); // 0x0000000180501660-0x0000000180501980
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180500950-0x0000000180500990
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x00000001804FFF20-0x00000001804FFF70
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180500860-0x00000001805008B0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FFFC0-0x0000000180500490
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001804FFF70-0x00000001804FFFC0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001805008B0-0x0000000180500900
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180500900-0x0000000180500950
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180500490-0x0000000180500860
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int param_0000e684, int param_0000e685, JoystickMap param_0000e686, ActionElementMap param_0000e687, bool param_0000e688 = false /* Metadata: 0x007312E7 */, bool param_0000e689 = false /* Metadata: 0x007312E8 */, bool param_0000e68a = true /* Metadata: 0x007312E9 */); // 0x0000000180500B90-0x0000000180500C80
				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck param_0000e68b, bool param_0000e68c = false /* Metadata: 0x007312EA */, bool param_0000e68d = false /* Metadata: 0x007312EB */, bool param_0000e68e = true /* Metadata: 0x007312EC */); // 0x0000000180500C80-0x0000000180500D80
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(int param_0000e68f, KeyboardMap param_0000e690, ActionElementMap param_0000e691, bool param_0000e692 = false /* Metadata: 0x007312ED */, bool param_0000e693 = false /* Metadata: 0x007312EE */, bool param_0000e694 = true /* Metadata: 0x007312EF */); // 0x0000000180503EF0-0x0000000180503FE0
				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck param_0000e695, bool param_0000e696 = false /* Metadata: 0x007312F0 */, bool param_0000e697 = false /* Metadata: 0x007312F1 */, bool param_0000e698 = true /* Metadata: 0x007312F2 */); // 0x0000000180503FE0-0x00000001805040E0
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(int param_0000e699, MouseMap param_0000e69a, ActionElementMap param_0000e69b, bool param_0000e69c = false /* Metadata: 0x007312F3 */, bool param_0000e69d = false /* Metadata: 0x007312F4 */, bool param_0000e69e = true /* Metadata: 0x007312F5 */); // 0x0000000180500AA0-0x0000000180500B90
				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck param_0000e69f, bool param_0000e6a0 = false /* Metadata: 0x007312F6 */, bool param_0000e6a1 = false /* Metadata: 0x007312F7 */, bool param_0000e6a2 = true /* Metadata: 0x007312F8 */); // 0x0000000180500990-0x0000000180500AA0
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int param_0000e6a3, int param_0000e6a4, CustomControllerMap param_0000e6a5, ActionElementMap param_0000e6a6, bool param_0000e6a7 = false /* Metadata: 0x007312F9 */, bool param_0000e6a8 = false /* Metadata: 0x007312FA */, bool param_0000e6a9 = true /* Metadata: 0x007312FB */); // 0x0000000180502C00-0x0000000180502D20
				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck param_0000e6aa, bool param_0000e6ab = false /* Metadata: 0x007312FC */, bool param_0000e6ac = false /* Metadata: 0x007312FD */, bool param_0000e6ad = true /* Metadata: 0x007312FE */); // 0x0000000180502D20-0x0000000180502E00
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001805019D0-0x0000000180501A10
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x0000000180501D30-0x0000000180501D80
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180501CE0-0x0000000180501D30
				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180501D80-0x0000000180502020
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180501C90-0x0000000180501CE0
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180501980-0x00000001805019D0
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x0000000180501A10-0x0000000180501A60
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x0000000180501A60-0x0000000180501C90
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int param_0000e6d2, int param_0000e6d3, JoystickMap param_0000e6d4, ActionElementMap param_0000e6d5, bool param_0000e6d6 = false /* Metadata: 0x007312FF */, bool param_0000e6d7 = false /* Metadata: 0x00731300 */, bool param_0000e6d8 = true /* Metadata: 0x00731301 */); // 0x0000000180504C10-0x0000000180504F60
				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck param_0000e6d9, bool param_0000e6da = false /* Metadata: 0x00731302 */, bool param_0000e6db = false /* Metadata: 0x00731303 */, bool param_0000e6dc = true /* Metadata: 0x00731304 */); // 0x0000000180504F60-0x00000001805052A0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(int param_0000e6dd, KeyboardMap param_0000e6de, ActionElementMap param_0000e6df, bool param_0000e6e0 = false /* Metadata: 0x00731305 */, bool param_0000e6e1 = false /* Metadata: 0x00731306 */, bool param_0000e6e2 = true /* Metadata: 0x00731307 */); // 0x00000001804FD370-0x00000001804FD6A0
				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck param_0000e6e3, bool param_0000e6e4 = false /* Metadata: 0x00731308 */, bool param_0000e6e5 = false /* Metadata: 0x00731309 */, bool param_0000e6e6 = true /* Metadata: 0x0073130A */); // 0x00000001804FD6A0-0x00000001804FD9E0
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(int param_0000e6e7, MouseMap param_0000e6e8, ActionElementMap param_0000e6e9, bool param_0000e6ea = false /* Metadata: 0x0073130B */, bool param_0000e6eb = false /* Metadata: 0x0073130C */, bool param_0000e6ec = true /* Metadata: 0x0073130D */); // 0x00000001805043D0-0x0000000180504660
				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck param_0000e6ed, bool param_0000e6ee = false /* Metadata: 0x0073130E */, bool param_0000e6ef = false /* Metadata: 0x0073130F */, bool param_0000e6f0 = true /* Metadata: 0x00731310 */); // 0x00000001805040E0-0x00000001805043D0
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int param_0000e6f1, int param_0000e6f2, CustomControllerMap param_0000e6f3, ActionElementMap param_0000e6f4, bool param_0000e6f5 = false /* Metadata: 0x00731311 */, bool param_0000e6f6 = false /* Metadata: 0x00731312 */, bool param_0000e6f7 = true /* Metadata: 0x00731313 */); // 0x00000001805030B0-0x0000000180503390
				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck param_0000e6f8, bool param_0000e6f9 = false /* Metadata: 0x00731314 */, bool param_0000e6fa = false /* Metadata: 0x00731315 */, bool param_0000e6fb = true /* Metadata: 0x00731316 */); // 0x0000000180502E00-0x00000001805030B0
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001804FD9E0-0x00000001804FDA20
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps); // 0x00000001804FDDC0-0x00000001804FDE10
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001804FDAC0-0x00000001804FDB10
				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FDB60-0x00000001804FDDC0
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001804FDB10-0x00000001804FDB60
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001804FDA20-0x00000001804FDA70
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories); // 0x00000001804FDA70-0x00000001804FDAC0
				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer); // 0x00000001804FDE10-0x00000001804FE050
				private int NelggbthumjxGTexgIAOZhYwWoK(int param_0000e720, int param_0000e721, JoystickMap param_0000e722, ActionElementMap param_0000e723, bool param_0000e724 = false /* Metadata: 0x00731317 */, bool param_0000e725 = false /* Metadata: 0x00731318 */, bool param_0000e726 = true /* Metadata: 0x00731319 */); // 0x0000000180501100-0x00000001805013E0
				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck param_0000e727, bool param_0000e728 = false /* Metadata: 0x0073131A */, bool param_0000e729 = false /* Metadata: 0x0073131B */, bool param_0000e72a = true /* Metadata: 0x0073131C */); // 0x0000000180500D80-0x0000000180501100
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(int param_0000e72b, KeyboardMap param_0000e72c, ActionElementMap param_0000e72d, bool param_0000e72e = false /* Metadata: 0x0073131D */, bool param_0000e72f = false /* Metadata: 0x0073131E */, bool param_0000e730 = true /* Metadata: 0x0073131F */); // 0x0000000180502020-0x0000000180502380
				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck param_0000e731, bool param_0000e732 = false /* Metadata: 0x00731320 */, bool param_0000e733 = false /* Metadata: 0x00731321 */, bool param_0000e734 = true /* Metadata: 0x00731322 */); // 0x0000000180502380-0x0000000180502640
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(int param_0000e735, MouseMap param_0000e736, ActionElementMap param_0000e737, bool param_0000e738 = false /* Metadata: 0x00731323 */, bool param_0000e739 = false /* Metadata: 0x00731324 */, bool param_0000e73a = true /* Metadata: 0x00731325 */); // 0x0000000180503650-0x00000001805038C0
				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck param_0000e73b, bool param_0000e73c = false /* Metadata: 0x00731326 */, bool param_0000e73d = false /* Metadata: 0x00731327 */, bool param_0000e73e = true /* Metadata: 0x00731328 */); // 0x0000000180503390-0x0000000180503650
				private int qzXyzfORVDqhzRVipLqpqtoChSh(int param_0000e73f, int param_0000e740, CustomControllerMap param_0000e741, ActionElementMap param_0000e742, bool param_0000e743 = false /* Metadata: 0x00731329 */, bool param_0000e744 = false /* Metadata: 0x0073132A */, bool param_0000e745 = true /* Metadata: 0x0073132B */); // 0x0000000180503BF0-0x0000000180503EF0
				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck param_0000e746, bool param_0000e747 = false /* Metadata: 0x0073132C */, bool param_0000e748 = false /* Metadata: 0x0073132D */, bool param_0000e749 = true /* Metadata: 0x0073132E */); // 0x00000001805038C0-0x0000000180503BF0
			}
	
			// Constructors
			private ControllerHelper(); // 0x0000000180508290-0x0000000180508320
	
			// Methods
			public T GetController<T>(int controllerId)
				where T : Controller;
			public int GetControllerCount(ControllerType controllerType); // 0x0000000180506200-0x0000000180506380
			public Controller GetController(ControllerType controllerType, int controllerId); // 0x0000000180506500-0x00000001805065C0
			public Controller GetController(ControllerIdentifier controllerIdentifier); // 0x0000000180506430-0x0000000180506500
			public Controller[] GetControllers(ControllerType controllerType); // 0x00000001805065C0-0x0000000180506670
			public string[] GetControllerNames(ControllerType controllerType); // 0x0000000180506380-0x0000000180506430
			public bool IsControllerAssigned(ControllerType controllerType, Controller controller); // 0x00000001805072C0-0x0000000180507370
			public bool IsControllerAssigned(ControllerType controllerType, int controllerId); // 0x0000000180507370-0x0000000180507430
			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId); // 0x00000001805071F0-0x00000001805072C0
			public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = true /* Metadata: 0x007312C9 */); // 0x0000000180507870-0x0000000180507920
			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true /* Metadata: 0x007312CA */); // 0x0000000180507920-0x00000001805079F0
			public Joystick GetJoystick(int joystickId); // 0x0000000180506A90-0x0000000180506B40
			public Joystick[] GetJoysticks(); // 0x0000000180506B40-0x0000000180506BB0
			public string[] GetJoystickNames(); // 0x00000001805069E0-0x0000000180506A90
			public bool IsJoystickAssigned(Joystick joystick); // 0x00000001805077C0-0x0000000180507870
			public bool IsJoystickAssigned(int joystickId); // 0x0000000180507710-0x00000001805077C0
			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId); // 0x0000000180507650-0x0000000180507710
			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true /* Metadata: 0x007312CB */); // 0x0000000180507C40-0x0000000180507D10
			public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = true /* Metadata: 0x007312CC */); // 0x0000000180507B90-0x0000000180507C40
			public int GetUnityJoystickIdFromAnyButtonPress(); // 0x0000000180507010-0x00000001805071F0
			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly); // 0x0000000180506DA0-0x0000000180507010
			public void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x0000000180508170-0x0000000180508290
			public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId); // 0x0000000180507F40-0x0000000180508170
			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly); // 0x0000000180507E90-0x0000000180507F40
			public CustomController GetCustomController(int customControllerId); // 0x0000000180506720-0x00000001805067D0
			public CustomController[] GetCustomControllers(); // 0x00000001805067D0-0x0000000180506880
			public string[] GetCustomControllerNames(); // 0x0000000180506670-0x0000000180506720
			public bool IsCustomControllerAssigned(CustomController customController); // 0x00000001805074F0-0x00000001805075A0
			public bool IsCustomControllerAssigned(int customControllerId); // 0x00000001805075A0-0x0000000180507650
			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId); // 0x0000000180507430-0x00000001805074F0
			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true /* Metadata: 0x007312CD */); // 0x0000000180507AC0-0x0000000180507B90
			public void RemoveCustomControllerFromAllPlayers(int customControllerId, bool includeSystemPlayer = true /* Metadata: 0x007312CE */); // 0x00000001805079F0-0x0000000180507AC0
			public CustomController CreateCustomController(int sourceControllerId); // 0x0000000180505720-0x00000001805057D0
			public CustomController CreateCustomController(int sourceControllerId, string tag); // 0x00000001805057D0-0x00000001805058A0
			public bool DestroyCustomController(CustomController customController); // 0x0000000180505A00-0x0000000180505B70
			public CustomController GetFirstCustomControllerWithSourceId(int sourceId); // 0x0000000180506880-0x0000000180506930
			public CustomController GetFirstCustomControllerWithTag(string tag); // 0x0000000180506930-0x00000001805069E0
			public IEnumerable<CustomController> CustomControllersWithSourceId(int sourceId); // 0x00000001805058A0-0x0000000180505950
			public IEnumerable<CustomController> CustomControllersWithTag(string tag); // 0x0000000180505950-0x0000000180505A00
			public IList<TInterface> GetControllerTemplates<TInterface>()
				where TInterface : IControllerTemplate;
			public Controller GetLastActiveController(); // 0x0000000180506D00-0x0000000180506DA0
			public Controller GetLastActiveController(ControllerType controllerType); // 0x0000000180506C50-0x0000000180506D00
			public T GetLastActiveController<T>()
				where T : Controller;
			public ControllerType GetLastActiveControllerType(); // 0x0000000180506BB0-0x0000000180506C50
			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback); // 0x00000001805052A0-0x0000000180505350
			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000180505350-0x0000000180505400
			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback); // 0x0000000180507D10-0x0000000180507DD0
			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType); // 0x0000000180507DD0-0x0000000180507E90
			public void ClearLastActiveControllerChangedDelegates(); // 0x0000000180505680-0x0000000180505720
			public bool GetAnyButton(); // 0x00000001805060B0-0x0000000180506150
			public bool GetAnyButton(ControllerType controllerType); // 0x0000000180506150-0x0000000180506200
			public bool GetAnyButtonDown(); // 0x0000000180505CC0-0x0000000180505D60
			public bool GetAnyButtonDown(ControllerType controllerType); // 0x0000000180505D60-0x0000000180505E10
			public bool GetAnyButtonUp(); // 0x0000000180506010-0x00000001805060B0
			public bool GetAnyButtonUp(ControllerType controllerType); // 0x0000000180505F60-0x0000000180506010
			public bool GetAnyButtonChanged(); // 0x0000000180505C20-0x0000000180505CC0
			public bool GetAnyButtonChanged(ControllerType controllerType); // 0x0000000180505B70-0x0000000180505C20
			public bool GetAnyButtonPrev(); // 0x0000000180505EC0-0x0000000180505F60
			public bool GetAnyButtonPrev(ControllerType controllerType); // 0x0000000180505E10-0x0000000180505EC0
			public bool AutoAssignJoystick(Joystick joystick); // 0x0000000180505400-0x00000001805054F0
			public void AutoAssignJoysticks(); // 0x00000001805054F0-0x0000000180505680
		}
	
		[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
		[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
		public sealed class MappingHelper : CodeHelper // TypeDefIndex: 6710
		{
			// Fields
			private static MappingHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static MappingHelper Instance { get; } // 0x0000000180651BF0-0x0000000180651C60 
			public IList<InputMapCategory> MapCategories { get; } // 0x0000000180651DC0-0x0000000180651E70 
			public IEnumerable<InputMapCategory> UserAssignableMapCategories { get; } // 0x0000000180652080-0x0000000180652130 
			public IList<InputCategory> ActionCategories { get; } // 0x00000001806519E0-0x0000000180651A90 
			public IEnumerable<InputCategory> UserAssignableActionCategories { get; } // 0x0000000180651F20-0x0000000180651FD0 
			public IList<InputLayout> JoystickLayouts { get; } // 0x0000000180651C60-0x0000000180651D10 
			public IList<InputLayout> KeyboardLayouts { get; } // 0x0000000180651D10-0x0000000180651DC0 
			public IList<InputLayout> MouseLayouts { get; } // 0x0000000180651E70-0x0000000180651F20 
			public IList<InputLayout> CustomControllerLayouts { get; } // 0x0000000180651B40-0x0000000180651BF0 
			public IList<InputAction> Actions { get; } // 0x0000000180651A90-0x0000000180651B40 
			public IEnumerable<InputAction> UserAssignableActions { get; } // 0x0000000180651FD0-0x0000000180652080 
	
			// Constructors
			private MappingHelper(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			public InputMapCategory GetMapCategory(int mapCategoryId); // 0x00000001806500A0-0x0000000180650150
			public InputMapCategory GetMapCategory(string name); // 0x0000000180650150-0x0000000180650200
			public int GetMapCategoryId(string name); // 0x000000018064FFF0-0x00000001806500A0
			public IEnumerable<InputMapCategory> MapCategoriesWithTag(string tag); // 0x00000001806510E0-0x0000000180651190
			public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(string tag); // 0x0000000180651840-0x00000001806518F0
			public bool IsMapCategoryUserAssignable(int mapCategoryId); // 0x0000000180650FE0-0x00000001806510E0
			public InputCategory GetActionCategory(int mapCategoryId); // 0x0000000180649910-0x00000001806499C0
			public InputCategory GetActionCategory(string name); // 0x00000001806499C0-0x0000000180649A70
			public int GetActionCategoryId(string name); // 0x0000000180649860-0x0000000180649910
			public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag); // 0x0000000180649410-0x00000001806494C0
			public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(string tag); // 0x00000001806514A0-0x0000000180651550
			public bool IsActionCategoryUserAssignable(int mapCategoryId); // 0x0000000180650EC0-0x0000000180650FE0
			public InputLayout GetLayout(ControllerType controllerType, int layoutId); // 0x000000018064FBD0-0x000000018064FDE0
			public InputLayout GetLayout(ControllerType controllerType, string name); // 0x000000018064FDE0-0x000000018064FFF0
			public int GetLayoutId(ControllerType controllerType, string name); // 0x000000018064F9C0-0x000000018064FBD0
			public InputLayout GetJoystickLayout(int layoutId); // 0x000000018064D390-0x000000018064D440
			public InputLayout GetJoystickLayout(string name); // 0x000000018064D440-0x000000018064D4F0
			public int GetJoystickLayoutId(string name); // 0x000000018064D2E0-0x000000018064D390
			public InputLayout GetKeyboardLayout(int layoutId); // 0x000000018064F1F0-0x000000018064F2A0
			public InputLayout GetKeyboardLayout(string name); // 0x000000018064F140-0x000000018064F1F0
			public int GetKeyboardLayoutId(string name); // 0x000000018064F090-0x000000018064F140
			public InputLayout GetMouseLayout(int layoutId); // 0x00000001806502B0-0x0000000180650360
			public InputLayout GetMouseLayout(string name); // 0x0000000180650360-0x0000000180650410
			public int GetMouseLayoutId(string name); // 0x0000000180650200-0x00000001806502B0
			public InputLayout GetCustomControllerLayout(int layoutId); // 0x000000018064B7A0-0x000000018064B850
			public InputLayout GetCustomControllerLayout(string name); // 0x000000018064B850-0x000000018064B900
			public int GetCustomControllerLayoutId(string name); // 0x000000018064B6F0-0x000000018064B7A0
			public IList<InputLayout> MapLayouts(ControllerType controllerType); // 0x0000000180651190-0x00000001806514A0
			public InputAction GetAction(int actionId); // 0x0000000180649D20-0x0000000180649DD0
			public InputAction GetAction(string name); // 0x0000000180649DD0-0x0000000180649E80
			public int GetActionId(string name); // 0x0000000180649C70-0x0000000180649D20
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName); // 0x0000000180649630-0x00000001806496E0
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName, bool sort); // 0x00000001806496E0-0x00000001806497B0
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId); // 0x00000001806497B0-0x0000000180649860
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId, bool sort); // 0x0000000180649570-0x0000000180649630
			public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag); // 0x00000001806494C0-0x0000000180649570
			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId); // 0x0000000180651790-0x0000000180651840
			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId, bool sort); // 0x0000000180651620-0x00000001806516E0
			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName); // 0x00000001806516E0-0x0000000180651790
			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName, bool sort); // 0x0000000180651550-0x0000000180651620
			public IList<InputBehavior> GetInputBehaviors(int playerId); // 0x000000018064D230-0x000000018064D2E0
			public IList<InputBehavior> GetSystemPlayerInputBehaviors(); // 0x0000000180650E10-0x0000000180650EC0
			public InputBehavior GetInputBehavior(int playerId, int behaviorId); // 0x000000018064D170-0x000000018064D230
			public InputBehavior GetInputBehavior(int playerId, string behaviorName); // 0x000000018064D0B0-0x000000018064D170
			public InputBehavior GetSystemPlayerInputBehavior(int behaviorId); // 0x0000000180650D20-0x0000000180650E10
			public InputBehavior GetSystemPlayerInputBehavior(string behaviorName); // 0x0000000180650C30-0x0000000180650D20
			public int GetInputBehaviorId(string behaviorName); // 0x000000018064D000-0x000000018064D0B0
			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(int param_0000e789); // 0x0000000180651970-0x00000001806519E0
			internal InputBehavior VMSAYpiOGgFZnhPmOgWcUFTKLzU(string param_0000e78a); // 0x00000001806518F0-0x0000000180651970
			public ControllerMap GetControllerMap(int id); // 0x000000018064B240-0x000000018064B430
			public ActionElementMap GetActionElementMap(int id); // 0x0000000180649A70-0x0000000180649C70
			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId); // 0x000000018064AE90-0x000000018064B040
			public ControllerMap GetControllerMapInstance(Controller controller, string mapCategoryName, string layoutName); // 0x000000018064A900-0x000000018064A9D0
			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064ABF0-0x000000018064AE90
			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064A9D0-0x000000018064ABF0
			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId); // 0x000000018064EF80-0x000000018064F090
			public JoystickMap GetJoystickMapInstance(Joystick joystick, string mapCategoryName, string layoutName); // 0x000000018064E3B0-0x000000018064E530
			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId); // 0x000000018064E700-0x000000018064EB00
			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, string mapCategoryName, string layoutName); // 0x000000018064EB00-0x000000018064ED10
			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064ED10-0x000000018064EF80
			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064E530-0x000000018064E700
			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId); // 0x000000018064F7A0-0x000000018064F900
			public KeyboardMap GetKeyboardMapInstance(string mapCategoryName, string layoutName); // 0x000000018064F900-0x000000018064F9C0
			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId); // 0x0000000180650AE0-0x0000000180650C30
			public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName); // 0x0000000180650980-0x0000000180650AE0
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId); // 0x000000018064CAE0-0x000000018064CC30
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, string mapCategoryName, string layoutName); // 0x000000018064CC30-0x000000018064CED0
			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064C4C0-0x000000018064CAE0
			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064C350-0x000000018064C4C0
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, int mapCategoryId, int layoutId); // 0x000000018064A080-0x000000018064A410
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, string mapCategoryName, string layoutName); // 0x000000018064A410-0x000000018064A4F0
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064A4F0-0x000000018064A690
			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064A690-0x000000018064A900
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, int mapCategoryId, int layoutId); // 0x000000018064D4F0-0x000000018064D5B0
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, string mapCategoryName, string layoutName); // 0x000000018064D5B0-0x000000018064D750
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064D8C0-0x000000018064E3B0
			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064D750-0x000000018064D8C0
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, int mapCategoryId, int layoutId); // 0x000000018064BAC0-0x000000018064BB50
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, string mapCategoryName, string layoutName); // 0x000000018064BB50-0x000000018064BCA0
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId); // 0x000000018064BCA0-0x000000018064C350
			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName); // 0x000000018064B900-0x000000018064BAC0
			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId); // 0x000000018064F2A0-0x000000018064F6E0
			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName); // 0x000000018064F6E0-0x000000018064F7A0
			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId); // 0x0000000180650410-0x0000000180650800
			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName); // 0x0000000180650800-0x0000000180650980
			[Obsolete] // 0x00000001801195D0-0x0000000180119600
			public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(Joystick joystick, int joystickElementIdentifierId); // 0x000000018064CED0-0x000000018064D000
			private ControllerElementIdentifier vjwEhCZEZHlszoNSLRdwLzibmvc(Guid param_0000e7fd, int param_0000e7fe); // 0x0000000180652130-0x00000001806521E0
			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, int mapCategoryId, int layoutId); // 0x000000018064B430-0x000000018064B510
			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, string mapCategoryName, string layoutName); // 0x000000018064B510-0x000000018064B6F0
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id); // 0x000000018064B040-0x000000018064B0F0
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(string name); // 0x000000018064B0F0-0x000000018064B240
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id); // 0x0000000180649E80-0x0000000180649F30
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(string name); // 0x0000000180649F30-0x000000018064A080
		}
	
		[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
		[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
		public sealed class PlayerHelper : CodeHelper // TypeDefIndex: 6711
		{
			// Fields
			private static PlayerHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static PlayerHelper Instance { get; } // 0x0000000180652A50-0x0000000180652AC0 
			public int playerCount { get; } // 0x0000000180652CB0-0x0000000180652D50 
			public int allPlayerCount { get; } // 0x0000000180652C10-0x0000000180652CB0 
			public IList<Player> Players { get; } // 0x0000000180652AC0-0x0000000180652B70 
			public IList<Player> AllPlayers { get; } // 0x00000001806529A0-0x0000000180652A50 
			public Player SystemPlayer { get; } // 0x0000000180652B70-0x0000000180652C10 
	
			// Constructors
			private PlayerHelper(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			public IList<Player> GetPlayers(bool includeSystemPlayer = false /* Metadata: 0x0073132F */); // 0x0000000180652800-0x0000000180652900
			public Player GetPlayer(int playerId); // 0x0000000180652750-0x0000000180652800
			public Player GetPlayer(string name); // 0x00000001806526A0-0x0000000180652750
			public Player GetSystemPlayer(); // 0x0000000180652900-0x00000001806529A0
			public int GetPlayerId(string playerName); // 0x0000000180652490-0x0000000180652540
			public string[] GetPlayerNames(bool includeSystemPlayer = false /* Metadata: 0x00731330 */); // 0x00000001806525F0-0x00000001806526A0
			public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = false /* Metadata: 0x00731331 */); // 0x00000001806523E0-0x0000000180652490
			public int[] GetPlayerIds(bool includeSystemPlayer = false /* Metadata: 0x00731332 */); // 0x0000000180652540-0x00000001806525F0
		}
	
		[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
		[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
		public sealed class TimeHelper : CodeHelper // TypeDefIndex: 6712
		{
			// Fields
			private static TimeHelper wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static TimeHelper Instance { get; } // 0x0000000180658990-0x0000000180658A00 
			public float unscaledDeltaTime { get; } // 0x0000000180658AB0-0x0000000180658B60 
			public float unscaledTime { get; } // 0x0000000180658B60-0x0000000180658C10 
			public uint currentFrame { get; } // 0x0000000180658A00-0x0000000180658AB0 
	
			// Constructors
			private TimeHelper(); // 0x000000018037E800-0x000000018037E810
		}
	
		private class MPmBDkxdnNggWgQnkGyTossZItbb // TypeDefIndex: 6713
		{
			// Fields
			private StopwatchBase GcGMIVuBupFgRPpaUfXCcWsCyhK; // 0x10
			private float NyfpdpWceDuDtKKcqIcqrFZaZDk; // 0x18
			private NIMpESYenqcobEuRNuJIVWgBWKG hclpymcDtGBEMxZtqcadqiSrnKW; // 0x20
			private ADictionary<int, NIMpESYenqcobEuRNuJIVWgBWKG> EPsaxebuJgDuzXDToniUIUhlSrCu; // 0x28
			private uint tGJKVwrcRdmchlBMOqvPldsSKLg; // 0x30
	
			// Properties
			public float mvVqIzXhXGYlUhKStsZFaHkcgtP { get; } // 0x00000001806493F0-0x0000000180649410 
			public float EVVDxzguWHQDvWvgDUhVHBmQPkLi { get; } // 0x00000001806493D0-0x00000001806493F0 
			public float FfCgIRKtWTmYBEcpkONhoXkhUlk { get; } // 0x00000001806493B0-0x00000001806493D0 
			public float ljlgJtHKJJMJBJdDcshinawGVsGK { get; } // 0x0000000180649390-0x00000001806493B0 
			public float BDYwGXKPNXUpWCSHttDxCVFljrv { get; } // 0x0000000180649370-0x0000000180649390 
			public float XgHDcEjUvQpuRrECxetxmajRXulN { get; } // 0x0000000180649330-0x0000000180649370 
			public uint eupkLNYHupbKxOgCHbqidLtXZAwi { get; } // 0x0000000180649310-0x0000000180649330 
			public uint CHOCNYDOKokOAieAfEYuhwIXqJOv { get; } // 0x00000001806492F0-0x0000000180649310 
			public uint gjDADGoAsnfIVCcCovIDYiFadpH { get; } // 0x000000018043DDC0-0x000000018043DDD0 
	
			// Nested types
			private class NIMpESYenqcobEuRNuJIVWgBWKG // TypeDefIndex: 6714
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
				public float mvVqIzXhXGYlUhKStsZFaHkcgtP { get; } // 0x000000018048F530-0x000000018048F540 
				public float EVVDxzguWHQDvWvgDUhVHBmQPkLi { get; } // 0x00000001805D9080-0x00000001805D9090 
				public float FfCgIRKtWTmYBEcpkONhoXkhUlk { get; } // 0x00000001805D9070-0x00000001805D9080 
				public uint eupkLNYHupbKxOgCHbqidLtXZAwi { get; } // 0x00000001803C26F0-0x00000001803C2700 
				public uint CHOCNYDOKokOAieAfEYuhwIXqJOv { get; } // 0x000000018038E0E0-0x000000018038E0F0 
				public float ljlgJtHKJJMJBJdDcshinawGVsGK { get; } // 0x0000000180487D70-0x0000000180487D80 
				public float BDYwGXKPNXUpWCSHttDxCVFljrv { get; } // 0x0000000180485990-0x00000001804859A0 
	
				// Constructors
				public NIMpESYenqcobEuRNuJIVWgBWKG(UpdateLoopType updateLoop); // 0x00000001806523A0-0x00000001806523E0
	
				// Methods
				public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x00000001806521E0-0x00000001806523A0
			}
	
			private static class GFEsypbXOzjblWUKhucUcNKZvaR // TypeDefIndex: 6715
			{
				// Properties
				public static StopwatchBase OMmnejZDVQLniULQgbPlHRIjfE { get; } // 0x0000000180648180-0x0000000180648240 
	
				// Methods
				public static StopwatchBase AQMpZVIIXTyemnHtIDPtxhINdLN(); // 0x00000001806480B0-0x0000000180648180
				public static StopwatchBase wyCjNuqsWjGtSUFEElHBnTNnQLS(); // 0x0000000180648240-0x00000001806482F0
			}
	
			// Constructors
			public MPmBDkxdnNggWgQnkGyTossZItbb(); // 0x0000000180649220-0x00000001806492F0
	
			// Methods
			public void KBPXdDXgvchYOmaFpDETYNhRqLD(); // 0x0000000180648CE0-0x0000000180648D00
			public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x0000000180648FD0-0x0000000180649220
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000e810); // 0x0000000180648D00-0x0000000180648FD0
		}
	
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class UnityTouch : CodeHelper // TypeDefIndex: 6716
		{
			// Fields
			private static UnityTouch wyGHCdkUHFjOjLlAQjAUDxGKybH; // 0x00
	
			// Properties
			internal static UnityTouch Instance { get; } // 0x0000000180659260-0x00000001806592D0 
			public int touchCount { get; } // 0x00000001806592F0-0x0000000180659300 
			public Touch[] touches { get; } // 0x0000000180659300-0x0000000180659310 
			public bool simulateMouseWithTouches { get; set; } // 0x00000001806592E0-0x00000001806592F0 0x0000000180659320-0x0000000180659330
			public bool multiTouchEnabled { get; set; } // 0x00000001806592D0-0x00000001806592E0 0x0000000180659310-0x0000000180659320
	
			// Constructors
			private UnityTouch(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			public Touch GetTouch(int index); // 0x0000000180659210-0x0000000180659260
		}
	
		internal class ptveCNmVZXCKQBRQPTFtDMcYzpD // TypeDefIndex: 6717
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
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<bool> mhIoohQKHLtRvnOkGOyhEaVZzEI; // 0x00
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<bool> xLsnLVMSdomUJlraUjoaaJurhHn; // 0x08
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<int> LqpbqWhYLnPlrmeWYhUGvnoFNkYM; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<float> KSctgEtbfpMomXNHtoTyKVtwYdL; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<bool> nnpRHVINhHOVQHcgAExuBWHPHnOo; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<string> zxFEUXSbZKUDkCYPKPrDQPuLYa; // 0x28
	
			// Properties
			public int FQTGxzXqRPJAshSJnXqTZxHMxHI { get; } // 0x0000000180384C10-0x0000000180384C20 
	
			// Constructors
			public ptveCNmVZXCKQBRQPTFtDMcYzpD(); // 0x0000000180661F40-0x00000001806625C0
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x0000000180661D70-0x0000000180661E50
			public void NoDuTeAvSQJdmCqMOdLbwQahaKY(); // 0x0000000180661E50-0x0000000180661F30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static bool PoAQZUDaExIpnInliWEtfKfdTHa(); // 0x0000000180661F30-0x0000000180661F40
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static bool JmTKlkertXqrKlYerpRBRaythRj(); // 0x0000000180661D50-0x0000000180661D60
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int KEgqyXXRmHNFhEKlnChuTefKlow(); // 0x0000000180661D60-0x0000000180661D70
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static float HzfFxSBABnlOZCrpvMtPGvPHUzfW(); // 0x0000000180661D40-0x0000000180661D50
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static bool psSvwMhRMUVndaclooBCVmmUEhN(); // 0x00000001806625C0-0x00000001806625E0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string vgAUbxLblEVuBCHukgGuKwPkixt(); // 0x00000001806625E0-0x0000000180662650
		}
	
		// Constructors
		static ReInput(); // 0x0000000180512E20-0x0000000180513700
	
		// Methods
		public static void Reset(); // 0x00000001805122F0-0x0000000180512430
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool IsInputAllowed(ControllerType controllerType); // 0x00000001805103E0-0x00000001805105C0
		internal static void ItdhavHGXcUkAhyjaCFbIXENJheh(InputManager_Base param_0000e542, Func<ConfigVars, object> param_0000e543, ConfigVars param_0000e544, ControllerDataFiles param_0000e545, UserData param_0000e546); // 0x00000001805105C0-0x00000001805117F0
		internal static void JHzUZUsFQTvSmWjmIewXSnYsiSq(); // 0x00000001805118D0-0x0000000180511C30
		internal static void czYodqxgdcIwdElMkyegUEfPyfS(UpdateLoopType param_0000e547); // 0x0000000180514720-0x0000000180514810
		private static void WtfzmRcJkpzskEdOCFPheCSULzaC(UpdateLoopType param_0000e548); // 0x0000000180512710-0x0000000180512900
		private static void aLjDyaCCxjAPHdAQcpOppSlVkLmE(); // 0x0000000180513700-0x0000000180513860
		internal static void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000e549); // 0x0000000180511CF0-0x0000000180512290
		internal static void YXPwgQXmKLEoGBmBdjMvbzFLpnmw(); // 0x0000000180512900-0x00000001805129E0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static void EditorUpdate(); // 0x000000018050FA00-0x000000018050FC60
		internal static void cozuwinUKQpqyFkBMspLZBpsgZx(); // 0x00000001805144D0-0x00000001805146E0
		internal static void CihfeCOLgmPrJRnRPoaeejEWizEf(); // 0x000000018050F7C0-0x000000018050F860
		internal static void ARSkBchNZoCnEalDDuBpuIFdqwp(bool param_0000e54a); // 0x000000018050F1D0-0x000000018050F370
		internal static void ClVLoPPfUviCWYBLLDoDisJmYPc(); // 0x000000018050F860-0x000000018050F940
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController); // 0x000000018050FCE0-0x000000018050FD60
		internal static HardwareJoystickMap GcBIiOdyTQzggNpeAanbphqNHTo(Guid param_0000e54c); // 0x000000018050FC60-0x000000018050FCE0
		internal static HardwareJoystickTemplateMap CgDjzNHGwPDmghWwPZmlMDMkyXF(Guid param_0000e54d); // 0x000000018050F530-0x000000018050F5B0
		internal static IHardwareControllerTemplateMap vJYIYfBwdUOpGFkPnpFNkRYssPG(Guid param_0000e54e); // 0x00000001805192D0-0x0000000180519350
		internal static IList<HardwareJoystickTemplateMap> wjdeIRdNjPOyAgaohSPOaXpVswuY(Guid param_0000e54f); // 0x0000000180519420-0x00000001805197D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static int GetNewJoystickId(); // 0x000000018050FD60-0x000000018050FDD0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static void HandleCallbackException(string source, Exception exception); // 0x000000018050FF30-0x0000000180510160
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static void HandleExternException(string source, Exception exception); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static void HandleExternalInterfaceException(string source, Exception exception); // 0x0000000180510160-0x0000000180510380
		internal static void ZJiVzFiamhXWJiEaoqsHhYSmrpk(); // 0x0000000180512AF0-0x0000000180512B70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static void CheckRewiredVersionCompatibility(); // 0x000000018050F6D0-0x000000018050F7C0
		internal static float gOwEjOBAnElHMdCPMXqWzFbEyII(); // 0x00000001805148C0-0x0000000180514940
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool CheckInitialized(); // 0x000000018050F660-0x000000018050F6D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static bool CheckInitialized(int reInputId); // 0x000000018050F5B0-0x000000018050F660
		private static void ACxMnYVUvcAyDDIzgwIKJklrBJr(); // 0x000000018050EC30-0x000000018050ED60
		private static void xbNIgpPTtLbPHTlmmHCRmhjXJri(); // 0x0000000180519850-0x000000018051A210
		private static void jaWlNYsvYwfyhnyIPFoJHebdAdah(string param_0000e557 = null); // 0x0000000180517010-0x00000001805170A0
		private static void GgEJvrkhnkpoSrnymeVJMKKKgDy(); // 0x000000018050FDD0-0x000000018050FED0
		private static void ctaxpqhtkFbLIhJlHhEeUanHRkf(); // 0x00000001805146E0-0x0000000180514720
		private static void ZjLUjUuRFWofLJwnZpIlgLMrRXo(BridgedController param_0000e558); // 0x0000000180512B70-0x0000000180512E20
		private static void idUTwhlvoGWmxtXkHdgaCohAfqt(ControllerDisconnectedEventArgs param_0000e559); // 0x0000000180516E00-0x0000000180517010
		private static void eQTXJZPHXrmQIErbgNHRGjesfXpg(ControllerStatusChangedEventArgs param_0000e55a); // 0x0000000180514810-0x00000001805148C0
		private static void BvHwccPfrHUFcpcPIygMLRubGwt(ControllerStatusChangedEventArgs param_0000e55b); // 0x000000018050F450-0x000000018050F530
		private static void IyiZLQpuMCDajwliXvGjQjSEwTv(ControllerStatusChangedEventArgs param_0000e55c); // 0x00000001805117F0-0x00000001805118D0
		private static void wpXzZTjUfZJCSxmuaZcKtEujgiW(UpdateControllerInfoEventArgs param_0000e55d); // 0x00000001805197D0-0x0000000180519850
		private static void YXaERQllkGCuyBHgnojbfAfAhwpJ(bool param_0000e55e); // 0x00000001805129E0-0x0000000180512AF0
		private static void DPWTEFhSmOrDBmHhxCEvvIttcpy(bool param_0000e55f); // 0x000000018050F940-0x000000018050FA00
		private static void RhaFTWKlzuDUhQOZTFjOktfeFrz(int param_0000e560); // 0x0000000180512430-0x0000000180512530
		private static void VeJROhQFjuOiuGnhGoIiTxAozOL(bool param_0000e561); // 0x0000000180512590-0x0000000180512650
		private static void vQSGogEDYoNdYcdUKBuyEXfgcaJm(bool param_0000e562); // 0x0000000180519350-0x0000000180519420
		private static void yBMPtlETbMyFNpxEJpKyiwylIHq(); // 0x000000018051A530-0x000000018051A890
		private static void xcSbHFyvsKOdbzkSRAioGmIwKzs(); // 0x000000018051A210-0x000000018051A530
		private static void JZZDkvIKTiCvpsFsmhxPPMgCkMRC(bool param_0000e563); // 0x0000000180511C30-0x0000000180511CF0
		private static void toDAwKEZKpnEZPCkeFNrIPAvDLcC(Func<ConfigVars, object> param_0000e564); // 0x0000000180517DD0-0x00000001805192D0
		private static void BWjrCznwcgjVJTeRHmTNILudaZn(); // 0x000000018050F370-0x000000018050F450
		private static void AJdGwTsaQxxBMwQQMglszXwCgc(); // 0x000000018050EDC0-0x000000018050F1D0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void SHhkYQoZOcOvJaWepRTLupkJhxaf(Exception param_0000e565); // 0x0000000180512530-0x0000000180512590
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void zyjcYRapgfnlEbfnXogwbFUcPyiy(Exception param_0000e566); // 0x000000018051A910-0x000000018051A970
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void WMjiGVYNTwahDyfALkkAnsuilfh(Exception param_0000e567); // 0x0000000180512650-0x00000001805126B0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void lnjopNOBhuaRKiVQFMcqAgQPFJN(Exception param_0000e568); // 0x00000001805170A0-0x0000000180517100
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void HBDhQkuzifPZriThEpKvTAUIOJs(Exception param_0000e569); // 0x000000018050FED0-0x000000018050FF30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void WfJqObvMclFMRCKCczMhnQXSand(Exception param_0000e56a); // 0x00000001805126B0-0x0000000180512710
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void IKjuwUUlRDnScUiUdfOaCwquUts(Exception param_0000e56b); // 0x0000000180510380-0x00000001805103E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void OoUyvPYFKXXtxclqQWxQnwNfNRS(Exception param_0000e56c); // 0x0000000180512290-0x00000001805122F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void ADiipXCZmdRaXOJTswlCTxGhonwD(Exception param_0000e56d); // 0x000000018050ED60-0x000000018050EDC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool ysDyOMuGptHqmlSZXAOdikDwkxRC(); // 0x000000018051A890-0x000000018051A910
	}
}
