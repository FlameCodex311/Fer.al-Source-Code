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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyUI_LevelSelect : MonoBehaviour // TypeDefIndex: 12849
{
	// Fields
	public GameObject buttonHolder; // 0x20
	public ScrollRect scrollRect; // 0x28
	public BuildersFollyUI_LevelButton levelButton; // 0x30
	public WWTextMeshProUGUI levelSelectHeader; // 0x38
	[RootSelector] // 0x0000000180134030-0x0000000180134090
	public string normalLevelsHeader; // 0x40
	private string _normalLevelsHeader; // 0x48
	[RootSelector] // 0x00000001801341C0-0x0000000180134220
	public string expertLevelsHeader; // 0x50
	private string _expertLevelsHeader; // 0x58
	private List<BuildersFollyUI_LevelButton> _buttons; // 0x60
	private BuildersFollyGame _game; // 0x68
	public GameObject startButton; // 0x70
	private float normalScrollPosition; // 0x78
	private float expertScrollPosition; // 0x7C

	// Properties
	private string NormalLevelsHeader { get; } // 0x00000001813DC450-0x00000001813DC570 
	private string ExpertLevelsHeader { get; } // 0x00000001813DC330-0x00000001813DC450 

	// Constructors
	public BuildersFollyUI_LevelSelect(); // 0x00000001813DC310-0x00000001813DC330

	// Methods
	private void Start(); // 0x00000001813DC0E0-0x00000001813DC1A0
	private void OnEnable(); // 0x00000001813DB7E0-0x00000001813DBFE0
	private void OnDisable(); // 0x00000001813DB650-0x00000001813DB7E0
	private void OnDestroy(); // 0x00000001813DB5C0-0x00000001813DB650
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x00000001813DBFE0-0x00000001813DC000
	private void SetupLevelInfo(int inLevelIndex); // 0x00000001813DC000-0x00000001813DC0E0
	public void BtnClicked_LevelStart(); // 0x00000001813DB590-0x00000001813DB5C0
	internal void ToggleButtons(); // 0x00000001813DC1A0-0x00000001813DC290
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ToggleButtons>b__24_0(); // 0x00000001813DC290-0x00000001813DC310
}

