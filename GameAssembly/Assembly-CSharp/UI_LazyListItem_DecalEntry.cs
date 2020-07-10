/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_DecalEntry : UI_LazyListItem<ActorInfoDecalEntry> // TypeDefIndex: 12035
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconHighlightImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIHsvModifier _iconHSVModifier; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _isVisible; // 0x88

	// Constructors
	public UI_LazyListItem_DecalEntry(); // 0x0000000180E73DC0-0x0000000180E73E00

	// Methods
	public override void Setup(Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnClicked, Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnSelected, ActorInfoDecalEntry inData, UI_LazyItemList<ActorInfoDecalEntry> inItemList); // 0x0000000180E73B10-0x0000000180E73C80
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public void RefreshIcon(); // 0x0000000180E738C0-0x0000000180E73B10
	public void RefreshIconColor(); // 0x0000000180E737D0-0x0000000180E738C0
	public void ToggleBtnClicked_ShowHide(bool inIsOn); // 0x0000000180E73C80-0x0000000180E73D40
	public void BtnClicked_Remove(); // 0x0000000180E73760-0x0000000180E737D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshIcon>b__7_0(Sprite loadedSprite); // 0x0000000180E73D40-0x0000000180E73DC0
}

