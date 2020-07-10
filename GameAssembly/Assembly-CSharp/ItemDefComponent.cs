/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x00000001800BA450-0x00000001800BA480
public class ItemDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 10248
{
	// Fields
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ItemType itemType; // 0x18

	// Constructors
	public ItemDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
	public static implicit operator bool(ItemDefComponent i); // 0x00000001807FBF50-0x00000001807FBF60
	public void OnClientOnlyItemCreated(Item item); // 0x00000001812BEAE0-0x00000001812BEB70
}

