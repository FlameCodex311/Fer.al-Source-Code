/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180234960-0x0000000180234990
public class SeasonPassTierDefComponent : DefComponent // TypeDefIndex: 11634
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isFree; // 0x18
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int requiredAuraPoints; // 0x1C
	[ChartClass] // 0x0000000180234DD0-0x0000000180234E10
	[JsonProperty] // 0x0000000180234DD0-0x0000000180234E10
	[SerializeField] // 0x0000000180234DD0-0x0000000180234E10
	private BundlePackDefComponent.CraftableItemsEntry _reward; // 0x20

	// Properties
	public BundlePackDefComponent.CraftableItemsEntry Reward { get; } // 0x0000000180374AF0-0x0000000180374B00 

	// Constructors
	public SeasonPassTierDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200
}

