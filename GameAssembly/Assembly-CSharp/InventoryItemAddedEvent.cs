/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryItemAddedEvent : Message // TypeDefIndex: 11197
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <Quantity>k__BackingField; // 0x20

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public int Quantity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700

	// Constructors
	public InventoryItemAddedEvent(Item item, int quantity = 1 /* Metadata: 0x00782809 */); // 0x0000000180F62670-0x0000000180F626B0

	// Methods
	public static InventoryItemAddedEvent Create(Item item, int quantity = 1 /* Metadata: 0x0078280D */); // 0x0000000180F62530-0x0000000180F62600
	public override void ReturnToPool(); // 0x0000000180F62600-0x0000000180F62670
}

