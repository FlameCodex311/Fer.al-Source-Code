/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class VisibilityCalculator // TypeDefIndex: 12180
{
	// Fields
	private LazyLayoutGroup _layoutGroup; // 0x10
	private ScrollRect _scrollRect; // 0x18
	private Action<int, bool> _itemVisibilityCallback; // 0x20
	private int _maskingAxis; // 0x28

	// Constructors
	public VisibilityCalculator(LazyLayoutGroup inLayout, ScrollRect inScrollRect, Action<int, bool> inItemVisibilityCallback, int inMaskingAxis = 1 /* Metadata: 0x00782DF8 */); // 0x00000001811329D0-0x0000000181132B40

	// Methods
	private void OnScroll(Vector2 inScrollPosition); // 0x00000001811329C0-0x00000001811329D0
	private void OnLayoutChanged(); // 0x00000001811329C0-0x00000001811329D0
	public void CalculateVisibility(); // 0x00000001811325D0-0x00000001811329C0
}

