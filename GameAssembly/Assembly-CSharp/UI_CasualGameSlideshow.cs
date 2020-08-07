/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CasualGameSlideshow : MonoBehaviour // TypeDefIndex: 10849
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nextBtnText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x28

	// Constructors
	public UI_CasualGameSlideshow(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Show(int inStartIndex = 0 /* Metadata: 0x0077C232 */); // 0x0000000180520430-0x0000000180520590
	public void Hide(); // 0x0000000180520280-0x0000000180520320
	public void BtnClicked_Next(); // 0x0000000180520170-0x0000000180520280
	private void OnPageSelected(int inCurrentPageIndex); // 0x0000000180520320-0x0000000180520430
}

