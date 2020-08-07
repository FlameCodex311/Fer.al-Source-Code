/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class QuestDefObjective // TypeDefIndex: 11639
{
	// Fields
	[ChartDef] // 0x00000001802383B0-0x0000000180238440
	public string localizedTitleDefID; // 0x10
	private LocalizationDef _localizedTitleDef; // 0x18
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<QuestDefTask> tasks; // 0x20
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isFinalObjective; // 0x28

	// Properties
	public LocalizationDef LocalizedTitle { get; } // 0x0000000180649620-0x00000001806496D0 

	// Constructors
	public QuestDefObjective(); // 0x00000001806495C0-0x0000000180649620
}

