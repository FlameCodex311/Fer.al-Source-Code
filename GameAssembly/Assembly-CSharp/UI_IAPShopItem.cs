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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_IAPShopItem : MonoBehaviour // TypeDefIndex: 13564
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _moreInfoBtn; // 0x20
	[Header] // 0x00000001802683B0-0x0000000180268400
	[SerializeField] // 0x00000001802683B0-0x0000000180268400
	private CanvasGroup _loadingGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _loadedGroup; // 0x30
	[Header] // 0x00000001801E6260-0x00000001801E62B0
	[SerializeField] // 0x00000001801E6260-0x00000001801E62B0
	private WWImage _iapImage; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x48
	private IAPItem _iapItem; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__7 : IAsyncStateMachine // TypeDefIndex: 13565
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_IAPShopItem <>4__this; // 0x18
		public IAPItem inItem; // 0x20
		public CancellationToken inCancellationToken; // 0x28
		private TaskAwaiter<Sprite> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002030-0x0000000180002040
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_IAPShopItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	[AsyncStateMachine] // 0x0000000180268920-0x0000000180268970
	public UniTask Setup(IAPItem inItem, CancellationToken inCancellationToken); // 0x00000001803794C0-0x0000000180379580
	public void BtnClicked_MoreInfo(); // 0x00000001803794B0-0x00000001803794C0
}

