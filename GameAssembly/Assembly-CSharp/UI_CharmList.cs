/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CharmList : MonoBehaviour // TypeDefIndex: 12286
{
	// Fields
	public List<Sprite> charmSlotSprites; // 0x20
	public Sprite charmIconNormal; // 0x28
	public Sprite charmIconSpecial; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_CharmItem> _charms; // 0x38
	private UI_Panel_CreatureOverview _panel; // 0x40

	// Constructors
	public UI_CharmList(); // 0x0000000180F20900-0x0000000180F20960

	// Methods
	public void Setup(UI_Panel_CreatureOverview inCreatureOverviewPanel, int inCharmCount); // 0x0000000180F20800-0x0000000180F20900
	public void CharmClicked(UI_CharmItem inClickedItem); // 0x0000000180F204C0-0x0000000180F206C0
	public void DeselectAllCharms(); // 0x0000000180F206C0-0x0000000180F20800
}

