/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_House : UI_LazyListItem<SanctuaryLookItemComponent> // TypeDefIndex: 12051
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	[Header] // 0x00000001800D2DF0-0x00000001800D2E40
	[SerializeField] // 0x00000001800D2DF0-0x00000001800D2E40
	private GameObject _equippedIcon; // 0x78
	private bool _isEquipped; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnClicked>d__6 : IAsyncStateMachine // TypeDefIndex: 12052
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_House <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F06C0-0x00000001801F06D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItem_House(); // 0x0000000180E75F10-0x0000000180E75F50

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList); // 0x0000000180E75D70-0x0000000180E75ED0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	[AsyncStateMachine] // 0x00000001800D3110-0x00000001800D3160
	protected override void OnClicked(); // 0x0000000180E75BC0-0x0000000180E75C70
	public override void Refresh(); // 0x0000000180E75D20-0x0000000180E75D70
	private void RefreshEquipped(); // 0x0000000180E75C70-0x0000000180E75D20
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(); // 0x0000000180E75ED0-0x0000000180E75F10
}

