/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TestSeasonPassTier : ISeasonPassTier // TypeDefIndex: 11882
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <TierNumber>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly bool <IsFree>k__BackingField; // 0x14
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <TotalRequiredAuraPoints>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <LocalRequiredAuraPoints>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly int <UnlockCost>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly BundlePackDefComponent.CraftableItemsEntry <Reward>k__BackingField; // 0x28
	private ISeasonPass _seasonPass; // 0x30

	// Properties
	public int TierNumber { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
	public bool IsFree { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180491CD0-0x0000000180491CE0 
	public int Progress { get; } // 0x0000000181210050-0x0000000181210070 
	public float NormalizedProgress { get; } // 0x000000018120FFC0-0x0000000181210050 
	public int TotalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180367710-0x0000000180367720 
	public int LocalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018037E420-0x000000018037E430 
	public int UnlockCost { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C2700-0x00000001803C2710 
	public BundlePackDefComponent.CraftableItemsEntry Reward { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B60-0x0000000180369B70 
	public bool IsCompleted { get; } // 0x000000018120FEF0-0x000000018120FF00 
	public bool IsCurrent { get; } // 0x000000018120FF00-0x000000018120FFC0 

	// Constructors
	public TestSeasonPassTier(int inTierNumber, bool inIsFree, BundlePackDefComponent.CraftableItemsEntry inReward, int inPriorRequiredPoints, ISeasonPass inSeasonPass); // 0x000000018120FE70-0x000000018120FEF0
}

