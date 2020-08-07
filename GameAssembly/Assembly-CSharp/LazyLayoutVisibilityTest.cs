/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LazyLayoutVisibilityTest : MonoBehaviour // TypeDefIndex: 13638
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LazyLayoutGroup _layoutGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ScrollRect _scrollRect; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FlowLazyLayoutGroup.Axis _maskingAxis; // 0x30

	// Constructors
	public LazyLayoutVisibilityTest(); // 0x000000018087C620-0x000000018087C630

	// Methods
	private void Start(); // 0x000000018087C500-0x000000018087C620
	private void OnScroll(Vector2 inScrollPosition); // 0x000000018087C4F0-0x000000018087C500
	private void OnLayoutChanged(); // 0x000000018087C4F0-0x000000018087C500
	private void CalculateVisibility(); // 0x000000018087C220-0x000000018087C4F0
}

