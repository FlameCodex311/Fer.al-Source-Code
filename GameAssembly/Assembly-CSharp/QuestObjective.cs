/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestObjective // TypeDefIndex: 11690
{
	// Fields
	private QuestDefObjective _objectiveInfo; // 0x10
	private List<QuestTask> _tasks; // 0x18

	// Properties
	public QuestDefObjective ObjectiveInfo { get; } // 0x000000018036AC80-0x000000018036AC90 
	public string Title { get; } // 0x000000018100E890-0x000000018100E960 
	public bool IsFinalObjective { get; } // 0x000000018100E6D0-0x000000018100E6E0 
	public bool IsCompleted { get; } // 0x000000018100E530-0x000000018100E6D0 
	public float NormalizedProgress { get; } // 0x000000018100E6E0-0x000000018100E890 
	public List<QuestTask> Tasks { get; } // 0x000000018038B150-0x000000018038B160 

	// Constructors
	public QuestObjective(QuestDefObjective inObjectiveInfo); // 0x000000018100E370-0x000000018100E530
}

