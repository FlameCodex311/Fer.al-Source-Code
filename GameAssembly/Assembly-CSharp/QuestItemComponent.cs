/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class QuestItemComponent : ItemComponent // TypeDefIndex: 12017
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool open; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private QuestSummary best; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int completions; // 0x30
	private TimestampItemComponent _timestampItemComponent; // 0x38

	// Properties
	public QuestDefComponent QuestDef { get; } // 0x000000018064B370-0x000000018064B3C0 
	public string Title { get; } // 0x000000018064B3E0-0x000000018064B450 
	public string Description { get; } // 0x000000018064B110-0x000000018064B180 
	public ImageDefComponent ImageDef { get; } // 0x000000018064B1F0-0x000000018064B250 
	public string GiverName { get; } // 0x000000018064B180-0x000000018064B1F0 
	public string Location { get; } // 0x000000018064B300-0x000000018064B370 
	public ImageDefComponent ChallengeBannerImageDef { get; } // 0x000000018064B030-0x000000018064B110 
	public bool IsChallenge { get; } // 0x000000018064B2A0-0x000000018064B300 
	public bool IsOpen { get; } // 0x00000001803FA090-0x00000001803FA0A0 
	public DateTime TimeOpened { get; } // 0x000000018064B3C0-0x000000018064B3E0 
	public QuestSummary BestRunSummary { get; } // 0x00000001803745B0-0x00000001803745C0 
	public bool IsActive { get; } // 0x000000018064B250-0x000000018064B2A0 
	public int CompletionCount { get; } // 0x00000001804AA650-0x00000001804AA660 

	// Constructors
	public QuestItemComponent(); // 0x000000018064B020-0x000000018064B030

	// Methods
	public override void OnLoaded(); // 0x000000018064AEE0-0x000000018064AF40
	public QuestItemComponent Setup(QuestDefComponent inQuestDef); // 0x000000018064AF50-0x000000018064B020
	public void CompleteQuest(QuestSummary inQuestSummary); // 0x000000018064AED0-0x000000018064AEE0
	public void ReopenQuest(); // 0x000000018064AF40-0x000000018064AF50
}

