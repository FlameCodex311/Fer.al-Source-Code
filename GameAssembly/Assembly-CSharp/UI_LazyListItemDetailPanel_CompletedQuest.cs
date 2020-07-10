/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_CompletedQuest : UI_LazyListItemDetailPanel<QuestItemComponent> // TypeDefIndex: 12109
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _noQuestSelectedGroup; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _questSelectedGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _giverNameText; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_QuestSummary _uiQuestSummary; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _replayQuestButtonGroup; // 0x68
	private QuestStartMode _questStartMode; // 0x70

	// Nested types
	private enum QuestStartMode // TypeDefIndex: 12110
	{
		Solo = 0,
		Group = 1,
		Public = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12111
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E5AAF0-0x0000000180E5AB50
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnQuestOpenSuccess>b__18_0(); // 0x0000000180E5A6F0-0x0000000180E5A740
	}

	// Constructors
	public UI_LazyListItemDetailPanel_CompletedQuest(); // 0x0000000180E631F0-0x0000000180E63230

	// Methods
	public override void Setup(UI_LazyListItem<QuestItemComponent> inDataSrc); // 0x0000000180E62D00-0x0000000180E63170
	private void ReplayQuest(); // 0x0000000180E62BD0-0x0000000180E62D00
	public void BtnClicked_ReplayQuestSolo(); // 0x0000000180E627A0-0x0000000180E627B0
	public void BtnClicked_ReplayQuestGroup(); // 0x0000000180E62780-0x0000000180E62790
	public void BtnClicked_ReplayQuestPublic(); // 0x0000000180E62790-0x0000000180E627A0
	private void Awake(); // 0x0000000180E626F0-0x0000000180E62780
	private void OnDestroy(); // 0x0000000180E627B0-0x0000000180E62840
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x0000000180E62840-0x0000000180E62920
	private void OnQuestOpenFailure(RequestQuestGenericFailedMessage inMessage); // 0x0000000180E62920-0x0000000180E62950
	private void OnQuestOpenSuccess(RequestQuestOpenSuccessMessage inMessage); // 0x0000000180E62950-0x0000000180E62BD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(); // 0x0000000180E63170-0x0000000180E631B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_1(); // 0x0000000180E631B0-0x0000000180E631F0
}

