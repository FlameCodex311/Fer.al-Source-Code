/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180132810-0x0000000180132840
public class ActorClassDefComponent : DefComponent // TypeDefIndex: 10561
{
	// Fields
	[ChartFloat] // 0x00000001800B5960-0x00000001800B5970
	public float scale; // 0x18
	[ChartDef] // 0x0000000180132C20-0x0000000180132CD0
	[ChartList] // 0x0000000180132C20-0x0000000180132CD0
	public List<string> bodyPartDefIDs; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<BaseDef> <BodyParts>k__BackingField; // 0x28
	[ChartDef] // 0x0000000180133330-0x00000001801333D0
	[ChartList] // 0x0000000180133330-0x00000001801333D0
	public List<string> bodyPartNodeDefIDs; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<BaseDef> <BodyPartNodes>k__BackingField; // 0x38
	[ChartDef] // 0x0000000180133980-0x0000000180133A20
	[ChartList] // 0x0000000180133980-0x0000000180133A20
	public List<string> scaleGroupDefIDs; // 0x40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<BaseDef> <ScaleGroups>k__BackingField; // 0x48
	[ChartDef] // 0x0000000180133EB0-0x0000000180133F60
	[ChartList] // 0x0000000180133EB0-0x0000000180133F60
	public List<string> npcClothingItemDefIDs; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<BaseDef> <NPCClothingItems>k__BackingField; // 0x58
	[ChartDef] // 0x00000001801354D0-0x0000000180135580
	[ChartList] // 0x00000001801354D0-0x0000000180135580
	public ChartDefList eyeShapeDefs; // 0x60
	[ChartDef] // 0x00000001801357F0-0x00000001801358A0
	[ChartList] // 0x00000001801357F0-0x00000001801358A0
	public ChartDefList eyePupilDefs; // 0x68
	[ChartDef] // 0x0000000180135B20-0x0000000180135BA0
	public string avatarLookDefId; // 0x70
	private string _skeletonBundleID; // 0x78
	private string _wingSkeletonBundleID; // 0x80
	private string _dataBundleID; // 0x88
	private string _bodyPartsBundleID; // 0x90
	private BundleIDDefComponent _bundleIDDefComponent; // 0x98
	private ActorInfo _defaultActorInfo; // 0xA0

	// Properties
	public List<BaseDef> BodyParts { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public List<BaseDef> BodyPartNodes { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public List<BaseDef> ScaleGroups { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
	public List<BaseDef> NPCClothingItems { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
	public string SkeletonBundleID { get; } // 0x0000000181404220-0x0000000181404310 
	public string WingSkeletonBundleID { get; } // 0x0000000181404310-0x0000000181404400 
	public string DataBundleID { get; } // 0x0000000181403F50-0x0000000181404040 
	public string BodyPartsBundleID { get; } // 0x0000000181403E00-0x0000000181403EF0 
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x0000000181403EF0-0x0000000181403F50 
	public ActorInfo DefaultActorInfo { get; } // 0x0000000181404040-0x0000000181404220 

	// Constructors
	public ActorClassDefComponent(); // 0x0000000181403CF0-0x0000000181403E00

	// Methods
	public List<ActorBodyPartDefComponent> GetBodyPartsForNode(string inNodeDefId); // 0x00000001814039F0-0x0000000181403BD0
	public List<ActorBodyPartDefComponent> GetAllOwnedBodyPartsForActorByNode(string actorClassDefID, string inNodeDefId); // 0x0000000181403720-0x00000001814039F0
	protected override void LoadEntry(); // 0x0000000181403BD0-0x0000000181403CF0
}

