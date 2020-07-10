/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Panel : ManagedBehaviour // TypeDefIndex: 13631
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected GameObject _selectOnFocus; // 0x50
	protected GameObject _previouslySelectedObject; // 0x58

	// Properties
	public bool IsFocused { get; } // 0x0000000180E878D0-0x0000000180E87960 

	// Constructors
	public UI_Panel(); // 0x0000000180E7F830-0x0000000180E7F890

	// Methods
	public virtual void OnReceiveFocus(); // 0x0000000180E87760-0x0000000180E878D0
	public virtual void OnLoseFocus(); // 0x0000000180E87620-0x0000000180E87760
	public override void MOnDestroy(); // 0x0000000180E875B0-0x0000000180E87620
}

