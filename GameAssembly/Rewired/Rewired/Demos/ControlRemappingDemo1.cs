/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class ControlRemappingDemo1 : UnityEngine.MonoBehaviour // TypeDefIndex: 9380
	{
		// Fields
		private const float defaultModalWidth = 250f; // Metadata: 0x00779A57
		private const float defaultModalHeight = 200f; // Metadata: 0x00779A5B
		private const float assignmentTimeout = 5f; // Metadata: 0x00779A5F
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
		private class ControllerSelection // TypeDefIndex: 9381
		{
			// Fields
			private int _id; // 0x10
			private int _idPrev; // 0x14
			private ControllerType _type; // 0x18
			private ControllerType _typePrev; // 0x1C
	
			// Properties
			public int id { get; set; } // 0x0000000180387590-0x0000000180387930 0x0000000180DCAF50-0x0000000180DCAF60
			public ControllerType type { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x0000000180DCAF60-0x0000000180DCAF70
			public int idPrev { get; } // 0x00000001803FD2F0-0x00000001803FD300 
			public ControllerType typePrev { get; } // 0x00000001803FB770-0x00000001803FB780 
			public bool hasSelection { get; } // 0x0000000180DCAF40-0x0000000180DCAF50 
	
			// Constructors
			public ControllerSelection(); // 0x0000000180DCAF10-0x0000000180DCAF40
	
			// Methods
			public void Set(int id, ControllerType type); // 0x0000000180DCAEF0-0x0000000180DCAF10
			public void Clear(); // 0x0000000180DCAED0-0x0000000180DCAEF0
		}
	
		private class DialogHelper // TypeDefIndex: 9382
		{
			// Fields
			private const float openBusyDelay = 0.25f; // Metadata: 0x00779A63
			private const float closeBusyDelay = 0.1f; // Metadata: 0x00779A67
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
			private float busyTimer { get; } // 0x0000000180DCDDA0-0x0000000180DCDDE0 
			public bool enabled { get; set; } // 0x00000001809A8910-0x00000001809A8920 0x0000000180DCDDF0-0x0000000180DCDE50
			public DialogType type { get; set; } // 0x0000000180DCDDE0-0x0000000180DCDDF0 0x0000000180DCDE50-0x0000000180DCDEB0
			public bool busy { get; } // 0x000000018041B650-0x000000018041B660 
	
			// Nested types
			public enum DialogType // TypeDefIndex: 9383
			{
				None = 0,
				JoystickConflict = 1,
				ElementConflict = 2,
				KeyConflict = 3,
				DeleteAssignmentConfirmation = 10,
				AssignElement = 11
			}
	
			// Constructors
			public DialogHelper(); // 0x0000000180DCDD00-0x0000000180DCDDA0
	
			// Methods
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback); // 0x0000000180DCDAE0-0x0000000180DCDB60
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay); // 0x0000000180DCDA30-0x0000000180DCDAE0
			public void Update(); // 0x0000000180DCDBA0-0x0000000180DCDD00
			public void Draw(); // 0x0000000180DCD880-0x0000000180DCD9C0
			public void DrawConfirmButton(); // 0x0000000180DCD560-0x0000000180DCD5A0
			public void DrawConfirmButton(string title); // 0x0000000180DCD710-0x0000000180DCD830
			public void DrawConfirmButton(UserResponse response); // 0x0000000180DCD6C0-0x0000000180DCD710
			public void DrawConfirmButton(UserResponse response, string title); // 0x0000000180DCD5A0-0x0000000180DCD6C0
			public void DrawCancelButton(); // 0x0000000180DCD520-0x0000000180DCD560
			public void DrawCancelButton(string title); // 0x0000000180DCD410-0x0000000180DCD520
			public void Confirm(); // 0x0000000180DCD400-0x0000000180DCD410
			public void Confirm(UserResponse response); // 0x0000000180DCD370-0x0000000180DCD400
			public void Cancel(); // 0x0000000180DCD2B0-0x0000000180DCD330
			private void DrawWindow(int windowId); // 0x0000000180DCD830-0x0000000180DCD880
			private void UpdateTimers(); // 0x0000000180DCDB60-0x0000000180DCDBA0
			private void StartBusyTimer(float time); // 0x0000000180DCDA00-0x0000000180DCDA30
			private void Close(); // 0x0000000180DCD330-0x0000000180DCD370
			private void StateChanged(float delay); // 0x0000000180DCDA00-0x0000000180DCDA30
			private void Reset(); // 0x0000000180DCD9E0-0x0000000180DCDA00
			private void ResetTimers(); // 0x0000000180654F10-0x0000000180654F20
			public void FullReset(); // 0x0000000180DCD9C0-0x0000000180DCD9E0
		}
	
		private abstract class QueueEntry // TypeDefIndex: 9384
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <id>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private QueueActionType <queueActionType>k__BackingField; // 0x14
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private State <state>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private UserResponse <response>k__BackingField; // 0x1C
			private static int uidCounter; // 0x00
	
			// Properties
			public int id { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
			public QueueActionType queueActionType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
			public State state { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public UserResponse response { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
			protected static int nextId { get; } // 0x0000000180DD7B30-0x0000000180DD7B70 
	
			// Nested types
			public enum State // TypeDefIndex: 9385
			{
				Waiting = 0,
				Confirmed = 1,
				Canceled = 2
			}
	
			// Constructors
			public QueueEntry(QueueActionType queueActionType); // 0x0000000180DD7AD0-0x0000000180DD7B30
	
			// Methods
			public void Confirm(UserResponse response); // 0x0000000180DD7AC0-0x0000000180DD7AD0
			public void Cancel(); // 0x0000000180DD7AB0-0x0000000180DD7AC0
		}
	
		private class JoystickAssignmentChange : QueueEntry // TypeDefIndex: 9386
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <playerId>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <joystickId>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <assign>k__BackingField; // 0x28
	
			// Properties
			public int playerId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
			public int joystickId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
			public bool assign { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
	
			// Constructors
			public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign); // 0x0000000180DD2DC0-0x0000000180DD2E40
		}
	
		private class ElementAssignmentChange : QueueEntry // TypeDefIndex: 9387
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ElementAssignmentChangeType <changeType>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private InputMapper.Context <context>k__BackingField; // 0x28
	
			// Properties
			public ElementAssignmentChangeType changeType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
			public InputMapper.Context context { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
			// Constructors
			public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context); // 0x0000000180DD0310-0x0000000180DD0380
			public ElementAssignmentChange(ElementAssignmentChange other); // 0x0000000180DD0270-0x0000000180DD0310
		}
	
		private class FallbackJoystickIdentification : QueueEntry // TypeDefIndex: 9388
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <joystickId>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string <joystickName>k__BackingField; // 0x28
	
			// Properties
			public int joystickId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
			public string joystickName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
			// Constructors
			public FallbackJoystickIdentification(int joystickId, string joystickName); // 0x0000000180DD0A00-0x0000000180DD0A70
		}
	
		private class Calibration : QueueEntry // TypeDefIndex: 9389
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Player <player>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ControllerType <controllerType>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Joystick <joystick>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private CalibrationMap <calibrationMap>k__BackingField; // 0x38
			public int selectedElementIdentifierId; // 0x40
			public bool recording; // 0x44
	
			// Properties
			public Player player { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
			public ControllerType controllerType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
			public Joystick joystick { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
			public CalibrationMap calibrationMap { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	
			// Constructors
			public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap); // 0x0000000180DC27F0-0x0000000180DC2880
		}
	
		private struct WindowProperties // TypeDefIndex: 9390
		{
			// Fields
			public int windowId; // 0x00
			public Rect rect; // 0x04
			public Action<string, string> windowDrawDelegate; // 0x18
			public string title; // 0x20
			public string message; // 0x28
		}
	
		private enum QueueActionType // TypeDefIndex: 9391
		{
			None = 0,
			JoystickAssignment = 1,
			ElementAssignment = 2,
			FallbackJoystickIdentification = 3,
			Calibrate = 4
		}
	
		private enum ElementAssignmentChangeType // TypeDefIndex: 9392
		{
			Add = 0,
			Replace = 1,
			Remove = 2,
			ReassignOrRemove = 3,
			ConflictCheck = 4
		}
	
		public enum UserResponse // TypeDefIndex: 9393
		{
			Confirm = 0,
			Cancel = 1,
			Custom1 = 2,
			Custom2 = 3
		}
	
		// Constructors
		public ControlRemappingDemo1(); // 0x0000000180DCACD0-0x0000000180DCAD30
	
		// Methods
		private void Awake(); // 0x0000000180DC2880-0x0000000180DC2920
		private void OnEnable(); // 0x0000000180DC8C60-0x0000000180DC8D50
		private void OnDisable(); // 0x0000000180DC8C40-0x0000000180DC8C60
		private void Initialize(); // 0x0000000180DC8300-0x0000000180DC8530
		private void Setup(); // 0x0000000180DCAA30-0x0000000180DCAB60
		private void Subscribe(); // 0x0000000180DC8C60-0x0000000180DC8D50
		private void Unsubscribe(); // 0x0000000180DC8C40-0x0000000180DC8C60
		public void OnGUI(); // 0x0000000180DC8D50-0x0000000180DC93F0
		private void HandleMenuControl(); // 0x0000000180DC7F00-0x0000000180DC8030
		private void Close(); // 0x0000000180DC2A40-0x0000000180DC2A60
		private void Open(); // 0x0000000180DC9400-0x0000000180DC9410
		private void DrawInitialScreen(); // 0x0000000180DC6200-0x0000000180DC6490
		private void DrawPage(); // 0x0000000180DC76D0-0x0000000180DC7900
		private void DrawPlayerSelector(); // 0x0000000180DC7900-0x0000000180DC7CC0
		private void DrawMouseAssignment(); // 0x0000000180DC7260-0x0000000180DC76D0
		private void DrawJoystickSelector(); // 0x0000000180DC6590-0x0000000180DC6AC0
		private void DrawControllerSelector(); // 0x0000000180DC52A0-0x0000000180DC5980
		private void DrawCalibrateButton(); // 0x0000000180DC30D0-0x0000000180DC34D0
		private void DrawMapCategories(); // 0x0000000180DC6AC0-0x0000000180DC7070
		private void DrawCategoryActions(); // 0x0000000180DC4400-0x0000000180DC52A0
		private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180DC2BF0-0x0000000180DC2EA0
		private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap); // 0x0000000180DC6490-0x0000000180DC6590
		private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap); // 0x0000000180DC2EA0-0x0000000180DC30D0
		private void ShowDialog(); // 0x0000000180DCAB60-0x0000000180DCACD0
		private void DrawModalWindow(string title, string message); // 0x0000000180DC7140-0x0000000180DC7260
		private void DrawModalWindow_OkayOnly(string title, string message); // 0x0000000180DC7070-0x0000000180DC7140
		private void DrawElementAssignmentWindow(string title, string message); // 0x0000000180DC5D10-0x0000000180DC5FC0
		private void DrawElementAssignmentProtectedConflictWindow(string title, string message); // 0x0000000180DC5B60-0x0000000180DC5D10
		private void DrawElementAssignmentNormalConflictWindow(string title, string message); // 0x0000000180DC5980-0x0000000180DC5B60
		private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message); // 0x0000000180DC7CC0-0x0000000180DC7DC0
		private void DrawFallbackJoystickIdentificationWindow(string title, string message); // 0x0000000180DC5FC0-0x0000000180DC6200
		private void DrawCalibrationWindow(string title, string message); // 0x0000000180DC34D0-0x0000000180DC4400
		private void DialogResultCallback(int queueActionId, UserResponse response); // 0x0000000180DC2A60-0x0000000180DC2BF0
		private Rect GetScreenCenteredRect(float width, float height); // 0x0000000180DC7E50-0x0000000180DC7F00
		private void EnqueueAction(QueueEntry entry); // 0x0000000180DC7DC0-0x0000000180DC7E50
		private void ProcessQueue(); // 0x0000000180DCA2D0-0x0000000180DCA460
		private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry); // 0x0000000180DC9FE0-0x0000000180DCA2D0
		private bool ProcessElementAssignmentChange(ElementAssignmentChange entry); // 0x0000000180DC9960-0x0000000180DC9A40
		private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry); // 0x0000000180DCA660-0x0000000180DCA8B0
		private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry); // 0x0000000180DCA460-0x0000000180DCA660
		private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry); // 0x0000000180DC9410-0x0000000180DC9750
		private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry); // 0x0000000180DC9A40-0x0000000180DC9DE0
		private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry); // 0x0000000180DC9DE0-0x0000000180DC9FE0
		private bool ProcessCalibration(Calibration entry); // 0x0000000180DC9750-0x0000000180DC9960
		private void PlayerSelectionChanged(); // 0x0000000180DC2920-0x0000000180DC2960
		private void ControllerSelectionChanged(); // 0x0000000180DC2960-0x0000000180DC2970
		private void ClearControllerSelection(); // 0x0000000180DC2920-0x0000000180DC2960
		private void ClearMapSelection(); // 0x0000000180DC2960-0x0000000180DC2970
		private void ResetAll(); // 0x0000000180DCA8B0-0x0000000180DCA8D0
		private void ClearWorkingVars(); // 0x0000000180DC2970-0x0000000180DC2A40
		private void SetGUIStateStart(); // 0x0000000180DCA960-0x0000000180DCAA30
		private void SetGUIStateEnd(); // 0x0000000180DCA8D0-0x0000000180DCA960
		private void JoystickConnected(ControllerStatusChangedEventArgs args); // 0x0000000180DC8530-0x0000000180DC8850
		private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args); // 0x0000000180DC88D0-0x0000000180DC8C40
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args); // 0x0000000180DC8850-0x0000000180DC88D0
		private void OnConflictFound(InputMapper.ConflictFoundEventData data); // 0x00000001803FA0C0-0x00000001803FA0D0
		private void OnStopped(InputMapper.StoppedEventData data); // 0x0000000180DC93F0-0x0000000180DC9400
		public void IdentifyAllJoysticks(); // 0x0000000180DC8030-0x0000000180DC8300
		protected void CheckRecompile(); // 0x00000001803774A0-0x00000001803774B0
		private void RecompileWindow(int windowId); // 0x00000001803774A0-0x00000001803774B0
	}
}
