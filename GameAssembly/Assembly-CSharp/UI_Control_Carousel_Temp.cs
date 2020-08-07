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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Control_Carousel_Temp : MonoBehaviour // TypeDefIndex: 13546
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FancyScrollView_Temp _scrollView; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _currentlySelectedText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Button _leftArrowBtn; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Button _rightArrowBtn; // 0x38
	private bool _isSetup; // 0x40
	private bool _paddingNeeded; // 0x41

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13547
	{
		// Fields
		public UI_Control_Carousel_Temp <>4__this; // 0x10
		public List<int> data; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnEnable>b__0(); // 0x000000018053D8F0-0x000000018053D950
		internal void <OnEnable>b__1(); // 0x000000018053D950-0x000000018053D9C0
	}

	// Constructors
	public UI_Control_Carousel_Temp(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001805466E0-0x0000000180546920
	private void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_LeftArrow(); // 0x0000000180546540-0x0000000180546560
	public void BtnClicked_RightArrow(); // 0x0000000180546560-0x0000000180546580
	private void HandleSelectedIndexChanged(int index); // 0x0000000180546580-0x00000001805466E0
}

