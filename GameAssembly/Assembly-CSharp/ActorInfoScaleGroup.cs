/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorInfoScaleGroup // TypeDefIndex: 10881
{
	// Fields
	[ChartDef] // 0x00000001800ECD60-0x00000001800ECDF0
	public string scaleGroupDefID; // 0x10
	[NonSerialized]
	private ActorScaleGroupDefComponent _scaleGroupDef; // 0x18
	[NonSerialized]
	public bool enabled; // 0x20
	public float scale; // 0x24

	// Properties
	public ActorScaleGroupDefComponent ScaleGroupDef { get; } // 0x0000000181407450-0x00000001814074F0 

	// Constructors
	public ActorInfoScaleGroup(); // 0x0000000181407430-0x0000000181407450

	// Methods
	public void ResetCaches(); // 0x0000000180C1E5A0-0x0000000180C1E5B0
}

