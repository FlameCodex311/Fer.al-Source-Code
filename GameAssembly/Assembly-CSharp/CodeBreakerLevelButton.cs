/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerLevelButton : MonoBehaviour // TypeDefIndex: 12891
{
	// Fields
	public bool redLevel; // 0x20
	public WWButton levelButton; // 0x28
	public WWTextMeshProUGUI levelText; // 0x30
	public CanvasGroup canvasGroup; // 0x38
	public GameObject levelIcon; // 0x40
	public GameObject levelIcon_Red; // 0x48
	public GameObject levelIconSelected_NoStar; // 0x50
	public GameObject levelIconSelected_NoStar_Red; // 0x58
	public GameObject levelIconSelected_OneStar; // 0x60
	public GameObject levelIconSelected_OneStar_Red; // 0x68
	public GameObject levelIconSelected_TwoStar; // 0x70
	public GameObject levelIconSelected_TwoStar_Red; // 0x78
	public GameObject levelIconSelected_ThreeStar; // 0x80
	public GameObject levelIconSelected_ThreeStar_Red; // 0x88
	public GameObject oneStar; // 0x90
	public GameObject twoStar; // 0x98
	public GameObject threeStar; // 0xA0
	public GameObject levelLockedIcon; // 0xA8
	private ObscuredInt _level; // 0xB0
	private bool _locked; // 0xC4
	private long _bestScore; // 0xC8
	private int _stars; // 0xD0

	// Properties
	public long BestScore { get; } // 0x00000001804A2590-0x00000001804A25A0 

	// Constructors
	public CodeBreakerLevelButton(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000181271BC0-0x0000000181271C50
	private void OnDestroy(); // 0x00000001812712F0-0x0000000181271380
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x0000000181271380-0x00000001812713E0
	public void SetSelected(bool inSelected); // 0x0000000181271700-0x0000000181271AB0
	private void ShowStars(int inStarCount); // 0x0000000181271B20-0x0000000181271BC0
	private void ShowSelected(int inStarCount); // 0x0000000181271AB0-0x0000000181271B20
	private void SetLevelText(int inLevel); // 0x00000001812713E0-0x0000000181271490
	public void SetLevel(int inLevelIndex, CodeBreakerLevel inLevel); // 0x0000000181271490-0x0000000181271700
	public void BtnClicked_LevelSelected(); // 0x00000001812711A0-0x00000001812712F0
}

