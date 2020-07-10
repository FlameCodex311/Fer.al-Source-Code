/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SeasonPassChallenge : ISeasonPassChallenge // TypeDefIndex: 11876
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly string <DefId>k__BackingField; // 0x10
	private int _progress; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <Requirement>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <AuraPoints>k__BackingField; // 0x20
	private SeasonPassChallengeDefComponent _challengeDef; // 0x28

	// Properties
	public string DefId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	public string LocalizedName { get; } // 0x0000000180EBCEF0-0x0000000180EBCF60 
	public int Progress { get; set; } // 0x0000000180367710-0x0000000180367720 0x0000000180EBCFD0-0x0000000180EBD050
	public float NormalizedProgress { get; } // 0x0000000180EBCF60-0x0000000180EBCFD0 
	public int Requirement { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018037E420-0x000000018037E430 
	public bool IsCompleted { get; } // 0x0000000180EBCEE0-0x0000000180EBCEF0 
	public int AuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C2700-0x00000001803C2710 

	// Constructors
	public SeasonPassChallenge(string inDefId, int inProgress); // 0x0000000180EBCD90-0x0000000180EBCEE0

	// Methods
	public void SetState(int inProgress); // 0x0000000180EBCD80-0x0000000180EBCD90
}

