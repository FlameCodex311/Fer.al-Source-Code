/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TreasureInteractableItemComponent : ItemComponent // TypeDefIndex: 10544
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Dictionary<string, InteractionsData> interactions; // 0x20

	// Nested types
	[Serializable]
	public class InteractionsData // TypeDefIndex: 10545
	{
		// Fields
		public bool isLooted; // 0x10
		public long lastLootTime; // 0x18

		// Constructors
		public InteractionsData(bool isLooted, long lastLootTime); // 0x0000000180A125B0-0x0000000180A125F0
	}

	// Constructors
	public TreasureInteractableItemComponent(); // 0x0000000180FA8E90-0x0000000180FA8EF0

	// Methods
	public override void OnLoaded(); // 0x000000018036B6C0-0x000000018036B6D0
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180FA8830-0x0000000180FA8BB0
	protected override JsonData ToJsonOverride(); // 0x0000000180FA8BB0-0x0000000180FA8E90
	public bool HasLootedTreasure(string treasureUUID); // 0x0000000180FA8790-0x0000000180FA8830
}

