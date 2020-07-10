/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_IAPLoadingWebApp : UI_Window // TypeDefIndex: 12495
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12496
	{
		// Fields
		public IAPItem inIAP; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_IAPLoadingWebApp window); // 0x0000000180ECE120-0x0000000180ECE150
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12497
	{
		// Fields
		public IAPItem inIAP; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECEB00-0x0000000180ECEBD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__4 : IAsyncStateMachine // TypeDefIndex: 12498
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public IAPItem inIAP; // 0x28
		public UI_Window_IAPLoadingWebApp <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38
		private UniTask<WWWResponse<StorePageURLResponse>> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F1050-0x00000001801F1060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_IAPLoadingWebApp(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(IAPItem inIAP); // 0x0000000180ED5710-0x0000000180ED57D0
	public static void QueueWindow(IAPItem inIAP); // 0x0000000180ED57D0-0x0000000180ED5890
	public static void CloseWindow(); // 0x0000000180ED56C0-0x0000000180ED5710
	[AsyncStateMachine] // 0x00000001800C7050-0x00000001800C70A0
	private void Setup(IAPItem inIAP); // 0x0000000180ED5890-0x0000000180ED5950
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

