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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_SanctuaryExpansions : UI_Window // TypeDefIndex: 13766
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SanctuaryExpansionRoomControlPanel _controlPanel; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _floorTabGroup; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _applyBtn; // 0x120
	public List<GameObject> floorContainers; // 0x128
	private UI_Stage_SanctuaryExpansionShopStage _stage; // 0x130
	private int _currentRoomIndex; // 0x138
	private int _currentFloorIndex; // 0x13C
	private List<UI_SanctuaryExpansionRoomButton> _activeRoomButtons; // 0x140

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13767
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Shop_SanctuaryExpansions> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Func<bool> <>9__12_0; // 0x18

		// Constructors
		static <>c(); // 0x00000001804486E0-0x0000000180448740
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Shop_SanctuaryExpansions window); // 0x0000000180446680-0x00000001804466A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180446820-0x00000001804468D0
		internal bool <Setup>b__12_0(); // 0x0000000180446950-0x0000000180446A20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 13768
	{
		// Fields
		public int roomToSelect; // 0x10
		public UI_Window_Shop_SanctuaryExpansions <>4__this; // 0x18
		public Func<bool> <>9__2; // 0x20
		public Action <>9__3; // 0x28

		// Constructors
		public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__1(); // 0x0000000180446C00-0x0000000180446F40
		internal bool <Setup>b__2(); // 0x0000000180446F40-0x0000000180446FA0
		internal void <Setup>b__3(); // 0x0000000180446FA0-0x0000000180446FD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoDelayedOpenAnimation>d__14 : IAsyncStateMachine // TypeDefIndex: 13769
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_SanctuaryExpansions <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800046C0-0x00000001800046D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Shop_SanctuaryExpansions(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x000000018044B410-0x000000018044B510
	public static void QueueWindow(); // 0x000000018044B510-0x000000018044B610
	public static void CloseWindow(); // 0x000000018044AEB0-0x000000018044AF00
	private void Setup(); // 0x000000018044B830-0x000000018044B9C0
	protected override void OnOpen(); // 0x000000018044B160-0x000000018044B320
	[AsyncStateMachine] // 0x00000001801FAF60-0x00000001801FAFB0
	protected override void DoDelayedOpenAnimation(); // 0x000000018044AF00-0x000000018044AFB0
	private void OnStageLoaded(UISanctuaryExpansionsShopLoadedStage inMessage); // 0x000000018044B320-0x000000018044B340
	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage); // 0x000000018044B340-0x000000018044B410
	private void Refresh(); // 0x000000018044B340-0x000000018044B410
	protected override void OnClose(bool inAnimate); // 0x000000018044AFB0-0x000000018044B160
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void SetRoomSelection(int inRoomIndex); // 0x000000018044B6A0-0x000000018044B830
	public void ShowFloor(int inFloorIndex); // 0x000000018044B9C0-0x000000018044BBA0
	public void SetButtonActive(UI_SanctuaryExpansionRoomButton inButton, bool inActive); // 0x000000018044B610-0x000000018044B6A0
	public void BtnClicked_Close(); // 0x000000018044ACD0-0x000000018044AEB0
	public void BtnClicked_Apply(); // 0x000000018044A780-0x000000018044ACD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__14_0(); // 0x000000018044BDC0-0x000000018044BE20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Close>b__23_0(bool response); // 0x000000018044BC80-0x000000018044BDC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Apply>b__24_0(bool response); // 0x000000018044BBA0-0x000000018044BC80
}

