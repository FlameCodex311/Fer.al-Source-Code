/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Match3LevelSpecialOrder // TypeDefIndex: 10652
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
	private int _regularLevelAppearancePercent; // 0x1C
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _accessoriesAppearancePercent; // 0x20
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _eggsAppearancePercent; // 0x24
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _limitedMovesAppearancePercent; // 0x28
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private int _comboAppearancePercent; // 0x2C
	private List<SpecialOrderType> _specialOrderTypes; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsSpecialOrderTypesGenerated>k__BackingField; // 0x38

	// Properties
	public bool IsSpecialOrderTypesGenerated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001804F1690-0x00000001804F16A0
	public List<SpecialOrderType> SpecialOrderTypes { get; } // 0x00000001807DF340-0x00000001807DF3B0 
	public int FromLevelNumber { get; } // 0x0000000180387590-0x0000000180387930 
	public int? ToLevelNumber { get; } // 0x00000001807DF3B0-0x00000001807DF410 
	public bool IsToLevelInfinite { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	public float RegularLevelAppearanceWeight { get; } // 0x00000001807DF320-0x00000001807DF340 
	public float AccessoriesAppearanceWeight { get; } // 0x00000001807DF2A0-0x00000001807DF2C0 
	public float EggsAppearanceWeight { get; } // 0x00000001807DF2E0-0x00000001807DF300 
	public float LimitedMoveAppearanceWeight { get; } // 0x00000001807DF300-0x00000001807DF320 
	public float ComboAppearanceWeight { get; } // 0x00000001807DF2C0-0x00000001807DF2E0 

	// Constructors
	public Match3LevelSpecialOrder(); // 0x00000001807DF240-0x00000001807DF2A0

	// Methods
	public void Initialize(); // 0x00000001807DEF30-0x00000001807DEFA0
	public bool IsLevelInRange(int levelNumber); // 0x00000001807DEFA0-0x00000001807DF060
	public void GenerateSpecialOrderTypes(); // 0x00000001807DEC60-0x00000001807DEE60
	private List<SpecialOrderType> GetAvailableCombos(); // 0x00000001807DEE60-0x00000001807DEF30
	private void Validate(); // 0x00000001807DF060-0x00000001807DF240
}

