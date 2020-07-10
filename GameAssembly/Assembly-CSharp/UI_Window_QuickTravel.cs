/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_QuickTravel : UI_Window // TypeDefIndex: 12551
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _backBtn; // 0x108
	private UI_WorldMapStage _stage; // 0x110

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12552
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_QuickTravel> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9F4B0-0x0000000180E9F510
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_QuickTravel window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D490-0x0000000180E9D510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_Sanctuary>d__12 : IAsyncStateMachine // TypeDefIndex: 12553
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0770-0x00000001801F0780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_QuickTravel(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EA0D90-0x0000000180EA0E90
	public static void QueueWindow(); // 0x0000000180EA0E90-0x0000000180EA0F90
	public static void CloseWindow(); // 0x0000000180EA0760-0x0000000180EA07B0
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EA0A70-0x0000000180EA0C00
	protected override void DoDelayedOpenAnimation(); // 0x0000000180EA07B0-0x0000000180EA0850
	protected override void OnClose(bool inAnimate); // 0x0000000180EA0850-0x0000000180EA09D0
	public override void OnReceiveFocus(); // 0x0000000180EA0C00-0x0000000180EA0CA0
	public override void OnLoseFocus(); // 0x0000000180EA09D0-0x0000000180EA0A70
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[AsyncStateMachine] // 0x00000001800E14C0-0x00000001800E1510
	public void BtnClicked_Sanctuary(); // 0x0000000180EA06D0-0x0000000180EA0760
	public void BtnClicked_Back(); // 0x0000000180EA06B0-0x0000000180EA06D0
	private void OnUIWorldMapStageLoaded(UIWorldMapStageLoadedMessage inMessage); // 0x0000000180EA0CA0-0x0000000180EA0D90
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__7_0(); // 0x0000000180EA0F90-0x0000000180EA0FF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__7_1(); // 0x00000001809E8060-0x00000001809E8080
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnUIWorldMapStageLoaded>b__14_0(UI_WorldMapButton inLevelButton); // 0x0000000180EA0FF0-0x0000000180EA10A0
}

