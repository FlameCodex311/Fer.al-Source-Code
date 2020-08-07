/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu] // 0x00000001802719F0-0x0000000180271A20
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 9435
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x00779B3B
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x00779B4B
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x00779B59
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x00779B65
		[SerializeField] // 0x0000000180271C90-0x0000000180271CE0
		[Tooltip] // 0x0000000180271C90-0x0000000180271CE0
		private InputManager_Base rewiredInputManager; // 0x70
		[SerializeField] // 0x0000000180271FE0-0x0000000180272020
		[Tooltip] // 0x0000000180271FE0-0x0000000180272020
		private bool useAllRewiredGamePlayers; // 0x78
		[SerializeField] // 0x0000000180272320-0x0000000180272360
		[Tooltip] // 0x0000000180272320-0x0000000180272360
		private bool useRewiredSystemPlayer; // 0x79
		[SerializeField] // 0x0000000180272650-0x0000000180272690
		[Tooltip] // 0x0000000180272650-0x0000000180272690
		private int[] rewiredPlayerIds; // 0x80
		[SerializeField] // 0x0000000180272910-0x0000000180272950
		[Tooltip] // 0x0000000180272910-0x0000000180272950
		private bool usePlayingPlayersOnly; // 0x88
		[SerializeField] // 0x0000000180273E80-0x0000000180273EC0
		[Tooltip] // 0x0000000180273E80-0x0000000180273EC0
		private List<Rewired.Components.PlayerMouse> playerMice; // 0x90
		[SerializeField] // 0x0000000180274050-0x0000000180274090
		[Tooltip] // 0x0000000180274050-0x0000000180274090
		private bool moveOneElementPerAxisPress; // 0x98
		[SerializeField] // 0x0000000180274400-0x0000000180274440
		[Tooltip] // 0x0000000180274400-0x0000000180274440
		private bool setActionsById; // 0x99
		[SerializeField] // 0x00000001802745B0-0x00000001802745F0
		[Tooltip] // 0x00000001802745B0-0x00000001802745F0
		private int horizontalActionId; // 0x9C
		[SerializeField] // 0x0000000180274740-0x0000000180274780
		[Tooltip] // 0x0000000180274740-0x0000000180274780
		private int verticalActionId; // 0xA0
		[SerializeField] // 0x0000000180274A70-0x0000000180274AB0
		[Tooltip] // 0x0000000180274A70-0x0000000180274AB0
		private int submitActionId; // 0xA4
		[SerializeField] // 0x0000000180274CC0-0x0000000180274D00
		[Tooltip] // 0x0000000180274CC0-0x0000000180274D00
		private int cancelActionId; // 0xA8
		[SerializeField] // 0x0000000180276320-0x0000000180276360
		[Tooltip] // 0x0000000180276320-0x0000000180276360
		private string m_HorizontalAxis; // 0xB0
		[SerializeField] // 0x0000000180276670-0x00000001802766B0
		[Tooltip] // 0x0000000180276670-0x00000001802766B0
		private string m_VerticalAxis; // 0xB8
		[SerializeField] // 0x00000001802768A0-0x00000001802768E0
		[Tooltip] // 0x00000001802768A0-0x00000001802768E0
		private string m_SubmitButton; // 0xC0
		[SerializeField] // 0x0000000180276AF0-0x0000000180276B30
		[Tooltip] // 0x0000000180276AF0-0x0000000180276B30
		private string m_CancelButton; // 0xC8
		[SerializeField] // 0x0000000180277010-0x0000000180277050
		[Tooltip] // 0x0000000180277010-0x0000000180277050
		private float m_InputActionsPerSecond; // 0xD0
		[SerializeField] // 0x00000001802771D0-0x0000000180277210
		[Tooltip] // 0x00000001802771D0-0x0000000180277210
		private float m_RepeatDelay; // 0xD4
		[SerializeField] // 0x00000001802773E0-0x0000000180277420
		[Tooltip] // 0x00000001802773E0-0x0000000180277420
		private bool m_allowMouseInput; // 0xD8
		[SerializeField] // 0x0000000180277810-0x0000000180277850
		[Tooltip] // 0x0000000180277810-0x0000000180277850
		private bool m_allowMouseInputIfTouchSupported; // 0xD9
		[SerializeField] // 0x0000000180277B60-0x0000000180277BA0
		[Tooltip] // 0x0000000180277B60-0x0000000180277BA0
		private bool m_allowTouchInput; // 0xDA
		[FormerlySerializedAs] // 0x0000000180277E30-0x0000000180277EA0
		[SerializeField] // 0x0000000180277E30-0x0000000180277EA0
		[Tooltip] // 0x0000000180277E30-0x0000000180277EA0
		private bool m_ForceModuleActive; // 0xDB
		[NonSerialized]
		private int[] playerIds; // 0xE0
		private bool recompiling; // 0xE8
		[NonSerialized]
		private bool isTouchSupported; // 0xE9
		[NonSerialized]
		private float m_PrevActionTime; // 0xEC
		[NonSerialized]
		private Vector2 m_LastMoveVector; // 0xF0
		[NonSerialized]
		private int m_ConsecutiveMoveCount; // 0xF8
		[NonSerialized]
		private bool m_HasFocus; // 0xFC
	
		// Properties
		public InputManager_Base RewiredInputManager { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		public bool UseAllRewiredGamePlayers { get; set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000181069B10-0x0000000181069B30
		public bool UseRewiredSystemPlayer { get; set; } // 0x0000000180968EF0-0x0000000180968F00 0x0000000181069B30-0x0000000181069B50
		public int[] RewiredPlayerIds { get; set; } // 0x00000001810692E0-0x0000000181069360 0x00000001810698C0-0x0000000181069970
		public bool UsePlayingPlayersOnly { get; set; } // 0x00000001804A0200-0x00000001804A0210 0x0000000180434D60-0x0000000180434D70
		public List<Rewired.Components.PlayerMouse> PlayerMice { get; set; } // 0x0000000181069280-0x00000001810692E0 0x0000000181069830-0x00000001810698C0
		public bool MoveOneElementPerAxisPress { get; set; } // 0x00000001803D3E90-0x00000001803D3EA0 0x00000001803D3F20-0x00000001803D3F30
		public bool allowMouseInput { get; set; } // 0x0000000180556810-0x0000000180556820 0x00000001805569D0-0x00000001805569E0
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x0000000181069370-0x0000000181069380 0x0000000181069CE0-0x0000000181069CF0
		public bool allowTouchInput { get; set; } // 0x0000000181069380-0x0000000181069390 0x0000000181069CF0-0x0000000181069D00
		public bool SetActionsById { get; set; } // 0x00000001803D3EC0-0x00000001803D3ED0 0x0000000181069970-0x0000000181069990
		public int HorizontalActionId { get; set; } // 0x00000001804DB9F0-0x00000001804DBA00 0x00000001810696B0-0x0000000181069830
		public int VerticalActionId { get; set; } // 0x0000000180476030-0x0000000180476040 0x0000000181069B50-0x0000000181069CD0
		public int SubmitActionId { get; set; } // 0x00000001807C4E60-0x00000001807C4E70 0x0000000181069990-0x0000000181069B10
		public int CancelActionId { get; set; } // 0x000000018072EFF0-0x000000018072F000 0x0000000181069530-0x00000001810696B0
		protected override bool isMouseSupported { get; } // 0x0000000181069390-0x0000000181069520 
		private bool isTouchAllowed { get; } // 0x0000000181069380-0x0000000181069390 
		[Obsolete] // 0x00000001802780F0-0x0000000180278120
		public bool allowActivationOnMobileDevice { get; set; } // 0x0000000181069360-0x0000000181069370 0x0000000181069CD0-0x0000000181069CE0
		public bool forceModuleActive { get; set; } // 0x0000000181069360-0x0000000181069370 0x0000000181069CD0-0x0000000181069CE0
		public float inputActionsPerSecond { get; set; } // 0x00000001805568F0-0x0000000180556900 0x00000001805569E0-0x00000001805569F0
		public float repeatDelay { get; set; } // 0x0000000181069520-0x0000000181069530 0x0000000181069F20-0x0000000181069F30
		public string horizontalAxis { get; set; } // 0x000000018067DD20-0x000000018067DD30 0x0000000181069E10-0x0000000181069F20
		public string verticalAxis { get; set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018106A040-0x000000018106A150
		public string submitButton { get; set; } // 0x0000000180529360-0x0000000180529370 0x0000000181069F30-0x000000018106A040
		public string cancelButton { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x0000000181069D00-0x0000000181069E10
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 9436
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting(); // 0x0000000181060190-0x00000001810601F0
			private PlayerSetting(PlayerSetting other); // 0x00000001810601F0-0x00000001810603C0
	
			// Methods
			public PlayerSetting Clone(); // 0x0000000181060130-0x0000000181060190
		}
	
		// Constructors
		private RewiredStandaloneInputModule(); // 0x00000001810690D0-0x0000000181069280
	
		// Methods
		protected override void Awake(); // 0x0000000181064280-0x00000001810643E0
		public override void UpdateModule(); // 0x0000000181068F60-0x00000001810690D0
		public override bool IsModuleSupported(); // 0x0000000180380B60-0x0000000180380B70
		public override bool ShouldActivateModule(); // 0x00000001810687C0-0x0000000181068E90
		public override void ActivateModule(); // 0x0000000181064190-0x0000000181064280
		public override void DeactivateModule(); // 0x00000001810646F0-0x0000000181064710
		public override void Process(); // 0x00000001810671A0-0x0000000181067460
		private bool ProcessTouchEvents(); // 0x0000000181065FF0-0x0000000181066AA0
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x0000000181066AA0-0x00000001810671A0
		private bool SendSubmitEventToSelectedObject(); // 0x0000000181067830-0x0000000181067AB0
		private Vector2 GetRawMoveVector(); // 0x0000000181064B00-0x0000000181064F20
		private bool SendMoveEventToSelectedObject(); // 0x0000000181067460-0x0000000181067830
		private void CheckButtonOrKeyMovement(float time, out bool downHorizontal, out bool downVertical); // 0x00000001810643E0-0x00000001810645B0
		private void ProcessMouseEvents(); // 0x0000000181065860-0x0000000181065A10
		private void ProcessMouseEvent(int playerId, int pointerIndex); // 0x0000000181065420-0x0000000181065860
		private bool SendUpdateEventToSelectedObject(); // 0x0000000181067AB0-0x0000000181067C20
		private void ProcessMousePress(MouseButtonEventData data); // 0x0000000181065A10-0x0000000181065FF0
		private void OnApplicationFocus(bool hasFocus); // 0x0000000180D11E60-0x0000000180D11E70
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x0000000181068E90-0x0000000181068F60
		protected override void OnDestroy(); // 0x0000000181065310-0x00000001810653A0
		protected override bool IsDefaultPlayer(int playerId); // 0x00000001810650E0-0x0000000181065310
		private void InitializeRewired(); // 0x0000000181064F20-0x00000001810650E0
		private void SetupRewiredVars(); // 0x0000000181068130-0x00000001810687C0
		private void SetUpRewiredPlayerMice(); // 0x0000000181067F80-0x0000000181068130
		private void SetUpRewiredActions(); // 0x0000000181067C20-0x0000000181067F80
		private bool GetButtonDown(Player player, int actionId); // 0x00000001810648F0-0x0000000181064930
		private bool GetNegativeButtonDown(Player player, int actionId); // 0x0000000181064AC0-0x0000000181064B00
		private float GetAxis(Player player, int actionId); // 0x00000001810648B0-0x00000001810648F0
		private void CheckEditorRecompile(); // 0x00000001810645B0-0x0000000181064680
		private void OnEditorRecompile(); // 0x00000001810653A0-0x0000000181065410
		private void ClearRewiredVars(); // 0x0000000181064680-0x00000001810646F0
		private bool DidAnyMouseMove(); // 0x0000000181064710-0x00000001810648B0
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex); // 0x0000000181064930-0x0000000181064AC0
		private void OnRewiredInitialized(); // 0x0000000181065410-0x0000000181065420
		private void OnRewiredShutDown(); // 0x0000000181064680-0x00000001810646F0
	}
}
