/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_BodyPart : UI_LazyListItem<ActorBodyPartDefComponent> // TypeDefIndex: 12034
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E6EB80-0x0000000180E6EBD0 

	// Constructors
	public UI_LazyListItem_BodyPart(); // 0x0000000180E6EB40-0x0000000180E6EB80

	// Methods
	public override void Setup(Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnSelected, ActorBodyPartDefComponent inData, UI_LazyItemList<ActorBodyPartDefComponent> inItemList); // 0x0000000180E6EA70-0x0000000180E6EB40
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public override void Refresh(); // 0x0000000180E6E890-0x0000000180E6EA70
}

