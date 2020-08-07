/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonPassTier : ISeasonPassTier // TypeDefIndex: 13415
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly string <DefId>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <TierNumber>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly int <LocalRequiredAuraPoints>k__BackingField; // 0x1C
	private SeasonPassTierDefComponent _tierDef; // 0x20
	private ISeasonPass _seasonPass; // 0x28

	// Properties
	public string DefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	public int TierNumber { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803F46B0-0x00000001803F46C0 
	public bool IsFree { get; } // 0x00000001803FBD90-0x00000001803FBDB0 
	public int Progress { get; } // 0x00000001803FBE30-0x00000001803FBF40 
	public float NormalizedProgress { get; } // 0x00000001803FBDB0-0x00000001803FBE30 
	public bool IsCompleted { get; } // 0x00000001803FBD20-0x00000001803FBD40 
	public bool IsCurrent { get; } // 0x00000001803FBD40-0x00000001803FBD90 
	public int TotalRequiredAuraPoints { get; } // 0x00000001803FB770-0x00000001803FB780 
	public int LocalRequiredAuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FB770-0x00000001803FB780 
	public int UnlockCost { get; } // 0x00000001803FBF60-0x00000001803FC040 
	public BundlePackDefComponent.CraftableItemsEntry Reward { get; } // 0x00000001803FBF40-0x00000001803FBF60 

	// Constructors
	public SeasonPassTier(string inDefId, int inTierNumber, ISeasonPass inSeasonPass); // 0x00000001803FBC70-0x00000001803FBD20
}

