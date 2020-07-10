/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Panel_SwitchCreature : MonoBehaviour // TypeDefIndex: 12332
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarPositioner _avatarPositioner; // 0x20
	[RootSelector] // 0x000000018013F590-0x000000018013F600
	[SerializeField] // 0x000000018013F590-0x000000018013F600
	private string _currentLookLocalizationDefId; // 0x28
	[RootSelector] // 0x000000018013F7D0-0x000000018013F840
	[SerializeField] // 0x000000018013F7D0-0x000000018013F840
	private string _chooseLookLocalizationDefId; // 0x30

	// Properties
	private string CurrentLookLocalizationText { get; } // 0x0000000180EE20B0-0x0000000180EE2130 
	private string ChooseLookLocalizationText { get; } // 0x0000000180EE2030-0x0000000180EE20B0 

	// Constructors
	public UI_Panel_SwitchCreature(); // 0x0000000180EE1FE0-0x0000000180EE2030

	// Methods
	public void BtnClicked_SwitchCreatureLeft(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_SwitchCreatureRight(); // 0x00000001803581E0-0x00000001803581F0
	private void RefreshChooseButtonText(); // 0x00000001803581E0-0x00000001803581F0
	private void OnEnable(); // 0x0000000180EE1E70-0x0000000180EE1EE0
	private void OnDisable(); // 0x0000000180EE1D50-0x0000000180EE1E70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnEnable>b__10_0(); // 0x0000000180EE1EE0-0x0000000180EE1FE0
}

