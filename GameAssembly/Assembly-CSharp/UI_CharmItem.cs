/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CharmItem : MonoBehaviour // TypeDefIndex: 12284
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _slotIconImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _gemIconImage; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _starIconImage; // 0x38
	private bool _isEquipped; // 0x40
	private bool _isSpecial; // 0x41

	// Properties
	public FeralButton Button { get; } // 0x000000018036AC70-0x000000018036AC80 
	public bool IsEquipped { get; } // 0x0000000180478660-0x0000000180478670 
	public bool IsSpecial { get; } // 0x00000001804785A0-0x00000001804785B0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12285
	{
		// Fields
		public UI_CharmList inCharmList; // 0x10
		public UI_CharmItem <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000180F1F610-0x0000000180F1F640
	}

	// Constructors
	public UI_CharmItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Reset(); // 0x0000000180F202A0-0x0000000180F202E0
	public void Setup(UI_CharmList inCharmList, bool inIsSpecial, bool inIsEquipped); // 0x0000000180F202E0-0x0000000180F204C0
}

