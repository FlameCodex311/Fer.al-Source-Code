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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_Inspiration : UI_LazyListItem<InspirationItemComponent> // TypeDefIndex: 12062
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	private UI_Window_Inspirations _inspirationWindow; // 0x78
	private Waiter _iconLoadWaiter; // 0x80

	// Constructors
	public UI_LazyListItem_Inspiration(); // 0x0000000180E76500-0x0000000180E76540

	// Methods
	public override void Setup(Action<UI_LazyListItem<InspirationItemComponent>> inOnClicked, Action<UI_LazyListItem<InspirationItemComponent>> inOnSelected, InspirationItemComponent inData, UI_LazyItemList<InspirationItemComponent> inItemList); // 0x0000000180E760E0-0x0000000180E76430
	private void OnInspirationAddedOrRemoved(InspirationItemComponent inInspiration); // 0x0000000180E75FF0-0x0000000180E76040
	protected override void OnClicked(); // 0x0000000180E75F50-0x0000000180E75FF0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public override void Refresh(); // 0x0000000180E76040-0x0000000180E760E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__4_0(); // 0x0000000180E76430-0x0000000180E76500
}

