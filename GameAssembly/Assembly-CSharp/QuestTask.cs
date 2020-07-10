/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestTask // TypeDefIndex: 11704
{
	// Fields
	private QuestDefTask _taskInfo; // 0x10
	private int _currentProgress; // 0x18
	private bool _isUnread; // 0x1C

	// Properties
	public QuestDefTask TaskInfo { get; } // 0x000000018036AC80-0x000000018036AC90 
	public string Description { get; } // 0x0000000181010090-0x00000001810101D0 
	public ImageDefComponent ImageDef { get; } // 0x00000001810101D0-0x0000000181010280 
	public int CurrentProgress { get; set; } // 0x0000000180367710-0x0000000180367720 0x0000000181010310-0x0000000181010320
	public int TargetProgress { get; } // 0x00000001810102F0-0x0000000181010310 
	public float NormalizedProgress { get; } // 0x00000001810102B0-0x00000001810102E0 
	public bool ShowProgressText { get; } // 0x00000001810102E0-0x00000001810102F0 
	public bool IsCompleted { get; } // 0x0000000181010280-0x00000001810102B0 
	public bool IsUnread { get; } // 0x000000018036CB20-0x000000018036CB30 

	// Constructors
	public QuestTask(QuestDefTask inTaskDef); // 0x000000018037D3F0-0x000000018037D420

	// Methods
	public void MarkAsRead(); // 0x0000000181010080-0x0000000181010090
}

