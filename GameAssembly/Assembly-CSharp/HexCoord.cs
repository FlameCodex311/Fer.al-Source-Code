/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public struct HexCoord // TypeDefIndex: 13145
{
	// Fields
	[DeDisabled] // 0x00000001800FAAC0-0x00000001800FAB10
	[SerializeField] // 0x00000001800FAAC0-0x00000001800FAB10
	private int _q; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _r; // 0x04

	// Properties
	public int q { get; } // 0x0000000180004180-0x0000000180004190 
	public int r { get; } // 0x0000000180002FD0-0x0000000180003310 
	public int s { get; } // 0x00000001801F8F60-0x00000001801F8F70 

	// Constructors
	public HexCoord(int q, int r); // 0x0000000180012950-0x0000000180012990

	// Methods
	public static HexCoord operator +(HexCoord a, HexCoord b); // 0x000000018105D510-0x000000018105D540
	public static HexCoord operator -(HexCoord a, HexCoord b); // 0x000000018105D540-0x000000018105D570
}

