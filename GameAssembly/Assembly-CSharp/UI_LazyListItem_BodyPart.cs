/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_BodyPart : UI_LazyListItem<ActorBodyPartDefComponent> // TypeDefIndex: 13588
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70

	// Properties
	private ActorInfo ActorInfo { get; } // 0x00000001803A23A0-0x00000001803A23F0 

	// Constructors
	public UI_LazyListItem_BodyPart(); // 0x00000001803A2360-0x00000001803A23A0

	// Methods
	public override void Setup(Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnSelected, ActorBodyPartDefComponent inData, UI_LazyItemList<ActorBodyPartDefComponent> inItemList); // 0x00000001803A2290-0x00000001803A2360
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public override void Refresh(); // 0x00000001803A20C0-0x00000001803A2290
}

