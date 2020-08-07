/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801D9FB0-0x00000001801D9FE0
public class NetworkedScene : ManagedBehaviour // TypeDefIndex: 12392
{
	// Fields
	[RootSelectorCompact] // 0x000000018028B0A0-0x000000018028B120
	[Space] // 0x000000018028B0A0-0x000000018028B120
	public string networkedObjectsChartID; // 0x50
	public List<QuestTrackableItem> questTrackableItems; // 0x58

	// Nested types
	[Serializable]
	public class QuestTrackableItem // TypeDefIndex: 12393
	{
		// Fields
		public NetworkedObjectInfo NetworkedVar; // 0x10
		public QuestTrackableItemDetails questTrackableItemDetails; // 0x18

		// Constructors
		public QuestTrackableItem(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class QuestTrackableItemDetails // TypeDefIndex: 12394
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string networkedVarUUID; // 0x10
		[RootSelectorCompact] // 0x000000018028C680-0x000000018028C6E0
		public string craftableItemChartID; // 0x18
		[RootSelectorCompact] // 0x000000018028C770-0x000000018028C7D0
		public string harvestPointChartID; // 0x20
		public float harvestPointRespawnOverride; // 0x28
		public int numRequired; // 0x2C

		// Constructors
		public QuestTrackableItemDetails(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public NetworkedScene(); // 0x00000001807D7140-0x00000001807D71C0

	// Methods
	public override void MStart(); // 0x00000001807D70E0-0x00000001807D7140
}

