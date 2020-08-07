/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3LevelObjectiveTracker : MonoBehaviour // TypeDefIndex: 10657
{
	// Fields
	public IntEvent removeBlockersObjectiveStarted; // 0x20
	public IntEvent specialOrderObjectiveStarted; // 0x28
	[Header] // 0x0000000180235050-0x0000000180235080
	public VoidEvent orderCompleteEvent; // 0x30
	public VoidEvent orderCompleteEvent_Combo; // 0x38
	public VoidEvent orderCompleteEvent_RushHour; // 0x40
	public VoidEvent orderCompleteEvent_ShortStaffed; // 0x48
	public VoidEvent orderCompleteEvent_SpecialItems; // 0x50
	private List<Match3LevelObjectiveTrackingInfo> _tracking; // 0x58

	// Properties
	public bool AllObjectivesComplete { get; } // 0x00000001807DE9D0-0x00000001807DEB30 
	public Match3LevelObjectiveTrackingInfo ScoreTrackingInfo { get; } // 0x00000001807DEB30-0x00000001807DEB40 

	// Constructors
	public Match3LevelObjectiveTracker(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001807DDA50-0x00000001807DDAB0
	private void ClearTrackedObjectives(); // 0x00000001807DDAB0-0x00000001807DDB00
	public bool IsTrackingObjective(Match3LevelObjectiveType inObjectiveType); // 0x00000001807DDCA0-0x00000001807DDCC0
	public Match3LevelObjectiveTrackingInfo GetTrackingInfoByType(Match3LevelObjectiveType inObjectiveType); // 0x00000001807DDB00-0x00000001807DDCA0
	public void OnLevelStart(int inLevelIndex); // 0x00000001807DDCC0-0x00000001807DE520
	public void OnObjectiveUpdated_Score(int inAddScore); // 0x00000001807DE640-0x00000001807DE7A0
	public void OnObjectiveUpdated_TileTypeRemoved(Match3TileType inType, int inCount); // 0x00000001803774A0-0x00000001803774B0
	public void OnObjectiveUpdated_BlockerRemoved(); // 0x00000001807DE520-0x00000001807DE640
	public void OnObjectiveUpdated_SpecialOrderRemoved(); // 0x00000001807DE7A0-0x00000001807DE8C0
	public void OnObjectiveComplete(Match3LevelObjectiveTrackingInfo inTrack); // 0x00000001803774A0-0x00000001803774B0
	public void TriggerOrderCompleteEvents(); // 0x00000001807DE8C0-0x00000001807DE9D0
}

