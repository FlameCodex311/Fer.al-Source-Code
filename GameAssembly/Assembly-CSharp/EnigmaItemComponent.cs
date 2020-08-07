/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class EnigmaItemComponent : ItemComponent // TypeDefIndex: 11977
{
	// Fields
	private EnigmaDefComponent _enigmaDefComponent; // 0x20
	public bool activated; // 0x28

	// Properties
	public EnigmaDefComponent EnigmaDefComponent { get; } // 0x000000018085EAF0-0x000000018085EB50 

	// Constructors
	public EnigmaItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public void unlock(); // 0x000000018085EB50-0x000000018085EB60
	protected override ItemComponent UpdateFromServerOverride(ItemComponent fromServer); // 0x0000000180626360-0x0000000180626370
}

