/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class PlacementInfoItemComponent : ItemComponent // TypeDefIndex: 10538
{
	// Fields
	public Inventory placedItems; // 0x20

	// Constructors
	public PlacementInfoItemComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x00000001811590E0-0x0000000181159170
	protected override JsonData ToJsonOverride(); // 0x0000000181159170-0x00000001811591D0
}

