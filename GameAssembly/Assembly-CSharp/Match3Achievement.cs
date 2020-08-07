/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityAtoms;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Match3Achievement : IAtomListener<ObscuredInt, ObscuredInt> // TypeDefIndex: 10612
{
	// Fields
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public Match3AchievementType achievementType; // 0x10
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int threshold; // 0x14
	private Match3AchievementTypeData _achievementTypeData; // 0x18
	private int _puzzleIndex; // 0x20
	private int _pieceIndex; // 0x24
	private IntIntEvent _unlockedEvent; // 0x28

	// Properties
	public int Progress { get; } // 0x00000001804F6DE0-0x00000001804F6E60 
	public float NormalizedProgress { get; } // 0x00000001804F6DB0-0x00000001804F6DE0 
	public bool IsCompleted { get; } // 0x00000001804F6C40-0x00000001804F6C60 
	public string LocalizedText { get; } // 0x00000001804F6C60-0x00000001804F6DB0 

	// Constructors
	public Match3Achievement(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public void Init(Match3AchievementTypeData inTypeData, int inPuzzleIndex, int inPieceIndex, IntIntEvent inUnlockedEvent); // 0x00000001804F6A30-0x00000001804F6B90
	public void OnEventRaised(ObscuredInt inCurrentValue, ObscuredInt inOldValue); // 0x00000001804F6B90-0x00000001804F6C40
}

