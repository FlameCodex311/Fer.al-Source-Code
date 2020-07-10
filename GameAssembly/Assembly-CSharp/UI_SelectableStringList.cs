/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SelectableStringList : UI_SelectableList<string> // TypeDefIndex: 12195
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SelectableListStringItem _stringItemPrefab; // 0x68

	// Properties
	protected override UI_SelectableListItem<string> ListItemPrefab { get; } // 0x0000000180358970-0x0000000180358980 

	// Constructors
	public UI_SelectableStringList(); // 0x0000000180EF1AC0-0x0000000180EF1B00

	// Methods
	[DeMethodButton] // 0x000000018010B450-0x000000018010B4B0
	public void AddTestItem(); // 0x0000000180EF19A0-0x0000000180EF1A40
	[DeMethodButton] // 0x000000018010B7F0-0x000000018010B850
	public void RemoveFirstItem(); // 0x0000000180EF1A40-0x0000000180EF1AC0
}

