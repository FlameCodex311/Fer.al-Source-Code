/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WWSmoothLayoutSizeApplier : MonoBehaviour // TypeDefIndex: 13624
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _applyVertical; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _applyHorizontal; // 0x21
	[SerializeField] // 0x00000001800DD5B0-0x00000001800DD600
	[Tooltip] // 0x00000001800DD5B0-0x00000001800DD600
	private GameObject _srcLayoutElementObject; // 0x28
	private ILayoutElement _srcLayoutElement; // 0x30
	private LayoutElement _targetLayoutElement; // 0x38
	private bool _isSetup; // 0x40
	private WWSmoothLayout _smoothLayout; // 0x48
	private RectTransform _rectTransform; // 0x50

	// Constructors
	public WWSmoothLayoutSizeApplier(); // 0x0000000180FF8660-0x0000000180FF8670

	// Methods
	public void Setup(LayoutElement inChangeTarget, WWSmoothLayout inSmoothLayout); // 0x0000000180FF83D0-0x0000000180FF84B0
	private void Update(); // 0x0000000180FF84B0-0x0000000180FF8660
	private void OnRectTransformDimensionsChange(); // 0x0000000180FF81A0-0x0000000180FF8380
	private void Reset(); // 0x0000000180FF8380-0x0000000180FF83D0
}

