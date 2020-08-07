/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_PrimaryAvatarLook : UI_LazyListItem<AvatarLookItemComponent> // TypeDefIndex: 13591
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarLookImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _equipLookSound; // 0x78
	private bool _isEquipped; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnClicked>d__6 : IAsyncStateMachine // TypeDefIndex: 13592
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_PrimaryAvatarLook <>4__this; // 0x28
		private TaskAwaiter<CreatureCustomizationTarget> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002190-0x00000001800021A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItem_PrimaryAvatarLook(); // 0x00000001803AAA80-0x00000001803AAAC0

	// Methods
	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList); // 0x00000001803AA910-0x00000001803AAA40
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	[AsyncStateMachine] // 0x0000000180274560-0x00000001802745B0
	protected override void OnClicked(); // 0x00000001803AA720-0x00000001803AA7D0
	public override void Refresh(); // 0x00000001803AA8C0-0x00000001803AA910
	private void RefreshEquipped(); // 0x00000001803AA7D0-0x00000001803AA8C0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(); // 0x00000001803AAA40-0x00000001803AAA80
}

