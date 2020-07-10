/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_IAPShopItem : MonoBehaviour // TypeDefIndex: 12018
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _moreInfoBtn; // 0x20
	[Header] // 0x00000001800C5150-0x00000001800C51A0
	[SerializeField] // 0x00000001800C5150-0x00000001800C51A0
	private CanvasGroup _loadingGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _loadedGroup; // 0x30
	[Header] // 0x00000001800C54D0-0x00000001800C5520
	[SerializeField] // 0x00000001800C54D0-0x00000001800C5520
	private WWImage _iapImage; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x48
	private IAPItem _iapItem; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__7 : IAsyncStateMachine // TypeDefIndex: 12019
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_IAPShopItem <>4__this; // 0x18
		public IAPItem inItem; // 0x20
		public CancellationToken inCancellationToken; // 0x28
		private TaskAwaiter<Sprite> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0510-0x00000001801F0520
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_IAPShopItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	[AsyncStateMachine] // 0x00000001800C5A30-0x00000001800C5A80
	public UniTask Setup(IAPItem inItem, CancellationToken inCancellationToken); // 0x0000000180E41CF0-0x0000000180E41DB0
	public void BtnClicked_MoreInfo(); // 0x0000000180E41CE0-0x0000000180E41CF0
}

