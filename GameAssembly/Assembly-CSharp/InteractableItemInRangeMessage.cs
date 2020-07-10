/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InteractableItemInRangeMessage : Message // TypeDefIndex: 10482
{
	// Fields
	private bool _isInRange; // 0x18
	private Interactable _target; // 0x20

	// Properties
	public bool IsInRange { get; } // 0x000000018041BAC0-0x000000018041BAD0 
	public Interactable Target { get; } // 0x000000018036AC70-0x000000018036AC80 

	// Constructors
	private InteractableItemInRangeMessage(bool inIsInRange, Interactable inTarget); // 0x0000000180EBFD20-0x0000000180EBFD60

	// Methods
	public static InteractableItemInRangeMessage Create(bool inIsInRange, Interactable inTarget); // 0x0000000180F5D300-0x0000000180F5D3D0
	public override void ReturnToPool(); // 0x000000018036B6C0-0x000000018036B6D0
}

