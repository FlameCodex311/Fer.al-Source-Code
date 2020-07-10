/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ColorChannelTab : MonoBehaviour // TypeDefIndex: 12288
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _currentColorFullRectangle; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _currentColorHalfRectangle; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _targetColorHalfRectangle; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _colorSelectedGroup; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _clearColorBtnGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _undyeColorBtnGroup; // 0x48
	private HSVColor _defaultColor; // 0x50
	private HSVColor _currentColor; // 0x88
	private HSVColor? _targetColor; // 0xC0

	// Properties
	public HSVColor DefaultColor { get; set; } // 0x0000000180F28110-0x0000000180F28140 0x0000000180F28240-0x0000000180F28410
	public HSVColor CurrentColor { get; set; } // 0x0000000180F280D0-0x0000000180F28110 0x0000000180F28170-0x0000000180F28240
	public HSVColor? TargetColor { get; set; } // 0x0000000180F28140-0x0000000180F28170 0x0000000180F28410-0x0000000180F287D0

	// Constructors
	public UI_ColorChannelTab(); // 0x0000000180E095D0-0x0000000180E095E0
}

