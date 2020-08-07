/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWSmoothLayoutSizeApplier : MonoBehaviour // TypeDefIndex: 11291
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _applyVertical; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _applyHorizontal; // 0x21
	[SerializeField] // 0x0000000180279950-0x00000001802799A0
	[Tooltip] // 0x0000000180279950-0x00000001802799A0
	private GameObject _srcLayoutElementObject; // 0x28
	private ILayoutElement _srcLayoutElement; // 0x30
	private LayoutElement _targetLayoutElement; // 0x38
	private bool _isSetup; // 0x40
	private WWSmoothLayout _smoothLayout; // 0x48
	private RectTransform _rectTransform; // 0x50

	// Constructors
	public WWSmoothLayoutSizeApplier(); // 0x00000001805DFA20-0x00000001805DFA30

	// Methods
	public void Setup(LayoutElement inChangeTarget, WWSmoothLayout inSmoothLayout); // 0x00000001805DF7A0-0x00000001805DF880
	private void Update(); // 0x00000001805DF880-0x00000001805DFA20
	private void OnRectTransformDimensionsChange(); // 0x00000001805DF580-0x00000001805DF750
	private void Reset(); // 0x00000001805DF750-0x00000001805DF7A0
}

