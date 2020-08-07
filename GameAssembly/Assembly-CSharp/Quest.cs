/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Quest // TypeDefIndex: 13213
{
	// Fields
	private QuestDefComponent _questDef; // 0x10
	private SocialExpanseDefComponent _socialExpanseDef; // 0x18
	public QuestObjective _currentObjective; // 0x20
	private bool _isPrimary; // 0x28

	// Properties
	public QuestDefComponent QuestDef { get; } // 0x0000000180372440-0x0000000180372450 
	public SocialExpanseDefComponent SocialExpanseDef { get; } // 0x0000000180372430-0x0000000180372440 
	public QuestObjective CurrentObjective { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public bool IsCompleted { get; } // 0x0000000180655E60-0x0000000180655E80 
	public string Title { get; } // 0x0000000180655EE0-0x0000000180655F40 
	public string Description { get; } // 0x0000000180655D50-0x0000000180655DB0 
	public ImageDefComponent ImageDef { get; } // 0x0000000180655E10-0x0000000180655E30 
	public string GiverName { get; } // 0x0000000180655DB0-0x0000000180655E10 
	public string Location { get; } // 0x0000000180655E80-0x0000000180655EE0 
	public bool IsChallenge { get; } // 0x0000000180655E30-0x0000000180655E60 

	// Constructors
	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001801D7A30-0x00000001801D7AB0 */ List<ValueTuple<int, int>> inTaskStates = null, QuestDefComponent inQuestDef = null); // 0x0000000180655D20-0x0000000180655D50
	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001801D7F80-0x00000001801D8000 */ List<ValueTuple<int, int>> inTaskStates = null, SocialExpanseDefComponent inSocialExpanseDef = null); // 0x0000000180655CF0-0x0000000180655D20
	private Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [TupleElementNames] /* 0x00000001801D82F0-0x00000001801D8370 */ List<ValueTuple<int, int>> inTaskStates = null); // 0x0000000180655B10-0x0000000180655CF0

	// Methods
	public void SetCurrentObjective(QuestDefObjective inCurrentObjectiveDef, [TupleElementNames] /* 0x00000001801D74F0-0x00000001801D7570 */ List<ValueTuple<int, int>> inTaskStates = null); // 0x0000000180655650-0x00000001806558B0
	public void UpdateTask(int taskIndex, int inProgress); // 0x00000001806558B0-0x0000000180655B10
}

