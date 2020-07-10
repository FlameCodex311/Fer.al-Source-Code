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

namespace Rewired.Demos.GamepadTemplateUI
{
	public class GamepadTemplateUI : UnityEngine.MonoBehaviour // TypeDefIndex: 9259
	{
		// Fields
		private const float stickRadius = 20f; // Metadata: 0x00744E25
		public int playerId; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform leftStick; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform rightStick; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement leftStickX; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement leftStickY; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement leftStickButton; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement rightStickX; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement rightStickY; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement rightStickButton; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionBottomRow1; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionBottomRow2; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionBottomRow3; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionTopRow1; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionTopRow2; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement actionTopRow3; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement leftShoulder; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement leftTrigger; // 0x98
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement rightShoulder; // 0xA0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement rightTrigger; // 0xA8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement center1; // 0xB0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement center2; // 0xB8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement center3; // 0xC0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement dPadUp; // 0xC8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement dPadRight; // 0xD0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement dPadDown; // 0xD8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement dPadLeft; // 0xE0
		private UIElement[] _uiElementsArray; // 0xE8
		private Dictionary<int, ControllerUIElement> _uiElements; // 0xF0
		private IList<ControllerTemplateElementTarget> _tempTargetList; // 0xF8
		private Stick[] _sticks; // 0x100
	
		// Properties
		private Player player { get; } // 0x00000001815B85D0-0x00000001815B8640 
	
		// Nested types
		private class Stick // TypeDefIndex: 9260
		{
			// Fields
			private RectTransform _transform; // 0x10
			private Vector2 _origPosition; // 0x18
			private int _xAxisElementId; // 0x20
			private int _yAxisElementId; // 0x24
	
			// Properties
			public Vector2 position { get; set; } // 0x00000001815C1A40-0x00000001815C1B40 0x00000001815C1B40-0x00000001815C1C20
	
			// Constructors
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId); // 0x00000001815C1970-0x00000001815C1A40
	
			// Methods
			public void Reset(); // 0x00000001815C1690-0x00000001815C1730
			public bool ContainsElement(int elementId); // 0x00000001815C15E0-0x00000001815C1690
			public void SetAxisPosition(int elementId, float value); // 0x00000001815C1730-0x00000001815C1970
		}
	
		private class UIElement // TypeDefIndex: 9261
		{
			// Fields
			public int id; // 0x10
			public ControllerUIElement element; // 0x18
	
			// Constructors
			public UIElement(int id, ControllerUIElement element); // 0x0000000180393700-0x0000000180393740
		}
	
		// Constructors
		public GamepadTemplateUI(); // 0x00000001815B8540-0x00000001815B85D0
	
		// Methods
		private void Awake(); // 0x00000001815B6580-0x00000001815B7440
		private void Start(); // 0x00000001815B83C0-0x00000001815B8480
		private void OnDestroy(); // 0x00000001815B8300-0x00000001815B83C0
		private void Update(); // 0x00000001815B8480-0x00000001815B8540
		private void DrawActiveElements(); // 0x00000001815B7440-0x00000001815B7810
		private void ActivateElements(Player player, int actionId); // 0x00000001815B61D0-0x00000001815B6580
		private void DrawLabels(); // 0x00000001815B7EB0-0x00000001815B8180
		private void DrawLabels(Player player, InputAction action); // 0x00000001815B7C30-0x00000001815B7EB0
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element); // 0x00000001815B7810-0x00000001815B7C30
		private Stick GetStick(int elementId); // 0x00000001815B8180-0x00000001815B82F0
		private void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x00000001815B82F0-0x00000001815B8300
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x00000001815B82F0-0x00000001815B8300
	}
}
