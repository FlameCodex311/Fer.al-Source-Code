/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonPassChallenge : ISeasonPassChallenge // TypeDefIndex: 13412
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly string <DefId>k__BackingField; // 0x10
	private int _progress; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <Requirement>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <AuraPoints>k__BackingField; // 0x20
	private SeasonPassChallengeDefComponent _challengeDef; // 0x28

	// Properties
	public string DefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	public string LocalizedName { get; } // 0x00000001803FB690-0x00000001803FB700 
	public int Progress { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803FB780-0x00000001803FB800
	public float NormalizedProgress { get; } // 0x00000001803FB700-0x00000001803FB770 
	public int Requirement { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FB770-0x00000001803FB780 
	public bool IsCompleted { get; } // 0x00000001803FB680-0x00000001803FB690 
	public int AuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FB670-0x00000001803FB680 

	// Constructors
	public SeasonPassChallenge(string inDefId, int inProgress); // 0x00000001803FB520-0x00000001803FB670

	// Methods
	public void SetState(int inProgress); // 0x00000001803FB510-0x00000001803FB520
}

