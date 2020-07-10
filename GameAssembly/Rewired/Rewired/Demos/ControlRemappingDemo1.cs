/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class ControlRemappingDemo1 : UnityEngine.MonoBehaviour // TypeDefIndex: 9214
	{
		// Fields
		private const float defaultModalWidth = 250f; // Metadata: 0x00744D69
		private const float defaultModalHeight = 200f; // Metadata: 0x00744D6D
		private const float assignmentTimeout = 5f; // Metadata: 0x00744D71
		private DialogHelper dialog; // 0x18
		private InputMapper inputMapper; // 0x20
		private InputMapper.ConflictFoundEventData conflictFoundEventData; // 0x28
		private bool guiState; // 0x30
		private bool busy; // 0x31
		private bool pageGUIState; // 0x32
		private Player selectedPlayer; // 0x38
		private int selectedMapCategoryId; // 0x40
		private ControllerSelection selectedController; // 0x48
		private ControllerMap selectedMap; // 0x50
		private bool showMenu; // 0x58
		private bool startListening; // 0x59
		private Vector2 actionScrollPos; // 0x5C
		private Vector2 calibrateScrollPos; // 0x64
		private Queue<QueueEntry> actionQueue; // 0x70
		private bool setupFinished; // 0x78
		[NonSerialized]
		private bool initialized; // 0x79
		private bool isCompiling; // 0x7A
		private GUIStyle style_wordWrap; // 0x80
		private GUIStyle style_centeredBox; // 0x88
	
		// Nested types
		private class ControllerSelection // TypeDefIndex: 9215
		{
			// Fields
			private int _id; // 0x10
			private int _idPrev; // 0x14
			private ControllerType _type; // 0x18
			private ControllerType _typePrev; // 0x1C
	
			// Properties
			public int id { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x00000001815B0A00-0x00000001815B0A10
			public ControllerType type { get; set; } // 0x0000000180367710-0x0000000180367720 0x00000001815B0A10-0x00000001815B0A20
			public int idPrev { get; } // 0x0000000180372360-0x0000000180372370 
			public ControllerType typePrev { get; } // 0x000000018037E420-0x000000018037E430 
			public bool hasSelection { get; } // 0x00000001815B09F0-0x00000001815B0A00 
	
			// Constructors
			public ControllerSelection(); // 0x00000001815B09C0-0x00000001815B09F0
	
			// Methods
			public void Set(int id, ControllerType type); // 0x00000001815B09A0-0x00000001815B09C0
			public void Clear(); // 0x00000001815B0980-0x00000001815B09A0
		}
	
		private class DialogHelper // TypeDefIndex: 9216
		{
			// Fields
			private const float openBusyDelay = 0.25f; // Metadata: 0x00744D75
			private const float closeBusyDelay = 0.1f; // Metadata: 0x00744D79
			private DialogType _type; // 0x10
			private bool _enabled; // 0x14
			private float _busyTime; // 0x18
			private bool _busyTimerRunning; // 0x1C
			private Action<int> drawWindowDelegate; // 0x20
			private GUI.WindowFunction drawWindowFunction; // 0x28
			private WindowProperties windowProperties; // 0x30
			private int currentActionId; // 0x60
			private Action<int, UserResponse> resultCallback; // 0x68
	
			// Properties
			private float busyTimer { get; } // 0x00000001815B37F0-0x00000001815B3830 
			public bool enabled { get; set; } // 0x0000000180491CD0-0x0000000180491CE0 0x00000001815B3840-0x00000001815B38A0
			public DialogType type { get; set; } // 0x00000001815B3830-0x00000001815B3840 0x00000001815B38A0-0x00000001815B3900
			public bool busy { get; } // 0x000000018036CB20-0x000000018036CB30 
	
			// Nested types
			public enum DialogType // TypeDefIndex: 9217
			{
				None = 0,
				JoystickConflict = 1,
				ElementConflict = 2,
				KeyConflict = 3,
				DeleteAssignmentConfirmation = 10,
				AssignElement = 11
			}
	
			// Constructors
			public DialogHelper(); // 0x00000001815B3750-0x00000001815B37F0
	
			// Methods
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback); // 0x00000001815B3530-0x00000001815B35B0
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay); // 0x00000001815B3480-0x00000001815B3530
			public void Update(); // 0x00000001815B35F0-0x00000001815B3750
			public void Draw(); // 0x00000001815B32D0-0x00000001815B3410
			public void DrawConfirmButton(); // 0x00000001815B2FB0-0x00000001815B2FF0
			public void DrawConfirmButton(string title); // 0x00000001815B3160-0x00000001815B3280
			public void DrawConfirmButton(UserResponse response); // 0x00000001815B3110-0x00000001815B3160
			public void DrawConfirmButton(UserResponse response, string title); // 0x00000001815B2FF0-0x00000001815B3110
			public void DrawCancelButton(); // 0x00000001815B2F70-0x00000001815B2FB0
			public void DrawCancelButton(string title); // 0x00000001815B2E60-0x00000001815B2F70
			public void Confirm(); // 0x00000001815B2E50-0x00000001815B2E60
			public void Confirm(UserResponse response); // 0x00000001815B2DC0-0x00000001815B2E50
			public void Cancel(); // 0x00000001815B2D00-0x00000001815B2D80
			private void DrawWindow(int windowId); // 0x00000001815B3280-0x00000001815B32D0
			private void UpdateTimers(); // 0x00000001815B35B0-0x00000001815B35F0
			private void StartBusyTimer(float time); // 0x00000001815B3450-0x00000001815B3480
			private void Close(); // 0x00000001815B2D80-0x00000001815B2DC0
			private void StateChanged(float delay); // 0x00000001815B3450-0x00000001815B3480
			private void Reset(); // 0x00000001815B3430-0x00000001815B3450
			private void ResetTimers(); // 0x0000000181010080-0x0000000181010090
			public void FullReset(); // 0x00000001815B3410-0x00000001815B3430
		}
	
		private abstract class QueueEntry // TypeDefIndex: 9218
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <id>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private QueueActionType <queueActionType>k__BackingField; // 0x14
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private State <state>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private UserResponse <response>k__BackingField; // 0x1C
			private static int uidCounter; // 0x00
	
			// Properties
			public int id { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
			public QueueActionType queueActionType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
			public State state { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public UserResponse response { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
			protected static int nextId { get; } // 0x00000001815BE370-0x00000001815BE3B0 
	
			// Nested types
			public enum State // TypeDefIndex: 9219
			{
				Waiting = 0,
				Confirmed = 1,
				Canceled = 2
			}
	
			// Constructors
			public QueueEntry(QueueActionType queueActionType); // 0x00000001815BE310-0x00000001815BE370
	
			// Methods
			public void Confirm(UserResponse response); // 0x00000001815BE300-0x00000001815BE310
			public void Cancel(); // 0x00000001815BE2F0-0x00000001815BE300
		}
	
		private class JoystickAssignmentChange : QueueEntry // TypeDefIndex: 9220
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <playerId>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <joystickId>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <assign>k__BackingField; // 0x28
	
			// Properties
			public int playerId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
			public int joystickId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
			public bool assign { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803A2790-0x00000001803A27A0 0x00000001803A2840-0x00000001803A2850
	
			// Constructors
			public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign); // 0x00000001815B8640-0x00000001815B86C0
		}
	
		private class ElementAssignmentChange : QueueEntry // TypeDefIndex: 9221
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private ElementAssignmentChangeType <changeType>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private InputMapper.Context <context>k__BackingField; // 0x28
	
			// Properties
			public ElementAssignmentChangeType changeType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
			public InputMapper.Context context { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
			// Constructors
			public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context); // 0x00000001815B5A60-0x00000001815B5AD0
			public ElementAssignmentChange(ElementAssignmentChange other); // 0x00000001815B59C0-0x00000001815B5A60
		}
	
		private class FallbackJoystickIdentification : QueueEntry // TypeDefIndex: 9222
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <joystickId>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <joystickName>k__BackingField; // 0x28
	
			// Properties
			public int joystickId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
			public string joystickName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
			// Constructors
			public FallbackJoystickIdentification(int joystickId, string joystickName); // 0x00000001815B6160-0x00000001815B61D0
		}
	
		private class Calibration : QueueEntry // TypeDefIndex: 9223
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Player <player>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private ControllerType <controllerType>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Joystick <joystick>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private CalibrationMap <calibrationMap>k__BackingField; // 0x38
			public int selectedElementIdentifierId; // 0x40
			public bool recording; // 0x44
	
			// Properties
			public Player player { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
			public ControllerType controllerType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
			public Joystick joystick { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
			public CalibrationMap calibrationMap { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	
			// Constructors
			public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap); // 0x00000001815A81A0-0x00000001815A8230
		}
	
		private struct WindowProperties // TypeDefIndex: 9224
		{
			// Fields
			public int windowId; // 0x00
			public Rect rect; // 0x04
			public Action<string, string> windowDrawDelegate; // 0x18
			public string title; // 0x20
			public string message; // 0x28
		}
	
		private enum QueueActionType // TypeDefIndex: 9225
		{
			None = 0,
			JoystickAssignment = 1,
			ElementAssignment = 2,
			FallbackJoystickIdentification = 3,
			Calibrate = 4
		}
	
		private enum ElementAssignmentChangeType // TypeDefIndex: 9226
		{
			Add = 0,
			Replace = 1,
			Remove = 2,
			ReassignOrRemove = 3,
			ConflictCheck = 4
		}
	
		public enum UserResponse // TypeDefIndex: 9227
		{
			Confirm = 0,
			Cancel = 1,
			Custom1 = 2,
			Custom2 = 3
		}
	
		// Constructors
		public ControlRemappingDemo1(); // 0x00000001815B0760-0x00000001815B07C0
	
		// Methods
		private void Awake(); // 0x00000001815A8230-0x00000001815A82D0
		private void OnEnable(); // 0x00000001815AE7F0-0x00000001815AE8E0
		private void OnDisable(); // 0x00000001815AE7D0-0x00000001815AE7F0
		private void Initialize(); // 0x00000001815ADE60-0x00000001815AE090
		private void Setup(); // 0x00000001815B04B0-0x00000001815B05F0
		private void Subscribe(); // 0x00000001815AE7F0-0x00000001815AE8E0
		private void Unsubscribe(); // 0x00000001815AE7D0-0x00000001815AE7F0
		public void OnGUI(); // 0x00000001815AE8E0-0x00000001815AEE30
		private void HandleMenuControl(); // 0x00000001815ADA40-0x00000001815ADB80
		private void Close(); // 0x00000001815A8400-0x00000001815A8420
		private void Open(); // 0x00000001810F6E90-0x00000001810F6EA0
		private void DrawInitialScreen(); // 0x00000001815ABCA0-0x00000001815ABF40
		private void DrawPage(); // 0x00000001815AD1F0-0x00000001815AD420
		private void DrawPlayerSelector(); // 0x00000001815AD420-0x00000001815AD800
		private void DrawMouseAssignment(); // 0x00000001815ACD60-0x00000001815AD1F0
		private void DrawJoystickSelector(); // 0x00000001815AC050-0x00000001815AC5A0
		private void DrawControllerSelector(); // 0x00000001815AACF0-0x00000001815AB400
		private void DrawCalibrateButton(); // 0x00000001815A8AB0-0x00000001815A8EC0
		private void DrawMapCategories(); // 0x00000001815AC5A0-0x00000001815ACB70
		private void DrawCategoryActions(); // 0x00000001815A9E50-0x00000001815AACF0
		private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001815A85B0-0x00000001815A8880
		private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap); // 0x00000001815ABF40-0x00000001815AC050
		private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap); // 0x00000001815A8880-0x00000001815A8AB0
		private void ShowDialog(); // 0x00000001815B05F0-0x00000001815B0760
		private void DrawModalWindow(string title, string message); // 0x00000001815ACC40-0x00000001815ACD60
		private void DrawModalWindow_OkayOnly(string title, string message); // 0x00000001815ACB70-0x00000001815ACC40
		private void DrawElementAssignmentWindow(string title, string message); // 0x00000001815AB7A0-0x00000001815ABA60
		private void DrawElementAssignmentProtectedConflictWindow(string title, string message); // 0x00000001815AB5E0-0x00000001815AB7A0
		private void DrawElementAssignmentNormalConflictWindow(string title, string message); // 0x00000001815AB400-0x00000001815AB5E0
		private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message); // 0x00000001815AD800-0x00000001815AD900
		private void DrawFallbackJoystickIdentificationWindow(string title, string message); // 0x00000001815ABA60-0x00000001815ABCA0
		private void DrawCalibrationWindow(string title, string message); // 0x00000001815A8EC0-0x00000001815A9E50
		private void DialogResultCallback(int queueActionId, UserResponse response); // 0x00000001815A8420-0x00000001815A85B0
		private Rect GetScreenCenteredRect(float width, float height); // 0x00000001815AD990-0x00000001815ADA40
		private void EnqueueAction(QueueEntry entry); // 0x00000001815AD900-0x00000001815AD990
		private void ProcessQueue(); // 0x00000001815AFD40-0x00000001815AFED0
		private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry); // 0x00000001815AFA40-0x00000001815AFD40
		private bool ProcessElementAssignmentChange(ElementAssignmentChange entry); // 0x00000001815AF3B0-0x00000001815AF490
		private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry); // 0x00000001815B00D0-0x00000001815B0330
		private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry); // 0x00000001815AFED0-0x00000001815B00D0
		private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry); // 0x00000001815AEE40-0x00000001815AF190
		private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry); // 0x00000001815AF490-0x00000001815AF830
		private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry); // 0x00000001815AF830-0x00000001815AFA40
		private bool ProcessCalibration(Calibration entry); // 0x00000001815AF190-0x00000001815AF3B0
		private void PlayerSelectionChanged(); // 0x00000001815A82D0-0x00000001815A8310
		private void ControllerSelectionChanged(); // 0x00000001815A8310-0x00000001815A8320
		private void ClearControllerSelection(); // 0x00000001815A82D0-0x00000001815A8310
		private void ClearMapSelection(); // 0x00000001815A8310-0x00000001815A8320
		private void ResetAll(); // 0x00000001815B0330-0x00000001815B0350
		private void ClearWorkingVars(); // 0x00000001815A8320-0x00000001815A8400
		private void SetGUIStateStart(); // 0x00000001815B03E0-0x00000001815B04B0
		private void SetGUIStateEnd(); // 0x00000001815B0350-0x00000001815B03E0
		private void JoystickConnected(ControllerStatusChangedEventArgs args); // 0x00000001815AE090-0x00000001815AE3C0
		private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args); // 0x00000001815AE440-0x00000001815AE7D0
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args); // 0x00000001815AE3C0-0x00000001815AE440
		private void OnConflictFound(InputMapper.ConflictFoundEventData data); // 0x0000000180422D30-0x0000000180422D40
		private void OnStopped(InputMapper.StoppedEventData data); // 0x00000001815AEE30-0x00000001815AEE40
		public void IdentifyAllJoysticks(); // 0x00000001815ADB80-0x00000001815ADE60
		protected void CheckRecompile(); // 0x00000001803581E0-0x00000001803581F0
		private void RecompileWindow(int windowId); // 0x00000001803581E0-0x00000001803581F0
	}
}
