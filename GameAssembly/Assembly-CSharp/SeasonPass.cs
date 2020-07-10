/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SeasonPass : ISeasonPass // TypeDefIndex: 11871
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <HasPremium>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <AuraPoints>k__BackingField; // 0x14
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly List<ISeasonPassChallenge> <AvailableChallenges>k__BackingField; // 0x28
	private SeasonPassDefComponent _seasonPassDef; // 0x30
	private int _currentTierIndex; // 0x38

	// Properties
	public bool HasPremium { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
	public int AuraPoints { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
	public string DefId { get; } // 0x0000000180EBEA70-0x0000000180EBEA90 
	public BaseDef PurchaseDef { get; } // 0x0000000180EBEC20-0x0000000180EBED00 
	public List<ISeasonPassTier> Tiers { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	public ISeasonPassTier CurrentTier { get; } // 0x0000000180EBE9F0-0x0000000180EBEA70 
	public List<ISeasonPassChallenge> Challenges { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 
	public List<ISeasonPassChallenge> AvailableChallenges { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B60-0x0000000180369B70 
	public string LocalizedName { get; } // 0x0000000180EBEB40-0x0000000180EBEBB0 
	public DateTime EndDate { get; } // 0x0000000180EBEA90-0x0000000180EBEB40 
	public float NormalizedProgress { get; } // 0x0000000180EBEBB0-0x0000000180EBEC20 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 11872
	{
		// Fields
		public SeasonSrvHandler.ListChallengesResponse.ChallengeItem cItem; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetupChallenges>b__0(ISeasonPassChallenge challenge); // 0x0000000180EC8DA0-0x0000000180EC8E20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass32_1 // TypeDefIndex: 11873
	{
		// Fields
		public SeasonSrvHandler.ListChallengesResponse.ChallengeItem cItem; // 0x10

		// Constructors
		public <>c__DisplayClass32_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetupChallenges>b__1(ISeasonPassChallenge challenge); // 0x0000000180EC8E20-0x0000000180EC8EA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 11874
	{
		// Fields
		public SeasonPassChallengeUpdateResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnChallengeUpdated>b__0(ISeasonPassChallenge c); // 0x0000000180EC8EA0-0x0000000180EC8F20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 11875
	{
		// Fields
		public SeasonPassChallengeCompleteResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass37_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnChallengeCompleted>b__0(ISeasonPassChallenge c); // 0x0000000180EC8F20-0x0000000180EC8FA0
		internal bool <OnChallengeCompleted>b__1(ISeasonPassChallenge c); // 0x0000000180EC8FA0-0x0000000180EC9020
	}

	// Constructors
	public SeasonPass(string inDefId, int inCurrentTier, int inAuraPoints, bool inHasPremium); // 0x0000000180EBE4B0-0x0000000180EBE9F0

	// Methods
	public void SetupChallenges(SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCurrentChallenges, SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCompletedChallenges); // 0x0000000180EBE170-0x0000000180EBE4B0
	public void DeInit(); // 0x0000000180EBD930-0x0000000180EBDA40
	private void AddListeners(); // 0x0000000180EBD820-0x0000000180EBD930
	private void RemoveListeners(); // 0x0000000180EBD930-0x0000000180EBDA40
	private void OnChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage); // 0x0000000180EBDF00-0x0000000180EBE090
	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x0000000180EBDB70-0x0000000180EBDF00
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x0000000180EBE090-0x0000000180EBE170
	private void OnAuraPointsReceived(int inAuraPoints); // 0x0000000180EBDA40-0x0000000180EBDB70
}

