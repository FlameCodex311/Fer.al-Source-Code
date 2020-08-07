/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180233C20-0x0000000180233C50
public class SeasonPassDefComponent : DefComponent // TypeDefIndex: 11633
{
	// Fields
	[ChartDef] // 0x0000000180233E80-0x0000000180233F10
	[ChartList] // 0x0000000180233E80-0x0000000180233F10
	public ChartDefList tiers; // 0x18
	[ChartDef] // 0x0000000180234360-0x00000001802343F0
	[ChartList] // 0x0000000180234360-0x00000001802343F0
	public ChartDefList challenges; // 0x20
	[ChartDef] // 0x0000000180234670-0x00000001802346F0
	[SerializeField] // 0x0000000180234670-0x00000001802346F0
	private string _purchaseableDef; // 0x28

	// Properties
	public BaseDef PurchaseableDef { get; } // 0x00000001803FB880-0x00000001803FB8E0 

	// Constructors
	public SeasonPassDefComponent(); // 0x00000001803FB800-0x00000001803FB880
}

