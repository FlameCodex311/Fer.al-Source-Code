/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TwiggleItemComponent : ItemComponent // TypeDefIndex: 10520
{
	// Fields
	public long endWorkTime; // 0x20
	public int workType; // 0x28
	public JsonData workParams; // 0x30

	// Constructors
	public TwiggleItemComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180FAF010-0x0000000180FAF0A0
	protected override JsonData ToJsonOverride(); // 0x0000000180FAF0A0-0x0000000180FAF140
}

