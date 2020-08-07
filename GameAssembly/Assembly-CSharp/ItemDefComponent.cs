/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x00000001801CFA30-0x00000001801CFA60
public class ItemDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 11739
{
	// Fields
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ItemType itemType; // 0x18

	// Constructors
	public ItemDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
	public static implicit operator bool(ItemDefComponent i); // 0x000000018066B080-0x000000018066B090
	public void OnClientOnlyItemCreated(Item item); // 0x0000000180878580-0x0000000180878600
}

