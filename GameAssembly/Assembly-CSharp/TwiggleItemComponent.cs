/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TwiggleItemComponent : ItemComponent // TypeDefIndex: 12008
{
	// Fields
	public long endWorkTime; // 0x20
	public int workType; // 0x28
	public JsonData workParams; // 0x30

	// Constructors
	public TwiggleItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180514390-0x0000000180514420
	protected override JsonData ToJsonOverride(); // 0x0000000180514420-0x00000001805144B0
}

