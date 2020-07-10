/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FancyScrollView;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FancyScrollView_Temp : FancyScrollView<int, FancyScrollViewContext_Temp> // TypeDefIndex: 11999
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ScrollPositionController _scrollPositionController; // 0x60
	private Action<int> onSelectedIndexChanged; // 0x68
	private int _paddingCells; // 0x70

	// Constructors
	public FancyScrollView_Temp(); // 0x0000000181492B50-0x0000000181492B90

	// Methods
	private void Awake(); // 0x00000001814924D0-0x0000000181492620
	public void UpdateData(List<int> data, bool inPaddingNeeded); // 0x0000000181492860-0x0000000181492930
	public void UpdateSelection(int index, int direction = 0 /* Metadata: 0x00782D87 */); // 0x0000000181492930-0x0000000181492B50
	public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged); // 0x00000001803A27D0-0x00000001803A27E0
	public void SelectNextCell(); // 0x0000000181492720-0x0000000181492770
	public void SelectPrevCell(); // 0x0000000181492770-0x00000001814927C0
	private void HandleItemSelected(int selectedItemIndex); // 0x0000000181492620-0x00000001814926C0
	private void OnPressedCell(FancyScrollViewCell_Temp cell); // 0x00000001814926C0-0x0000000181492720
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Awake>b__3_0(float p); // 0x00000001814927C0-0x0000000181492810
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Awake>b__3_1(int index); // 0x0000000181492810-0x0000000181492860
}

