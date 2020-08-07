/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_EyeDecal : UI_LazyListItem<BaseDef> // TypeDefIndex: 13590
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	private QRoutine _imageDownloadQRoutine; // 0x78

	// Properties
	private ActorInfo ActorInfo { get; } // 0x00000001803A6300-0x00000001803A6350 

	// Constructors
	public UI_LazyListItem_EyeDecal(); // 0x00000001803A62C0-0x00000001803A6300

	// Methods
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x00000001803A5FF0-0x00000001803A6280
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public override void Refresh(); // 0x00000001803A5E30-0x00000001803A5FF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__5_0(Sprite inSprite); // 0x00000001803A6280-0x00000001803A62C0
}

