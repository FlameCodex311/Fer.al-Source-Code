/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityAtoms;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Match3Achievement : IAtomListener<ObscuredInt, ObscuredInt> // TypeDefIndex: 12947
{
	// Fields
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public Match3AchievementType achievementType; // 0x10
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int threshold; // 0x14
	private Match3AchievementTypeData _achievementTypeData; // 0x18
	private int _puzzleIndex; // 0x20
	private int _pieceIndex; // 0x24
	private IntIntEvent _unlockedEvent; // 0x28

	// Properties
	public int Progress { get; } // 0x00000001811F0240-0x00000001811F0370 
	public float NormalizedProgress { get; } // 0x00000001811F0210-0x00000001811F0240 
	public bool IsCompleted { get; } // 0x00000001811F0110-0x00000001811F0130 
	public string LocalizedText { get; } // 0x00000001811F0130-0x00000001811F0210 

	// Constructors
	public Match3Achievement(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public void Init(Match3AchievementTypeData inTypeData, int inPuzzleIndex, int inPieceIndex, IntIntEvent inUnlockedEvent); // 0x00000001811EFEF0-0x00000001811F0060
	public void OnEventRaised(ObscuredInt inCurrentValue, ObscuredInt inOldValue); // 0x00000001811F0060-0x00000001811F0110
}

