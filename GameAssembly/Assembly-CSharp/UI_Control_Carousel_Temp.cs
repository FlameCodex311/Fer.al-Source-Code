/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Control_Carousel_Temp : MonoBehaviour // TypeDefIndex: 12000
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FancyScrollView_Temp _scrollView; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _currentlySelectedText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Button _leftArrowBtn; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Button _rightArrowBtn; // 0x38
	private bool _isSetup; // 0x40
	private bool _paddingNeeded; // 0x41

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12001
	{
		// Fields
		public UI_Control_Carousel_Temp <>4__this; // 0x10
		public List<int> data; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnEnable>b__0(); // 0x0000000180F1F9B0-0x0000000180F1FA10
		internal void <OnEnable>b__1(); // 0x0000000180F1FA10-0x0000000180F1FA80
	}

	// Constructors
	public UI_Control_Carousel_Temp(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180F28CE0-0x0000000180F28F20
	private void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_LeftArrow(); // 0x0000000180F28B40-0x0000000180F28B60
	public void BtnClicked_RightArrow(); // 0x0000000180F28B60-0x0000000180F28B80
	private void HandleSelectedIndexChanged(int index); // 0x0000000180F28B80-0x0000000180F28CE0
}

