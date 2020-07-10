/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180151E10-0x0000000180151E40
public class BundlePackDefComponent : DefComponent // TypeDefIndex: 10124
{
	// Fields
	[ChartList] // 0x000000018012DE50-0x000000018012DE90
	[JsonProperty] // 0x000000018012DE50-0x000000018012DE90
	[SerializeField] // 0x000000018012DE50-0x000000018012DE90
	private List<CraftableItemsEntry> _craftableItems; // 0x18

	// Properties
	public List<CraftableItemsEntry> CraftableItems { get; } // 0x000000018038B150-0x000000018038B160 

	// Nested types
	[Serializable]
	public class CraftableItemsEntry // TypeDefIndex: 10125
	{
		// Fields
		[ChartDef] // 0x00000001801522B0-0x0000000180152340
		public string itemDefID; // 0x10
		[ChartInt] // 0x000000018012E910-0x000000018012E950
		public int count; // 0x18

		// Constructors
		public CraftableItemsEntry(); // 0x000000018139C450-0x000000018139C460
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10126
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Item> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001813E0FB0-0x00000001813E1010
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <GenerateItemList>b__5_0(Item a, Item b); // 0x00000001813E0E50-0x00000001813E0FB0
	}

	// Constructors
	public BundlePackDefComponent(); // 0x00000001813DD4D0-0x00000001813DD530

	// Methods
	public CraftableItemsEntry GetOnlyItem(); // 0x00000001813DD460-0x00000001813DD4D0
	public List<Item> GenerateItemList(); // 0x00000001813DD100-0x00000001813DD460
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
}

