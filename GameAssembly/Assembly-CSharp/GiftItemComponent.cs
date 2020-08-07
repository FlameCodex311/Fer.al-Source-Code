/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class GiftItemComponent : ItemComponent // TypeDefIndex: 12006
{
	// Fields
	public ItemType giftItemType; // 0x20
	public string giftItemDefId; // 0x28
	public GiftFromType fromType; // 0x30
	public int fromId; // 0x34
	public int count; // 0x38
	public Dictionary<string, string> redeemedItemIds; // 0x40

	// Properties
	public bool IsRedeemed { get; } // 0x0000000180681250-0x0000000180681260 

	// Constructors
	public GiftItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180680F30-0x0000000180681200
	protected override JsonData ToJsonOverride(); // 0x0000000180681200-0x0000000180681250
}

