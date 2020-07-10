/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatItem : MonoBehaviour, ISelectHandler // TypeDefIndex: 11930
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _contentText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _nameTextColorMe; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _nameTextColorOther; // 0x40
	private Action<UI_ChatItem> _onSelectedAction; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__5 : IAsyncStateMachine // TypeDefIndex: 11931
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatItem <>4__this; // 0x28
		public string inUserId; // 0x30
		public string inContent; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F1400-0x00000001801F1410
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_ChatItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	[AsyncStateMachine] // 0x000000018015E390-0x000000018015E3E0
	public void Setup(string inUserId, string inContent, Action<UI_ChatItem> inSelectedAction = null, bool inFromSetup = false /* Metadata: 0x00782D0B */); // 0x0000000180F22CA0-0x0000000180F22D70
	public void OnSelect(BaseEventData eventData); // 0x0000000180F22C20-0x0000000180F22C70
	public void SetTextSize(int inTextSize); // 0x0000000180F22C70-0x0000000180F22CA0
}

