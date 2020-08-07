/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TaskItem : MonoBehaviour // TypeDefIndex: 13957
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _isUnreadGameObject; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _isCompleteToggle; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _taskDescription; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _progressText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _taskCompleteColor; // 0x48
	private QuestTask _task; // 0x58

	// Constructors
	public UI_TaskItem(); // 0x00000001804D4C50-0x00000001804D4C80

	// Methods
	public void Setup(QuestTask inTask, bool inIsFinalObjective); // 0x00000001804D47A0-0x00000001804D4C50
	private void RefreshText(); // 0x00000001804D4640-0x00000001804D47A0
	private void RefreshIsCompleted(); // 0x00000001804D4480-0x00000001804D45C0
	private void RefreshIsUnread(); // 0x00000001804D45C0-0x00000001804D4640
}

