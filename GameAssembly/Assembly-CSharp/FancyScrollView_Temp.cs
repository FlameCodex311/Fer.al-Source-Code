/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FancyScrollView;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FancyScrollView_Temp : FancyScrollView<int, FancyScrollViewContext_Temp> // TypeDefIndex: 13545
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ScrollPositionController _scrollPositionController; // 0x60
	private Action<int> onSelectedIndexChanged; // 0x68
	private int _paddingCells; // 0x70

	// Constructors
	public FancyScrollView_Temp(); // 0x0000000180E22700-0x0000000180E22740

	// Methods
	private void Awake(); // 0x0000000180E22090-0x0000000180E221E0
	public void UpdateData(List<int> data, bool inPaddingNeeded); // 0x0000000180E22420-0x0000000180E224F0
	public void UpdateSelection(int index, int direction = 0 /* Metadata: 0x007BA495 */); // 0x0000000180E224F0-0x0000000180E22700
	public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged); // 0x00000001804ADAC0-0x00000001804ADAD0
	public void SelectNextCell(); // 0x0000000180E222E0-0x0000000180E22330
	public void SelectPrevCell(); // 0x0000000180E22330-0x0000000180E22380
	private void HandleItemSelected(int selectedItemIndex); // 0x0000000180E221E0-0x0000000180E22280
	private void OnPressedCell(FancyScrollViewCell_Temp cell); // 0x0000000180E22280-0x0000000180E222E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Awake>b__3_0(float p); // 0x0000000180E22380-0x0000000180E223D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Awake>b__3_1(int index); // 0x0000000180E223D0-0x0000000180E22420
}

