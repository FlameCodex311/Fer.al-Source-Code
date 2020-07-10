/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_DecalItem : MonoBehaviour // TypeDefIndex: 12301
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _decalIconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x28
	private BaseDef _decalDef; // 0x30

	// Properties
	public FeralButton Button { get; } // 0x0000000180369B60-0x0000000180369B70 
	public BaseDef DecalDef { get; } // 0x0000000180397720-0x0000000180397730 

	// Constructors
	public UI_DecalItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(BaseDef inDecalDef); // 0x0000000180F33070-0x0000000180F33180
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__7_0(Sprite loadedSprite); // 0x0000000180F33180-0x0000000180F33230
}

