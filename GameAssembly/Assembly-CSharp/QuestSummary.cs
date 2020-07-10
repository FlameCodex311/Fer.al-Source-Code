/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class QuestSummary // TypeDefIndex: 11699
{
	// Fields
	public SummaryTallies summaryTallies; // 0x10

	// Nested types
	public enum TallyType // TypeDefIndex: 11700
	{
		SideQuests = 0,
		Cinders = 1,
		Secrets = 2,
		Treasures = 3,
		Puzzles = 4
	}

	[Serializable]
	public class SummaryTallies // TypeDefIndex: 11701
	{
		// Fields
		public SummaryTally sideQuests; // 0x10
		public SummaryTally cinders; // 0x18
		public SummaryTally secrets; // 0x20
		public SummaryTally treasures; // 0x28
		public SummaryTally puzzles; // 0x30

		// Constructors
		public SummaryTallies(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class SummaryTally // TypeDefIndex: 11702
	{
		// Fields
		public int current; // 0x10
		public int targetMax; // 0x14

		// Constructors
		public SummaryTally(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public QuestSummary(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public float GetNormalizedProgress(bool inQuestIsComplete = true /* Metadata: 0x00782B44 */); // 0x000000018100FD30-0x000000018100FFA0
	public void SetTallyValue(TallyType inTallyType, int inValue); // 0x000000018100FFA0-0x0000000181010080
}

