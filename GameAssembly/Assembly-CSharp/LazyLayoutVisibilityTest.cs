/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LazyLayoutVisibilityTest : MonoBehaviour // TypeDefIndex: 12092
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layoutGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ScrollRect _scrollRect; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FlowLazyLayoutGroup.Axis _maskingAxis; // 0x30

	// Constructors
	public LazyLayoutVisibilityTest(); // 0x00000001812CD390-0x00000001812CD3A0

	// Methods
	private void Start(); // 0x00000001812CD270-0x00000001812CD390
	private void OnScroll(Vector2 inScrollPosition); // 0x00000001812CD260-0x00000001812CD270
	private void OnLayoutChanged(); // 0x00000001812CD260-0x00000001812CD270
	private void CalculateVisibility(); // 0x00000001812CCF80-0x00000001812CD260
}

