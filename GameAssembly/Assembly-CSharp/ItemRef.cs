/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ItemRef : SoftRef<Item>, IEqualityComparer // TypeDefIndex: 12011
{
	// Fields
	public readonly string ItemId; // 0x18
	public readonly ItemType ItemType; // 0x20

	// Constructors
	public ItemRef(string itemId, ItemType itemType); // 0x0000000180878950-0x00000001808789B0

	// Methods
	public new bool Equals(object x, object y); // 0x0000000180878850-0x00000001808788A0
	public int GetHashCode(object obj); // 0x00000001808788A0-0x00000001808788F0
	protected override void UpdateRef(); // 0x00000001808788F0-0x0000000180878950
	public static implicit operator Item(ItemRef i); // 0x0000000180878A50-0x0000000180878AA0
	public static implicit operator ItemRef(Item r); // 0x00000001808789B0-0x0000000180878A50
}

