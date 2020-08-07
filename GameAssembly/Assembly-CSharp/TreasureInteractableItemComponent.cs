/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TreasureInteractableItemComponent : ItemComponent // TypeDefIndex: 12032
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Dictionary<string, InteractionsData> interactions; // 0x20

	// Nested types
	[Serializable]
	public class InteractionsData // TypeDefIndex: 12033
	{
		// Fields
		public bool isLooted; // 0x10
		public long lastLootTime; // 0x18

		// Constructors
		public InteractionsData(bool isLooted, long lastLootTime); // 0x0000000180509910-0x0000000180509950
	}

	// Constructors
	public TreasureInteractableItemComponent(); // 0x000000018050E380-0x000000018050E3E0

	// Methods
	public override void OnLoaded(); // 0x0000000180373240-0x0000000180373250
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018050DD40-0x000000018050E0B0
	protected override JsonData ToJsonOverride(); // 0x000000018050E0B0-0x000000018050E380
	public bool HasLootedTreasure(string treasureUUID); // 0x000000018050DCB0-0x000000018050DD40
}

