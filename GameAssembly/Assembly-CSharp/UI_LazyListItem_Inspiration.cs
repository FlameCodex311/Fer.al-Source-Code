/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_Inspiration : UI_LazyListItem<InspirationItemComponent> // TypeDefIndex: 13609
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	private UI_Window_Inspirations _inspirationWindow; // 0x78
	private Waiter _iconLoadWaiter; // 0x80

	// Constructors
	public UI_LazyListItem_Inspiration(); // 0x00000001803A80A0-0x00000001803A80E0

	// Methods
	public override void Setup(Action<UI_LazyListItem<InspirationItemComponent>> inOnClicked, Action<UI_LazyListItem<InspirationItemComponent>> inOnSelected, InspirationItemComponent inData, UI_LazyItemList<InspirationItemComponent> inItemList); // 0x00000001803A7C80-0x00000001803A7FD0
	private void OnInspirationAddedOrRemoved(InspirationItemComponent inInspiration); // 0x00000001803A7BA0-0x00000001803A7BF0
	protected override void OnClicked(); // 0x00000001803A7B00-0x00000001803A7BA0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public override void Refresh(); // 0x00000001803A7BF0-0x00000001803A7C80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__4_0(); // 0x00000001803A7FD0-0x00000001803A80A0
}

