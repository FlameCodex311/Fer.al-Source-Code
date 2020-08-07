/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public struct HSLColor // TypeDefIndex: 10887
{
	// Fields
	public float h; // 0x00
	public float s; // 0x04
	public float l; // 0x08
	public float a; // 0x0C

	// Constructors
	public HSLColor(float h, float s, float l, float a); // 0x0000000180007650-0x0000000180007670
	public HSLColor(float h, float s, float l); // 0x000000018000A630-0x000000018000A650
	public HSLColor(Color c); // 0x000000018000A650-0x000000018000A6B0

	// Methods
	public static HSLColor FromRGBA(Color c); // 0x0000000180686D10-0x0000000180687060
	public Color ToRGBA(); // 0x000000018000A610-0x000000018000A630
	private static float Value(float n1, float n2, float hue); // 0x0000000180687060-0x0000000180687130
	public static implicit operator HSLColor(Color src); // 0x0000000180687130-0x0000000180687170
	public static implicit operator Color(HSLColor src); // 0x0000000180687170-0x00000001806873A0
}

