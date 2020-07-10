/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class EnigmaItemComponent : ItemComponent // TypeDefIndex: 10489
{
	// Fields
	private EnigmaDefComponent _enigmaDefComponent; // 0x20
	public bool activated; // 0x28

	// Properties
	public EnigmaDefComponent EnigmaDefComponent { get; } // 0x0000000181191F40-0x0000000181191FA0 

	// Constructors
	public EnigmaItemComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public void unlock(); // 0x0000000181191FA0-0x0000000181191FB0
	protected override ItemComponent UpdateFromServerOverride(ItemComponent fromServer); // 0x0000000180F5CEE0-0x0000000180F5CEF0
}

