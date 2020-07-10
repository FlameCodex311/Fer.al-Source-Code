/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Match3SpecialOrderCountRangeByLevel // TypeDefIndex: 12990
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _fromLevelNumber; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _toLevelNumber; // 0x14
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _isToLevelInfinite; // 0x18
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _minimumAccessoryCount; // 0x1C
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _maximumAccessoryCount; // 0x20
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _minimumEggRowCount; // 0x24
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _maximumEggRowCount; // 0x28
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _minimumLimitedMovesOnlyCount; // 0x2C
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _maximumLimitedMovesOnlyCount; // 0x30
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _minimumLimitedMovesComboCount; // 0x34
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _maximumLimitedMovesComboCount; // 0x38

	// Properties
	public int FromLevelNumber { get; } // 0x000000018036CFF0-0x000000018036D000 
	public int? ToLevelNumber { get; } // 0x00000001810A3730-0x00000001810A3790 
	public bool IsToLevelInfinite { get; } // 0x000000018041BAC0-0x000000018041BAD0 
	public int MinimumAccessoryCount { get; } // 0x000000018037E420-0x000000018037E430 
	public int MaximumAccessoryCount { get; } // 0x00000001803C2700-0x00000001803C2710 
	public int MinimumEggRowCount { get; } // 0x00000001803C26F0-0x00000001803C2700 
	public int MaximumEggRowCount { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	public int MinimumLimitedMovesOnlyCount { get; } // 0x000000018038E0D0-0x000000018038E0E0 
	public int MaximumLimitedMovesOnlyCount { get; } // 0x000000018043DDC0-0x000000018043DDD0 
	public int MinimumLimitedMovesComboCount { get; } // 0x000000018043E170-0x000000018043E180 
	public int MaximumLimitedMovesComboCount { get; } // 0x00000001804999D0-0x00000001804999E0 

	// Constructors
	public Match3SpecialOrderCountRangeByLevel(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public void Initialize(); // 0x00000001810A3460-0x00000001810A3470
	public bool IsLevelInRange(int levelNumber); // 0x00000001810A3470-0x00000001810A3530
	public int GetCountBySpecialOrderType(SpecialOrderType specialOrderType, bool isCombo); // 0x00000001810A30B0-0x00000001810A3290
	private int GetRandomWeightedCount(string specialOrderTypeName, float minimumCount, float maximumCount, int countMultiplier, bool reverseWeightDirection); // 0x00000001810A3290-0x00000001810A3460
	private void Validate(); // 0x00000001810A3530-0x00000001810A3730
}

