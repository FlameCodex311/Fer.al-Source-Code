/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ChartDef // TypeDefIndex: 13172
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _defID; // 0x10
	[NonSerialized]
	private BaseDef _def; // 0x18

	// Properties
	public string DefID { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public BaseDef Def { get; } // 0x000000018049FC80-0x000000018049FD20 

	// Constructors
	public ChartDef(); // 0x000000018049FC40-0x000000018049FC80

	// Methods
	public static implicit operator BaseDef(ChartDef inDef); // 0x000000018049FD20-0x000000018049FDD0
	public static implicit operator string(ChartDef inDef); // 0x000000018049FDD0-0x000000018049FDF0
}

