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

public class UI_QuestSummary : MonoBehaviour // TypeDefIndex: 12340
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _completeColor; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _incompleteColor; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _sideQuestsText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _sideQuestsGroup; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _cindersDefeatedText; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _cindersDefeatedGroup; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _secretsFoundText; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _secretsFoundGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _treasuresFoundText; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _treasuresFoundGroup; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _puzzlesSolvedText; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _puzzlesSolvedGroup; // 0x88
	[Header] // 0x00000001800EE7A0-0x00000001800EE7F0
	[SerializeField] // 0x00000001800EE7A0-0x00000001800EE7F0
	private WWImage _progressImage; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Slider _progressSlider; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _progressText; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _fullCompletionGroup; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Selectable _fullCompletionSelectable; // 0xB0
	private QuestSummary _summary; // 0xB8
	private Func<bool> _questIsCompleteFunc; // 0xC0

	// Properties
	public WWImage ProgessImage { get; } // 0x0000000180382A80-0x0000000180382A90 
	public WWTextMeshProUGUI ProgressText { get; } // 0x0000000180382AA0-0x0000000180382AB0 
	private bool QuestIsComplete { get; } // 0x0000000180EE7AD0-0x0000000180EE7B20 

	// Constructors
	public UI_QuestSummary(); // 0x0000000180EE7A90-0x0000000180EE7AD0

	// Methods
	public void Setup(QuestSummary inSummary, Func<bool> inQuestIsComplete = null); // 0x0000000180EE7950-0x0000000180EE7A00
	private void Refresh(); // 0x0000000180EE6B60-0x0000000180EE7350
	private void Start(); // 0x0000000180EE7A00-0x0000000180EE7A90
	private void OnDestroy(); // 0x0000000180EE6800-0x0000000180EE6890
	private void OnQuestSummaryUpdated(QuestSummaryUpdatedMessage inMessage); // 0x0000000180EE6890-0x0000000180EE68C0
	private void SetSideQuestsProgress(int inCurrent, int inTotal); // 0x0000000180EE76F0-0x0000000180EE7820
	private void SetCindersDefeatedProgress(int inCurrent, int inTotal); // 0x0000000180EE7350-0x0000000180EE7480
	private void SetSecretsFoundProgress(int inCurrent, int inTotal); // 0x0000000180EE75C0-0x0000000180EE76F0
	private void SetTreasuresFoundProgress(int inCurrent, int inTotal); // 0x0000000180EE7820-0x0000000180EE7950
	private void SetPuzzlesSolvedProgress(int inCurrent, int inTotal); // 0x0000000180EE7480-0x0000000180EE75C0
	private void RefreshCompletion(); // 0x0000000180EE68C0-0x0000000180EE6B60
}

