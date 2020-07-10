/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_SanctuaryExpansions : UI_Window // TypeDefIndex: 12216
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SanctuaryExpansionRoomControlPanel _controlPanel; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _floorTabGroup; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _applyBtn; // 0x120
	public List<GameObject> floorContainers; // 0x128
	private UI_Stage_SanctuaryExpansionShopStage _stage; // 0x130
	private int _currentRoomIndex; // 0x138
	private int _currentFloorIndex; // 0x13C
	private List<UI_SanctuaryExpansionRoomButton> _activeRoomButtons; // 0x140

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12217
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Shop_SanctuaryExpansions> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Func<bool> <>9__12_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180F7B670-0x0000000180F7B6D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Shop_SanctuaryExpansions window); // 0x0000000180F79DD0-0x0000000180F79E00
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180F79F80-0x0000000180F7A030
		internal bool <Setup>b__12_0(); // 0x0000000180F7A0B0-0x0000000180F7A180
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 12218
	{
		// Fields
		public int roomToSelect; // 0x10
		public UI_Window_Shop_SanctuaryExpansions <>4__this; // 0x18
		public Func<bool> <>9__2; // 0x20
		public Action <>9__3; // 0x28

		// Constructors
		public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__1(); // 0x0000000180F7A360-0x0000000180F7A6B0
		internal bool <Setup>b__2(); // 0x0000000180F7A6B0-0x0000000180F7A710
		internal void <Setup>b__3(); // 0x0000000180F7A710-0x0000000180F7A740
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoDelayedOpenAnimation>d__14 : IAsyncStateMachine // TypeDefIndex: 12219
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_SanctuaryExpansions <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F17C0-0x00000001801F17D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Shop_SanctuaryExpansions(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EB1EF0-0x0000000180EB1FF0
	public static void QueueWindow(); // 0x0000000180EB1FF0-0x0000000180EB20F0
	public static void CloseWindow(); // 0x0000000180EB1970-0x0000000180EB19C0
	private void Setup(); // 0x0000000180EB2320-0x0000000180EB24B0
	protected override void OnOpen(); // 0x0000000180EB1C20-0x0000000180EB1DE0
	[AsyncStateMachine] // 0x0000000180113310-0x0000000180113360
	protected override void DoDelayedOpenAnimation(); // 0x0000000180EB19C0-0x0000000180EB1A70
	private void OnStageLoaded(UISanctuaryExpansionsShopLoadedStage inMessage); // 0x0000000180EB1DE0-0x0000000180EB1E10
	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage); // 0x0000000180EB1E10-0x0000000180EB1EF0
	private void Refresh(); // 0x0000000180EB1E10-0x0000000180EB1EF0
	protected override void OnClose(bool inAnimate); // 0x0000000180EB1A70-0x0000000180EB1C20
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void SetRoomSelection(int inRoomIndex); // 0x0000000180EB2180-0x0000000180EB2320
	public void ShowFloor(int inFloorIndex); // 0x0000000180EB24B0-0x0000000180EB26A0
	public void SetButtonActive(UI_SanctuaryExpansionRoomButton inButton, bool inActive); // 0x0000000180EB20F0-0x0000000180EB2180
	public void BtnClicked_Close(); // 0x0000000180EB1840-0x0000000180EB1970
	public void BtnClicked_Apply(); // 0x0000000180EB12D0-0x0000000180EB1840
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__14_0(); // 0x0000000180EB28C0-0x0000000180EB2920
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Close>b__23_0(bool response); // 0x0000000180EB2780-0x0000000180EB28C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Apply>b__24_0(bool response); // 0x0000000180EB26A0-0x0000000180EB2780
}

