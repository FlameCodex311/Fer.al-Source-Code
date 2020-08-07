/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_DecalEntryItem : MonoBehaviour // TypeDefIndex: 13884
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _decalIconHighlightImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIHsvModifier _iconHSVModifier; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _isVisible; // 0x40
	private ActorInfoDecalEntry _decalEntry; // 0x48

	// Properties
	public FeralButton Button { get; } // 0x00000001803743D0-0x00000001803743E0 
	public ActorInfoDecalEntry DecalEntry { get; } // 0x00000001803743E0-0x00000001803743F0 

	// Constructors
	public UI_DecalEntryItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(ActorInfoDecalEntry inDecalEntry); // 0x0000000180374230-0x0000000180374340
	private void OnDestroy(); // 0x0000000180373E60-0x0000000180373F30
	private void OnDecalVisibilityChanged(bool inIsVisible); // 0x0000000180373E30-0x0000000180373E60
	public void RefreshIcon(); // 0x0000000180374000-0x0000000180374230
	public void RefreshIconColor(); // 0x0000000180373F30-0x0000000180374000
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshIcon>b__13_0(Sprite loadedSprite); // 0x0000000180374340-0x00000001803743C0
}

