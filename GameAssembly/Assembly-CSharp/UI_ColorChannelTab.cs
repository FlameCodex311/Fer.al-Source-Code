/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ColorChannelTab : MonoBehaviour // TypeDefIndex: 13872
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _currentColorFullRectangle; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _currentColorHalfRectangle; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _targetColorHalfRectangle; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _colorSelectedGroup; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _clearColorBtnGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _undyeColorBtnGroup; // 0x48
	private HSVColor _defaultColor; // 0x50
	private HSVColor _currentColor; // 0x88
	private HSVColor? _targetColor; // 0xC0

	// Properties
	public HSVColor DefaultColor { get; set; } // 0x0000000180545B20-0x0000000180545B50 0x0000000180545C40-0x0000000180545E10
	public HSVColor CurrentColor { get; set; } // 0x0000000180545AE0-0x0000000180545B20 0x0000000180545B80-0x0000000180545C40
	public HSVColor? TargetColor { get; set; } // 0x0000000180545B50-0x0000000180545B80 0x0000000180545E10-0x00000001805461D0

	// Constructors
	public UI_ColorChannelTab(); // 0x00000001803743C0-0x00000001803743D0
}

