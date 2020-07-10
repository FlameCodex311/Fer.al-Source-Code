/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_EyeDecal : UI_LazyListItem<BaseDef> // TypeDefIndex: 12036
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	private QRoutine _imageDownloadQRoutine; // 0x78

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E74720-0x0000000180E74770 

	// Constructors
	public UI_LazyListItem_EyeDecal(); // 0x0000000180E746E0-0x0000000180E74720

	// Methods
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x0000000180E74400-0x0000000180E746A0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public override void Refresh(); // 0x0000000180E74230-0x0000000180E74400
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__5_0(Sprite inSprite); // 0x0000000180E746A0-0x0000000180E746E0
}

