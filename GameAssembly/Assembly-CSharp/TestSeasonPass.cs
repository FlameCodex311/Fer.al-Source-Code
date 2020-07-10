/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TestSeasonPass : ISeasonPass // TypeDefIndex: 11880
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly bool <HasPremium>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly DateTime <EndDate>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <TotalRequiredAuraPoints>k__BackingField; // 0x30

	// Properties
	public bool HasPremium { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180375540-0x0000000180375550 
	public int AuraPoints { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	public string DefId { get; } // 0x0000000181210990-0x00000001812109C0 
	public BaseDef PurchaseDef { get; } // 0x0000000181210A50-0x0000000181210B00 
	public List<ISeasonPassTier> Tiers { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	public ISeasonPassTier CurrentTier { get; } // 0x0000000181210800-0x0000000181210990 
	public List<ISeasonPassChallenge> Challenges { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 
	public List<ISeasonPassChallenge> AvailableChallenges { get; } // 0x0000000181210640-0x0000000181210800 
	public string LocalizedName { get; } // 0x00000001812109C0-0x00000001812109F0 
	public DateTime EndDate { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B60-0x0000000180369B70 
	public int TotalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018043DDC0-0x000000018043DDD0 
	public int Progress { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	public float NormalizedProgress { get; } // 0x00000001812109F0-0x0000000181210A50 

	// Constructors
	public TestSeasonPass(); // 0x0000000181210070-0x0000000181210640

	// Methods
	public void DeInit(); // 0x00000001803581E0-0x00000001803581F0
}

