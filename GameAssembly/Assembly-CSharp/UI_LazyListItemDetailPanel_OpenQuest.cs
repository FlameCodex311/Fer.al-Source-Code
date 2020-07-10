/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_OpenQuest : UI_LazyListItemDetailPanel<QuestItemComponent> // TypeDefIndex: 12112
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _noQuestSelectedGroup; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _questSelectedGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _activeQuestGroup; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _nonActiveQuestGroup; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _giverNameText; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ObjectiveItem _objectiveItem; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_QuestSummary _questSummary; // 0x78
	private List<UI_TaskItem> _taskItems; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12113
	{
		// Fields
		public Quest quest; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__0(); // 0x0000000180E5A8F0-0x0000000180E5A910
	}

	// Constructors
	public UI_LazyListItemDetailPanel_OpenQuest(); // 0x0000000180E6C760-0x0000000180E6C7D0

	// Methods
	public override void Setup(UI_LazyListItem<QuestItemComponent> inDataSrc); // 0x0000000180E6C150-0x0000000180E6C710
	public void BtnClicked_StartQuestSolo(); // 0x0000000180E6BF30-0x0000000180E6C010
	private static void SoloAutoStartHelper(); // 0x0000000180E6C710-0x0000000180E6C760
	public void BtnClicked_StartQuestGroup(); // 0x0000000180E6BDF0-0x0000000180E6BE90
	public void BtnClicked_StartQuestPublic(); // 0x0000000180E6BE90-0x0000000180E6BF30
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x0000000180E6C0A0-0x0000000180E6C150
	private void Awake(); // 0x0000000180E6BD60-0x0000000180E6BDF0
	private void OnDestroy(); // 0x0000000180E6C010-0x0000000180E6C0A0
}

