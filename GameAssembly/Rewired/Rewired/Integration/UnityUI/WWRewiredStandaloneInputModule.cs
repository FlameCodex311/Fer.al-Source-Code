/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu] // 0x0000000180111100-0x0000000180111130
	public class WWRewiredStandaloneInputModule : PointerInputModule // TypeDefIndex: 9271
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x00744E83
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x00744E93
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x00744EA1
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x00744EAD
		private int[] playerIds; // 0x58
		private bool recompiling; // 0x60
		private bool isTouchSupported; // 0x61
		[SerializeField] // 0x000000018010D3A0-0x000000018010D3E0
		[Tooltip] // 0x000000018010D3A0-0x000000018010D3E0
		private bool useAllRewiredGamePlayers; // 0x62
		[SerializeField] // 0x000000018010D760-0x000000018010D7A0
		[Tooltip] // 0x000000018010D760-0x000000018010D7A0
		private bool useRewiredSystemPlayer; // 0x63
		[SerializeField] // 0x000000018010DA90-0x000000018010DAD0
		[Tooltip] // 0x000000018010DA90-0x000000018010DAD0
		private int[] rewiredPlayerIds; // 0x68
		[SerializeField] // 0x000000018010DDF0-0x000000018010DE30
		[Tooltip] // 0x000000018010DDF0-0x000000018010DE30
		private bool usePlayingPlayersOnly; // 0x70
		[SerializeField] // 0x000000018010E270-0x000000018010E2B0
		[Tooltip] // 0x000000018010E270-0x000000018010E2B0
		private bool moveOneElementPerAxisPress; // 0x71
		private float m_PrevActionTime; // 0x74
		private MoveDirection m_LastMoveDirection; // 0x78
		private int m_ConsecutiveMoveCount; // 0x7C
		private Vector2 m_LastMousePosition; // 0x80
		private Vector2 m_MousePosition; // 0x88
		private bool m_HasFocus; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_HorizontalAxis; // 0x98
		[SerializeField] // 0x000000018010F3B0-0x000000018010F3F0
		[Tooltip] // 0x000000018010F3B0-0x000000018010F3F0
		private string m_VerticalAxis; // 0xA0
		[SerializeField] // 0x000000018010F660-0x000000018010F6A0
		[Tooltip] // 0x000000018010F660-0x000000018010F6A0
		private string m_SubmitButton; // 0xA8
		[SerializeField] // 0x000000018010F900-0x000000018010F940
		[Tooltip] // 0x000000018010F900-0x000000018010F940
		private string m_CancelButton; // 0xB0
		[SerializeField] // 0x0000000180112210-0x0000000180112250
		[Tooltip] // 0x0000000180112210-0x0000000180112250
		private float m_InputActionsPerSecond_min; // 0xB8
		[SerializeField] // 0x0000000180112400-0x0000000180112440
		[Tooltip] // 0x0000000180112400-0x0000000180112440
		private float m_InputActionsPerSecond_max; // 0xBC
		[SerializeField] // 0x0000000180112700-0x0000000180112740
		[Tooltip] // 0x0000000180112700-0x0000000180112740
		private float m_InputActionsPerSecondPerAction; // 0xC0
		[SerializeField] // 0x000000018010FF20-0x000000018010FF60
		[Tooltip] // 0x000000018010FF20-0x000000018010FF60
		private float m_RepeatDelay; // 0xC4
		[SerializeField] // 0x00000001801101C0-0x0000000180110200
		[Tooltip] // 0x00000001801101C0-0x0000000180110200
		private bool m_allowMouseInput; // 0xC8
		[SerializeField] // 0x0000000180110380-0x00000001801103C0
		[Tooltip] // 0x0000000180110380-0x00000001801103C0
		private bool m_allowMouseInputIfTouchSupported; // 0xC9
		[FormerlySerializedAs] // 0x0000000180110B00-0x0000000180110B70
		[SerializeField] // 0x0000000180110B00-0x0000000180110B70
		[Tooltip] // 0x0000000180110B00-0x0000000180110B70
		private bool m_ForceModuleActive; // 0xCA
	
		// Properties
		public bool UseAllRewiredGamePlayers { get; set; } // 0x0000000180AD7CB0-0x0000000180AD7CC0 0x0000000181BD11D0-0x0000000181BD11F0
		public bool UseRewiredSystemPlayer { get; set; } // 0x0000000180AD7CA0-0x0000000180AD7CB0 0x0000000181BD11F0-0x0000000181BD1210
		public int[] RewiredPlayerIds { get; set; } // 0x0000000181BD1020-0x0000000181BD10A0 0x0000000181BD1120-0x0000000181BD11D0
		public bool UsePlayingPlayersOnly { get; set; } // 0x0000000180545D70-0x0000000180545D80 0x0000000180545DC0-0x0000000180545DD0
		public bool MoveOneElementPerAxisPress { get; set; } // 0x00000001805459C0-0x00000001805459D0 0x0000000180545DA0-0x0000000180545DB0
		public bool allowMouseInput { get; set; } // 0x00000001804E7B40-0x00000001804E7B50 0x00000001804E7C20-0x00000001804E7C30
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x0000000181BD10B0-0x0000000181BD10C0 0x0000000181BD1220-0x0000000181BD1230
		private bool isMouseSupported { get; } // 0x0000000181BD10D0-0x0000000181BD1110 
		[Obsolete] // 0x0000000180110EC0-0x0000000180110EF0
		public bool allowActivationOnMobileDevice { get; set; } // 0x0000000181BD10A0-0x0000000181BD10B0 0x0000000181BD1210-0x0000000181BD1220
		public bool forceModuleActive { get; set; } // 0x0000000181BD10A0-0x0000000181BD10B0 0x0000000181BD1210-0x0000000181BD1220
		public float inputActionsPerSecondMin { get; set; } // 0x0000000181363A30-0x0000000181363A40 0x0000000181BD1240-0x0000000181BD1250
		public float inputActionsPerSecondMax { get; set; } // 0x0000000181363FF0-0x0000000181364000 0x0000000181BD1230-0x0000000181BD1240
		public float inputActionsPerSecondPerAction { get; set; } // 0x0000000181BD10C0-0x0000000181BD10D0 0x0000000181BD1250-0x0000000181BD1260
		public float repeatDelay { get; set; } // 0x0000000181BD1110-0x0000000181BD1120 0x0000000181BD1260-0x0000000181BD1270
		public string horizontalAxis { get; set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
		public string verticalAxis { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
		public string submitButton { get; set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
		public string cancelButton { get; set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
	
		// Constructors
		protected WWRewiredStandaloneInputModule(); // 0x0000000181BD0F60-0x0000000181BD1020
	
		// Methods
		protected override void Awake(); // 0x0000000181BCD7C0-0x0000000181BCD870
		public override void UpdateModule(); // 0x0000000181BD0D20-0x0000000181BD0F60
		public override bool IsModuleSupported(); // 0x00000001803C29F0-0x00000001803C2A00
		public override bool ShouldActivateModule(); // 0x0000000181BD07C0-0x0000000181BD0C40
		public override void ActivateModule(); // 0x0000000181BCD610-0x0000000181BCD7C0
		public override void DeactivateModule(); // 0x0000000181BCDB00-0x0000000181BCDB20
		public override void Process(); // 0x0000000181BCF970-0x0000000181BCFC10
		private bool ProcessTouchEvents(); // 0x0000000181BCE9E0-0x0000000181BCF270
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x0000000181BCF270-0x0000000181BCF970
		protected bool SendSubmitEventToSelectedObject(); // 0x0000000181BCFF80-0x0000000181BD0200
		private Vector2 GetRawMoveVector(); // 0x0000000181BCDB20-0x0000000181BCDF00
		protected bool SendMoveEventToSelectedObject(); // 0x0000000181BCFC10-0x0000000181BCFF80
		private bool CheckButtonOrKeyMovement(float time); // 0x0000000181BCD870-0x0000000181BCDA10
		protected void ProcessMouseEvent(); // 0x0000000181BCE380-0x0000000181BCE390
		protected void ProcessMouseEvent(int id); // 0x0000000181BCE070-0x0000000181BCE380
		protected bool SendUpdateEventToSelectedObject(); // 0x0000000181BD0200-0x0000000181BD0370
		protected void ProcessMousePress(MouseButtonEventData data); // 0x0000000181BCE390-0x0000000181BCE9E0
		protected virtual void OnApplicationFocus(bool hasFocus); // 0x00000001806FA350-0x00000001806FA360
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x0000000181BD0C40-0x0000000181BD0D20
		private void InitializeRewired(); // 0x0000000181BCDF00-0x0000000181BCE040
		private void SetupRewiredVars(); // 0x0000000181BD0370-0x0000000181BD07C0
		private void CheckEditorRecompile(); // 0x0000000181BCDA10-0x0000000181BCDAD0
		private void OnEditorRecompile(); // 0x0000000181BCE040-0x0000000181BCE070
		private void ClearRewiredVars(); // 0x0000000181BCDAD0-0x0000000181BCDB00
	}
}
