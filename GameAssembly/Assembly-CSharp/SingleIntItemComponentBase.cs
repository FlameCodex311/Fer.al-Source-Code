/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public abstract class SingleIntItemComponentBase : ItemComponent // TypeDefIndex: 11989
{
	// Fields
	public ObscuredInt value; // 0x20

	// Properties
	public abstract string JsonKey { get; }

	// Constructors
	protected SingleIntItemComponentBase(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018076F010-0x000000018076F090
	protected override JsonData ToJsonOverride(); // 0x000000018076F090-0x000000018076F150
}

