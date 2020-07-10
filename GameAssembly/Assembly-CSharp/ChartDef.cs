/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ChartDef // TypeDefIndex: 11647
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _defID; // 0x10
	[NonSerialized]
	private BaseDef _def; // 0x18

	// Properties
	public string DefID { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public BaseDef Def { get; } // 0x0000000181027310-0x00000001810273B0 

	// Constructors
	public ChartDef(); // 0x00000001810272D0-0x0000000181027310

	// Methods
	public static implicit operator BaseDef(ChartDef inDef); // 0x00000001810273B0-0x0000000181027460
	public static implicit operator string(ChartDef inDef); // 0x0000000180407850-0x0000000180407870
}

