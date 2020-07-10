/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Quests : UI_Window // TypeDefIndex: 12547
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _mainTabGroup; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_OpenQuest _openQuestItemList; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_CompletedQuest _completedQuestItemList; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 12548
	{
		// Fields
		public bool inViewOpenQuests; // 0x10
		public QuestItemComponent inQuestToSelect; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Quests window); // 0x0000000180E9EF80-0x0000000180E9EFB0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12549
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E9F2D0-0x0000000180E9F330
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__5_0(UI_Window inWindow); // 0x0000000180E9D690-0x0000000180E9D750
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12550
	{
		// Fields
		public QuestCompletedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnQuestCompleted>b__0(UI_LazyItemList<QuestItemComponent> item); // 0x0000000180E9DDE0-0x0000000180E9DE20
	}

	// Constructors
	public UI_Window_Quests(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(bool inViewOpenQuests = true /* Metadata: 0x00782FB1 */, QuestItemComponent inQuestToSelect = null, bool inAnimate = true /* Metadata: 0x00782FB2 */); // 0x0000000180EA0130-0x0000000180EA0210
	public static void QueueWindow(); // 0x0000000180EA0210-0x0000000180EA0310
	public static void CloseWindow(); // 0x0000000180E9F980-0x0000000180E9F9D0
	public override void MOnDestroy(); // 0x0000000180E9F9D0-0x0000000180E9FAF0
	public override void OnReceiveFocus(); // 0x0000000180EA0010-0x0000000180EA0020
	public override void OnLoseFocus(); // 0x0000000180E9FBB0-0x0000000180E9FBC0
	protected override void OnOpen(bool inAnimate); // 0x0000000180E9FBC0-0x0000000180E9FCC0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9FAF0-0x0000000180E9FBB0
	public void BtnClicked_Group(); // 0x0000000180E9F840-0x0000000180E9F8E0
	public void BtnClicked_Notifications(); // 0x0000000180E9F8E0-0x0000000180E9F980
	public void OnSearchUpdated(string inSearch); // 0x0000000180EA0030-0x0000000180EA00B0
	public void OnSortUpdated(int inSelectedOption); // 0x0000000180EA00B0-0x0000000180EA0130
	private void Setup(bool inViewOpenQuests = true /* Metadata: 0x00782FB3 */, QuestItemComponent inQuestToSelect = null); // 0x0000000180EA0310-0x0000000180EA06A0
	private void OnQuestReopened(RequestQuestOpenSuccessMessage inMessage); // 0x0000000180E9FE40-0x0000000180EA0010
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x0000000180E9FCC0-0x0000000180E9FE40
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Group>b__12_0(); // 0x0000000180EA06A0-0x0000000180EA06B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Notifications>b__13_0(); // 0x0000000180EA06A0-0x0000000180EA06B0
}

