/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SBPROP // TypeDefIndex: 10934
{
	// Fields
	private uint _id; // 0x10
	private string _key; // 0x18
	private object _value; // 0x20
	private bool _newDef; // 0x28

	// Properties
	public uint id { get; } // 0x0000000180387590-0x0000000180387930 
	public string key { get; } // 0x0000000180372430-0x0000000180372440 
	public object value { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public bool NewDef { get; } // 0x00000001804C6790-0x00000001804C67A0 

	// Constructors
	public SBPROP(uint id, string key, object value, bool newDef = false /* Metadata: 0x0077C4C8 */); // 0x0000000180744CB0-0x0000000180744D60

	// Methods
	public string toJson(bool onlyValuePair = false /* Metadata: 0x0077C4C9 */); // 0x0000000180744D60-0x00000001807452B0
	private string valueToJson(); // 0x00000001807452B0-0x0000000180745930
}

