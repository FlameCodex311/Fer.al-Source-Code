/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ItemRef : SoftRef<Item>, IEqualityComparer // TypeDefIndex: 10523
{
	// Fields
	public readonly string ItemId; // 0x18
	public readonly ItemType ItemType; // 0x20

	// Constructors
	public ItemRef(string itemId, ItemType itemType); // 0x00000001812BEEC0-0x00000001812BEF20

	// Methods
	public new bool Equals(object x, object y); // 0x00000001812BEDC0-0x00000001812BEE10
	public int GetHashCode(object obj); // 0x00000001812BEE10-0x00000001812BEE60
	protected override void UpdateRef(); // 0x00000001812BEE60-0x00000001812BEEC0
	public static implicit operator Item(ItemRef i); // 0x00000001812BEFC0-0x00000001812BF010
	public static implicit operator ItemRef(Item r); // 0x00000001812BEF20-0x00000001812BEFC0
}

