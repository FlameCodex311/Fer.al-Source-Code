/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180239F40-0x0000000180239F70
public class HarvestPointDefComponent : DefComponent // TypeDefIndex: 11674
{
	// Fields
	[ChartDef] // 0x000000018023A0C0-0x000000018023A140
	[ChartList] // 0x000000018023A0C0-0x000000018023A140
	public ChartDefList craftableItemRefArray; // 0x18
	[ChartInt] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<int> minimumCraftableItemsPerHarvest; // 0x20
	[ChartInt] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<int> maximumCraftableItemsPerHarvest; // 0x28
	[ChartInt] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<int> percentChance; // 0x30
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int harvests; // 0x38

	// Constructors
	public HarvestPointDefComponent(); // 0x000000018061B470-0x000000018061B530

	// Methods
	private bool Contains(string inCraftableItemDefId, out int IndexOf); // 0x000000018061B020-0x000000018061B0E0
	public void GetMinAndMax(string inCraftableItemDefId, out int outMin, out int outMax); // 0x000000018061B280-0x000000018061B350
	public void GetMinAndMaxAndPercent(string inCraftableItemDefId, out int outMin, out int outMax, out int outPercent); // 0x000000018061B170-0x000000018061B280
	public int GetMinimum(string inCraftableItemDefId); // 0x000000018061B350-0x000000018061B3E0
	public int GetMaximum(string inCraftableItemDefId); // 0x000000018061B0E0-0x000000018061B170
	public int GetPercent(string inCraftableItemDefId); // 0x000000018061B3E0-0x000000018061B470
}

