/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180155000-0x0000000180155030
public class LootDefComponent : DefComponent // TypeDefIndex: 10132
{
	// Fields
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public LootOperation operationType; // 0x18
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<LootChoiceInfo> choices; // 0x20

	// Constructors
	public LootDefComponent(); // 0x00000001811E9540-0x00000001811E95A0

	// Methods
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
	public ValueTuple<BaseDef, int> GetOnlyLootChoice(); // 0x00000001811E8F90-0x00000001811E9540
}

