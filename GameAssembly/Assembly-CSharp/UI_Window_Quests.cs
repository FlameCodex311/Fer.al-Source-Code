/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Quests : UI_Window // TypeDefIndex: 14149
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _mainTabGroup; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_OpenQuest _openQuestItemList; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_CompletedQuest _completedQuestItemList; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 14150
	{
		// Fields
		public bool inViewOpenQuests; // 0x10
		public QuestItemComponent inQuestToSelect; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Quests window); // 0x00000001803B3E70-0x00000001803B3EA0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14151
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803B4160-0x00000001803B41C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__5_0(UI_Window inWindow); // 0x00000001803B2AB0-0x00000001803B2B70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 14152
	{
		// Fields
		public QuestCompletedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnQuestCompleted>b__0(UI_LazyItemList<QuestItemComponent> item); // 0x00000001803B3000-0x00000001803B3030
	}

	// Constructors
	public UI_Window_Quests(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(bool inViewOpenQuests = true /* Metadata: 0x007BA6C9 */, QuestItemComponent inQuestToSelect = null, bool inAnimate = true /* Metadata: 0x007BA6CA */); // 0x00000001803B59E0-0x00000001803B5AC0
	public static void QueueWindow(); // 0x00000001803B5AC0-0x00000001803B5BC0
	public static void CloseWindow(); // 0x00000001803B5230-0x00000001803B5280
	public override void MOnDestroy(); // 0x00000001803B5280-0x00000001803B53A0
	public override void OnReceiveFocus(); // 0x00000001803B58C0-0x00000001803B58D0
	public override void OnLoseFocus(); // 0x00000001803B5460-0x00000001803B5470
	protected override void OnOpen(bool inAnimate); // 0x00000001803B5470-0x00000001803B5570
	protected override void OnClose(bool inAnimate); // 0x00000001803B53A0-0x00000001803B5460
	public void BtnClicked_Group(); // 0x00000001803B50F0-0x00000001803B5190
	public void BtnClicked_Notifications(); // 0x00000001803B5190-0x00000001803B5230
	public void OnSearchUpdated(string inSearch); // 0x00000001803B58E0-0x00000001803B5960
	public void OnSortUpdated(int inSelectedOption); // 0x00000001803B5960-0x00000001803B59E0
	private void Setup(bool inViewOpenQuests = true /* Metadata: 0x007BA6CB */, QuestItemComponent inQuestToSelect = null); // 0x00000001803B5BC0-0x00000001803B5F40
	private void OnQuestReopened(RequestQuestOpenSuccessMessage inMessage); // 0x00000001803B56F0-0x00000001803B58C0
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x00000001803B5570-0x00000001803B56F0
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Group>b__12_0(); // 0x00000001803B5F40-0x00000001803B5F50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Notifications>b__13_0(); // 0x00000001803B5F40-0x00000001803B5F50
}

