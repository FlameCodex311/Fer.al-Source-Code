/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SeasonPass : ISeasonPass // TypeDefIndex: 13407
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <HasPremium>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <AuraPoints>k__BackingField; // 0x14
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly List<ISeasonPassTier> <Tiers>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly List<ISeasonPassChallenge> <Challenges>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly List<ISeasonPassChallenge> <AvailableChallenges>k__BackingField; // 0x28
	private SeasonPassDefComponent _seasonPassDef; // 0x30
	private int _currentTierIndex; // 0x38

	// Properties
	public bool HasPremium { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
	public int AuraPoints { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
	public string DefId { get; } // 0x00000001803FD380-0x00000001803FD3A0 
	public BaseDef PurchaseDef { get; } // 0x00000001803FD540-0x00000001803FD620 
	public List<ISeasonPassTier> Tiers { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	public ISeasonPassTier CurrentTier { get; } // 0x00000001803FD300-0x00000001803FD380 
	public List<ISeasonPassChallenge> Challenges { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 
	public List<ISeasonPassChallenge> AvailableChallenges { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803745B0-0x00000001803745C0 
	public string LocalizedName { get; } // 0x00000001803FD460-0x00000001803FD4D0 
	public DateTime EndDate { get; } // 0x00000001803FD3A0-0x00000001803FD450 
	public float NormalizedProgress { get; } // 0x00000001803FD4D0-0x00000001803FD540 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 13408
	{
		// Fields
		public SeasonSrvHandler.ListChallengesResponse.ChallengeItem cItem; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetupChallenges>b__0(ISeasonPassChallenge challenge); // 0x0000000180405AE0-0x0000000180405B50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_1 // TypeDefIndex: 13409
	{
		// Fields
		public SeasonSrvHandler.ListChallengesResponse.ChallengeItem cItem; // 0x10

		// Constructors
		public <>c__DisplayClass32_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetupChallenges>b__1(ISeasonPassChallenge challenge); // 0x0000000180405B50-0x0000000180405BC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 13410
	{
		// Fields
		public SeasonPassChallengeUpdateResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnChallengeUpdated>b__0(ISeasonPassChallenge c); // 0x0000000180405BC0-0x0000000180405C30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 13411
	{
		// Fields
		public SeasonPassChallengeCompleteResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass37_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnChallengeCompleted>b__0(ISeasonPassChallenge c); // 0x0000000180405C30-0x0000000180405CA0
		internal bool <OnChallengeCompleted>b__1(ISeasonPassChallenge c); // 0x0000000180405CA0-0x0000000180405D10
	}

	// Constructors
	public SeasonPass(string inDefId, int inCurrentTier, int inAuraPoints, bool inHasPremium); // 0x00000001803FCD90-0x00000001803FD2F0

	// Methods
	public void SetupChallenges(SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCurrentChallenges, SeasonSrvHandler.ListChallengesResponse.ChallengeItem[] inCompletedChallenges); // 0x00000001803FCA40-0x00000001803FCD90
	public void DeInit(); // 0x00000001803FC2C0-0x00000001803FC410
	private void AddListeners(); // 0x00000001803FC170-0x00000001803FC2C0
	private void RemoveListeners(); // 0x00000001803FC2C0-0x00000001803FC410
	private void OnChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage); // 0x00000001803FC7B0-0x00000001803FC940
	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x00000001803FC540-0x00000001803FC7B0
	private void OnTierPurchased(SeasonPassTierPurchasedMessage inMessage); // 0x00000001803FCA20-0x00000001803FCA40
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x00000001803FC940-0x00000001803FCA20
	private void OnAuraPointsReceived(int inAuraPoints); // 0x00000001803FC410-0x00000001803FC540
}

