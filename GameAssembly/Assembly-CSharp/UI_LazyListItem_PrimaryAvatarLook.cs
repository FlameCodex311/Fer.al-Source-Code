/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_PrimaryAvatarLook : UI_LazyListItem<AvatarLookItemComponent> // TypeDefIndex: 12037
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarLookImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _equipLookSound; // 0x78
	private bool _isEquipped; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnClicked>d__6 : IAsyncStateMachine // TypeDefIndex: 12038
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_PrimaryAvatarLook <>4__this; // 0x28
		private TaskAwaiter<CreatureCustomizationTarget> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F06B0-0x00000001801F06C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItem_PrimaryAvatarLook(); // 0x0000000180E78FB0-0x0000000180E78FF0

	// Methods
	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList); // 0x0000000180E78E40-0x0000000180E78F70
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	[AsyncStateMachine] // 0x00000001800CCD90-0x00000001800CCDE0
	protected override void OnClicked(); // 0x0000000180E78C50-0x0000000180E78D00
	public override void Refresh(); // 0x0000000180E78DF0-0x0000000180E78E40
	private void RefreshEquipped(); // 0x0000000180E78D00-0x0000000180E78DF0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(); // 0x0000000180E78F70-0x0000000180E78FB0
}

