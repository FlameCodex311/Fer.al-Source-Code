/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x000000018015BC50-0x000000018015BC80
public class SeasonPassDefComponent : DefComponent // TypeDefIndex: 10142
{
	// Fields
	[ChartDef] // 0x000000018015BDF0-0x000000018015BE80
	[ChartList] // 0x000000018015BDF0-0x000000018015BE80
	public ChartDefList tiers; // 0x18
	[ChartDef] // 0x000000018015C340-0x000000018015C3D0
	[ChartList] // 0x000000018015C340-0x000000018015C3D0
	public ChartDefList challenges; // 0x20
	[ChartDef] // 0x000000018015CA50-0x000000018015CAD0
	[SerializeField] // 0x000000018015CA50-0x000000018015CAD0
	private string _purchaseableDef; // 0x28

	// Properties
	public BaseDef PurchaseableDef { get; } // 0x0000000180EBD0D0-0x0000000180EBD130 

	// Constructors
	public SeasonPassDefComponent(); // 0x0000000180EBD050-0x0000000180EBD0D0
}

