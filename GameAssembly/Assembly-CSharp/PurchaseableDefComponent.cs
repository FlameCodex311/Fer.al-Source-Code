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

[ChartComponent] // 0x000000018012DBF0-0x000000018012DC20
public class PurchaseableDefComponent : DefComponent // TypeDefIndex: 10526
{
	// Fields
	[ChartList] // 0x000000018012DE50-0x000000018012DE90
	[JsonProperty] // 0x000000018012DE50-0x000000018012DE90
	[SerializeField] // 0x000000018012DE50-0x000000018012DE90
	private List<CostEntry> _cost; // 0x18
	[ChartBool] // 0x000000018012E0E0-0x000000018012E110
	[SerializeField] // 0x000000018012E0E0-0x000000018012E110
	private bool _defaultYield; // 0x20
	[ChartList] // 0x000000018012E380-0x000000018012E3D0
	[SerializeField] // 0x000000018012E380-0x000000018012E3D0
	private List<YieldEntry> _yields; // 0x28
	private List<YieldEntry> _defaultYields; // 0x30

	// Properties
	public List<CostEntry> Cost { get; } // 0x000000018038B150-0x000000018038B160 
	public List<YieldEntry> Yields { get; } // 0x00000001815EE2B0-0x00000001815EE390 

	// Nested types
	[Serializable]
	public class CostEntry // TypeDefIndex: 10527
	{
		// Fields
		[ChartDef] // 0x000000018012E570-0x000000018012E600
		public string itemDefID; // 0x10
		[ChartInt] // 0x000000018012E910-0x000000018012E950
		public int count; // 0x18

		// Properties
		public int RecycleCount { get; } // 0x00000001815EDBB0-0x00000001815EDC20 

		// Constructors
		public CostEntry(); // 0x000000018139C450-0x000000018139C460
	}

	[Serializable]
	public class YieldEntry // TypeDefIndex: 10528
	{
		// Fields
		[ChartDef] // 0x000000018012EBC0-0x000000018012EC50
		public string itemDefID; // 0x10
		[ChartInt] // 0x000000018012E910-0x000000018012E950
		public int count; // 0x18

		// Constructors
		public YieldEntry(); // 0x000000018139C450-0x000000018139C460
	}

	// Constructors
	public PurchaseableDefComponent(); // 0x00000001815EE220-0x00000001815EE2B0

	// Methods
	public bool UserHasCraftingRequirements(); // 0x00000001815EDF50-0x00000001815EE220
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
}

