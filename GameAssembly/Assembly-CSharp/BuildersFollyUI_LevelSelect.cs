/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyUI_LevelSelect : MonoBehaviour // TypeDefIndex: 10510
{
	// Fields
	public GameObject buttonHolder; // 0x20
	public ScrollRect scrollRect; // 0x28
	public BuildersFollyUI_LevelButton levelButton; // 0x30
	public WWTextMeshProUGUI levelSelectHeader; // 0x38
	[RootSelector] // 0x000000018020FCA0-0x000000018020FD00
	public string normalLevelsHeader; // 0x40
	private string _normalLevelsHeader; // 0x48
	[RootSelector] // 0x000000018020FFD0-0x0000000180210030
	public string expertLevelsHeader; // 0x50
	private string _expertLevelsHeader; // 0x58
	private List<BuildersFollyUI_LevelButton> _buttons; // 0x60
	private BuildersFollyGame _game; // 0x68
	public GameObject startButton; // 0x70
	private float normalScrollPosition; // 0x78
	private float expertScrollPosition; // 0x7C

	// Properties
	private string NormalLevelsHeader { get; } // 0x0000000180494A70-0x0000000180494B90 
	private string ExpertLevelsHeader { get; } // 0x0000000180494950-0x0000000180494A70 

	// Constructors
	public BuildersFollyUI_LevelSelect(); // 0x0000000180494930-0x0000000180494950

	// Methods
	private void Start(); // 0x0000000180494710-0x00000001804947D0
	private void OnEnable(); // 0x0000000180493E50-0x0000000180494620
	private void OnDisable(); // 0x0000000180493CC0-0x0000000180493E50
	private void OnDestroy(); // 0x0000000180493C30-0x0000000180493CC0
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x0000000180494620-0x0000000180494640
	private void SetupLevelInfo(int inLevelIndex); // 0x0000000180494640-0x0000000180494710
	public void BtnClicked_LevelStart(); // 0x0000000180493C00-0x0000000180493C30
	internal void ToggleButtons(); // 0x00000001804947D0-0x00000001804948B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ToggleButtons>b__24_0(); // 0x00000001804948B0-0x0000000180494930
}

