/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_OpenQuest : UI_LazyListItemDetailPanel<QuestItemComponent> // TypeDefIndex: 13656
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _noQuestSelectedGroup; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _questSelectedGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _activeQuestGroup; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _nonActiveQuestGroup; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _giverNameText; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ObjectiveItem _objectiveItem; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_QuestSummary _questSummary; // 0x78
	private List<UI_TaskItem> _taskItems; // 0x80

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 13657
	{
		// Fields
		public Quest quest; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__0(); // 0x000000018039E360-0x000000018039E380
	}

	// Constructors
	public UI_LazyListItemDetailPanel_OpenQuest(); // 0x000000018039FE90-0x000000018039FF00

	// Methods
	public override void Setup(UI_LazyListItem<QuestItemComponent> inDataSrc); // 0x000000018039F8A0-0x000000018039FE40
	public void BtnClicked_StartQuestSolo(); // 0x000000018039F680-0x000000018039F760
	private static void SoloAutoStartHelper(); // 0x000000018039FE40-0x000000018039FE90
	public void BtnClicked_StartQuestGroup(); // 0x000000018039F540-0x000000018039F5E0
	public void BtnClicked_StartQuestPublic(); // 0x000000018039F5E0-0x000000018039F680
	private void OnQuestCompleted(QuestCompletedMessage inMessage); // 0x000000018039F7F0-0x000000018039F8A0
	private void Awake(); // 0x000000018039F4B0-0x000000018039F540
	private void OnDestroy(); // 0x000000018039F760-0x000000018039F7F0
}

