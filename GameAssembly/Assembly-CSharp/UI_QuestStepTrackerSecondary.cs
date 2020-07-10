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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180141270-0x00000001801412A0
public class UI_QuestStepTrackerSecondary : ManagedBehaviour // TypeDefIndex: 12339
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _bgImage; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ObjectiveItem _objectiveItemPrefab; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _objectiveItemParent; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _unreadCountText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _unreadCountGroup; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _selectLeftBtn; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _selectRightBtn; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _questAddedSound; // 0x88
	private List<UI_ObjectiveItem> _objectiveItems; // 0x90
	private bool _isSlidOut; // 0x98
	private int _selectedIndex; // 0x9C

	// Constructors
	public UI_QuestStepTrackerSecondary(); // 0x0000000180EE6770-0x0000000180EE6800

	// Methods
	public override void MStart(); // 0x0000000180EE5930-0x0000000180EE5B10
	public override void MOnDestroy(); // 0x0000000180EE57D0-0x0000000180EE5930
	public void BtnClicked_SlideOutTab(); // 0x0000000180EE5540-0x0000000180EE56E0
	public void BtnClicked_SelectLeft(); // 0x0000000180EE54C0-0x0000000180EE54E0
	public void BtnClicked_SelectRight(); // 0x0000000180EE54E0-0x0000000180EE5540
	private void SelectItem(int inIndexToSelect); // 0x0000000180EE6180-0x0000000180EE6440
	private void RefreshSelectionButtons(); // 0x0000000180EE5D00-0x0000000180EE5D90
	private void RefreshUnreadCount(); // 0x0000000180EE5D90-0x0000000180EE5F90
	private void SpawnSecondaryQuestItem(Quest inSecondaryQuest); // 0x0000000180EE6440-0x0000000180EE65E0
	private void UpdateSecondaryQuestItem(Quest inSecondaryQuest); // 0x0000000180EE65E0-0x0000000180EE6770
	private void CompleteSecondaryQuestItem(UI_ObjectiveItem inObjectiveItem); // 0x0000000180EE56E0-0x0000000180EE57D0
	private void RemoveSecondaryQuestItem(Quest inSecondaryQuest); // 0x0000000180EE5F90-0x0000000180EE6180
	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage); // 0x0000000180EE5B10-0x0000000180EE5C40
	private void OnSecondaryQuestAdded(SecondaryQuestAddedMessage inMessage); // 0x0000000180EE5C40-0x0000000180EE5CA0
	private void OnSecondaryQuestUpdated(SecondaryQuestUpdatedMessage inMessage); // 0x0000000180EE5CD0-0x0000000180EE5D00
	private void OnSecondaryQuestRemoved(SecondaryQuestRemovedMessage inMessage); // 0x0000000180EE5CA0-0x0000000180EE5CD0
}

