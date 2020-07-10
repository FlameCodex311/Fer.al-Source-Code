/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180136B40-0x0000000180136B70
public class ActorClothingDefComponent : DefComponent // TypeDefIndex: 10566
{
	// Fields
	[ChartDef] // 0x0000000180136CD0-0x0000000180136D60
	public string attachNodeGroupDefID; // 0x18
	private ActorAttachNodeGroupDefComponent _attachNodeGroupDef; // 0x20
	[ChartDef] // 0x0000000180137030-0x00000001801370E0
	[ChartList] // 0x0000000180137030-0x00000001801370E0
	public ChartDefList clearAttachNodeGroups; // 0x28
	[ChartDef] // 0x0000000180137340-0x00000001801373D0
	public string attachNodeDefID; // 0x30
	private ActorAttachNodeDefComponent _attachNodeDef; // 0x38
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ActorClothingSkinningType skinningType; // 0x40
	private BundleIDDefComponent _bundleIDDefComponent; // 0x48
	private ActorClothingGetModelDefComponent _getModelDefComponent; // 0x50

	// Properties
	public ActorAttachNodeGroupDefComponent AttachNodeGroupDef { get; } // 0x00000001814045B0-0x0000000181404630 
	public ActorAttachNodeDefComponent AttachNodeDefComponent { get; } // 0x0000000181404530-0x00000001814045B0 
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x0000000181404630-0x0000000181404680 
	public ActorClothingGetModelDefComponent GetModelDefComponent { get; } // 0x0000000181404720-0x0000000181404770 
	public string FXAttachmentBundleID { get; } // 0x0000000181404680-0x0000000181404720 

	// Constructors
	public ActorClothingDefComponent(); // 0x00000001814044D0-0x0000000181404530

	// Methods
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
}

