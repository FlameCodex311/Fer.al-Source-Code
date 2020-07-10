/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x0000000180163D80-0x0000000180163DC0
public class Match3LevelData : ScriptableObject // TypeDefIndex: 12981
{
	// Fields
	public Match3LevelGrowthRate levelGrowthRate; // 0x18
	public List<Match3LevelSpecialOrder> specialOrders; // 0x20
	public List<Match3SpecialOrderCountRangeByLevel> specialOrderCountRanges; // 0x28
	public bool useDebugSpecialOrders; // 0x30
	public List<Match3LevelSpecialOrder> debugSpecialOrders; // 0x38
	public List<Match3SpecialOrderCountRangeByLevel> debugSepcialOrderCountRanges; // 0x40
	[EnumList] // 0x00000001801640A0-0x0000000180164110
	[Space] // 0x00000001801640A0-0x0000000180164110
	public List<Sprite> specialOrderIcons; // 0x48
	[RootSelectorCompact] // 0x00000001801644C0-0x0000000180164520
	public List<string> specialOrderText; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12982
	{
		// Fields
		public int levelNumber; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetSpecialOrder>b__0(Match3LevelSpecialOrder order); // 0x00000001816D5B00-0x00000001816D5B30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12983
	{
		// Fields
		public int levelNumber; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetSpecialOrderCountRange>b__0(Match3SpecialOrderCountRangeByLevel eggCountRange); // 0x00000001816D59A0-0x00000001816D59D0
	}

	// Constructors
	public Match3LevelData(); // 0x00000001816CE7B0-0x00000001816CE810

	// Methods
	public void Initialize(); // 0x00000001816CE2A0-0x00000001816CE7B0
	public Match3LevelSpecialOrder GetSpecialOrder(int levelNumber); // 0x00000001816CE1E0-0x00000001816CE2A0
	public Match3SpecialOrderCountRangeByLevel GetSpecialOrderCountRange(int levelNumber); // 0x00000001816CE120-0x00000001816CE1E0
}

