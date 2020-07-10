/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Components
{
	[Serializable]
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 5883
	{
		// Fields
		[CustomObfuscation] // 0x00000001800BD960-0x00000001800BD9C0
		[SerializeField] // 0x00000001800BD960-0x00000001800BD9C0
		[Tooltip] // 0x00000001800BD960-0x00000001800BD9C0
		private bool _defaultToCenter; // 0x58
		[CustomObfuscation] // 0x00000001800BDD10-0x00000001800BDD70
		[SerializeField] // 0x00000001800BDD10-0x00000001800BDD70
		[Tooltip] // 0x00000001800BDD10-0x00000001800BDD70
		private float _pointerSpeed; // 0x5C
		[CustomObfuscation] // 0x00000001800BF240-0x00000001800BF2A0
		[SerializeField] // 0x00000001800BF240-0x00000001800BF2A0
		[Tooltip] // 0x00000001800BF240-0x00000001800BF2A0
		private bool _useHardwarePointerPosition; // 0x60
		[CustomObfuscation] // 0x00000001800BF560-0x00000001800BF5C0
		[SerializeField] // 0x00000001800BF560-0x00000001800BF5C0
		[Tooltip] // 0x00000001800BF560-0x00000001800BF5C0
		private Rect _movementArea; // 0x64
		[CustomObfuscation] // 0x00000001800BF880-0x00000001800BF8E0
		[SerializeField] // 0x00000001800BF880-0x00000001800BF8E0
		[Tooltip] // 0x00000001800BF880-0x00000001800BF8E0
		private PlayerMouse.MovementAreaUnit _movementAreaUnit; // 0x74
		[CustomObfuscation] // 0x00000001800BFC70-0x00000001800BFCD0
		[SerializeField] // 0x00000001800BFC70-0x00000001800BFCD0
		[Tooltip] // 0x00000001800BFC70-0x00000001800BFCD0
		private ScreenPositionChangedHandler _onScreenPositionChanged; // 0x78
	
		// Properties
		private new Rewired.PlayerMouse source { get; } // 0x000000018190BBA0-0x000000018190BBF0 
		public bool defaultToCenter { get; set; } // 0x000000018190B540-0x000000018190B5D0 0x000000018190BF50-0x000000018190C000
		public ScreenRect movementArea { get; set; } // 0x000000018190B750-0x000000018190B880 0x000000018190C0C0-0x000000018190C170
		public PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; } // 0x000000018190B6D0-0x000000018190B750 0x000000018190C000-0x000000018190C0C0
		public Vector2 screenPosition { get; set; } // 0x000000018190BAF0-0x000000018190BBA0 0x000000018190C260-0x000000018190C310
		public Vector2 screenPositionPrev { get; } // 0x000000018190BA40-0x000000018190BAF0 
		public Vector2 screenPositionDelta { get; } // 0x000000018190B990-0x000000018190BA40 
		public PlayerController.MouseAxis xAxis { get; } // 0x000000018190BD00-0x000000018190BD80 
		public PlayerController.MouseAxis yAxis { get; } // 0x000000018190BD80-0x000000018190BE00 
		public PlayerController.MouseWheel wheel { get; } // 0x000000018190BC80-0x000000018190BD00 
		public PlayerController.Button leftButton { get; } // 0x000000018190B5D0-0x000000018190B650 
		public PlayerController.Button rightButton { get; } // 0x000000018190B910-0x000000018190B990 
		public PlayerController.Button middleButton { get; } // 0x000000018190B650-0x000000018190B6D0 
		public float pointerSpeed { get; set; } // 0x000000018190B880-0x000000018190B910 0x000000018190C170-0x000000018190C260
		public bool useHardwarePointerPosition { get; set; } // 0x000000018190BBF0-0x000000018190BC80 0x000000018190C310-0x000000018190C3C0
		bool IMouseInputSource.enabled { get; } // 0x000000018190AB10-0x000000018190ABA0 
		Vector2 IMouseInputSource.screenPosition { get; } // 0x000000018190ACE0-0x000000018190AD90 
		Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x000000018190AC30-0x000000018190ACE0 
		Vector2 IMouseInputSource.wheelDelta { get; } // 0x000000018190AD90-0x000000018190AE40 
		bool IMouseInputSource.locked { get; } // 0x000000018190ABA0-0x000000018190AC30 
		new bool IPlayerController.enabled { get; } // 0x00000001817D4210-0x00000001817D4220 
		new bool IPlayerController.enabled { set; } // 0x0000000181908670-0x0000000181908680
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent {
			add; // 0x000000018190B4B0-0x000000018190B540
			remove; // 0x000000018190BEC0-0x000000018190BF50
		}
	
		// Nested types
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2> // TypeDefIndex: 5884
		{
			// Constructors
			public ScreenPositionChangedHandler(); // 0x000000018045DB30-0x000000018045DB70
		}
	
		// Constructors
		public PlayerMouse(); // 0x000000018190B300-0x000000018190B4B0
	
		// Methods
		protected override void OnValidated(); // 0x000000018190A230-0x000000018190A930
		protected override void OnReset(); // 0x0000000181909FB0-0x000000018190A230
		protected override PlayerController CreateSource(object args); // 0x0000000181909A30-0x0000000181909F70
		protected override void Deinitialize(); // 0x0000000181909F70-0x0000000181909FB0
		protected override void Subscribe(); // 0x000000018190AE40-0x000000018190B090
		protected override void Unsubscribe(); // 0x000000018190B090-0x000000018190B300
		internal override List<ElementInfo> CreateDefaultElementInfos(); // 0x00000001819092A0-0x0000000181909A30
		private void npVtBgceAHVLlZaPfSMcUPDrKfH(Vector2 param_0000c89d); // 0x000000018190BE00-0x000000018190BEC0
		bool IMouseInputSource.GetButtonDown(int param_0000c89e); // 0x000000018190A930-0x000000018190A9D0
		bool IMouseInputSource.GetButtonUp(int param_0000c89f); // 0x000000018190A9D0-0x000000018190AA70
		bool IMouseInputSource.GetButton(int param_0000c8a0); // 0x000000018190AA70-0x000000018190AB10
	}
}
