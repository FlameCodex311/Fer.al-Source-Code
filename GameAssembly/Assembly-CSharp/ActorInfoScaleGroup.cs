/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorInfoScaleGroup // TypeDefIndex: 12404
{
	// Fields
	[ChartDef] // 0x000000018028E5A0-0x000000018028E630
	public string scaleGroupDefID; // 0x10
	[NonSerialized]
	private ActorScaleGroupDefComponent _scaleGroupDef; // 0x18
	[NonSerialized]
	public bool enabled; // 0x20
	public float scale; // 0x24

	// Properties
	public ActorScaleGroupDefComponent ScaleGroupDef { get; } // 0x00000001821D9160-0x00000001821D9200 

	// Constructors
	public ActorInfoScaleGroup(); // 0x00000001821D9140-0x00000001821D9160

	// Methods
	public void ResetCaches(); // 0x0000000180DAA140-0x0000000180DAA150
}

