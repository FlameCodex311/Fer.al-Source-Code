/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public interface ISeasonPassTier // TypeDefIndex: 11870
{
	// Properties
	int TierNumber { get; }
	bool IsFree { get; }
	int Progress { get; }
	float NormalizedProgress { get; }
	bool IsCompleted { get; }
	bool IsCurrent { get; }
	int TotalRequiredAuraPoints { get; }
	int LocalRequiredAuraPoints { get; }
	int UnlockCost { get; }
	BundlePackDefComponent.CraftableItemsEntry Reward { get; }
}

