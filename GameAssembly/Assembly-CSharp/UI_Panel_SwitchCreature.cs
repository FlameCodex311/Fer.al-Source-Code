/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Panel_SwitchCreature : MonoBehaviour // TypeDefIndex: 13916
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarPositioner _avatarPositioner; // 0x20
	[RootSelector] // 0x00000001802392B0-0x0000000180239320
	[SerializeField] // 0x00000001802392B0-0x0000000180239320
	private string _currentLookLocalizationDefId; // 0x28
	[RootSelector] // 0x00000001802395D0-0x0000000180239640
	[SerializeField] // 0x00000001802395D0-0x0000000180239640
	private string _chooseLookLocalizationDefId; // 0x30

	// Properties
	private string CurrentLookLocalizationText { get; } // 0x00000001803D1460-0x00000001803D14E0 
	private string ChooseLookLocalizationText { get; } // 0x00000001803D13E0-0x00000001803D1460 

	// Constructors
	public UI_Panel_SwitchCreature(); // 0x00000001803D1390-0x00000001803D13E0

	// Methods
	public void BtnClicked_SwitchCreatureLeft(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_SwitchCreatureRight(); // 0x00000001803774A0-0x00000001803774B0
	private void RefreshChooseButtonText(); // 0x00000001803774A0-0x00000001803774B0
	private void OnEnable(); // 0x00000001803D1290-0x00000001803D1300
	private void OnDisable(); // 0x00000001803D1200-0x00000001803D1290
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnEnable>b__10_0(); // 0x00000001803D1300-0x00000001803D1390
}

