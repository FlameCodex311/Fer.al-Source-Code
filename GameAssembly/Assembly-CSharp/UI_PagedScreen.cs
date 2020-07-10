/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_PagedScreen : MonoBehaviour // TypeDefIndex: 13184
{
	// Fields
	public List<GameObject> pages; // 0x20
	private int _currentPage; // 0x28

	// Constructors
	public UI_PagedScreen(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180E84C80-0x0000000180E84C90
	public void ShowPage(int inPageIndex); // 0x0000000180E84C90-0x0000000180E84D80
	public void BtnClicked_GoToPage(int inPage); // 0x0000000180E84C60-0x0000000180E84C70
	public void BtnClicked_GoToNextPage(); // 0x0000000180E84C50-0x0000000180E84C60
	public void BtnClicked_GoToPrevPage(); // 0x0000000180E84C70-0x0000000180E84C80
}

