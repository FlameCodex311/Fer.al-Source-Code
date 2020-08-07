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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatItem : MonoBehaviour, ISelectHandler // TypeDefIndex: 13476
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _contentText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _nameTextColorMe; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _nameTextColorOther; // 0x40
	private Action<UI_ChatItem> _onSelectedAction; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__5 : IAsyncStateMachine // TypeDefIndex: 13477
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatItem <>4__this; // 0x28
		public string inUserId; // 0x30
		public string inContent; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180006700-0x0000000180006710
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_ChatItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	[AsyncStateMachine] // 0x0000000180246550-0x00000001802465A0
	public void Setup(string inUserId, string inContent, Action<UI_ChatItem> inSelectedAction = null, bool inFromSetup = false /* Metadata: 0x007BA419 */); // 0x00000001805406F0-0x00000001805407C0
	public void OnSelect(BaseEventData eventData); // 0x0000000180540670-0x00000001805406C0
	public void SetTextSize(int inTextSize); // 0x00000001805406C0-0x00000001805406F0
}

