/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018022A7B0-0x000000018022A7E0
public class BundlePackDefComponent : DefComponent // TypeDefIndex: 11615
{
	// Fields
	[ChartList] // 0x0000000180203660-0x00000001802036A0
	[JsonProperty] // 0x0000000180203660-0x00000001802036A0
	[SerializeField] // 0x0000000180203660-0x00000001802036A0
	private List<CraftableItemsEntry> _craftableItems; // 0x18

	// Properties
	public List<CraftableItemsEntry> CraftableItems { get; } // 0x0000000180372430-0x0000000180372440 

	// Nested types
	[Serializable]
	public class CraftableItemsEntry // TypeDefIndex: 11616
	{
		// Fields
		[ChartDef] // 0x000000018022ACB0-0x000000018022AD40
		public string itemDefID; // 0x10
		[ChartInt] // 0x00000001802056A0-0x00000001802056E0
		public int count; // 0x18

		// Constructors
		public CraftableItemsEntry(); // 0x00000001804A3C00-0x00000001804A3C10
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11617
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Item> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804A9250-0x00000001804A92B0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <GenerateItemList>b__5_0(Item a, Item b); // 0x00000001804A8920-0x00000001804A8A80
	}

	// Constructors
	public BundlePackDefComponent(); // 0x0000000180495A80-0x0000000180495AE0

	// Methods
	public CraftableItemsEntry GetOnlyItem(); // 0x0000000180495A10-0x0000000180495A80
	public List<Item> GenerateItemList(); // 0x00000001804956C0-0x0000000180495A10
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
}

