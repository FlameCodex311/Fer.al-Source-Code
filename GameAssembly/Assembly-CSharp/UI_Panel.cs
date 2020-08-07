/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Panel : ManagedBehaviour // TypeDefIndex: 11298
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected GameObject _selectOnFocus; // 0x50
	protected GameObject _previouslySelectedObject; // 0x58

	// Properties
	public bool IsFocused { get; } // 0x00000001803D14E0-0x00000001803D1570 

	// Constructors
	public UI_Panel(); // 0x00000001803C8440-0x00000001803C84A0

	// Methods
	public virtual void OnReceiveFocus(); // 0x00000001803D10A0-0x00000001803D1200
	public virtual void OnLoseFocus(); // 0x00000001803D0F60-0x00000001803D10A0
	public override void MOnDestroy(); // 0x00000001803D0EF0-0x00000001803D0F60
}

