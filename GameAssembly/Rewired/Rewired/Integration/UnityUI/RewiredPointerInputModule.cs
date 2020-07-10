/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Integration.UnityUI
{
	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 9263
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x00744E29
		public const int kMouseRightId = -2; // Metadata: 0x00744E2D
		public const int kMouseMiddleId = -3; // Metadata: 0x00744E31
		public const int kFakeTouchesId = -4; // Metadata: 0x00744E35
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x00744E39
		private const int customButtonsMaxCount = 128; // Metadata: 0x00744E3D
		private const int customButtonsLastId = -2147483392; // Metadata: 0x00744E41
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x0000000181BC4860-0x0000000181BC48D0 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x0000000181BC4860-0x0000000181BC48D0 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x0000000181BC4860-0x0000000181BC48D0 
		protected virtual bool isMouseSupported { get; } // 0x0000000181BC48D0-0x0000000181BC4A40 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 9264
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x0000000181BC0880-0x0000000181BC08E0
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x0000000181BC04F0-0x0000000181BC05D0
			public bool AnyReleasesThisFrame(); // 0x0000000181BC05D0-0x0000000181BC06B0
			public ButtonState GetButtonState(int button); // 0x0000000181BC06B0-0x0000000181BC0820
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data); // 0x0000000181BC0820-0x0000000181BC0880
		}
	
		public class MouseButtonEventData // TypeDefIndex: 9265
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool PressedThisFrame(); // 0x00000001818689D0-0x00000001818689F0
			public bool ReleasedThisFrame(); // 0x00000001818689F0-0x0000000181868A00
		}
	
		protected class ButtonState // TypeDefIndex: 9266
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
			public int button { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
	
			// Constructors
			public ButtonState(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 9267
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get; } // 0x0000000181BCD320-0x0000000181BCD340 
			int ITouchInputSource.playerId { get; } // 0x0000000181BCD320-0x0000000181BCD340 
			bool IMouseInputSource.enabled { get; } // 0x0000000181BCD2E0-0x0000000181BCD300 
			bool IMouseInputSource.locked { get; } // 0x0000000181BCD300-0x0000000181BCD320 
			int IMouseInputSource.buttonCount { get; } // 0x0000000181BCD2C0-0x0000000181BCD2E0 
			Vector2 IMouseInputSource.screenPosition { get; } // 0x0000000181BCD3D0-0x0000000181BCD460 
			Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x0000000181BCD340-0x0000000181BCD3D0 
			Vector2 IMouseInputSource.wheelDelta { get; } // 0x0000000181BCD460-0x0000000181BCD480 
			bool ITouchInputSource.touchSupported { get; } // 0x0000000181BCD510-0x0000000181BCD530 
			int ITouchInputSource.touchCount { get; } // 0x0000000181BCD4F0-0x0000000181BCD510 
	
			// Constructors
			public UnityInputSource(); // 0x0000000181BCD600-0x0000000181BCD610
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button); // 0x0000000181BCD260-0x0000000181BCD280
			bool IMouseInputSource.GetButtonUp(int button); // 0x0000000181BCD280-0x0000000181BCD2A0
			bool IMouseInputSource.GetButton(int button); // 0x0000000181BCD2A0-0x0000000181BCD2C0
			Touch ITouchInputSource.GetTouch(int index); // 0x0000000181BCD480-0x0000000181BCD4F0
			private void TryUpdate(); // 0x0000000181BCD530-0x0000000181BCD600
		}
	
		// Constructors
		protected RewiredPointerInputModule(); // 0x0000000181BC4770-0x0000000181BC4860
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse); // 0x0000000181BC38B0-0x0000000181BC3930
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex); // 0x0000000181BC2300-0x0000000181BC24D0
		public void RemoveMouseInputSource(IMouseInputSource source); // 0x0000000181BC3FF0-0x0000000181BC4080
		public void AddMouseInputSource(IMouseInputSource source); // 0x0000000181BC1890-0x0000000181BC1950
		public int GetMouseInputSourceCount(int playerId); // 0x0000000181BC2180-0x0000000181BC2300
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex); // 0x0000000181BC34A0-0x0000000181BC3570
		public void RemoveTouchInputSource(ITouchInputSource source); // 0x0000000181BC4140-0x0000000181BC41C0
		public void AddTouchInputSource(ITouchInputSource source); // 0x0000000181BC1950-0x0000000181BC19F0
		public int GetTouchInputSourceCount(int playerId); // 0x0000000181BC3470-0x0000000181BC34A0
		protected void ClearMouseInputSources(); // 0x0000000181BC19F0-0x0000000181BC1A40
		protected abstract bool IsDefaultPlayer(int playerId);
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType); // 0x0000000181BC2F40-0x0000000181BC3470
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType); // 0x0000000181BC1D60-0x0000000181BC1E90
		protected void RemovePointerData(PlayerPointerEventData data); // 0x0000000181BC4080-0x0000000181BC4140
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released); // 0x0000000181BC3570-0x0000000181BC38B0
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex); // 0x0000000181BC24D0-0x0000000181BC2F40
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType); // 0x0000000181BC1F70-0x0000000181BC2180
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x0000000181BC41C0-0x0000000181BC4280
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent); // 0x0000000181BC3F20-0x0000000181BC3FF0
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent); // 0x0000000181BC3B80-0x0000000181BC3F20
		public override bool IsPointerOverGameObject(int pointerTypeId); // 0x0000000181BC3930-0x0000000181BC3B80
		protected void ClearSelection(); // 0x0000000181BC1A40-0x0000000181BC1D60
		public override string ToString(); // 0x0000000181BC4350-0x0000000181BC4770
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x0000000181BC1E90-0x0000000181BC1F70
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x000000018186AB20-0x000000018186ABF0
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId); // 0x0000000181BC4280-0x0000000181BC4350
	}
}
