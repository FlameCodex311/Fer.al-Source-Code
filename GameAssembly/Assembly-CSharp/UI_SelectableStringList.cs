/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SelectableStringList : UI_SelectableList<string> // TypeDefIndex: 13742
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SelectableListStringItem _stringItemPrefab; // 0x68

	// Properties
	protected override UI_SelectableListItem<string> ListItemPrefab { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Constructors
	public UI_SelectableStringList(); // 0x00000001804C63C0-0x00000001804C6400

	// Methods
	[DeMethodButton] // 0x00000001801EC9E0-0x00000001801ECA40
	public void AddTestItem(); // 0x00000001804C62A0-0x00000001804C6340
	[DeMethodButton] // 0x00000001801ECD00-0x00000001801ECD60
	public void RemoveFirstItem(); // 0x00000001804C6340-0x00000001804C63C0
}

