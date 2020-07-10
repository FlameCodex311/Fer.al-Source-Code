/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Match3LevelSpecialOrder // TypeDefIndex: 12987
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
	private int _regularLevelAppearancePercent; // 0x1C
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _accessoriesAppearancePercent; // 0x20
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _eggsAppearancePercent; // 0x24
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _limitedMovesAppearancePercent; // 0x28
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private int _comboAppearancePercent; // 0x2C
	private List<SpecialOrderType> _specialOrderTypes; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsSpecialOrderTypesGenerated>k__BackingField; // 0x38

	// Properties
	public bool IsSpecialOrderTypesGenerated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
	public List<SpecialOrderType> SpecialOrderTypes { get; } // 0x00000001810A2CC0-0x00000001810A2D30 
	public int FromLevelNumber { get; } // 0x000000018036CFF0-0x000000018036D000 
	public int? ToLevelNumber { get; } // 0x00000001810A2D30-0x00000001810A2D90 
	public bool IsToLevelInfinite { get; } // 0x000000018041BAC0-0x000000018041BAD0 
	public float RegularLevelAppearanceWeight { get; } // 0x00000001810A2CA0-0x00000001810A2CC0 
	public float AccessoriesAppearanceWeight { get; } // 0x00000001810A2C20-0x00000001810A2C40 
	public float EggsAppearanceWeight { get; } // 0x00000001810A2C60-0x00000001810A2C80 
	public float LimitedMoveAppearanceWeight { get; } // 0x00000001810A2C80-0x00000001810A2CA0 
	public float ComboAppearanceWeight { get; } // 0x00000001810A2C40-0x00000001810A2C60 

	// Constructors
	public Match3LevelSpecialOrder(); // 0x00000001810A2BC0-0x00000001810A2C20

	// Methods
	public void Initialize(); // 0x00000001810A28A0-0x00000001810A2910
	public bool IsLevelInRange(int levelNumber); // 0x00000001810A2910-0x00000001810A29D0
	public void GenerateSpecialOrderTypes(); // 0x00000001810A25C0-0x00000001810A27D0
	private List<SpecialOrderType> GetAvailableCombos(); // 0x00000001810A27D0-0x00000001810A28A0
	private void Validate(); // 0x00000001810A29D0-0x00000001810A2BC0
}

