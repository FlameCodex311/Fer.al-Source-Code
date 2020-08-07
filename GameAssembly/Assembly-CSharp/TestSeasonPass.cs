/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TestSeasonPass : ISeasonPass // TypeDefIndex: 13416
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly bool <HasPremium>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly DateTime <EndDate>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <TotalRequiredAuraPoints>k__BackingField; // 0x30

	// Properties
	public bool HasPremium { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FD450-0x00000001803FD460 
	public int AuraPoints { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	public string DefId { get; } // 0x00000001809608F0-0x0000000180960920 
	public BaseDef PurchaseDef { get; } // 0x00000001809609B0-0x0000000180960A60 
	public List<ISeasonPassTier> Tiers { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	public ISeasonPassTier CurrentTier { get; } // 0x0000000180960760-0x00000001809608F0 
	public List<ISeasonPassChallenge> Challenges { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 
	public List<ISeasonPassChallenge> AvailableChallenges { get; } // 0x00000001809605A0-0x0000000180960760 
	public string LocalizedName { get; } // 0x0000000180960920-0x0000000180960950 
	public DateTime EndDate { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803745B0-0x00000001803745C0 
	public int TotalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001804AA650-0x00000001804AA660 
	public int Progress { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	public float NormalizedProgress { get; } // 0x0000000180960950-0x00000001809609B0 

	// Constructors
	public TestSeasonPass(); // 0x000000018095FFF0-0x00000001809605A0

	// Methods
	public void DeInit(); // 0x00000001803774A0-0x00000001803774B0
}

