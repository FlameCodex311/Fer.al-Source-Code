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

public class UI_IAPDetailItem : MonoBehaviour // TypeDefIndex: 13562
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _bulletPointImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 13563
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
		private void MoveNext(); // 0x0000000180002010-0x0000000180002020
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_IAPDetailItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(string inLongDescription); // 0x0000000180379370-0x00000001803793F0
	[AsyncStateMachine] // 0x0000000180267EE0-0x0000000180267F30
	public UniTask Setup(IAPItemReward inDetail, CancellationToken inCancellationToken); // 0x00000001803793F0-0x00000001803794B0
}

