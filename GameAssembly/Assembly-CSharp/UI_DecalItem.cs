/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_DecalItem : MonoBehaviour // TypeDefIndex: 13885
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _decalIconImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x28
	private BaseDef _decalDef; // 0x30

	// Properties
	public FeralButton Button { get; } // 0x00000001803745B0-0x00000001803745C0 
	public BaseDef DecalDef { get; } // 0x00000001803745C0-0x00000001803745D0 

	// Constructors
	public UI_DecalItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(BaseDef inDecalDef); // 0x00000001803743F0-0x0000000180374500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__7_0(Sprite loadedSprite); // 0x0000000180374500-0x00000001803745B0
}

