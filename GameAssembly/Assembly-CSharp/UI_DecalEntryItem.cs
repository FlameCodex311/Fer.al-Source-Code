/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_DecalEntryItem : MonoBehaviour // TypeDefIndex: 12300
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _decalIconHighlightImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIHsvModifier _iconHSVModifier; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _isVisible; // 0x40
	private ActorInfoDecalEntry _decalEntry; // 0x48

	// Properties
	public FeralButton Button { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public ActorInfoDecalEntry DecalEntry { get; } // 0x0000000180369C40-0x0000000180369C50 

	// Constructors
	public UI_DecalEntryItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(ActorInfoDecalEntry inDecalEntry); // 0x0000000180F32EE0-0x0000000180F32FF0
	private void OnDestroy(); // 0x0000000180F32B10-0x0000000180F32BE0
	private void OnDecalVisibilityChanged(bool inIsVisible); // 0x0000000180F32AE0-0x0000000180F32B10
	public void RefreshIcon(); // 0x0000000180F32CB0-0x0000000180F32EE0
	public void RefreshIconColor(); // 0x0000000180F32BE0-0x0000000180F32CB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshIcon>b__13_0(Sprite loadedSprite); // 0x0000000180F32FF0-0x0000000180F33070
}

