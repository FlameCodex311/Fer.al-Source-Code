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

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu] // 0x000000018010CFF0-0x000000018010D020
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 9269
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x00744E4D
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x00744E5D
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x00744E6B
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x00744E77
		[SerializeField] // 0x000000018010D190-0x000000018010D1E0
		[Tooltip] // 0x000000018010D190-0x000000018010D1E0
		private InputManager_Base rewiredInputManager; // 0x70
		[SerializeField] // 0x000000018010D3A0-0x000000018010D3E0
		[Tooltip] // 0x000000018010D3A0-0x000000018010D3E0
		private bool useAllRewiredGamePlayers; // 0x78
		[SerializeField] // 0x000000018010D760-0x000000018010D7A0
		[Tooltip] // 0x000000018010D760-0x000000018010D7A0
		private bool useRewiredSystemPlayer; // 0x79
		[SerializeField] // 0x000000018010DA90-0x000000018010DAD0
		[Tooltip] // 0x000000018010DA90-0x000000018010DAD0
		private int[] rewiredPlayerIds; // 0x80
		[SerializeField] // 0x000000018010DDF0-0x000000018010DE30
		[Tooltip] // 0x000000018010DDF0-0x000000018010DE30
		private bool usePlayingPlayersOnly; // 0x88
		[SerializeField] // 0x000000018010E030-0x000000018010E070
		[Tooltip] // 0x000000018010E030-0x000000018010E070
		private List<Rewired.Components.PlayerMouse> playerMice; // 0x90
		[SerializeField] // 0x000000018010E270-0x000000018010E2B0
		[Tooltip] // 0x000000018010E270-0x000000018010E2B0
		private bool moveOneElementPerAxisPress; // 0x98
		[SerializeField] // 0x000000018010E5F0-0x000000018010E630
		[Tooltip] // 0x000000018010E5F0-0x000000018010E630
		private bool setActionsById; // 0x99
		[SerializeField] // 0x000000018010E910-0x000000018010E950
		[Tooltip] // 0x000000018010E910-0x000000018010E950
		private int horizontalActionId; // 0x9C
		[SerializeField] // 0x000000018010EB50-0x000000018010EB90
		[Tooltip] // 0x000000018010EB50-0x000000018010EB90
		private int verticalActionId; // 0xA0
		[SerializeField] // 0x000000018010ED90-0x000000018010EDD0
		[Tooltip] // 0x000000018010ED90-0x000000018010EDD0
		private int submitActionId; // 0xA4
		[SerializeField] // 0x000000018010EF80-0x000000018010EFC0
		[Tooltip] // 0x000000018010EF80-0x000000018010EFC0
		private int cancelActionId; // 0xA8
		[SerializeField] // 0x000000018010F1A0-0x000000018010F1E0
		[Tooltip] // 0x000000018010F1A0-0x000000018010F1E0
		private string m_HorizontalAxis; // 0xB0
		[SerializeField] // 0x000000018010F3B0-0x000000018010F3F0
		[Tooltip] // 0x000000018010F3B0-0x000000018010F3F0
		private string m_VerticalAxis; // 0xB8
		[SerializeField] // 0x000000018010F660-0x000000018010F6A0
		[Tooltip] // 0x000000018010F660-0x000000018010F6A0
		private string m_SubmitButton; // 0xC0
		[SerializeField] // 0x000000018010F900-0x000000018010F940
		[Tooltip] // 0x000000018010F900-0x000000018010F940
		private string m_CancelButton; // 0xC8
		[SerializeField] // 0x000000018010FC10-0x000000018010FC50
		[Tooltip] // 0x000000018010FC10-0x000000018010FC50
		private float m_InputActionsPerSecond; // 0xD0
		[SerializeField] // 0x000000018010FF20-0x000000018010FF60
		[Tooltip] // 0x000000018010FF20-0x000000018010FF60
		private float m_RepeatDelay; // 0xD4
		[SerializeField] // 0x00000001801101C0-0x0000000180110200
		[Tooltip] // 0x00000001801101C0-0x0000000180110200
		private bool m_allowMouseInput; // 0xD8
		[SerializeField] // 0x0000000180110380-0x00000001801103C0
		[Tooltip] // 0x0000000180110380-0x00000001801103C0
		private bool m_allowMouseInputIfTouchSupported; // 0xD9
		[SerializeField] // 0x0000000180110780-0x00000001801107C0
		[Tooltip] // 0x0000000180110780-0x00000001801107C0
		private bool m_allowTouchInput; // 0xDA
		[FormerlySerializedAs] // 0x0000000180110B00-0x0000000180110B70
		[SerializeField] // 0x0000000180110B00-0x0000000180110B70
		[Tooltip] // 0x0000000180110B00-0x0000000180110B70
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
		public InputManager_Base RewiredInputManager { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		public bool UseAllRewiredGamePlayers { get; set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000181BCA470-0x0000000181BCA490
		public bool UseRewiredSystemPlayer { get; set; } // 0x00000001804A24F0-0x00000001804A2500 0x0000000181BCA490-0x0000000181BCA4B0
		public int[] RewiredPlayerIds { get; set; } // 0x0000000181BC9C50-0x0000000181BC9CD0 0x0000000181BCA220-0x0000000181BCA2D0
		public bool UsePlayingPlayersOnly { get; set; } // 0x00000001804E88A0-0x00000001804E88B0 0x0000000180386220-0x0000000180386230
		public List<Rewired.Components.PlayerMouse> PlayerMice { get; set; } // 0x0000000181BC9BF0-0x0000000181BC9C50 0x0000000181BCA190-0x0000000181BCA220
		public bool MoveOneElementPerAxisPress { get; set; } // 0x000000018081DF30-0x000000018081DF40 0x000000018081F000-0x000000018081F010
		public bool allowMouseInput { get; set; } // 0x00000001809336D0-0x00000001809336E0 0x00000001809337E0-0x00000001809337F0
		public bool allowMouseInputIfTouchSupported { get; set; } // 0x0000000181BC9CD0-0x0000000181BC9CE0 0x0000000181BCA630-0x0000000181BCA640
		public bool allowTouchInput { get; set; } // 0x00000001819DFB70-0x00000001819DFB80 0x00000001819DFE50-0x00000001819DFE60
		public bool SetActionsById { get; set; } // 0x0000000180EE4B60-0x0000000180EE4B70 0x0000000181BCA2D0-0x0000000181BCA2F0
		public int HorizontalActionId { get; set; } // 0x0000000180751B90-0x0000000180751BA0 0x0000000181BCA010-0x0000000181BCA190
		public int VerticalActionId { get; set; } // 0x00000001804A36F0-0x00000001804A3700 0x0000000181BCA4B0-0x0000000181BCA630
		public int SubmitActionId { get; set; } // 0x00000001804A3700-0x00000001804A3710 0x0000000181BCA2F0-0x0000000181BCA470
		public int CancelActionId { get; set; } // 0x0000000180E08B10-0x0000000180E08B20 0x0000000181BC9E90-0x0000000181BCA010
		protected override bool isMouseSupported { get; } // 0x0000000181BC9CE0-0x0000000181BC9E80 
		private bool isTouchAllowed { get; } // 0x00000001819DFB70-0x00000001819DFB80 
		[Obsolete] // 0x0000000180110EC0-0x0000000180110EF0
		public bool allowActivationOnMobileDevice { get; set; } // 0x00000001819DFB60-0x00000001819DFB70 0x00000001819DFE40-0x00000001819DFE50
		public bool forceModuleActive { get; set; } // 0x00000001819DFB60-0x00000001819DFB70 0x00000001819DFE40-0x00000001819DFE50
		public float inputActionsPerSecond { get; set; } // 0x0000000180F44050-0x0000000180F44060 0x0000000180F44130-0x0000000180F44140
		public float repeatDelay { get; set; } // 0x0000000181BC9E80-0x0000000181BC9E90 0x0000000181BCA860-0x0000000181BCA870
		public string horizontalAxis { get; set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x0000000181BCA750-0x0000000181BCA860
		public string verticalAxis { get; set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x0000000181BCA980-0x0000000181BCAA90
		public string submitButton { get; set; } // 0x00000001804A1050-0x00000001804A1060 0x0000000181BCA870-0x0000000181BCA980
		public string cancelButton { get; set; } // 0x00000001804A2590-0x00000001804A25A0 0x0000000181BCA640-0x0000000181BCA750
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 9270
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting(); // 0x0000000181BC0B70-0x0000000181BC0BD0
			private PlayerSetting(PlayerSetting other); // 0x0000000181BC0BD0-0x0000000181BC0DB0
	
			// Methods
			public PlayerSetting Clone(); // 0x0000000181BC0B10-0x0000000181BC0B70
		}
	
		// Constructors
		private RewiredStandaloneInputModule(); // 0x0000000181BC9A40-0x0000000181BC9BF0
	
		// Methods
		protected override void Awake(); // 0x0000000181BC4B40-0x0000000181BC4CA0
		public override void UpdateModule(); // 0x0000000181BC98D0-0x0000000181BC9A40
		public override bool IsModuleSupported(); // 0x00000001803C29F0-0x00000001803C2A00
		public override bool ShouldActivateModule(); // 0x0000000181BC9100-0x0000000181BC97F0
		public override void ActivateModule(); // 0x0000000181BC4A40-0x0000000181BC4B40
		public override void DeactivateModule(); // 0x0000000181BC4FB0-0x0000000181BC4FD0
		public override void Process(); // 0x0000000181BC7A90-0x0000000181BC7D60
		private bool ProcessTouchEvents(); // 0x0000000181BC68E0-0x0000000181BC7390
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x0000000181BC7390-0x0000000181BC7A90
		private bool SendSubmitEventToSelectedObject(); // 0x0000000181BC8130-0x0000000181BC83C0
		private Vector2 GetRawMoveVector(); // 0x0000000181BC53C0-0x0000000181BC57E0
		private bool SendMoveEventToSelectedObject(); // 0x0000000181BC7D60-0x0000000181BC8130
		private void CheckButtonOrKeyMovement(float time, out bool downHorizontal, out bool downVertical); // 0x0000000181BC4CA0-0x0000000181BC4E70
		private void ProcessMouseEvents(); // 0x0000000181BC6140-0x0000000181BC6300
		private void ProcessMouseEvent(int playerId, int pointerIndex); // 0x0000000181BC5CF0-0x0000000181BC6140
		private bool SendUpdateEventToSelectedObject(); // 0x0000000181BC83C0-0x0000000181BC8530
		private void ProcessMousePress(MouseButtonEventData data); // 0x0000000181BC6300-0x0000000181BC68E0
		private void OnApplicationFocus(bool hasFocus); // 0x0000000180F7D9E0-0x0000000180F7D9F0
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x0000000181BC97F0-0x0000000181BC98D0
		protected override void OnDestroy(); // 0x0000000181BC5BE0-0x0000000181BC5C70
		protected override bool IsDefaultPlayer(int playerId); // 0x0000000181BC59A0-0x0000000181BC5BE0
		private void InitializeRewired(); // 0x0000000181BC57E0-0x0000000181BC59A0
		private void SetupRewiredVars(); // 0x0000000181BC8A50-0x0000000181BC9100
		private void SetUpRewiredPlayerMice(); // 0x0000000181BC88A0-0x0000000181BC8A50
		private void SetUpRewiredActions(); // 0x0000000181BC8530-0x0000000181BC88A0
		private bool GetButtonDown(Player player, int actionId); // 0x0000000181BC51B0-0x0000000181BC51F0
		private bool GetNegativeButtonDown(Player player, int actionId); // 0x0000000181BC5380-0x0000000181BC53C0
		private float GetAxis(Player player, int actionId); // 0x0000000181BC5170-0x0000000181BC51B0
		private void CheckEditorRecompile(); // 0x0000000181BC4E70-0x0000000181BC4F40
		private void OnEditorRecompile(); // 0x0000000181BC5C70-0x0000000181BC5CE0
		private void ClearRewiredVars(); // 0x0000000181BC4F40-0x0000000181BC4FB0
		private bool DidAnyMouseMove(); // 0x0000000181BC4FD0-0x0000000181BC5170
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex); // 0x0000000181BC51F0-0x0000000181BC5380
		private void OnRewiredInitialized(); // 0x0000000181BC5CE0-0x0000000181BC5CF0
		private void OnRewiredShutDown(); // 0x0000000181BC4F40-0x0000000181BC4FB0
	}
}
