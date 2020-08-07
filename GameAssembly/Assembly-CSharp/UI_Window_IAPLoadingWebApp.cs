/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_IAPLoadingWebApp : UI_Window // TypeDefIndex: 14094
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14095
	{
		// Fields
		public IAPItem inIAP; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_IAPLoadingWebApp window); // 0x00000001803E1720-0x00000001803E1750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14096
	{
		// Fields
		public IAPItem inIAP; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E1FA0-0x00000001803E2070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__4 : IAsyncStateMachine // TypeDefIndex: 14097
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public IAPItem inIAP; // 0x28
		public UI_Window_IAPLoadingWebApp <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38
		private UniTask<WWWResponse<StorePageURLResponse>> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800026D0-0x00000001800026E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_IAPLoadingWebApp(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(IAPItem inIAP); // 0x00000001803E8950-0x00000001803E8A10
	public static void QueueWindow(IAPItem inIAP); // 0x00000001803E8A10-0x00000001803E8AD0
	public static void CloseWindow(); // 0x00000001803E8900-0x00000001803E8950
	[AsyncStateMachine] // 0x00000001802809E0-0x0000000180280A30
	private void Setup(IAPItem inIAP); // 0x00000001803E8AD0-0x00000001803E8B90
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

