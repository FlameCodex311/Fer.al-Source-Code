/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public struct HSLColor // TypeDefIndex: 13221
{
	// Fields
	public float h; // 0x00
	public float s; // 0x04
	public float l; // 0x08
	public float a; // 0x0C

	// Constructors
	public HSLColor(float h, float s, float l, float a); // 0x0000000180010AB0-0x0000000180010AD0
	public HSLColor(float h, float s, float l); // 0x00000001801F85A0-0x00000001801F85C0
	public HSLColor(Color c); // 0x00000001801F85C0-0x00000001801F8620

	// Methods
	public static HSLColor FromRGBA(Color c); // 0x000000018105B6C0-0x000000018105BA10
	public Color ToRGBA(); // 0x00000001801F8580-0x00000001801F85A0
	private static float Value(float n1, float n2, float hue); // 0x000000018105BA10-0x000000018105BAE0
	public static implicit operator HSLColor(Color src); // 0x000000018105BAE0-0x000000018105BB20
	public static implicit operator Color(HSLColor src); // 0x000000018105BB20-0x000000018105BD50
}

