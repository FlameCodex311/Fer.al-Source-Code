/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class StringSerializableVector2 // TypeDefIndex: 13682
{
	// Fields
	public string x; // 0x10
	public string y; // 0x18

	// Properties
	public float xFloat { get; set; } // 0x0000000181203E50-0x0000000181203E60 0x0000000181203FD0-0x0000000181203FF0
	public float yFloat { get; set; } // 0x0000000181203E60-0x0000000181203E70 0x0000000181203FF0-0x0000000181204010

	// Constructors
	public StringSerializableVector2(Vector2 inVector2); // 0x0000000181203E10-0x0000000181203E50

	// Methods
	public Vector2 ToVector2(); // 0x0000000181203D50-0x0000000181203DB0
	public Vector3 ToVector3(); // 0x0000000181203DB0-0x0000000181203E10
	public static implicit operator Vector2(StringSerializableVector2 inObj); // 0x0000000181203F70-0x0000000181203FD0
	public static implicit operator Vector3(StringSerializableVector2 inObj); // 0x0000000181203EE0-0x0000000181203F70
	public static implicit operator StringSerializableVector2(Vector2 inObj); // 0x0000000181203E70-0x0000000181203EE0
}

