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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ToggleButtonGraphic : MonoBehaviour // TypeDefIndex: 13550
{
	// Nested types
	[Serializable]
	public class ToggleGraphic // TypeDefIndex: 13551
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Graphic _graphic; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorOn; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorOff; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorDisabled; // 0x38
		[Header] // 0x0000000180262820-0x0000000180262870
		[SerializeField] // 0x0000000180262820-0x0000000180262870
		private Sprite _spriteOn; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Sprite _spriteOff; // 0x50
		private bool _lastIsOnValue; // 0x58
		private bool _lastIsDisabledValue; // 0x59
		private Image _image; // 0x60
		private Rectangle _rectangle; // 0x68

		// Constructors
		public ToggleGraphic(); // 0x0000000180632CF0-0x0000000180632D50

		// Methods
		public void Init(bool inIsOn, bool inIsDisabled); // 0x0000000180632860-0x0000000180632AE0
		public void OnToggle(bool inIsOn, bool inIsDisabled); // 0x0000000180632AE0-0x0000000180632CF0
	}

	[Serializable]
	public class ToggleCanvasGroup // TypeDefIndex: 13552
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _canvasGroup; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _onState; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _offState; // 0x19
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _useDisabledState; // 0x1A
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _disabledState; // 0x1B
		private bool _lastValue; // 0x1C

		// Constructors
		public ToggleCanvasGroup(); // 0x0000000180632850-0x0000000180632860

		// Methods
		public void Init(bool inIsOn, bool inIsDisabled); // 0x0000000180632570-0x0000000180632670
		public void OnToggle(bool inIsOn, bool inIsDisabled); // 0x0000000180632670-0x0000000180632810
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnToggle>b__7_0(); // 0x0000000180632810-0x0000000180632850
	}

	[Serializable]
	public class ToggleUIEffect // TypeDefIndex: 13553
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UIEffect _effect; // 0x10
		[SerializeField] // 0x0000000180264B50-0x0000000180264B90
		[Tooltip] // 0x0000000180264B50-0x0000000180264B90
		private bool _invert; // 0x18
		private bool _lastValue; // 0x19

		// Constructors
		public ToggleUIEffect(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void Init(bool inIsOn); // 0x0000000180632D50-0x0000000180632E00
		public void OnToggle(bool inIsOn); // 0x0000000180632E00-0x0000000180633000
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnToggle>b__4_0(); // 0x0000000180633000-0x0000000180633020
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnToggle>b__4_1(float factor); // 0x0000000180633020-0x00000001806330B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnToggle>b__4_2(); // 0x0000000180633000-0x0000000180633020
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnToggle>b__4_3(float factor); // 0x00000001806330B0-0x0000000180634A10
	}

	[Serializable]
	public class CornerNoise // TypeDefIndex: 13554
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Rectangle _rectangle; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 _moveScale; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _fromStartOffset; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _outward; // 0x25
		private float _currentMoveScale; // 0x28
		private bool _doUpdate; // 0x2C
		private Vector2 _cornerAStart; // 0x30
		private Vector2 _cornerBStart; // 0x38
		private Vector2 _cornerCStart; // 0x40
		private Vector2 _cornerDStart; // 0x48

		// Constructors
		public CornerNoise(); // 0x0000000180632520-0x0000000180632570

		// Methods
		public void Init(); // 0x0000000180631900-0x0000000180631A50
		public void StartMovement(); // 0x0000000180631A50-0x0000000180631B80
		public void EndMovement(); // 0x0000000180631810-0x0000000180631900
		public void Update(); // 0x0000000180631B80-0x0000000180632520
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <StartMovement>b__12_0(); // 0x0000000180491DA0-0x0000000180491DB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <StartMovement>b__12_1(float x); // 0x0000000180626240-0x0000000180626250
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <EndMovement>b__13_0(); // 0x0000000180491DA0-0x0000000180491DB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <EndMovement>b__13_1(float x); // 0x0000000180626240-0x0000000180626250
	}

	// Constructors
	public UI_ToggleButtonGraphic(); // 0x00000001803743C0-0x00000001803743D0
}

