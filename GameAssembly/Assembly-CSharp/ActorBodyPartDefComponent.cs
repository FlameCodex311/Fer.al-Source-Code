/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180208560-0x0000000180208590
public class ActorBodyPartDefComponent : DefComponent // TypeDefIndex: 12047
{
	// Fields
	[ChartDef] // 0x00000001802086D0-0x0000000180208770
	public ChartDef actorClassDef; // 0x18
	[ChartDef] // 0x0000000180208D10-0x0000000180208DA0
	public string bodyPartNodeDefID; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ActorBodyPartNodeDefComponent <BodyPartNode>k__BackingField; // 0x28
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool blank; // 0x30
	[ChartInt] // 0x0000000180209230-0x0000000180209270
	public int availableColorChannels; // 0x34
	[ChartButton] // 0x00000001802094C0-0x0000000180209510
	private bool buttonGetEyeDecalsFromNPCEditor; // 0x38
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ActorInfoDecalEntry> eyeDecals; // 0x40
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ActorBodyPartAdditiveAnimationEntry> additiveAnimations; // 0x48
	private BundleIDDefComponent _bundleIDDefComponent; // 0x50
	private ActorBodyPartGetModelDefComponent _getModelDefComponent; // 0x58

	// Properties
	public ActorBodyPartNodeDefComponent BodyPartNode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x00000001821D3AC0-0x00000001821D3B10 
	public ActorBodyPartGetModelDefComponent GetModelDefComponent { get; } // 0x00000001821D3CC0-0x00000001821D3D10 
	public string DataBundleID { get; } // 0x00000001821D3BA0-0x00000001821D3C30 
	public string FXAttachmentBundleID { get; } // 0x00000001821D3C30-0x00000001821D3CC0 
	public string BaseTextureBundleID { get; } // 0x00000001821D3A30-0x00000001821D3AC0 
	public string ColorIDTextureBundleID { get; } // 0x00000001821D3B10-0x00000001821D3BA0 

	// Constructors
	public ActorBodyPartDefComponent(); // 0x00000001821D39D0-0x00000001821D3A30

	// Methods
	public void ButtonGetEyeDecalsFromNPCEditor(PropertyEditor.DefEntry inDefEntry); // 0x00000001821D38A0-0x00000001821D3960
	protected override void LoadEntry(); // 0x00000001821D3960-0x00000001821D39D0
}

