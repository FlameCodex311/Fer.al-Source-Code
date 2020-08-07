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

public class UI_LazyListItem_SeasonPassChallenges : UI_LazyListItem<ISeasonPassChallenge> // TypeDefIndex: 13671
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardText; // 0x70
	[Header] // 0x000000018023F220-0x000000018023F270
	[SerializeField] // 0x000000018023F220-0x000000018023F270
	private WWImage _progressImage; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupComplete; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _progressText; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _progressColorIncomplete; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _progressColorComplete; // 0xA0

	// Constructors
	public UI_LazyListItem_SeasonPassChallenges(); // 0x00000001803ACCE0-0x00000001803ACD50

	// Methods
	public override void Setup(Action<UI_LazyListItem<ISeasonPassChallenge>> inOnClicked, Action<UI_LazyListItem<ISeasonPassChallenge>> inOnSelected, ISeasonPassChallenge inData, UI_LazyItemList<ISeasonPassChallenge> inItemList); // 0x00000001803AC940-0x00000001803ACC00
	public override void Refresh(); // 0x00000001803AC750-0x00000001803AC940
	protected override void Start(); // 0x00000001803ACC00-0x00000001803ACCE0
	private void OnDestroy(); // 0x00000001803AC680-0x00000001803AC750
	private void OnChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage); // 0x00000001803AC5F0-0x00000001803AC680
	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x00000001803AC560-0x00000001803AC5F0
}

