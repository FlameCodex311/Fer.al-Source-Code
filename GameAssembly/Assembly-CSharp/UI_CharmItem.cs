/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CharmItem : MonoBehaviour // TypeDefIndex: 13868
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _slotIconImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _gemIconImage; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _starIconImage; // 0x38
	private bool _isEquipped; // 0x40
	private bool _isSpecial; // 0x41

	// Properties
	public FeralButton Button { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public bool IsEquipped { get; } // 0x0000000180455BA0-0x0000000180455BB0 
	public bool IsSpecial { get; } // 0x000000018053DFB0-0x000000018053DFC0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13869
	{
		// Fields
		public UI_CharmList inCharmList; // 0x10
		public UI_CharmItem <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x000000018053D550-0x000000018053D580
	}

	// Constructors
	public UI_CharmItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Reset(); // 0x000000018053DDB0-0x000000018053DDF0
	public void Setup(UI_CharmList inCharmList, bool inIsSpecial, bool inIsEquipped); // 0x000000018053DDF0-0x000000018053DFB0
}

