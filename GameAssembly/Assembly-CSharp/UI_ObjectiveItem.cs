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

public class UI_ObjectiveItem : MonoBehaviour // TypeDefIndex: 13911
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _taskItemParent; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TaskItem _taskItemPrefab; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _noTasksGroup; // 0x40
	private Quest _quest; // 0x48
	private QuestObjective _objective; // 0x50
	private List<UI_TaskItem> _taskItems; // 0x58
	private bool _isUnread; // 0x60

	// Properties
	public CanvasGroup CanvasGroup { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public Quest Quest { get; } // 0x00000001803743E0-0x00000001803743F0 
	public bool IsUnread { get; } // 0x00000001803CE080-0x00000001803CE090 

	// Constructors
	public UI_ObjectiveItem(); // 0x00000001803CE010-0x00000001803CE080

	// Methods
	public void Setup(Quest inQuest); // 0x00000001803CD940-0x00000001803CDD50
	public void MarkAsRead(); // 0x00000001803CD8B0-0x00000001803CD8C0
	private void SpawnTaskItems(); // 0x00000001803CDD50-0x00000001803CE010
	private void RefreshText(); // 0x00000001803CD8C0-0x00000001803CD940
}

