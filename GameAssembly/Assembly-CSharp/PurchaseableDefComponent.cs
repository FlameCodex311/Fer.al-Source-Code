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

[ChartComponent] // 0x0000000180203290-0x00000001802032C0
public class PurchaseableDefComponent : DefComponent // TypeDefIndex: 12014
{
	// Fields
	[ChartList] // 0x0000000180203660-0x00000001802036A0
	[JsonProperty] // 0x0000000180203660-0x00000001802036A0
	[SerializeField] // 0x0000000180203660-0x00000001802036A0
	private List<CostEntry> _cost; // 0x18
	[ChartBool] // 0x0000000180203A00-0x0000000180203A30
	[SerializeField] // 0x0000000180203A00-0x0000000180203A30
	private bool _defaultYield; // 0x20
	[ChartList] // 0x0000000180203D00-0x0000000180203D50
	[SerializeField] // 0x0000000180203D00-0x0000000180203D50
	private List<YieldEntry> _yields; // 0x28
	private List<YieldEntry> _defaultYields; // 0x30

	// Properties
	public List<CostEntry> Cost { get; } // 0x0000000180372430-0x0000000180372440 
	public List<YieldEntry> Yields { get; } // 0x0000000180A2BEC0-0x0000000180A2BFA0 

	// Nested types
	[Serializable]
	public class CostEntry // TypeDefIndex: 12015
	{
		// Fields
		[ChartDef] // 0x0000000180205350-0x00000001802053E0
		public string itemDefID; // 0x10
		[ChartInt] // 0x00000001802056A0-0x00000001802056E0
		public int count; // 0x18

		// Properties
		public int RecycleCount { get; } // 0x0000000180A2B7B0-0x0000000180A2B820 

		// Constructors
		public CostEntry(); // 0x00000001804A3C00-0x00000001804A3C10
	}

	[Serializable]
	public class YieldEntry // TypeDefIndex: 12016
	{
		// Fields
		[ChartDef] // 0x0000000180205890-0x0000000180205920
		public string itemDefID; // 0x10
		[ChartInt] // 0x00000001802056A0-0x00000001802056E0
		public int count; // 0x18

		// Constructors
		public YieldEntry(); // 0x00000001804A3C00-0x00000001804A3C10
	}

	// Constructors
	public PurchaseableDefComponent(); // 0x0000000180A2BE30-0x0000000180A2BEC0

	// Methods
	public bool UserHasCraftingRequirements(); // 0x0000000180A2BB70-0x0000000180A2BE30
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
}

