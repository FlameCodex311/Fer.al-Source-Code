/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class StringSerializableVector2 // TypeDefIndex: 11349
{
	// Fields
	public string x; // 0x10
	public string y; // 0x18

	// Properties
	public float xFloat { get; set; } // 0x0000000180CB9540-0x0000000180CB9550 0x0000000180CB96B0-0x0000000180CB96D0
	public float yFloat { get; set; } // 0x0000000180CB9550-0x0000000180CB9560 0x0000000180CB96D0-0x0000000180CB96F0

	// Constructors
	public StringSerializableVector2(Vector2 inVector2); // 0x0000000180CB9500-0x0000000180CB9540

	// Methods
	public Vector2 ToVector2(); // 0x0000000180CB9440-0x0000000180CB94A0
	public Vector3 ToVector3(); // 0x0000000180CB94A0-0x0000000180CB9500
	public static implicit operator Vector2(StringSerializableVector2 inObj); // 0x0000000180CB9650-0x0000000180CB96B0
	public static implicit operator Vector3(StringSerializableVector2 inObj); // 0x0000000180CB95D0-0x0000000180CB9650
	public static implicit operator StringSerializableVector2(Vector2 inObj); // 0x0000000180CB9560-0x0000000180CB95D0
}

