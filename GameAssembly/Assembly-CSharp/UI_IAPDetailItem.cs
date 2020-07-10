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

public class UI_IAPDetailItem : MonoBehaviour // TypeDefIndex: 12016
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _bulletPointImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 12017
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_IAPDetailItem <>4__this; // 0x18
		public IAPItemReward inDetail; // 0x20
		public CancellationToken inCancellationToken; // 0x28
		private bool <hasImage>5__2; // 0x30
		private TaskAwaiter<Sprite> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F04F0-0x00000001801F0500
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_IAPDetailItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(string inLongDescription); // 0x0000000180E41BA0-0x0000000180E41C20
	[AsyncStateMachine] // 0x00000001800C3880-0x00000001800C38D0
	public UniTask Setup(IAPItemReward inDetail, CancellationToken inCancellationToken); // 0x0000000180E41C20-0x0000000180E41CE0
}

