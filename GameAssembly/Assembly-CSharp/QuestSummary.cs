/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class QuestSummary // TypeDefIndex: 13226
{
	// Fields
	public SummaryTallies summaryTallies; // 0x10

	// Nested types
	public enum TallyType // TypeDefIndex: 13227
	{
		SideQuests = 0,
		Cinders = 1,
		Secrets = 2,
		Treasures = 3,
		Puzzles = 4
	}

	[Serializable]
	public class SummaryTallies // TypeDefIndex: 13228
	{
		// Fields
		public SummaryTally sideQuests; // 0x10
		public SummaryTally cinders; // 0x18
		public SummaryTally secrets; // 0x20
		public SummaryTally treasures; // 0x28
		public SummaryTally puzzles; // 0x30

		// Constructors
		public SummaryTallies(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class SummaryTally // TypeDefIndex: 13229
	{
		// Fields
		public int current; // 0x10
		public int targetMax; // 0x14

		// Constructors
		public SummaryTally(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public QuestSummary(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public float GetNormalizedProgress(bool inQuestIsComplete = true /* Metadata: 0x007BA252 */); // 0x0000000180654BF0-0x0000000180654E40
	public void SetTallyValue(TallyType inTallyType, int inValue); // 0x0000000180654E40-0x0000000180654F10
}

