/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TestPlayerLevel : IPlayerLevel // TypeDefIndex: 12725
{
	// Fields
	private const int XP_PER_LEVEL = 10; // Metadata: 0x00783032
	private int _currentLevel; // 0x10
	private int _currentXP; // 0x14

	// Properties
	public int CurrentLevel { get; } // 0x000000018036CFF0-0x000000018036D000 
	public int CurrentXP { get; } // 0x0000000180372360-0x0000000180372370 
	public int NextLevelXP { get; } // 0x000000018120FCA0-0x000000018120FCB0 
	public float NormalizedLevelProgress { get; } // 0x000000018120FCB0-0x000000018120FCF0 

	// Constructors
	public TestPlayerLevel(); // 0x000000018120FC50-0x000000018120FCA0

	// Methods
	public int XPLevelRequirement(int inLevel); // 0x000000018120FC40-0x000000018120FC50
}

