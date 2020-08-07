/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CharmList : MonoBehaviour // TypeDefIndex: 13870
{
	// Fields
	public List<Sprite> charmSlotSprites; // 0x20
	public Sprite charmIconNormal; // 0x28
	public Sprite charmIconSpecial; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_CharmItem> _charms; // 0x38
	private UI_Panel_CreatureOverview _panel; // 0x40

	// Constructors
	public UI_CharmList(); // 0x000000018053E3F0-0x000000018053E450

	// Methods
	public void Setup(UI_Panel_CreatureOverview inCreatureOverviewPanel, int inCharmCount); // 0x000000018053E2F0-0x000000018053E3F0
	public void CharmClicked(UI_CharmItem inClickedItem); // 0x000000018053DFC0-0x000000018053E1B0
	public void DeselectAllCharms(); // 0x000000018053E1B0-0x000000018053E2F0
}

