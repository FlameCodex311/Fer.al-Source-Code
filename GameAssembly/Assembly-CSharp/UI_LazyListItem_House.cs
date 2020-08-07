/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_House : UI_LazyListItem<SanctuaryLookItemComponent> // TypeDefIndex: 13600
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	[Header] // 0x0000000180277BF0-0x0000000180277C40
	[SerializeField] // 0x0000000180277BF0-0x0000000180277C40
	private GameObject _equippedIcon; // 0x78
	private bool _isEquipped; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnClicked>d__6 : IAsyncStateMachine // TypeDefIndex: 13601
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_House <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800021A0-0x00000001800021B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItem_House(); // 0x00000001803A7AC0-0x00000001803A7B00

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList); // 0x00000001803A7930-0x00000001803A7A80
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	[AsyncStateMachine] // 0x0000000180277F60-0x0000000180277FB0
	protected override void OnClicked(); // 0x00000001803A7780-0x00000001803A7830
	public override void Refresh(); // 0x00000001803A78E0-0x00000001803A7930
	private void RefreshEquipped(); // 0x00000001803A7830-0x00000001803A78E0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(); // 0x00000001803A7A80-0x00000001803A7AC0
}

