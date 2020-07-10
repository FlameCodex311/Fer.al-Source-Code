/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Quest // TypeDefIndex: 11686
{
	// Fields
	private QuestDefComponent _questDef; // 0x10
	private SocialExpanseDefComponent _socialExpanseDef; // 0x18
	public QuestObjective _currentObjective; // 0x20
	private bool _isPrimary; // 0x28

	// Properties
	public QuestDefComponent QuestDef { get; } // 0x000000018036AC80-0x000000018036AC90 
	public SocialExpanseDefComponent SocialExpanseDef { get; } // 0x000000018038B150-0x000000018038B160 
	public QuestObjective CurrentObjective { get; } // 0x000000018036AC70-0x000000018036AC80 
	public bool IsCompleted { get; } // 0x0000000181010E50-0x0000000181010E70 
	public string Title { get; } // 0x0000000181010ED0-0x0000000181010F30 
	public string Description { get; } // 0x0000000181010D40-0x0000000181010DA0 
	public ImageDefComponent ImageDef { get; } // 0x0000000181010E00-0x0000000181010E20 
	public string GiverName { get; } // 0x0000000181010DA0-0x0000000181010E00 
	public string Location { get; } // 0x0000000181010E70-0x0000000181010ED0 
	public bool IsChallenge { get; } // 0x0000000181010E20-0x0000000181010E50 

	// Constructors
	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001800FE580-0x00000001800FE600 */ List<ValueTuple<int, int>> inTaskStates = null, QuestDefComponent inQuestDef = null); // 0x0000000181010D10-0x0000000181010D40
	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001800FE7E0-0x00000001800FE860 */ List<ValueTuple<int, int>> inTaskStates = null, SocialExpanseDefComponent inSocialExpanseDef = null); // 0x0000000181010CE0-0x0000000181010D10
	private Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001800FEA60-0x00000001800FEAE0 */ List<ValueTuple<int, int>> inTaskStates = null); // 0x0000000181010B00-0x0000000181010CE0

	// Methods
	public void SetCurrentObjective(QuestDefObjective inCurrentObjectiveDef, [TupleElementNames] /* 0x00000001800FE1D0-0x00000001800FE250 */ List<ValueTuple<int, int>> inTaskStates = null); // 0x0000000181010640-0x00000001810108A0
	public void UpdateTask(int taskIndex, int inProgress); // 0x00000001810108A0-0x0000000181010B00
}

