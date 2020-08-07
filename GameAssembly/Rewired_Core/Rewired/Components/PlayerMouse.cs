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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Components
{
	[Serializable]
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 6042
	{
		// Fields
		[CustomObfuscation] // 0x000000018021E660-0x000000018021E6C0
		[SerializeField] // 0x000000018021E660-0x000000018021E6C0
		[Tooltip] // 0x000000018021E660-0x000000018021E6C0
		private bool _defaultToCenter; // 0x58
		[CustomObfuscation] // 0x000000018021E9A0-0x000000018021EA00
		[SerializeField] // 0x000000018021E9A0-0x000000018021EA00
		[Tooltip] // 0x000000018021E9A0-0x000000018021EA00
		private float _pointerSpeed; // 0x5C
		[CustomObfuscation] // 0x000000018021EE00-0x000000018021EE60
		[SerializeField] // 0x000000018021EE00-0x000000018021EE60
		[Tooltip] // 0x000000018021EE00-0x000000018021EE60
		private bool _useHardwarePointerPosition; // 0x60
		[CustomObfuscation] // 0x000000018021F200-0x000000018021F260
		[SerializeField] // 0x000000018021F200-0x000000018021F260
		[Tooltip] // 0x000000018021F200-0x000000018021F260
		private Rect _movementArea; // 0x64
		[CustomObfuscation] // 0x000000018021F5A0-0x000000018021F600
		[SerializeField] // 0x000000018021F5A0-0x000000018021F600
		[Tooltip] // 0x000000018021F5A0-0x000000018021F600
		private PlayerMouse.MovementAreaUnit _movementAreaUnit; // 0x74
		[CustomObfuscation] // 0x000000018021F810-0x000000018021F870
		[SerializeField] // 0x000000018021F810-0x000000018021F870
		[Tooltip] // 0x000000018021F810-0x000000018021F870
		private ScreenPositionChangedHandler _onScreenPositionChanged; // 0x78
	
		// Properties
		private new Rewired.PlayerMouse source { get; } // 0x00000001810B1A10-0x00000001810B1A60 
		public bool defaultToCenter { get; set; } // 0x00000001810B1400-0x00000001810B1480 0x00000001810B1DB0-0x00000001810B1E60
		public ScreenRect movementArea { get; set; } // 0x00000001810B1600-0x00000001810B1730 0x00000001810B1F20-0x00000001810B1FD0
		public PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; } // 0x00000001810B1580-0x00000001810B1600 0x00000001810B1E60-0x00000001810B1F20
		public Vector2 screenPosition { get; set; } // 0x00000001810B1970-0x00000001810B1A10 0x00000001810B20C0-0x00000001810B2170
		public Vector2 screenPositionPrev { get; } // 0x00000001810B18D0-0x00000001810B1970 
		public Vector2 screenPositionDelta { get; } // 0x00000001810B1830-0x00000001810B18D0 
		public PlayerController.MouseAxis xAxis { get; } // 0x00000001810B1B60-0x00000001810B1BE0 
		public PlayerController.MouseAxis yAxis { get; } // 0x00000001810B1BE0-0x00000001810B1C60 
		public PlayerController.MouseWheel wheel { get; } // 0x00000001810B1AE0-0x00000001810B1B60 
		public PlayerController.Button leftButton { get; } // 0x00000001810B1480-0x00000001810B1500 
		public PlayerController.Button rightButton { get; } // 0x00000001810B17B0-0x00000001810B1830 
		public PlayerController.Button middleButton { get; } // 0x00000001810B1500-0x00000001810B1580 
		public float pointerSpeed { get; set; } // 0x00000001810B1730-0x00000001810B17B0 0x00000001810B1FD0-0x00000001810B20C0
		public bool useHardwarePointerPosition { get; set; } // 0x00000001810B1A60-0x00000001810B1AE0 0x00000001810B2170-0x00000001810B2220
		bool IMouseInputSource.enabled { get; } // 0x00000001810B09F0-0x00000001810B0A80 
		Vector2 IMouseInputSource.screenPosition { get; } // 0x00000001810B0BC0-0x00000001810B0C70 
		Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x00000001810B0B10-0x00000001810B0BC0 
		Vector2 IMouseInputSource.wheelDelta { get; } // 0x00000001810B0C70-0x00000001810B0D20 
		bool IMouseInputSource.locked { get; } // 0x00000001810B0A80-0x00000001810B0B10 
		new bool IPlayerController.enabled { get; } // 0x00000001810AE5B0-0x00000001810AE5C0 
		new bool IPlayerController.enabled { set; } // 0x00000001810AE5C0-0x00000001810AE5D0
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent {
			add; // 0x00000001810B1370-0x00000001810B1400
			remove; // 0x00000001810B1D20-0x00000001810B1DB0
		}
	
		// Nested types
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2> // TypeDefIndex: 6043
		{
			// Constructors
			public ScreenPositionChangedHandler(); // 0x00000001808E43E0-0x00000001808E4420
		}
	
		// Constructors
		public PlayerMouse(); // 0x00000001810B11C0-0x00000001810B1370
	
		// Methods
		protected override void OnValidated(); // 0x00000001810B0120-0x00000001810B0810
		protected override void OnReset(); // 0x00000001810AFEA0-0x00000001810B0120
		protected override PlayerController CreateSource(object args); // 0x00000001810AF930-0x00000001810AFE60
		protected override void Deinitialize(); // 0x00000001810AFE60-0x00000001810AFEA0
		protected override void Subscribe(); // 0x00000001810B0D20-0x00000001810B0F60
		protected override void Unsubscribe(); // 0x00000001810B0F60-0x00000001810B11C0
		internal override List<ElementInfo> CreateDefaultElementInfos(); // 0x00000001810AF1D0-0x00000001810AF930
		private void npVtBgceAHVLlZaPfSMcUPDrKfH(Vector2 param_0000cb0d); // 0x00000001810B1C60-0x00000001810B1D20
		bool IMouseInputSource.GetButtonDown(int param_0000cb0e); // 0x00000001810B0810-0x00000001810B08B0
		bool IMouseInputSource.GetButtonUp(int param_0000cb0f); // 0x00000001810B08B0-0x00000001810B0950
		bool IMouseInputSource.GetButton(int param_0000cb10); // 0x00000001810B0950-0x00000001810B09F0
	}
}
