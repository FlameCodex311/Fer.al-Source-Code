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

public class BuildersFollyUI_LevelButton : MonoBehaviour // TypeDefIndex: 10509
{
	// Fields
	public WWButton levelButton; // 0x20
	public WWTextMeshProUGUI levelText; // 0x28
	public CanvasGroup canvasGroup; // 0x30
	public GameObject levelIcon; // 0x38
	public GameObject levelIconSelected; // 0x40
	public GameObject levelLockedIcon; // 0x48
	public UI_ColorizedIcon halfStar; // 0x50
	public UI_ColorizedIcon oneStar; // 0x58
	public UI_ColorizedIcon oneHalfStar; // 0x60
	public UI_ColorizedIcon twoStar; // 0x68
	public UI_ColorizedIcon twoHalfStar; // 0x70
	public UI_ColorizedIcon threeStar; // 0x78
	private int _level; // 0x80
	private bool _locked; // 0x84
	private int _bestScore; // 0x88
	private int _stars; // 0x8C

	// Properties
	public int BestScore { get; } // 0x00000001803CCE20-0x00000001803CCE30 

	// Constructors
	public BuildersFollyUI_LevelButton(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180493B70-0x0000000180493C00
	private void OnDestroy(); // 0x0000000180493360-0x00000001804933F0
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x00000001804933F0-0x0000000180493420
	public void SetSelected(bool inSelected); // 0x00000001804934E0-0x0000000180493770
	private void ShowStars(int inStarCount); // 0x0000000180493770-0x0000000180493B70
	public void SetLevel(int inLevelIndex, BuildersFollyLevel_Scriptable inLevel); // 0x0000000180493420-0x00000001804934E0
	public void BtnClicked_LevelSelected(); // 0x00000001804932C0-0x0000000180493360
}

