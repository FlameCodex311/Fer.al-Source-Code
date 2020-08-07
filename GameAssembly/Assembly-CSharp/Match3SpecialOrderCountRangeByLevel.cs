/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Match3SpecialOrderCountRangeByLevel // TypeDefIndex: 10655
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _fromLevelNumber; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _toLevelNumber; // 0x14
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _isToLevelInfinite; // 0x18
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _minimumAccessoryCount; // 0x1C
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _maximumAccessoryCount; // 0x20
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _minimumEggRowCount; // 0x24
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _maximumEggRowCount; // 0x28
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _minimumLimitedMovesOnlyCount; // 0x2C
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _maximumLimitedMovesOnlyCount; // 0x30
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _minimumLimitedMovesComboCount; // 0x34
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _maximumLimitedMovesComboCount; // 0x38

	// Properties
	public int FromLevelNumber { get; } // 0x0000000180387590-0x0000000180387930 
	public int? ToLevelNumber { get; } // 0x00000001807DFDA0-0x00000001807DFE00 
	public bool IsToLevelInfinite { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	public int MinimumAccessoryCount { get; } // 0x00000001803FB770-0x00000001803FB780 
	public int MaximumAccessoryCount { get; } // 0x00000001803FB670-0x00000001803FB680 
	public int MinimumEggRowCount { get; } // 0x0000000180491DB0-0x0000000180491DC0 
	public int MaximumEggRowCount { get; } // 0x000000018043C680-0x000000018043C690 
	public int MinimumLimitedMovesOnlyCount { get; } // 0x000000018043C670-0x000000018043C680 
	public int MaximumLimitedMovesOnlyCount { get; } // 0x00000001804AA650-0x00000001804AA660 
	public int MinimumLimitedMovesComboCount { get; } // 0x00000001804EF8F0-0x00000001804EF900 
	public int MaximumLimitedMovesComboCount { get; } // 0x000000018057D1C0-0x000000018057D1D0 

	// Constructors
	public Match3SpecialOrderCountRangeByLevel(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public void Initialize(); // 0x00000001807DFAD0-0x00000001807DFAE0
	public bool IsLevelInRange(int levelNumber); // 0x00000001807DFAE0-0x00000001807DFBA0
	public int GetCountBySpecialOrderType(SpecialOrderType specialOrderType, bool isCombo); // 0x00000001807DF730-0x00000001807DF900
	private int GetRandomWeightedCount(string specialOrderTypeName, float minimumCount, float maximumCount, int countMultiplier, bool reverseWeightDirection); // 0x00000001807DF900-0x00000001807DFAD0
	private void Validate(); // 0x00000001807DFBA0-0x00000001807DFDA0
}

