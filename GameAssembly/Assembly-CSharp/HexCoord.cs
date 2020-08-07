/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public struct HexCoord // TypeDefIndex: 10810
{
	// Fields
	[DeDisabled] // 0x00000001801CE4C0-0x00000001801CE510
	[SerializeField] // 0x00000001801CE4C0-0x00000001801CE510
	private int _q; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _r; // 0x04

	// Properties
	public int q { get; } // 0x0000000180004EC0-0x0000000180004ED0 
	public int r { get; } // 0x0000000180003CA0-0x0000000180003FD0 
	public int s { get; } // 0x0000000180009E50-0x0000000180009E60 

	// Constructors
	public HexCoord(int q, int r); // 0x0000000180006A50-0x0000000180006A60

	// Methods
	public static HexCoord operator +(HexCoord a, HexCoord b); // 0x000000018061B5B0-0x000000018061B5E0
	public static HexCoord operator -(HexCoord a, HexCoord b); // 0x000000018061B5E0-0x000000018061B610
}

