/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TaskItem : MonoBehaviour // TypeDefIndex: 12372
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _isUnreadGameObject; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _isCompleteToggle; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _taskDescription; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _progressText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _taskCompleteColor; // 0x48
	private QuestTask _task; // 0x58

	// Constructors
	public UI_TaskItem(); // 0x0000000180F93EF0-0x0000000180F93F20

	// Methods
	public void Setup(QuestTask inTask, bool inIsFinalObjective); // 0x0000000180F93B40-0x0000000180F93EF0
	private void RefreshText(); // 0x0000000180F939E0-0x0000000180F93B40
	private void RefreshIsCompleted(); // 0x0000000180F93820-0x0000000180F93960
	private void RefreshIsUnread(); // 0x0000000180F93960-0x0000000180F939E0
}

