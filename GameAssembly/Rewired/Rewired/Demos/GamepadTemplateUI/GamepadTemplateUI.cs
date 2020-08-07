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

namespace Rewired.Demos.GamepadTemplateUI
{
	public class GamepadTemplateUI : UnityEngine.MonoBehaviour // TypeDefIndex: 9425
	{
		// Fields
		private const float stickRadius = 20f; // Metadata: 0x00779B13
		public int playerId; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform leftStick; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform rightStick; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement leftStickX; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement leftStickY; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement leftStickButton; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement rightStickX; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement rightStickY; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement rightStickButton; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionBottomRow1; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionBottomRow2; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionBottomRow3; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionTopRow1; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionTopRow2; // 0x80
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement actionTopRow3; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement leftShoulder; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement leftTrigger; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement rightShoulder; // 0xA0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement rightTrigger; // 0xA8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement center1; // 0xB0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement center2; // 0xB8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement center3; // 0xC0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement dPadUp; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement dPadRight; // 0xD0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement dPadDown; // 0xD8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement dPadLeft; // 0xE0
		private UIElement[] _uiElementsArray; // 0xE8
		private Dictionary<int, ControllerUIElement> _uiElements; // 0xF0
		private IList<ControllerTemplateElementTarget> _tempTargetList; // 0xF8
		private Stick[] _sticks; // 0x100
	
		// Properties
		private Player player { get; } // 0x0000000180DD2D50-0x0000000180DD2DC0 
	
		// Nested types
		private class Stick // TypeDefIndex: 9426
		{
			// Fields
			private RectTransform _transform; // 0x10
			private Vector2 _origPosition; // 0x18
			private int _xAxisElementId; // 0x20
			private int _yAxisElementId; // 0x24
	
			// Properties
			public Vector2 position { get; set; } // 0x0000000180DD7FD0-0x0000000180DD80D0 0x0000000180DD80D0-0x0000000180DD81B0
	
			// Constructors
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId); // 0x0000000180DD7F00-0x0000000180DD7FD0
	
			// Methods
			public void Reset(); // 0x0000000180DD7C20-0x0000000180DD7CC0
			public bool ContainsElement(int elementId); // 0x0000000180DD7B70-0x0000000180DD7C20
			public void SetAxisPosition(int elementId, float value); // 0x0000000180DD7CC0-0x0000000180DD7F00
		}
	
		private class UIElement // TypeDefIndex: 9427
		{
			// Fields
			public int id; // 0x10
			public ControllerUIElement element; // 0x18
	
			// Constructors
			public UIElement(int id, ControllerUIElement element); // 0x0000000180568A80-0x0000000180568AC0
		}
	
		// Constructors
		public GamepadTemplateUI(); // 0x0000000180DD2CC0-0x0000000180DD2D50
	
		// Methods
		private void Awake(); // 0x0000000180DD0E10-0x0000000180DD1C20
		private void Start(); // 0x0000000180DD2B40-0x0000000180DD2C00
		private void OnDestroy(); // 0x0000000180DD2A80-0x0000000180DD2B40
		private void Update(); // 0x0000000180DD2C00-0x0000000180DD2CC0
		private void DrawActiveElements(); // 0x0000000180DD1C20-0x0000000180DD1FE0
		private void ActivateElements(Player player, int actionId); // 0x0000000180DD0A70-0x0000000180DD0E10
		private void DrawLabels(); // 0x0000000180DD2650-0x0000000180DD2910
		private void DrawLabels(Player player, InputAction action); // 0x0000000180DD23E0-0x0000000180DD2650
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element); // 0x0000000180DD1FE0-0x0000000180DD23E0
		private Stick GetStick(int elementId); // 0x0000000180DD2910-0x0000000180DD2A70
		private void OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x0000000180DD2A70-0x0000000180DD2A80
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x0000000180DD2A70-0x0000000180DD2A80
	}
}
