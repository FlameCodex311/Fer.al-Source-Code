/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TestSeasonPassTier : ISeasonPassTier // TypeDefIndex: 13418
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly string <DefId>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <TierNumber>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly bool <IsFree>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <TotalRequiredAuraPoints>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <LocalRequiredAuraPoints>k__BackingField; // 0x24
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <UnlockCost>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly BundlePackDefComponent.CraftableItemsEntry <Reward>k__BackingField; // 0x30
	private ISeasonPass _seasonPass; // 0x38

	// Properties
	public string DefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	public int TierNumber { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803F46B0-0x00000001803F46C0 
	public bool IsFree { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018041B650-0x000000018041B660 
	public int Progress { get; } // 0x000000018095FFD0-0x000000018095FFF0 
	public float NormalizedProgress { get; } // 0x000000018095FF40-0x000000018095FFD0 
	public int TotalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FB670-0x00000001803FB680 
	public int LocalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180491DB0-0x0000000180491DC0 
	public int UnlockCost { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x000000018043C680-0x000000018043C690 
	public BundlePackDefComponent.CraftableItemsEntry Reward { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803745C0-0x00000001803745D0 
	public bool IsCompleted { get; } // 0x000000018095FE70-0x000000018095FE80 
	public bool IsCurrent { get; } // 0x000000018095FE80-0x000000018095FF40 

	// Constructors
	public TestSeasonPassTier(int inTierNumber, bool inIsFree, BundlePackDefComponent.CraftableItemsEntry inReward, int inPriorRequiredPoints, ISeasonPass inSeasonPass); // 0x000000018095FDF0-0x000000018095FE70
}

