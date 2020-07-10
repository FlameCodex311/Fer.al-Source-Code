/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Panel_CreatureOverview : UI_Panel // TypeDefIndex: 12328
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarPositioner _avatarPositioner; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _visibilityToggle; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _textBox; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _charmLocations; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useAvgForCalloutAngles; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _usePresetAngles; // 0x81
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CharmSlotCallout> _charmSlotCallouts; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothLayout _smoothLayout; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CharmList> _charmLists; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _charmClickedSound; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _charmSlotClickedSound; // 0xA8
	private RectTransform _charmLocationsRectTransform; // 0xB0
	private UI_Stage_Avatar _avatarStage; // 0xB8
	private Camera _uiCamera; // 0xC0

	// Properties
	private RectTransform CharmLocationsRectTransform { get; } // 0x0000000180E86220-0x0000000180E862D0 
	public UI_Stage_Avatar AvatarStage { get; set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x0000000180E862D0-0x0000000180E862E0

	// Constructors
	public UI_Panel_CreatureOverview(); // 0x0000000180E7F830-0x0000000180E7F890

	// Methods
	public override void MOnEnable(); // 0x0000000180E85290-0x0000000180E855E0
	public override void MOnDisable(); // 0x0000000180E85240-0x0000000180E85290
	public override void MUpdate(); // 0x0000000180E855E0-0x0000000180E85600
	public void BtnClicked_ViewCharmLocationsToggle(bool inIsOn); // 0x0000000180E84D80-0x0000000180E84E60
	public void CharmClicked(UI_CharmList inCharmList, UI_CharmItem inCharmItem); // 0x0000000180E84E60-0x0000000180E85240
	private void SetupCharmSlotCallouts(); // 0x0000000180E85600-0x0000000180E85950
	private void UpdateCharmSlotCallouts(); // 0x0000000180E85980-0x0000000180E86220
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_ViewCharmLocationsToggle>b__22_0(); // 0x0000000180E85950-0x0000000180E85980
}

