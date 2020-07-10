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

public class UI_ObjectiveItem : MonoBehaviour // TypeDefIndex: 12327
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _taskItemParent; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TaskItem _taskItemPrefab; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _noTasksGroup; // 0x40
	private Quest _quest; // 0x48
	private QuestObjective _objective; // 0x50
	private List<UI_TaskItem> _taskItems; // 0x58
	private bool _isUnread; // 0x60

	// Properties
	public CanvasGroup CanvasGroup { get; } // 0x000000018036AC70-0x000000018036AC80 
	public Quest Quest { get; } // 0x0000000180369C40-0x0000000180369C50 
	public bool IsUnread { get; } // 0x00000001804785B0-0x00000001804785C0 

	// Constructors
	public UI_ObjectiveItem(); // 0x0000000180E84750-0x0000000180E847C0

	// Methods
	public void Setup(Quest inQuest); // 0x0000000180E84050-0x0000000180E84480
	public void MarkAsRead(); // 0x0000000180E83FC0-0x0000000180E83FD0
	private void SpawnTaskItems(); // 0x0000000180E84480-0x0000000180E84750
	private void RefreshText(); // 0x0000000180E83FD0-0x0000000180E84050
}

