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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_DecalEntry : UI_LazyListItem<ActorInfoDecalEntry> // TypeDefIndex: 13589
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconHighlightImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIHsvModifier _iconHSVModifier; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _isVisible; // 0x88

	// Constructors
	public UI_LazyListItem_DecalEntry(); // 0x00000001803A59D0-0x00000001803A5A10

	// Methods
	public override void Setup(Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnClicked, Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnSelected, ActorInfoDecalEntry inData, UI_LazyItemList<ActorInfoDecalEntry> inItemList); // 0x00000001803A5720-0x00000001803A5890
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public void RefreshIcon(); // 0x00000001803A54E0-0x00000001803A5720
	public void RefreshIconColor(); // 0x00000001803A5400-0x00000001803A54E0
	public void ToggleBtnClicked_ShowHide(bool inIsOn); // 0x00000001803A5890-0x00000001803A5950
	public void BtnClicked_Remove(); // 0x00000001803A5390-0x00000001803A5400
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshIcon>b__7_0(Sprite loadedSprite); // 0x00000001803A5950-0x00000001803A59D0
}

