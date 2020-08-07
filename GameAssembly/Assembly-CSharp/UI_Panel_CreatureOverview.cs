/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Panel_CreatureOverview : UI_Panel // TypeDefIndex: 13912
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarPositioner _avatarPositioner; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _visibilityToggle; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _textBox; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _charmLocations; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useAvgForCalloutAngles; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _usePresetAngles; // 0x81
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CharmSlotCallout> _charmSlotCallouts; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWSmoothLayout _smoothLayout; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CharmList> _charmLists; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _charmClickedSound; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _charmSlotClickedSound; // 0xA8
	private RectTransform _charmLocationsRectTransform; // 0xB0
	private UI_Stage_Avatar _avatarStage; // 0xB8
	private Camera _uiCamera; // 0xC0

	// Properties
	private RectTransform CharmLocationsRectTransform { get; } // 0x00000001803CFB70-0x00000001803CFC20 
	public UI_Stage_Avatar AvatarStage { get; set; } // 0x00000001803CFB60-0x00000001803CFB70 0x00000001803CFC20-0x00000001803CFC30

	// Constructors
	public UI_Panel_CreatureOverview(); // 0x00000001803C8440-0x00000001803C84A0

	// Methods
	public override void MOnEnable(); // 0x00000001803CEC40-0x00000001803CEF80
	public override void MOnDisable(); // 0x00000001803CEBF0-0x00000001803CEC40
	public override void MUpdate(); // 0x00000001803CEF80-0x00000001803CEFA0
	public void BtnClicked_ViewCharmLocationsToggle(bool inIsOn); // 0x00000001803CE740-0x00000001803CE820
	public void CharmClicked(UI_CharmList inCharmList, UI_CharmItem inCharmItem); // 0x00000001803CE820-0x00000001803CEBF0
	private void SetupCharmSlotCallouts(); // 0x00000001803CEFA0-0x00000001803CF2D0
	private void UpdateCharmSlotCallouts(); // 0x00000001803CF300-0x00000001803CFB60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_ViewCharmLocationsToggle>b__22_0(); // 0x00000001803CF2D0-0x00000001803CF300
}

