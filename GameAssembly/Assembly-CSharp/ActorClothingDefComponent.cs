/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180210140-0x0000000180210170
public class ActorClothingDefComponent : DefComponent // TypeDefIndex: 12054
{
	// Fields
	[ChartDef] // 0x00000001802103B0-0x0000000180210440
	public string attachNodeGroupDefID; // 0x18
	private ActorAttachNodeGroupDefComponent _attachNodeGroupDef; // 0x20
	[ChartDef] // 0x0000000180210890-0x0000000180210940
	[ChartList] // 0x0000000180210890-0x0000000180210940
	public ChartDefList clearAttachNodeGroups; // 0x28
	[ChartDef] // 0x0000000180210D50-0x0000000180210DE0
	public string attachNodeDefID; // 0x30
	private ActorAttachNodeDefComponent _attachNodeDef; // 0x38
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ActorClothingSkinningType skinningType; // 0x40
	private BundleIDDefComponent _bundleIDDefComponent; // 0x48
	private ActorClothingGetModelDefComponent _getModelDefComponent; // 0x50

	// Properties
	public ActorAttachNodeGroupDefComponent AttachNodeGroupDef { get; } // 0x00000001821D6380-0x00000001821D6400 
	public ActorAttachNodeDefComponent AttachNodeDefComponent { get; } // 0x00000001821D6300-0x00000001821D6380 
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x00000001821D6400-0x00000001821D6450 
	public ActorClothingGetModelDefComponent GetModelDefComponent { get; } // 0x00000001821D64E0-0x00000001821D6530 
	public string FXAttachmentBundleID { get; } // 0x00000001821D6450-0x00000001821D64E0 

	// Constructors
	public ActorClothingDefComponent(); // 0x00000001821D62A0-0x00000001821D6300

	// Methods
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
}

