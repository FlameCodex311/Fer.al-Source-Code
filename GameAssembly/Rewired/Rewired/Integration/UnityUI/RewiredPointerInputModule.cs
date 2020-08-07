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

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Integration.UnityUI
{
	public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 9429
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x00779B17
		public const int kMouseRightId = -2; // Metadata: 0x00779B1B
		public const int kMouseMiddleId = -3; // Metadata: 0x00779B1F
		public const int kFakeTouchesId = -4; // Metadata: 0x00779B23
		private const int customButtonsStartingId = -2147483520; // Metadata: 0x00779B27
		private const int customButtonsMaxCount = 128; // Metadata: 0x00779B2B
		private const int customButtonsLastId = -2147483392; // Metadata: 0x00779B2F
		private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x48
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x50
		private ITouchInputSource m_UserDefaultTouchInputSource; // 0x58
		private UnityInputSource __m_DefaultInputSource; // 0x60
		private readonly MouseState m_MouseState; // 0x68
	
		// Properties
		private UnityInputSource defaultInputSource { get; } // 0x0000000181063FB0-0x0000000181064020 
		private IMouseInputSource defaultMouseInputSource { get; } // 0x0000000181063FB0-0x0000000181064020 
		protected ITouchInputSource defaultTouchInputSource { get; } // 0x0000000181063FB0-0x0000000181064020 
		protected virtual bool isMouseSupported { get; } // 0x0000000181064020-0x0000000181064190 
	
		// Nested types
		protected class MouseState // TypeDefIndex: 9430
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x000000018105FE90-0x000000018105FEF0
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x000000018105FB30-0x000000018105FC00
			public bool AnyReleasesThisFrame(); // 0x000000018105FC00-0x000000018105FCD0
			public ButtonState GetButtonState(int button); // 0x000000018105FCD0-0x000000018105FE30
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data); // 0x000000018105FE30-0x000000018105FE90
		}
	
		public class MouseButtonEventData // TypeDefIndex: 9431
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PlayerPointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool PressedThisFrame(); // 0x0000000180DB9BB0-0x0000000180DB9BD0
			public bool ReleasedThisFrame(); // 0x0000000180DB9BD0-0x0000000180DB9BE0
		}
	
		protected class ButtonState // TypeDefIndex: 9432
		{
			// Fields
			private int m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
			public int button { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
	
			// Constructors
			public ButtonState(); // 0x0000000180373240-0x0000000180373250
		}
	
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 9433
		{
			// Fields
			private Vector2 m_MousePosition; // 0x10
			private Vector2 m_MousePositionPrev; // 0x18
			private int m_LastUpdatedFrame; // 0x20
	
			// Properties
			int IMouseInputSource.playerId { get; } // 0x000000018106F4B0-0x000000018106F4D0 
			int ITouchInputSource.playerId { get; } // 0x000000018106F4B0-0x000000018106F4D0 
			bool IMouseInputSource.enabled { get; } // 0x000000018106F470-0x000000018106F490 
			bool IMouseInputSource.locked { get; } // 0x000000018106F490-0x000000018106F4B0 
			int IMouseInputSource.buttonCount { get; } // 0x000000018106F450-0x000000018106F470 
			Vector2 IMouseInputSource.screenPosition { get; } // 0x000000018106F560-0x000000018106F5F0 
			Vector2 IMouseInputSource.screenPositionDelta { get; } // 0x000000018106F4D0-0x000000018106F560 
			Vector2 IMouseInputSource.wheelDelta { get; } // 0x000000018106F5F0-0x000000018106F610 
			bool ITouchInputSource.touchSupported { get; } // 0x000000018106F6A0-0x000000018106F6C0 
			int ITouchInputSource.touchCount { get; } // 0x000000018106F680-0x000000018106F6A0 
	
			// Constructors
			public UnityInputSource(); // 0x000000018106F790-0x000000018106F7A0
	
			// Methods
			bool IMouseInputSource.GetButtonDown(int button); // 0x000000018106F3F0-0x000000018106F410
			bool IMouseInputSource.GetButtonUp(int button); // 0x000000018106F410-0x000000018106F430
			bool IMouseInputSource.GetButton(int button); // 0x000000018106F430-0x000000018106F450
			Touch ITouchInputSource.GetTouch(int index); // 0x000000018106F610-0x000000018106F680
			private void TryUpdate(); // 0x000000018106F6C0-0x000000018106F790
		}
	
		// Constructors
		protected RewiredPointerInputModule(); // 0x0000000181063EC0-0x0000000181063FB0
	
		// Methods
		protected bool IsDefaultMouse(IMouseInputSource mouse); // 0x0000000181063030-0x00000001810630B0
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex); // 0x0000000181061AF0-0x0000000181061CC0
		public void RemoveMouseInputSource(IMouseInputSource source); // 0x0000000181063760-0x00000001810637F0
		public void AddMouseInputSource(IMouseInputSource source); // 0x00000001810610C0-0x0000000181061180
		public int GetMouseInputSourceCount(int playerId); // 0x0000000181061980-0x0000000181061AF0
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex); // 0x0000000181062C30-0x0000000181062D00
		public void RemoveTouchInputSource(ITouchInputSource source); // 0x00000001810638B0-0x0000000181063930
		public void AddTouchInputSource(ITouchInputSource source); // 0x0000000181061180-0x0000000181061220
		public int GetTouchInputSourceCount(int playerId); // 0x0000000181062C00-0x0000000181062C30
		protected void ClearMouseInputSources(); // 0x0000000181061220-0x0000000181061270
		protected abstract bool IsDefaultPlayer(int playerId);
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType); // 0x0000000181062700-0x0000000181062C00
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType); // 0x0000000181061570-0x00000001810616A0
		protected void RemovePointerData(PlayerPointerEventData data); // 0x00000001810637F0-0x00000001810638B0
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released); // 0x0000000181062D00-0x0000000181063030
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex); // 0x0000000181061CC0-0x0000000181062700
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType); // 0x0000000181061780-0x0000000181061980
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x0000000181063930-0x00000001810639F0
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent); // 0x0000000181063690-0x0000000181063760
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent); // 0x00000001810632F0-0x0000000181063690
		public override bool IsPointerOverGameObject(int pointerTypeId); // 0x00000001810630B0-0x00000001810632F0
		protected void ClearSelection(); // 0x0000000181061270-0x0000000181061570
		public override string ToString(); // 0x0000000181063AC0-0x0000000181063EC0
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x00000001810616A0-0x0000000181061780
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x0000000180DBBCA0-0x0000000180DBBD70
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId); // 0x00000001810639F0-0x0000000181063AC0
	}
}
