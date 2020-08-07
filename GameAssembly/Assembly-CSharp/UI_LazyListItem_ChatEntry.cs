/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_ChatEntry : UI_LazyListItem<ChatEntry> // TypeDefIndex: 13509
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _contentText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _nameTextColorMe; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _nameTextColorOther; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _ignoreBlockState; // 0x98

	// Constructors
	public UI_LazyListItem_ChatEntry(); // 0x00000001803A3540-0x00000001803A35B0

	// Methods
	protected override void Start(); // 0x00000001803A3500-0x00000001803A3540
	public override void Setup(Action<UI_LazyListItem<ChatEntry>> inOnClicked, Action<UI_LazyListItem<ChatEntry>> inOnSelected, ChatEntry inData, UI_LazyItemList<ChatEntry> inItemList); // 0x00000001803A3320-0x00000001803A3500
	private void OnChatDisplayDataChanged(ChatEntry.ChatDisplayData inDisplayData); // 0x00000001803A2EB0-0x00000001803A2FB0
	public void SetTextSize(int inTextSize); // 0x00000001803A32F0-0x00000001803A3320
	private void RefreshText(); // 0x00000001803A2FC0-0x00000001803A32F0
	private void OnDisable(); // 0x00000001803A2FB0-0x00000001803A2FC0
}

