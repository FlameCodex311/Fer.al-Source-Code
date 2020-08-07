/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_QuickTravel : UI_Window // TypeDefIndex: 14153
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _backBtn; // 0x108
	private UI_WorldMapStage _stage; // 0x110

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14154
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_QuickTravel> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B4340-0x00000001803B43A0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_QuickTravel window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B28B0-0x00000001803B2930
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_Sanctuary>d__12 : IAsyncStateMachine // TypeDefIndex: 14155
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter<bool> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002370-0x0000000180002380
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_QuickTravel(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803B6630-0x00000001803B6730
	public static void QueueWindow(); // 0x00000001803B6730-0x00000001803B6830
	public static void CloseWindow(); // 0x00000001803B6000-0x00000001803B6050
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803B6310-0x00000001803B64A0
	protected override void DoDelayedOpenAnimation(); // 0x00000001803B6050-0x00000001803B60F0
	protected override void OnClose(bool inAnimate); // 0x00000001803B60F0-0x00000001803B6270
	public override void OnReceiveFocus(); // 0x00000001803B64A0-0x00000001803B6540
	public override void OnLoseFocus(); // 0x00000001803B6270-0x00000001803B6310
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[AsyncStateMachine] // 0x00000001801D0480-0x00000001801D04D0
	public void BtnClicked_Sanctuary(); // 0x00000001803B5F70-0x00000001803B6000
	public void BtnClicked_Back(); // 0x00000001803B5F50-0x00000001803B5F70
	private void OnUIWorldMapStageLoaded(UIWorldMapStageLoadedMessage inMessage); // 0x00000001803B6540-0x00000001803B6630
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__7_0(); // 0x00000001803B6830-0x00000001803B6890
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__7_1(); // 0x00000001803B6890-0x00000001803B68B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnUIWorldMapStageLoaded>b__14_0(UI_WorldMapButton inLevelButton); // 0x00000001803B68B0-0x00000001803B6960
}

