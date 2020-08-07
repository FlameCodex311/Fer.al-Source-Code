/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018022DFF0-0x000000018022E020
public class LootDefComponent : DefComponent // TypeDefIndex: 11623
{
	// Fields
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public LootOperation operationType; // 0x18
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<LootChoiceInfo> choices; // 0x20

	// Constructors
	public LootDefComponent(); // 0x00000001804F00E0-0x00000001804F0140

	// Methods
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
	public ValueTuple<BaseDef, int> GetOnlyLootChoice(); // 0x00000001804EFB70-0x00000001804F00E0
}

