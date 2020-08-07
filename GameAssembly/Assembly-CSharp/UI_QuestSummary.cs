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

public class UI_QuestSummary : MonoBehaviour // TypeDefIndex: 13924
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _completeColor; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _incompleteColor; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _sideQuestsText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _sideQuestsGroup; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _cindersDefeatedText; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _cindersDefeatedGroup; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _secretsFoundText; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _secretsFoundGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _treasuresFoundText; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _treasuresFoundGroup; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _puzzlesSolvedText; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _puzzlesSolvedGroup; // 0x88
	[Header] // 0x000000018023F220-0x000000018023F270
	[SerializeField] // 0x000000018023F220-0x000000018023F270
	private WWImage _progressImage; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Slider _progressSlider; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _progressText; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _fullCompletionGroup; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Selectable _fullCompletionSelectable; // 0xB0
	private QuestSummary _summary; // 0xB8
	private Func<bool> _questIsCompleteFunc; // 0xC0

	// Properties
	public WWImage ProgessImage { get; } // 0x00000001803D6D80-0x00000001803D6D90 
	public WWTextMeshProUGUI ProgressText { get; } // 0x00000001803D6D90-0x00000001803D6DA0 
	private bool QuestIsComplete { get; } // 0x00000001803D6DA0-0x00000001803D6DF0 

	// Constructors
	public UI_QuestSummary(); // 0x00000001803D6D40-0x00000001803D6D80

	// Methods
	public void Setup(QuestSummary inSummary, Func<bool> inQuestIsComplete = null); // 0x00000001803D6C00-0x00000001803D6CB0
	private void Refresh(); // 0x00000001803D5E50-0x00000001803D6600
	private void Start(); // 0x00000001803D6CB0-0x00000001803D6D40
	private void OnDestroy(); // 0x00000001803D5B00-0x00000001803D5B90
	private void OnQuestSummaryUpdated(QuestSummaryUpdatedMessage inMessage); // 0x00000001803D5B90-0x00000001803D5BC0
	private void SetSideQuestsProgress(int inCurrent, int inTotal); // 0x00000001803D69A0-0x00000001803D6AD0
	private void SetCindersDefeatedProgress(int inCurrent, int inTotal); // 0x00000001803D6600-0x00000001803D6730
	private void SetSecretsFoundProgress(int inCurrent, int inTotal); // 0x00000001803D6870-0x00000001803D69A0
	private void SetTreasuresFoundProgress(int inCurrent, int inTotal); // 0x00000001803D6AD0-0x00000001803D6C00
	private void SetPuzzlesSolvedProgress(int inCurrent, int inTotal); // 0x00000001803D6730-0x00000001803D6870
	private void RefreshCompletion(); // 0x00000001803D5BC0-0x00000001803D5E50
}

