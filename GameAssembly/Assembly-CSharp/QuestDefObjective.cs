/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class QuestDefObjective // TypeDefIndex: 10148
{
	// Fields
	[ChartDef] // 0x0000000180161260-0x00000001801612F0
	public string localizedTitleDefID; // 0x10
	private LocalizationDef _localizedTitleDef; // 0x18
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<QuestDefTask> tasks; // 0x20
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isFinalObjective; // 0x28

	// Properties
	public LocalizationDef LocalizedTitle { get; } // 0x00000001810059A0-0x0000000181005A50 

	// Constructors
	public QuestDefObjective(); // 0x0000000181005940-0x00000001810059A0
}

