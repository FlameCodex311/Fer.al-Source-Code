/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_PagedScreen : MonoBehaviour // TypeDefIndex: 10850
{
	// Fields
	public List<GameObject> pages; // 0x20
	private int _currentPage; // 0x28

	// Constructors
	public UI_PagedScreen(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001803CE640-0x00000001803CE650
	public void ShowPage(int inPageIndex); // 0x00000001803CE650-0x00000001803CE740
	public void BtnClicked_GoToPage(int inPage); // 0x00000001803CE620-0x00000001803CE630
	public void BtnClicked_GoToNextPage(); // 0x00000001803CE610-0x00000001803CE620
	public void BtnClicked_GoToPrevPage(); // 0x00000001803CE630-0x00000001803CE640
}

