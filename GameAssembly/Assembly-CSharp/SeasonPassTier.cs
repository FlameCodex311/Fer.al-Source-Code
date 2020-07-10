/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SeasonPassTier : ISeasonPassTier // TypeDefIndex: 11879
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <TierNumber>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <LocalRequiredAuraPoints>k__BackingField; // 0x14
	private SeasonPassTierDefComponent _tierDef; // 0x18
	private ISeasonPass _seasonPass; // 0x20

	// Properties
	public int TierNumber { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
	public bool IsFree { get; } // 0x0000000180EBD580-0x0000000180EBD5A0 
	public int Progress { get; } // 0x0000000180EBD620-0x0000000180EBD740 
	public float NormalizedProgress { get; } // 0x0000000180EBD5A0-0x0000000180EBD620 
	public bool IsCompleted { get; } // 0x0000000180EBD500-0x0000000180EBD520 
	public bool IsCurrent { get; } // 0x0000000180EBD520-0x0000000180EBD580 
	public int TotalRequiredAuraPoints { get; } // 0x0000000180372360-0x0000000180372370 
	public int LocalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180372360-0x0000000180372370 
	public int UnlockCost { get; } // 0x0000000180EBD740-0x0000000180EBD820 
	public BundlePackDefComponent.CraftableItemsEntry Reward { get; } // 0x00000001805A6C60-0x00000001805A6C80 

	// Constructors
	public SeasonPassTier(string inDefId, int inTierNumber, ISeasonPass inSeasonPass); // 0x0000000180EBD450-0x0000000180EBD500
}

