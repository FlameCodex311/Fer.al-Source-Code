/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001801627F0-0x0000000180162820
public class HarvestPointDefComponent : DefComponent // TypeDefIndex: 10183
{
	// Fields
	[ChartDef] // 0x0000000180162B90-0x0000000180162C10
	[ChartList] // 0x0000000180162B90-0x0000000180162C10
	public ChartDefList craftableItemRefArray; // 0x18
	[ChartInt] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<int> minimumCraftableItemsPerHarvest; // 0x20
	[ChartInt] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<int> maximumCraftableItemsPerHarvest; // 0x28
	[ChartInt] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<int> percentChance; // 0x30
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int harvests; // 0x38

	// Constructors
	public HarvestPointDefComponent(); // 0x000000018105D3E0-0x000000018105D4A0

	// Methods
	private bool Contains(string inCraftableItemDefId, out int IndexOf); // 0x000000018105CF90-0x000000018105D050
	public void GetMinAndMax(string inCraftableItemDefId, out int outMin, out int outMax); // 0x000000018105D1F0-0x000000018105D2C0
	public void GetMinAndMaxAndPercent(string inCraftableItemDefId, out int outMin, out int outMax, out int outPercent); // 0x000000018105D0E0-0x000000018105D1F0
	public int GetMinimum(string inCraftableItemDefId); // 0x000000018105D2C0-0x000000018105D350
	public int GetMaximum(string inCraftableItemDefId); // 0x000000018105D050-0x000000018105D0E0
	public int GetPercent(string inCraftableItemDefId); // 0x000000018105D350-0x000000018105D3E0
}

