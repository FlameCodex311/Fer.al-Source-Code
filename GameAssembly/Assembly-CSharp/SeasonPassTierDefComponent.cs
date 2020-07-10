/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x000000018015CEA0-0x000000018015CED0
public class SeasonPassTierDefComponent : DefComponent // TypeDefIndex: 10143
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isFree; // 0x18
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int requiredAuraPoints; // 0x1C
	[ChartClass] // 0x000000018015D2F0-0x000000018015D330
	[JsonProperty] // 0x000000018015D2F0-0x000000018015D330
	[SerializeField] // 0x000000018015D2F0-0x000000018015D330
	private BundlePackDefComponent.CraftableItemsEntry _reward; // 0x20

	// Properties
	public BundlePackDefComponent.CraftableItemsEntry Reward { get; } // 0x000000018036AC70-0x000000018036AC80 

	// Constructors
	public SeasonPassTierDefComponent(); // 0x0000000180363710-0x0000000180363720
}

