/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestTask // TypeDefIndex: 13231
{
	// Fields
	private QuestDefTask _taskInfo; // 0x10
	private int _currentProgress; // 0x18
	private bool _isUnread; // 0x1C

	// Properties
	public QuestDefTask TaskInfo { get; } // 0x0000000180372440-0x0000000180372450 
	public string Description { get; } // 0x0000000180654F20-0x0000000180655060 
	public ImageDefComponent ImageDef { get; } // 0x0000000180655060-0x0000000180655110 
	public int CurrentProgress { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001806551A0-0x00000001806551B0
	public int TargetProgress { get; } // 0x0000000180655180-0x00000001806551A0 
	public float NormalizedProgress { get; } // 0x0000000180655140-0x0000000180655170 
	public bool ShowProgressText { get; } // 0x0000000180655170-0x0000000180655180 
	public bool IsCompleted { get; } // 0x0000000180655110-0x0000000180655140 
	public bool IsUnread { get; } // 0x000000018041B650-0x000000018041B660 

	// Constructors
	public QuestTask(QuestDefTask inTaskDef); // 0x0000000180400150-0x0000000180400180

	// Methods
	public void MarkAsRead(); // 0x0000000180654F10-0x0000000180654F20
}

