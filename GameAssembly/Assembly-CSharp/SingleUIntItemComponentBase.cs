/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public abstract class SingleUIntItemComponentBase : ItemComponent // TypeDefIndex: 11990
{
	// Fields
	public uint value; // 0x20

	// Properties
	public abstract string JsonKey { get; }

	// Constructors
	protected SingleUIntItemComponentBase(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018076F1E0-0x000000018076F240
	protected override JsonData ToJsonOverride(); // 0x000000018076F240-0x000000018076F2E0
}

