/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ToggleButtonGraphic : MonoBehaviour // TypeDefIndex: 12004
{
	// Nested types
	[Serializable]
	public class ToggleGraphic // TypeDefIndex: 12005
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Graphic _graphic; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorOn; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorOff; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorDisabled; // 0x38
		[Header] // 0x00000001800C0B20-0x00000001800C0B70
		[SerializeField] // 0x00000001800C0B20-0x00000001800C0B70
		private Sprite _spriteOn; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Sprite _spriteOff; // 0x50
		private bool _lastIsOnValue; // 0x58
		private bool _lastIsDisabledValue; // 0x59
		private Image _image; // 0x60
		private Rectangle _rectangle; // 0x68

		// Constructors
		public ToggleGraphic(); // 0x0000000180F8ACC0-0x0000000180F8AD20

		// Methods
		public void Init(bool inIsOn, bool inIsDisabled); // 0x0000000180F8A830-0x0000000180F8AAB0
		public void OnToggle(bool inIsOn, bool inIsDisabled); // 0x0000000180F8AAB0-0x0000000180F8ACC0
	}

	[Serializable]
	public class ToggleCanvasGroup // TypeDefIndex: 12006
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _canvasGroup; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _onState; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _offState; // 0x19
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _useDisabledState; // 0x1A
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _disabledState; // 0x1B
		private bool _lastValue; // 0x1C

		// Constructors
		public ToggleCanvasGroup(); // 0x0000000180F8A820-0x0000000180F8A830

		// Methods
		public void Init(bool inIsOn, bool inIsDisabled); // 0x0000000180F8A540-0x0000000180F8A640
		public void OnToggle(bool inIsOn, bool inIsDisabled); // 0x0000000180F8A640-0x0000000180F8A7E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnToggle>b__7_0(); // 0x0000000180F8A7E0-0x0000000180F8A820
	}

	[Serializable]
	public class ToggleUIEffect // TypeDefIndex: 12007
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UIEffect _effect; // 0x10
		[SerializeField] // 0x00000001800C18B0-0x00000001800C18F0
		[Tooltip] // 0x00000001800C18B0-0x00000001800C18F0
		private bool _invert; // 0x18
		private bool _lastValue; // 0x19

		// Constructors
		public ToggleUIEffect(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void Init(bool inIsOn); // 0x0000000180F8AD20-0x0000000180F8ADD0
		public void OnToggle(bool inIsOn); // 0x0000000180F8ADD0-0x0000000180F8AFD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <OnToggle>b__4_0(); // 0x0000000180F8AFD0-0x0000000180F8AFF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnToggle>b__4_1(float factor); // 0x0000000180F8AFF0-0x0000000180F8EA50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <OnToggle>b__4_2(); // 0x0000000180F8AFD0-0x0000000180F8AFF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnToggle>b__4_3(float factor); // 0x0000000180F8AFF0-0x0000000180F8EA50
	}

	[Serializable]
	public class CornerNoise // TypeDefIndex: 12008
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Rectangle _rectangle; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _moveScale; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _fromStartOffset; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _outward; // 0x25
		private float _currentMoveScale; // 0x28
		private bool _doUpdate; // 0x2C
		private Vector2 _cornerAStart; // 0x30
		private Vector2 _cornerBStart; // 0x38
		private Vector2 _cornerCStart; // 0x40
		private Vector2 _cornerDStart; // 0x48

		// Constructors
		public CornerNoise(); // 0x0000000180F8A4F0-0x0000000180F8A540

		// Methods
		public void Init(); // 0x0000000180F89890-0x0000000180F89A00
		public void StartMovement(); // 0x0000000180F89A00-0x0000000180F89B30
		public void EndMovement(); // 0x0000000180F897A0-0x0000000180F89890
		public void Update(); // 0x0000000180F89B30-0x0000000180F8A4F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <StartMovement>b__12_0(); // 0x0000000180487D50-0x0000000180487D60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <StartMovement>b__12_1(float x); // 0x00000001805D90B0-0x00000001805D90C0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <EndMovement>b__13_0(); // 0x0000000180487D50-0x0000000180487D60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <EndMovement>b__13_1(float x); // 0x00000001805D90B0-0x00000001805D90C0
	}

	// Constructors
	public UI_ToggleButtonGraphic(); // 0x0000000180E095D0-0x0000000180E095E0
}

