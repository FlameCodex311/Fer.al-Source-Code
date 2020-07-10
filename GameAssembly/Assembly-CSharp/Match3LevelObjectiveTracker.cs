/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3LevelObjectiveTracker : MonoBehaviour // TypeDefIndex: 12992
{
	// Fields
	public IntEvent removeBlockersObjectiveStarted; // 0x20
	public IntEvent specialOrderObjectiveStarted; // 0x28
	[Header] // 0x0000000180158150-0x0000000180158180
	public VoidEvent orderCompleteEvent; // 0x30
	public VoidEvent orderCompleteEvent_Combo; // 0x38
	public VoidEvent orderCompleteEvent_RushHour; // 0x40
	public VoidEvent orderCompleteEvent_ShortStaffed; // 0x48
	public VoidEvent orderCompleteEvent_SpecialItems; // 0x50
	private List<Match3LevelObjectiveTrackingInfo> _tracking; // 0x58

	// Properties
	public bool AllObjectivesComplete { get; } // 0x00000001816CF870-0x00000001816CF9D0 
	public Match3LevelObjectiveTrackingInfo ScoreTrackingInfo { get; } // 0x00000001816CF9D0-0x00000001816CF9E0 

	// Constructors
	public Match3LevelObjectiveTracker(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x00000001816CEA70-0x00000001816CEAD0
	private void ClearTrackedObjectives(); // 0x00000001816CEAD0-0x00000001816CEB20
	public bool IsTrackingObjective(Match3LevelObjectiveType inObjectiveType); // 0x00000001816CECC0-0x00000001816CECE0
	public Match3LevelObjectiveTrackingInfo GetTrackingInfoByType(Match3LevelObjectiveType inObjectiveType); // 0x00000001816CEB20-0x00000001816CECC0
	public void OnLevelStart(int inLevelIndex); // 0x00000001816CECE0-0x00000001816CF480
	public void OnObjectiveUpdated_Score(int inAddScore); // 0x00000001816CF530-0x00000001816CF6A0
	public void OnObjectiveUpdated_TileTypeRemoved(Match3TileType inType, int inCount); // 0x00000001803581E0-0x00000001803581F0
	public void OnObjectiveUpdated_BlockerRemoved(); // 0x00000001816CF480-0x00000001816CF530
	public void OnObjectiveUpdated_SpecialOrderRemoved(); // 0x00000001816CF6A0-0x00000001816CF750
	public void OnObjectiveComplete(Match3LevelObjectiveTrackingInfo inTrack); // 0x00000001803581E0-0x00000001803581F0
	public void TriggerOrderCompleteEvents(); // 0x00000001816CF750-0x00000001816CF870
}

