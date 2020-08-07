/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_CompletedQuest : UI_LazyListItemDetailPanel<QuestItemComponent> // TypeDefIndex: 13653
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _noQuestSelectedGroup; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _questSelectedGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _giverNameText; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_QuestSummary _uiQuestSummary; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _replayQuestButtonGroup; // 0x68
	private QuestStartMode _questStartMode; // 0x70

	// Nested types
	private enum QuestStartMode // TypeDefIndex: 13654
	{
		Solo = 0,
		Group = 1,
		Public = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13655
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180388060-0x00000001803880C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnQuestOpenSuccess>b__18_0(); // 0x0000000180387930-0x0000000180387980
	}

	// Constructors
	public UI_LazyListItemDetailPanel_CompletedQuest(); // 0x0000000180394D00-0x0000000180394D40

	// Methods
	public override void Setup(UI_LazyListItem<QuestItemComponent> inDataSrc); // 0x0000000180394830-0x0000000180394C80
	private void ReplayQuest(); // 0x0000000180394700-0x0000000180394830
	public void BtnClicked_ReplayQuestSolo(); // 0x00000001803942E0-0x00000001803942F0
	public void BtnClicked_ReplayQuestGroup(); // 0x00000001803942C0-0x00000001803942D0
	public void BtnClicked_ReplayQuestPublic(); // 0x00000001803942D0-0x00000001803942E0
	private void Awake(); // 0x0000000180394230-0x00000001803942C0
	private void OnDestroy(); // 0x00000001803942F0-0x0000000180394380
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x0000000180394380-0x0000000180394450
	private void OnQuestOpenFailure(RequestQuestGenericFailedMessage inMessage); // 0x0000000180394450-0x0000000180394480
	private void OnQuestOpenSuccess(RequestQuestOpenSuccessMessage inMessage); // 0x0000000180394480-0x0000000180394700
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(); // 0x0000000180394C80-0x0000000180394CC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_1(); // 0x0000000180394CC0-0x0000000180394D00
}

