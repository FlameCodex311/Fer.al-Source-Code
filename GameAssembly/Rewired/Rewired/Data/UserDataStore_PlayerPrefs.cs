/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Data
{
	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 9204
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x00744B45
		private const string logPrefix = "Rewired: "; // Metadata: 0x00744B62
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x00744B6F
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x00744D3C
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x00744D55
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x00744D59
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x00744D5D
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x00744D61
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x00744D65
		[SerializeField] // 0x00000001800FAB80-0x00000001800FABD0
		[Tooltip] // 0x00000001800FAB80-0x00000001800FABD0
		private bool isEnabled; // 0x18
		[SerializeField] // 0x00000001800FC040-0x00000001800FC090
		[Tooltip] // 0x00000001800FC040-0x00000001800FC090
		private bool loadDataOnStart; // 0x19
		[SerializeField] // 0x00000001800FC360-0x00000001800FC3B0
		[Tooltip] // 0x00000001800FC360-0x00000001800FC3B0
		private bool loadJoystickAssignments; // 0x1A
		[SerializeField] // 0x00000001800FC720-0x00000001800FC770
		[Tooltip] // 0x00000001800FC720-0x00000001800FC770
		private bool loadKeyboardAssignments; // 0x1B
		[SerializeField] // 0x00000001800FC950-0x00000001800FC9A0
		[Tooltip] // 0x00000001800FC950-0x00000001800FC9A0
		private bool loadMouseAssignments; // 0x1C
		[SerializeField] // 0x00000001800FCCD0-0x00000001800FCD20
		[Tooltip] // 0x00000001800FCCD0-0x00000001800FCD20
		private string playerPrefsKeyPrefix; // 0x20
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching; // 0x28
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending; // 0x29
		[NonSerialized]
		private bool wasJoystickEverDetected; // 0x2A
		[NonSerialized]
		private List<int> __allActionIds; // 0x30
		[NonSerialized]
		private string __allActionIdsString; // 0x38
	
		// Properties
		public bool IsEnabled { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public bool LoadDataOnStart { get; set; } // 0x000000018048F440-0x000000018048F450 0x000000018048F560-0x000000018048F570
		public bool LoadJoystickAssignments { get; set; } // 0x000000018048F450-0x000000018048F460 0x000000018048F570-0x000000018048F580
		public bool LoadKeyboardAssignments { get; set; } // 0x000000018048F460-0x000000018048F470 0x000000018048F580-0x000000018048F590
		public bool LoadMouseAssignments { get; set; } // 0x000000018036CB20-0x000000018036CB30 0x000000018036CBC0-0x000000018036CBD0
		public string PlayerPrefsKeyPrefix { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		private string playerPrefsKey_controllerAssignments { get; } // 0x00000001815C9360-0x00000001815C93B0 
		private bool loadControllerAssignments { get; } // 0x00000001815C9340-0x00000001815C9360 
		private List<int> allActionIds { get; } // 0x00000001815C9120-0x00000001815C9340 
		private string allActionIdsString { get; } // 0x00000001815C8FF0-0x00000001815C9120 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 9205
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 9206
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x00000001803951A0-0x00000001803951B0 
	
				// Constructors
				public PlayerInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x00000001815B87F0-0x00000001815B8890
				public bool ContainsJoystick(int joystickId); // 0x00000001815B8750-0x00000001815B87F0
			}
	
			public class JoystickInfo // TypeDefIndex: 9207
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x000000018036B6C0-0x000000018036B6D0
			public ControllerAssignmentSaveInfo(int playerCount); // 0x00000001815B0880-0x00000001815B0980
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x00000001815B07E0-0x00000001815B0880
			public bool ContainsPlayer(int playerId); // 0x00000001815B07C0-0x00000001815B07E0
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 9208
		{
			// Fields
			public readonly Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId); // 0x00000001815B86C0-0x00000001815B8750
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass78_0 // TypeDefIndex: 9209
		{
			// Fields
			public Joystick joystick; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__0(JoystickAssignmentHistoryInfo x); // 0x0000000181281C10-0x0000000181281C40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass78_1 // TypeDefIndex: 9210
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__1(JoystickAssignmentHistoryInfo x); // 0x00000001815C21D0-0x00000001815C2200
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass78_2 // TypeDefIndex: 9211
		{
			// Fields
			public Joystick match; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_2(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__2(JoystickAssignmentHistoryInfo x); // 0x0000000181281C10-0x0000000181281C40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object> // TypeDefIndex: 9212
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UserDataStore_PlayerPrefs <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815C1C30-0x00000001815C1D20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815C1D20-0x00000001815C1D70
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs(); // 0x00000001815C8FA0-0x00000001815C8FF0
	
		// Methods
		public override void Save(); // 0x00000001815C8CB0-0x00000001815C8D20
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C7820-0x00000001815C78E0
		public override void SaveControllerData(ControllerType controllerType, int controllerId); // 0x00000001815C78E0-0x00000001815C7980
		public override void SavePlayerData(int playerId); // 0x00000001815C8BC0-0x00000001815C8CB0
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x00000001815C82A0-0x00000001815C8420
		public override void Load(); // 0x00000001815C6B90-0x00000001815C6C00
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C45B0-0x00000001815C4670
		public override void LoadControllerData(ControllerType controllerType, int controllerId); // 0x00000001815C4510-0x00000001815C45B0
		public override void LoadPlayerData(int playerId); // 0x00000001815C6AB0-0x00000001815C6B90
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x00000001815C4F00-0x00000001815C5060
		protected override void OnInitialize(); // 0x00000001815C6D30-0x00000001815C6DE0
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x00000001815C6C00-0x00000001815C6CD0
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x00000001815C6CF0-0x00000001815C6D30
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x00000001815C6CD0-0x00000001815C6CF0
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x00000001815C7D50-0x00000001815C7DF0
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x00000001815C48B0-0x00000001815C4990
		private int LoadAll(); // 0x00000001815C40B0-0x00000001815C42A0
		private int LoadPlayerDataNow(int playerId); // 0x00000001815C6770-0x00000001815C6800
		private int LoadPlayerDataNow(Player player); // 0x00000001815C6800-0x00000001815C6AB0
		private int LoadAllJoystickCalibrationData(); // 0x00000001815C3E60-0x00000001815C40B0
		private int LoadJoystickCalibrationData(Joystick joystick); // 0x00000001815C6070-0x00000001815C6110
		private int LoadJoystickCalibrationData(int joystickId); // 0x00000001815C6110-0x00000001815C6210
		private int LoadJoystickData(int joystickId); // 0x00000001815C6210-0x00000001815C6460
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C4470-0x00000001815C44F0
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId); // 0x00000001815C44F0-0x00000001815C4510
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C4990-0x00000001815C4CF0
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x00000001815C4670-0x00000001815C48B0
		private int LoadInputBehaviors(int playerId); // 0x00000001815C5060-0x00000001815C52B0
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x00000001815C4CF0-0x00000001815C4DF0
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x00000001815C4DF0-0x00000001815C4F00
		private bool LoadControllerAssignmentsNow(); // 0x00000001815C43D0-0x00000001815C4470
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x00000001815C6460-0x00000001815C6770
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x00000001815C5310-0x00000001815C6070
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x00000001815C42A0-0x00000001815C43D0
		[IteratorStateMachine] // 0x00000001800FD150-0x00000001800FD1A0
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x00000001815C52B0-0x00000001815C5310
		private void SaveAll(); // 0x00000001815C70B0-0x00000001815C72A0
		private void SavePlayerDataNow(int playerId); // 0x00000001815C8B30-0x00000001815C8BC0
		private void SavePlayerDataNow(Player player); // 0x00000001815C8920-0x00000001815C8B30
		private void SaveAllJoystickCalibrationData(); // 0x00000001815C6E90-0x00000001815C70B0
		private void SaveJoystickCalibrationData(int joystickId); // 0x00000001815C8590-0x00000001815C8670
		private void SaveJoystickCalibrationData(Joystick joystick); // 0x00000001815C8670-0x00000001815C86F0
		private void SaveJoystickData(int joystickId); // 0x00000001815C86F0-0x00000001815C8920
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C77C0-0x00000001815C7820
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId); // 0x00000001815C7790-0x00000001815C77C0
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x00000001815C7F60-0x00000001815C8130
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId); // 0x00000001815C7DF0-0x00000001815C7F60
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x00000001815C7980-0x00000001815C7D50
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x00000001815C8420-0x00000001815C8590
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x00000001815C8130-0x00000001815C8250
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x00000001815C8250-0x00000001815C82A0
		private bool SaveControllerAssignments(); // 0x00000001815C72A0-0x00000001815C7790
		private bool ControllerAssignmentSaveDataExists(); // 0x00000001815C26C0-0x00000001815C2770
		private string GetBasePlayerPrefsKey(Player player); // 0x00000001815C2970-0x00000001815C29E0
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x00000001815C3300-0x00000001815C3410
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x00000001815C29E0-0x00000001815C2AF0
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x00000001815C2D90-0x00000001815C3300
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick); // 0x00000001815C3C90-0x00000001815C3DE0
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId); // 0x00000001815C3B30-0x00000001815C3C00
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x00000001815C3560-0x00000001815C36B0
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x00000001815C2AF0-0x00000001815C2D90
		private string GetJoystickCalibrationMapXml(Joystick joystick); // 0x00000001815C3DE0-0x00000001815C3E60
		private string GetInputBehaviorXml(Player player, int id); // 0x00000001815C3C00-0x00000001815C3C90
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x00000001815C2200-0x00000001815C26C0
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x00000001815C2770-0x00000001815C2970
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches); // 0x00000001815C8D20-0x00000001815C8FA0
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x00000001815C36B0-0x00000001815C3B30
		private void RefreshLayoutManager(int playerId); // 0x00000001815C6DE0-0x00000001815C6E90
		private static Type GetControllerMapType(ControllerType controllerType); // 0x00000001815C3410-0x00000001815C3560
	}
}
