/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public interface IPlayerLevel // TypeDefIndex: 14296
{
	// Properties
	int CurrentLevel { get; }
	int CurrentXP { get; }
	int NextLevelXP { get; }
	float NormalizedLevelProgress { get; }

	// Methods
	int XPLevelRequirement(int inLevel);
}

