/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryItemAddedEvent : Message // TypeDefIndex: 12723
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Item <Item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <Quantity>k__BackingField; // 0x20

	// Properties
	public Item Item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public int Quantity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0

	// Constructors
	public InventoryItemAddedEvent(Item item, int quantity = 1 /* Metadata: 0x007B9F8F */); // 0x000000018050C7F0-0x000000018050C830

	// Methods
	public static InventoryItemAddedEvent Create(Item item, int quantity = 1 /* Metadata: 0x007B9F93 */); // 0x000000018062B910-0x000000018062B9E0
	public override void ReturnToPool(); // 0x000000018062B9E0-0x000000018062BA50
}

