/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu] // 0x0000000180278260-0x0000000180278290
	public class WWRewiredStandaloneInputModule : PointerInputModule // TypeDefIndex: 9437
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x00779B71
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x00779B81
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x00779B8F
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x00779B9B
		private int[] playerIds; // 0x58
		private bool recompiling; // 0x60
		private bool isTouchSupported; // 0x61
		[SerializeField] // 0x0000000180271FE0-0x0000000180272020
		[Tooltip] // 0x0000000180271FE0-0x0000000180272020
		private bool useAllRewiredGamePlayers; // 0x62
		[SerializeField] // 0x0000000180272320-0x0000000180272360
		[Tooltip] // 0x0000000180272320-0x0000000180272360
		private bool useRewiredSystemPlayer; // 0x63
		[SerializeField] // 0x0000000180272650-0x0000000180272690
		[Tooltip] // 0x0000000180272650-0x0000000180272690
		private int[] rewiredPlayerIds; // 0x68
		[SerializeField] // 0x0000000180272910-0x0000000180272950
		[Tooltip] // 0x0000000180272910-0x0000000180272950
		private bool usePlayingPlayersOnly; // 0x70
		[SerializeField] // 0x0000000180274050-0x0000000180274090
		[Tooltip] // 0x0000000180274050-0x0000000180274090
		private bool moveOneElementPerAxisPress; // 0x71
		private float m_PrevActionTime; // 0x74
		private MoveDirection m_LastMoveDirection; // 0x78
		private int m_ConsecutiveMoveCount; // 0x7C
		private Vector2 m_LastMousePosition; // 0x80
		private Vector2 m_MousePosition; // 0x88
		private bool m_HasFocus; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_HorizontalAxis; // 0x98
		[SerializeField] // 0x0000000180276670-0x00000001802766B0
		[Tooltip] // 0x0000000180276670-0x00000001802766B0
		private string m_VerticalAxis; // 0xA0
		[SerializeField] // 0x00000001802768A0-0x00000001802768E0
		[Tooltip] // 0x00000001802768A0-0x00000001802768E0
		private string m_SubmitButton; // 0xA8
		[SerializeField] // 0x0000000180276AF0-0x0000000180276B30
		[Tooltip] // 0x0000000180276AF0-0x0000000180276B30
		private string m_CancelButton; // 0xB0
		[SerializeField] // 0x0000000180279670-0x00000001802796B0
		[Tooltip] // 0x0000000180279670-0x00000001802796B0
		private float m_InputActionsPerSecond_min; // 0xB8
		[SerializeField] // 0x00000001802799A0-0x00000001802799E0
		[Tooltip] // 0x00000001802799A0-0x00000001802799E0
		private float m_InputActionsPerSecond_max; // 0xBC
		[SerializeField] // 0x0000000180279B50-0x0000000180279B90
		[Tooltip] // 0x0000000180279B50-0x0000000180279B90
		private float m_InputActionsPerSecondPerAction; // 0xC0
		[SerializeField] // 0x00000001802771D0-0x0000000180277210
		[Tooltip] // 0x00000001802771D0-0x0000000180277210
		private float m_RepeatDelay; // 0xC4
		[SerializeField] // 0x00000001802773E0-0x0000000180277420
		[Tooltip] // 0x00000001802773E0-0x0000000180277420
		private bool m_allowMouseInput; // 0xC8
		[SerializeField] // 0x0000000180277810-0x0000000180277850
		[Tooltip] // 0x0000000180277810-0x0000000180277850
		private bool m_allowMouseInputIfTouchSupported; // 0xC9
		[FormerlySerializedAs] // 0x0000000180277E30-0x0000000180277EA0
		[SerializeField] // 0x0000000180277E30-0x0000000180277EA0
		[Tooltip] // 0x0000000180277E30-0x0000000180277EA0
		private bool m_ForceModuleActive; // 0xCA
	
		// Properties
		public bool UseAllRewiredGamePlayers { get; set; } // 0x00000001810731A0-0x00000001810731B0 0x00000001810732F0-0x0000000181073310
		public bool UseRewiredSystemPlayer { get; set; } // 0x00000001810731B0-0x00000001810731C0 0x0000000181073310-0x0000000181073330
		public int[] RewiredPlayerIds { get; set; } // 0x0000000181073120-0x00000001810731A0 0x0000000181073240-0x00000001810732F0
		public bool UsePlayingPlayersOnly { get; set; } // 0x0000000180522FA0-0x0000000180522FB0 0x0000000180522FF0-0x0000000180523000
		public bool MoveOneElementPerAxisPress { get; set; } // 0x0000000180B929C0-0x0000000180B929D0 0x0000000180B92D60-0x0000000180B92D70
		public bool allowMouseInput { get; set; } // 0x0000000180AB93C0-0x0000000180AB93D0 0x0000000180AB93D0-0x0000000180AB93E0
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x00000001810731D0-0x00000001810731E0 0x0000000181073340-0x0000000181073350
		private bool isMouseSupported { get; } // 0x00000001810731F0-0x0000000181073230 
		[Obsolete] // 0x00000001802780F0-0x0000000180278120
		public bool allowActivationOnMobileDevice { get; set; } // 0x00000001810731C0-0x00000001810731D0 0x0000000181073330-0x0000000181073340
		public bool forceModuleActive { get; set; } // 0x00000001810731C0-0x00000001810731D0 0x0000000181073330-0x0000000181073340
		public float inputActionsPerSecondMin { get; set; } // 0x0000000180BEC230-0x0000000180BEC240 0x0000000181073360-0x0000000181073370
		public float inputActionsPerSecondMax { get; set; } // 0x0000000180BEC7F0-0x0000000180BEC800 0x0000000181073350-0x0000000181073360
		public float inputActionsPerSecondPerAction { get; set; } // 0x00000001810731E0-0x00000001810731F0 0x0000000181073370-0x0000000181073380
		public float repeatDelay { get; set; } // 0x0000000181073230-0x0000000181073240 0x0000000181073380-0x0000000181073390
		public string horizontalAxis { get; set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
		public string verticalAxis { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public string submitButton { get; set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
		public string cancelButton { get; set; } // 0x000000018067DD20-0x000000018067DD30 0x000000018067E630-0x000000018067E640
	
		// Constructors
		protected WWRewiredStandaloneInputModule(); // 0x0000000181073060-0x0000000181073120
	
		// Methods
		protected override void Awake(); // 0x000000018106F940-0x000000018106F9F0
		public override void UpdateModule(); // 0x0000000181072E20-0x0000000181073060
		public override bool IsModuleSupported(); // 0x0000000180380B60-0x0000000180380B70
		public override bool ShouldActivateModule(); // 0x00000001810728E0-0x0000000181072D50
		public override void ActivateModule(); // 0x000000018106F7A0-0x000000018106F940
		public override void DeactivateModule(); // 0x000000018106FC70-0x000000018106FC90
		public override void Process(); // 0x0000000181071AD0-0x0000000181071D70
		private bool ProcessTouchEvents(); // 0x0000000181070B40-0x00000001810713D0
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x00000001810713D0-0x0000000181071AD0
		protected bool SendSubmitEventToSelectedObject(); // 0x00000001810720E0-0x0000000181072350
		private Vector2 GetRawMoveVector(); // 0x000000018106FC90-0x0000000181070070
		protected bool SendMoveEventToSelectedObject(); // 0x0000000181071D70-0x00000001810720E0
		private bool CheckButtonOrKeyMovement(float time); // 0x000000018106F9F0-0x000000018106FB80
		protected void ProcessMouseEvent(); // 0x00000001810704E0-0x00000001810704F0
		protected void ProcessMouseEvent(int id); // 0x00000001810701E0-0x00000001810704E0
		protected bool SendUpdateEventToSelectedObject(); // 0x0000000181072350-0x00000001810724C0
		protected void ProcessMousePress(MouseButtonEventData data); // 0x00000001810704F0-0x0000000181070B40
		protected virtual void OnApplicationFocus(bool hasFocus); // 0x0000000180653490-0x00000001806534A0
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x0000000181072D50-0x0000000181072E20
		private void InitializeRewired(); // 0x0000000181070070-0x00000001810701B0
		private void SetupRewiredVars(); // 0x00000001810724C0-0x00000001810728E0
		private void CheckEditorRecompile(); // 0x000000018106FB80-0x000000018106FC40
		private void OnEditorRecompile(); // 0x00000001810701B0-0x00000001810701E0
		private void ClearRewiredVars(); // 0x000000018106FC40-0x000000018106FC70
	}
}
