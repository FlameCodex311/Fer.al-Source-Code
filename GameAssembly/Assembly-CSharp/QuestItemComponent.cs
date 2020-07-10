/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class QuestItemComponent : ItemComponent // TypeDefIndex: 10529
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool open; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private QuestSummary best; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int completions; // 0x30
	private TimestampItemComponent _timestampItemComponent; // 0x38

	// Properties
	public QuestDefComponent QuestDef { get; } // 0x0000000181007820-0x0000000181007870 
	public string Title { get; } // 0x0000000181007890-0x0000000181007910 
	public string Description { get; } // 0x0000000181007590-0x0000000181007610 
	public ImageDefComponent ImageDef { get; } // 0x0000000181007690-0x00000001810076F0 
	public string GiverName { get; } // 0x0000000181007610-0x0000000181007690 
	public string Location { get; } // 0x00000001810077A0-0x0000000181007820 
	public ImageDefComponent ChallengeBannerImageDef { get; } // 0x00000001810074B0-0x0000000181007590 
	public bool IsChallenge { get; } // 0x0000000181007740-0x00000001810077A0 
	public bool IsOpen { get; } // 0x00000001803C19E0-0x00000001803C19F0 
	public DateTime TimeOpened { get; } // 0x0000000181007870-0x0000000181007890 
	public QuestSummary BestRunSummary { get; } // 0x0000000180369B60-0x0000000180369B70 
	public bool IsActive { get; } // 0x00000001810076F0-0x0000000181007740 
	public int CompletionCount { get; } // 0x000000018043DDC0-0x000000018043DDD0 

	// Constructors
	public QuestItemComponent(); // 0x00000001810074A0-0x00000001810074B0

	// Methods
	public override void OnLoaded(); // 0x0000000181007360-0x00000001810073C0
	public QuestItemComponent Setup(QuestDefComponent inQuestDef); // 0x00000001810073D0-0x00000001810074A0
	public void CompleteQuest(QuestSummary inQuestSummary); // 0x0000000181007350-0x0000000181007360
	public void ReopenQuest(); // 0x00000001810073C0-0x00000001810073D0
}

