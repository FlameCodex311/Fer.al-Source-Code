/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class PlacementInfoItemComponent : ItemComponent // TypeDefIndex: 12026
{
	// Fields
	public Inventory placedItems; // 0x20

	// Constructors
	public PlacementInfoItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x00000001804E2340-0x00000001804E23D0
	protected override JsonData ToJsonOverride(); // 0x00000001804E23D0-0x00000001804E2430
}

