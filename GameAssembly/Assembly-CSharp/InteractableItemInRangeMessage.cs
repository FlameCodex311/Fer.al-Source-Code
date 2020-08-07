/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InteractableItemInRangeMessage : Message // TypeDefIndex: 11970
{
	// Fields
	private bool _isInRange; // 0x18
	private Interactable _target; // 0x20

	// Properties
	public bool IsInRange { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	public Interactable Target { get; } // 0x0000000180374AF0-0x0000000180374B00 

	// Constructors
	private InteractableItemInRangeMessage(bool inIsInRange, Interactable inTarget); // 0x00000001803FEA40-0x00000001803FEA80

	// Methods
	public static InteractableItemInRangeMessage Create(bool inIsInRange, Interactable inTarget); // 0x0000000180626770-0x0000000180626840
	public override void ReturnToPool(); // 0x0000000180373240-0x0000000180373250
}

