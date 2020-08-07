/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x0000000180240BF0-0x0000000180240C30
public class Match3LevelData : ScriptableObject // TypeDefIndex: 10646
{
	// Fields
	public Match3LevelGrowthRate levelGrowthRate; // 0x18
	public List<Match3LevelSpecialOrder> specialOrders; // 0x20
	public List<Match3SpecialOrderCountRangeByLevel> specialOrderCountRanges; // 0x28
	public bool useDebugSpecialOrders; // 0x30
	public List<Match3LevelSpecialOrder> debugSpecialOrders; // 0x38
	public List<Match3SpecialOrderCountRangeByLevel> debugSepcialOrderCountRanges; // 0x40
	[EnumList] // 0x0000000180240E20-0x0000000180240E90
	[Space] // 0x0000000180240E20-0x0000000180240E90
	public List<Sprite> specialOrderIcons; // 0x48
	[RootSelectorCompact] // 0x0000000180241240-0x00000001802412A0
	public List<string> specialOrderText; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 10647
	{
		// Fields
		public int levelNumber; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetSpecialOrder>b__0(Match3LevelSpecialOrder order); // 0x00000001807F13D0-0x00000001807F14B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 10648
	{
		// Fields
		public int levelNumber; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetSpecialOrderCountRange>b__0(Match3SpecialOrderCountRangeByLevel eggCountRange); // 0x00000001807F0DD0-0x00000001807F0EB0
	}

	// Constructors
	public Match3LevelData(); // 0x00000001807DD780-0x00000001807DD7E0

	// Methods
	public void Initialize(); // 0x00000001807DD200-0x00000001807DD780
	public Match3LevelSpecialOrder GetSpecialOrder(int levelNumber); // 0x00000001807DD150-0x00000001807DD200
	public Match3SpecialOrderCountRangeByLevel GetSpecialOrderCountRange(int levelNumber); // 0x00000001807DD0A0-0x00000001807DD150
}

