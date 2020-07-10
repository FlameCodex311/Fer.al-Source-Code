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

public class BuildersFollyUI_LevelButton : MonoBehaviour // TypeDefIndex: 12848
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
	public int BestScore { get; } // 0x000000018049D3B0-0x000000018049D3C0 

	// Constructors
	public BuildersFollyUI_LevelButton(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001813DB500-0x00000001813DB590
	private void OnDestroy(); // 0x00000001813DACD0-0x00000001813DAD60
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x00000001813DAD60-0x00000001813DAD90
	public void SetSelected(bool inSelected); // 0x00000001813DAE50-0x00000001813DB0E0
	private void ShowStars(int inStarCount); // 0x00000001813DB0E0-0x00000001813DB500
	public void SetLevel(int inLevelIndex, BuildersFollyLevel_Scriptable inLevel); // 0x00000001813DAD90-0x00000001813DAE50
	public void BtnClicked_LevelSelected(); // 0x00000001813DAC30-0x00000001813DACD0
}

