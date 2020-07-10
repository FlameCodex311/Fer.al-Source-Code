/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800E9750-0x00000001800E9780
public class NetworkedScene : ManagedBehaviour // TypeDefIndex: 10869
{
	// Fields
	[RootSelectorCompact] // 0x00000001800E9980-0x00000001800E9A00
	[Space] // 0x00000001800E9980-0x00000001800E9A00
	public string networkedObjectsChartID; // 0x50
	public List<QuestTrackableItem> questTrackableItems; // 0x58

	// Nested types
	[Serializable]
	public class QuestTrackableItem // TypeDefIndex: 10870
	{
		// Fields
		public NetworkedObjectInfo NetworkedVar; // 0x10
		public QuestTrackableItemDetails questTrackableItemDetails; // 0x18

		// Constructors
		public QuestTrackableItem(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class QuestTrackableItemDetails // TypeDefIndex: 10871
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string networkedVarUUID; // 0x10
		[RootSelectorCompact] // 0x00000001800E9CA0-0x00000001800E9D00
		public string craftableItemChartID; // 0x18
		[RootSelectorCompact] // 0x00000001800E9EF0-0x00000001800E9F50
		public string harvestPointChartID; // 0x20
		public float harvestPointRespawnOverride; // 0x28
		public int numRequired; // 0x2C

		// Constructors
		public QuestTrackableItemDetails(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public NetworkedScene(); // 0x000000018156FA40-0x000000018156FAC0

	// Methods
	public override void MStart(); // 0x000000018156F9E0-0x000000018156FA40
}

