/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180209D30-0x0000000180209D60
public class ActorClassDefComponent : DefComponent // TypeDefIndex: 12049
{
	// Fields
	[ChartFloat] // 0x00000001801DE450-0x00000001801DE460
	public float scale; // 0x18
	[ChartDef] // 0x0000000180209FB0-0x000000018020A060
	[ChartList] // 0x0000000180209FB0-0x000000018020A060
	public List<string> bodyPartDefIDs; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<BaseDef> <BodyParts>k__BackingField; // 0x28
	[ChartDef] // 0x000000018020A570-0x000000018020A610
	[ChartList] // 0x000000018020A570-0x000000018020A610
	public List<string> bodyPartNodeDefIDs; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<BaseDef> <BodyPartNodes>k__BackingField; // 0x38
	[ChartDef] // 0x000000018020AA50-0x000000018020AAF0
	[ChartList] // 0x000000018020AA50-0x000000018020AAF0
	public List<string> scaleGroupDefIDs; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<BaseDef> <ScaleGroups>k__BackingField; // 0x48
	[ChartDef] // 0x000000018020B110-0x000000018020B1C0
	[ChartList] // 0x000000018020B110-0x000000018020B1C0
	public List<string> npcClothingItemDefIDs; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<BaseDef> <NPCClothingItems>k__BackingField; // 0x58
	[ChartDef] // 0x000000018020B4E0-0x000000018020B590
	[ChartList] // 0x000000018020B4E0-0x000000018020B590
	public ChartDefList eyeShapeDefs; // 0x60
	[ChartDef] // 0x000000018020B950-0x000000018020BA00
	[ChartList] // 0x000000018020B950-0x000000018020BA00
	public ChartDefList eyePupilDefs; // 0x68
	[ChartDef] // 0x000000018020BD30-0x000000018020BDB0
	public string avatarLookDefId; // 0x70
	private string _skeletonBundleID; // 0x78
	private string _wingSkeletonBundleID; // 0x80
	private string _dataBundleID; // 0x88
	private string _bodyPartsBundleID; // 0x90
	private BundleIDDefComponent _bundleIDDefComponent; // 0x98
	private ActorInfo _defaultActorInfo; // 0xA0

	// Properties
	public List<BaseDef> BodyParts { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public List<BaseDef> BodyPartNodes { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public List<BaseDef> ScaleGroups { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	public List<BaseDef> NPCClothingItems { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	public string SkeletonBundleID { get; } // 0x00000001821D5FF0-0x00000001821D60E0 
	public string WingSkeletonBundleID { get; } // 0x00000001821D60E0-0x00000001821D61D0 
	public string DataBundleID { get; } // 0x00000001821D5D20-0x00000001821D5E10 
	public string BodyPartsBundleID { get; } // 0x00000001821D5BD0-0x00000001821D5CC0 
	public BundleIDDefComponent BundleIDDefComponent { get; } // 0x00000001821D5CC0-0x00000001821D5D20 
	public ActorInfo DefaultActorInfo { get; } // 0x00000001821D5E10-0x00000001821D5FF0 

	// Constructors
	public ActorClassDefComponent(); // 0x00000001821D5AC0-0x00000001821D5BD0

	// Methods
	public List<ActorBodyPartDefComponent> GetBodyPartsForNode(string inNodeDefId); // 0x00000001821D57C0-0x00000001821D59A0
	public List<ActorBodyPartDefComponent> GetAllOwnedBodyPartsForActorByNode(string actorClassDefID, string inNodeDefId); // 0x00000001821D5500-0x00000001821D57C0
	protected override void LoadEntry(); // 0x00000001821D59A0-0x00000001821D5AC0
}

