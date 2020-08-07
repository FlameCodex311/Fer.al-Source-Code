/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018023B950-0x000000018023B980
public class UI_QuestStepTrackerSecondary : ManagedBehaviour // TypeDefIndex: 13923
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _bgImage; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ObjectiveItem _objectiveItemPrefab; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _objectiveItemParent; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _unreadCountText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _unreadCountGroup; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _selectLeftBtn; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _selectRightBtn; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _questAddedSound; // 0x88
	private List<UI_ObjectiveItem> _objectiveItems; // 0x90
	private bool _isSlidOut; // 0x98
	private int _selectedIndex; // 0x9C

	// Constructors
	public UI_QuestStepTrackerSecondary(); // 0x00000001803D5A70-0x00000001803D5B00

	// Methods
	public override void MStart(); // 0x00000001803D4C80-0x00000001803D4E50
	public override void MOnDestroy(); // 0x00000001803D4B20-0x00000001803D4C80
	public void BtnClicked_SlideOutTab(); // 0x00000001803D48A0-0x00000001803D4A30
	public void BtnClicked_SelectLeft(); // 0x00000001803D4820-0x00000001803D4840
	public void BtnClicked_SelectRight(); // 0x00000001803D4840-0x00000001803D48A0
	private void SelectItem(int inIndexToSelect); // 0x00000001803D5490-0x00000001803D5740
	private void RefreshSelectionButtons(); // 0x00000001803D5020-0x00000001803D50B0
	private void RefreshUnreadCount(); // 0x00000001803D50B0-0x00000001803D52B0
	private void SpawnSecondaryQuestItem(Quest inSecondaryQuest); // 0x00000001803D5740-0x00000001803D58E0
	private void UpdateSecondaryQuestItem(Quest inSecondaryQuest); // 0x00000001803D58E0-0x00000001803D5A70
	private void CompleteSecondaryQuestItem(UI_ObjectiveItem inObjectiveItem); // 0x00000001803D4A30-0x00000001803D4B20
	private void RemoveSecondaryQuestItem(Quest inSecondaryQuest); // 0x00000001803D52B0-0x00000001803D5490
	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage); // 0x00000001803D4E50-0x00000001803D4F80
	private void OnSecondaryQuestAdded(SecondaryQuestAddedMessage inMessage); // 0x00000001803D4F80-0x00000001803D4FE0
	private void OnSecondaryQuestUpdated(SecondaryQuestUpdatedMessage inMessage); // 0x00000001803D5000-0x00000001803D5020
	private void OnSecondaryQuestRemoved(SecondaryQuestRemovedMessage inMessage); // 0x00000001803D4FE0-0x00000001803D5000
}

