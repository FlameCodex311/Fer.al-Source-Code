/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180131230-0x0000000180131260
public class ActorBodyPartDefComponent : DefComponent // TypeDefIndex: 10559
{
	// Fields
	[ChartDef] // 0x00000001801313A0-0x0000000180131440
	public ChartDef actorClassDef; // 0x18
	[ChartDef] // 0x0000000180131720-0x00000001801317B0
	public string bodyPartNodeDefID; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ActorBodyPartNodeDefComponent <BodyPartNode>k__BackingField; // 0x28
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool blank; // 0x30
	[ChartInt] // 0x0000000180131DD0-0x0000000180131E10
	public int availableColorChannels; // 0x34
	[ChartButton] // 0x0000000180131F60-0x0000000180131FB0
	private bool buttonGetEyeDecalsFromNPCEditor; // 0x38
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ActorInfoDecalEntry> eyeDecals; // 0x40
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ActorBodyPartAdditiveAnimationEntry> additiveAnimations; // 0x48
	private BundleIDDefComponent _bundleIDDefComponent; // 0x50
	private ActorBodyPartGetModelDefComponent _getModelDefComponent; // 0x58

	// Properties
	public ActorBodyPartNodeDefComponent BodyPartNode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x0000000181401C40-0x0000000181401C90 
	public ActorBodyPartGetModelDefComponent GetModelDefComponent { get; } // 0x0000000181401E70-0x0000000181401EC0 
	public string DataBundleID { get; } // 0x0000000181401D30-0x0000000181401DD0 
	public string FXAttachmentBundleID { get; } // 0x0000000181401DD0-0x0000000181401E70 
	public string BaseTextureBundleID { get; } // 0x0000000181401BA0-0x0000000181401C40 
	public string ColorIDTextureBundleID { get; } // 0x0000000181401C90-0x0000000181401D30 

	// Constructors
	public ActorBodyPartDefComponent(); // 0x0000000181401B40-0x0000000181401BA0

	// Methods
	public void ButtonGetEyeDecalsFromNPCEditor(PropertyEditor.DefEntry inDefEntry); // 0x0000000181401A00-0x0000000181401AD0
	protected override void LoadEntry(); // 0x0000000181401AD0-0x0000000181401B40
}

