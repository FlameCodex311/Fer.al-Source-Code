/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SBPROP // TypeDefIndex: 13268
{
	// Fields
	private uint _id; // 0x10
	private string _key; // 0x18
	private object _value; // 0x20
	private bool _newDef; // 0x28

	// Properties
	public uint id { get; } // 0x000000018036CFF0-0x000000018036D000 
	public string key { get; } // 0x000000018038B150-0x000000018038B160 
	public object value { get; } // 0x000000018036AC70-0x000000018036AC80 
	public bool NewDef { get; } // 0x00000001803A2790-0x00000001803A27A0 

	// Constructors
	public SBPROP(uint id, string key, object value, bool newDef = false /* Metadata: 0x00783A0D */); // 0x0000000180E12DF0-0x0000000180E12EA0

	// Methods
	public string toJson(bool onlyValuePair = false /* Metadata: 0x00783A0E */); // 0x0000000180E12EA0-0x0000000180E13440
	private string valueToJson(); // 0x0000000180E13440-0x0000000180E13AF0
}

