/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_ChatEntry : UI_LazyListItem<ChatEntry> // TypeDefIndex: 11961
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _contentText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _nameTextColorMe; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _nameTextColorOther; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _ignoreBlockState; // 0x98

	// Constructors
	public UI_LazyListItem_ChatEntry(); // 0x0000000180E6FD60-0x0000000180E6FDD0

	// Methods
	protected override void Start(); // 0x0000000180E6FD20-0x0000000180E6FD60
	public override void Setup(Action<UI_LazyListItem<ChatEntry>> inOnClicked, Action<UI_LazyListItem<ChatEntry>> inOnSelected, ChatEntry inData, UI_LazyItemList<ChatEntry> inItemList); // 0x0000000180E6FB40-0x0000000180E6FD20
	private void OnChatDisplayDataChanged(ChatEntry.ChatDisplayData inDisplayData); // 0x0000000180E6F6A0-0x0000000180E6F7B0
	public void SetTextSize(int inTextSize); // 0x0000000180E6FB10-0x0000000180E6FB40
	private void RefreshText(); // 0x0000000180E6F7C0-0x0000000180E6FB10
	private void OnDisable(); // 0x0000000180E6F7B0-0x0000000180E6F7C0
}

