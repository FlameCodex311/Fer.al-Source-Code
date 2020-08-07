/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class VisibilityCalculator // TypeDefIndex: 13727
{
	// Fields
	private LazyLayoutGroup _layoutGroup; // 0x10
	private ScrollRect _scrollRect; // 0x18
	private Action<int, bool> _itemVisibilityCallback; // 0x20
	private int _maskingAxis; // 0x28

	// Constructors
	public VisibilityCalculator(LazyLayoutGroup inLayout, ScrollRect inScrollRect, Action<int, bool> inItemVisibilityCallback, int inMaskingAxis = 1 /* Metadata: 0x007BA506 */); // 0x0000000180676940-0x0000000180676AB0

	// Methods
	private void OnScroll(Vector2 inScrollPosition); // 0x0000000180676930-0x0000000180676940
	private void OnLayoutChanged(); // 0x0000000180676930-0x0000000180676940
	public void CalculateVisibility(); // 0x0000000180676560-0x0000000180676930
}

