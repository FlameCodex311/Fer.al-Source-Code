/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TestPlayerLevel : IPlayerLevel // TypeDefIndex: 14297
{
	// Fields
	private const int XP_PER_LEVEL = 10; // Metadata: 0x007BA755
	private int _currentLevel; // 0x10
	private int _currentXP; // 0x14

	// Properties
	public int CurrentLevel { get; } // 0x0000000180387590-0x0000000180387930 
	public int CurrentXP { get; } // 0x00000001803FD2F0-0x00000001803FD300 
	public int NextLevelXP { get; } // 0x000000018095FC20-0x000000018095FC30 
	public float NormalizedLevelProgress { get; } // 0x000000018095FC30-0x000000018095FC70 

	// Constructors
	public TestPlayerLevel(); // 0x000000018095FBD0-0x000000018095FC20

	// Methods
	public int XPLevelRequirement(int inLevel); // 0x000000018095FBC0-0x000000018095FBD0
}

