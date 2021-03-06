﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public interface ISeasonPass // TypeDefIndex: 13404
{
	// Properties
	bool HasPremium { get; }
	int AuraPoints { get; }
	string DefId { get; }
	BaseDef PurchaseDef { get; }
	List<ISeasonPassTier> Tiers { get; }
	ISeasonPassTier CurrentTier { get; }
	List<ISeasonPassChallenge> Challenges { get; }
	List<ISeasonPassChallenge> AvailableChallenges { get; }
	string LocalizedName { get; }
	DateTime EndDate { get; }
	float NormalizedProgress { get; }

	// Methods
	void DeInit();
}

