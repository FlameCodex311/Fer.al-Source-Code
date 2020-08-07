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

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Data
{
	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 9370
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x00779833
		private const string logPrefix = "Rewired: "; // Metadata: 0x00779850
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x0077985D
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x00779A2A
		private const int controllerMapPPKeyVersion_original = 0; // Metadata: 0x00779A43
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; // Metadata: 0x00779A47
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; // Metadata: 0x00779A4B
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2; // Metadata: 0x00779A4F
		private const int controllerMapPPKeyVersion = 2; // Metadata: 0x00779A53
		[SerializeField] // 0x000000018025A240-0x000000018025A290
		[Tooltip] // 0x000000018025A240-0x000000018025A290
		private bool isEnabled; // 0x18
		[SerializeField] // 0x000000018025A4A0-0x000000018025A4F0
		[Tooltip] // 0x000000018025A4A0-0x000000018025A4F0
		private bool loadDataOnStart; // 0x19
		[SerializeField] // 0x000000018025A7A0-0x000000018025A7F0
		[Tooltip] // 0x000000018025A7A0-0x000000018025A7F0
		private bool loadJoystickAssignments; // 0x1A
		[SerializeField] // 0x000000018025BC80-0x000000018025BCD0
		[Tooltip] // 0x000000018025BC80-0x000000018025BCD0
		private bool loadKeyboardAssignments; // 0x1B
		[SerializeField] // 0x000000018025BE10-0x000000018025BE60
		[Tooltip] // 0x000000018025BE10-0x000000018025BE60
		private bool loadMouseAssignments; // 0x1C
		[SerializeField] // 0x000000018025C1D0-0x000000018025C220
		[Tooltip] // 0x000000018025C1D0-0x000000018025C220
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
		public bool IsEnabled { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public bool LoadDataOnStart { get; set; } // 0x0000000180690340-0x0000000180690350 0x0000000180878500-0x0000000180878510
		public bool LoadJoystickAssignments { get; set; } // 0x0000000180592780-0x0000000180592790 0x00000001809A61F0-0x00000001809A6200
		public bool LoadKeyboardAssignments { get; set; } // 0x00000001809A6100-0x00000001809A6110 0x00000001809A6200-0x00000001809A6210
		public bool LoadMouseAssignments { get; set; } // 0x000000018041B650-0x000000018041B660 0x000000018041B6E0-0x000000018041B6F0
		public string PlayerPrefsKeyPrefix { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		private string playerPrefsKey_controllerAssignments { get; } // 0x0000000180DDF150-0x0000000180DDF1A0 
		private bool loadControllerAssignments { get; } // 0x0000000180DDF130-0x0000000180DDF150 
		private List<int> allActionIds { get; } // 0x0000000180DDEF10-0x0000000180DDF130 
		private string allActionIdsString { get; } // 0x0000000180DDEDF0-0x0000000180DDEF10 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 9371
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 9372
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { get; } // 0x00000001805EF540-0x00000001805EF550 
	
				// Constructors
				public PlayerInfo(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public int IndexOfJoystick(int joystickId); // 0x0000000180DD2F60-0x0000000180DD2FF0
				public bool ContainsJoystick(int joystickId); // 0x0000000180DD2ED0-0x0000000180DD2F60
			}
	
			public class JoystickInfo // TypeDefIndex: 9373
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo(); // 0x0000000180373240-0x0000000180373250
			public ControllerAssignmentSaveInfo(int playerCount); // 0x0000000180DCADE0-0x0000000180DCAED0
	
			// Methods
			public int IndexOfPlayer(int playerId); // 0x0000000180DCAD50-0x0000000180DCADE0
			public bool ContainsPlayer(int playerId); // 0x0000000180DCAD30-0x0000000180DCAD50
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 9374
		{
			// Fields
			public readonly Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId); // 0x0000000180DD2E40-0x0000000180DD2ED0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass78_0 // TypeDefIndex: 9375
		{
			// Fields
			public Joystick joystick; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__0(JoystickAssignmentHistoryInfo x); // 0x0000000180786E80-0x0000000180786EA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass78_1 // TypeDefIndex: 9376
		{
			// Fields
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__1(JoystickAssignmentHistoryInfo x); // 0x0000000180DD8320-0x0000000180DD8350
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass78_2 // TypeDefIndex: 9377
		{
			// Fields
			public Joystick match; // 0x10
	
			// Constructors
			public <>c__DisplayClass78_2(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <LoadJoystickAssignmentsNow>b__2(JoystickAssignmentHistoryInfo x); // 0x0000000180786E80-0x0000000180786EA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object> // TypeDefIndex: 9378
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UserDataStore_PlayerPrefs <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DD81C0-0x0000000180DD82B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DD82B0-0x0000000180DD8300
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs(); // 0x0000000180DDEDA0-0x0000000180DDEDF0
	
		// Methods
		public override void Save(); // 0x0000000180DDEAB0-0x0000000180DDEB20
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDD670-0x0000000180DDD730
		public override void SaveControllerData(ControllerType controllerType, int controllerId); // 0x0000000180DDD730-0x0000000180DDD7D0
		public override void SavePlayerData(int playerId); // 0x0000000180DDE9C0-0x0000000180DDEAB0
		public override void SaveInputBehavior(int playerId, int behaviorId); // 0x0000000180DDE0C0-0x0000000180DDE240
		public override void Load(); // 0x0000000180DDCA20-0x0000000180DDCA90
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDA590-0x0000000180DDA650
		public override void LoadControllerData(ControllerType controllerType, int controllerId); // 0x0000000180DDA4F0-0x0000000180DDA590
		public override void LoadPlayerData(int playerId); // 0x0000000180DDC940-0x0000000180DDCA20
		public override void LoadInputBehavior(int playerId, int behaviorId); // 0x0000000180DDAE50-0x0000000180DDAFA0
		protected override void OnInitialize(); // 0x0000000180DDCBA0-0x0000000180DDCC50
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x0000000180DDCA90-0x0000000180DDCB50
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x0000000180DDCB70-0x0000000180DDCBA0
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x0000000180DDCB50-0x0000000180DDCB70
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x0000000180DDDB80-0x0000000180DDDC20
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x0000000180DDA820-0x0000000180DDA900
		private int LoadAll(); // 0x0000000180DDA090-0x0000000180DDA280
		private int LoadPlayerDataNow(int playerId); // 0x0000000180DDC620-0x0000000180DDC6A0
		private int LoadPlayerDataNow(Player player); // 0x0000000180DDC6A0-0x0000000180DDC940
		private int LoadAllJoystickCalibrationData(); // 0x0000000180DD9E40-0x0000000180DDA090
		private int LoadJoystickCalibrationData(Joystick joystick); // 0x0000000180DDBF40-0x0000000180DDBFE0
		private int LoadJoystickCalibrationData(int joystickId); // 0x0000000180DDBFE0-0x0000000180DDC0E0
		private int LoadJoystickData(int joystickId); // 0x0000000180DDC0E0-0x0000000180DDC320
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDA450-0x0000000180DDA4D0
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId); // 0x0000000180DDA4D0-0x0000000180DDA4F0
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDA900-0x0000000180DDAC50
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x0000000180DDA650-0x0000000180DDA820
		private int LoadInputBehaviors(int playerId); // 0x0000000180DDAFA0-0x0000000180DDB1E0
		private int LoadInputBehaviorNow(int playerId, int behaviorId); // 0x0000000180DDAC50-0x0000000180DDAD40
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x0000000180DDAD40-0x0000000180DDAE50
		private bool LoadControllerAssignmentsNow(); // 0x0000000180DDA3B0-0x0000000180DDA450
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x0000000180DDC320-0x0000000180DDC620
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data); // 0x0000000180DDB240-0x0000000180DDBF40
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData(); // 0x0000000180DDA280-0x0000000180DDA3B0
		[IteratorStateMachine] // 0x000000018025C380-0x000000018025C3D0
		private IEnumerator LoadJoystickAssignmentsDeferred(); // 0x0000000180DDB1E0-0x0000000180DDB240
		private void SaveAll(); // 0x0000000180DDCF20-0x0000000180DDD110
		private void SavePlayerDataNow(int playerId); // 0x0000000180DDE930-0x0000000180DDE9C0
		private void SavePlayerDataNow(Player player); // 0x0000000180DDE730-0x0000000180DDE930
		private void SaveAllJoystickCalibrationData(); // 0x0000000180DDCD00-0x0000000180DDCF20
		private void SaveJoystickCalibrationData(int joystickId); // 0x0000000180DDE3B0-0x0000000180DDE490
		private void SaveJoystickCalibrationData(Joystick joystick); // 0x0000000180DDE490-0x0000000180DDE510
		private void SaveJoystickData(int joystickId); // 0x0000000180DDE510-0x0000000180DDE730
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDD610-0x0000000180DDD670
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId); // 0x0000000180DDD5E0-0x0000000180DDD610
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData); // 0x0000000180DDDD80-0x0000000180DDDF50
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId); // 0x0000000180DDDC20-0x0000000180DDDD80
		private void SaveControllerMap(Player player, ControllerMap controllerMap); // 0x0000000180DDD7D0-0x0000000180DDDB80
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData); // 0x0000000180DDE240-0x0000000180DDE3B0
		private void SaveInputBehaviorNow(int playerId, int behaviorId); // 0x0000000180DDDF50-0x0000000180DDE070
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior); // 0x0000000180DDE070-0x0000000180DDE0C0
		private bool SaveControllerAssignments(); // 0x0000000180DDD110-0x0000000180DDD5E0
		private bool ControllerAssignmentSaveDataExists(); // 0x0000000180DD87F0-0x0000000180DD88A0
		private string GetBasePlayerPrefsKey(Player player); // 0x0000000180DD8AA0-0x0000000180DD8B10
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x0000000180DD9370-0x0000000180DD9480
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x0000000180DD8B10-0x0000000180DD8C20
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion); // 0x0000000180DD8E30-0x0000000180DD9370
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick); // 0x0000000180DD9C70-0x0000000180DD9DC0
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId); // 0x0000000180DD9B10-0x0000000180DD9BE0
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x0000000180DD95D0-0x0000000180DD9690
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x0000000180DD8C20-0x0000000180DD8E30
		private string GetJoystickCalibrationMapXml(Joystick joystick); // 0x0000000180DD9DC0-0x0000000180DD9E40
		private string GetInputBehaviorXml(Player player, int id); // 0x0000000180DD9BE0-0x0000000180DD9C70
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds); // 0x0000000180DD8350-0x0000000180DD87F0
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo); // 0x0000000180DD88A0-0x0000000180DD8AA0
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches); // 0x0000000180DDEB20-0x0000000180DDEDA0
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier); // 0x0000000180DD9690-0x0000000180DD9B10
		private void RefreshLayoutManager(int playerId); // 0x0000000180DDCC50-0x0000000180DDCD00
		private static Type GetControllerMapType(ControllerType controllerType); // 0x0000000180DD9480-0x0000000180DD95D0
	}
}
