/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestObjective // TypeDefIndex: 13217
{
	// Fields
	private QuestDefObjective _objectiveInfo; // 0x10
	private List<QuestTask> _tasks; // 0x18

	// Properties
	public QuestDefObjective ObjectiveInfo { get; } // 0x0000000180372440-0x0000000180372450 
	public string Title { get; } // 0x00000001806532A0-0x0000000180653370 
	public bool IsFinalObjective { get; } // 0x00000001806530F0-0x0000000180653100 
	public bool IsCompleted { get; } // 0x0000000180652F60-0x00000001806530F0 
	public float NormalizedProgress { get; } // 0x0000000180653100-0x00000001806532A0 
	public List<QuestTask> Tasks { get; } // 0x0000000180372430-0x0000000180372440 

	// Constructors
	public QuestObjective(QuestDefObjective inObjectiveInfo); // 0x0000000180652DA0-0x0000000180652F60
}

