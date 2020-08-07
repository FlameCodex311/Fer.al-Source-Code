/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x0000000180240DF0-0x0000000180240E20
public class QuestDefComponent : DefComponent // TypeDefIndex: 11706
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool disabled; // 0x18
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public QuestDifficultyLevel difficultyLevel; // 0x1C
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isPlatformer; // 0x20
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool playAsPet; // 0x21
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool noLobby; // 0x22
	[ChartDef] // 0x0000000180241960-0x00000001802419F0
	public string locTitleDefID; // 0x28
	private LocalizationDef _locTitleDef; // 0x30
	[ChartDef] // 0x0000000180241CA0-0x0000000180241D30
	public string locDescriptionDefID; // 0x38
	private LocalizationDef _locDescriptionDef; // 0x40
	[ChartDef] // 0x0000000180241FB0-0x0000000180242040
	public string locLocationDefID; // 0x48
	private LocalizationDef _locLocationDef; // 0x50
	[ChartDef] // 0x0000000180242330-0x00000001802423C0
	public string locGiverNameDefID; // 0x58
	private LocalizationDef _locGiverNameDef; // 0x60
	[ChartDef] // 0x00000001802428B0-0x0000000180242930
	[ChartList] // 0x00000001802428B0-0x0000000180242930
	public ChartDefList baseRooms; // 0x68
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<QuestDefObjective> primaryObjectives; // 0x70
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ObjectiveList> secondaryObjectiveLists; // 0x78
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int minPlayers; // 0x80
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int maxPlayers; // 0x84
	[ChartDef] // 0x0000000180244410-0x00000001802444A0
	public string iconImageDefId; // 0x88
	private ImageDefComponent _iconImageDef; // 0x90
	[ChartDef] // 0x0000000180244750-0x00000001802447E0
	public string gameImageDefId; // 0x98
	private ImageDefComponent _gameImageDef; // 0xA0
	[ChartDef] // 0x00000001802449A0-0x0000000180244A30
	public string bannerImageDefId; // 0xA8
	private ImageDefComponent _bannerImageDef; // 0xB0
	[ChartDef] // 0x0000000180244CB0-0x0000000180244D40
	public string allCompleteLootDefId; // 0xB8
	private LootDefComponent _allCompleteLootDef; // 0xC0
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ChallengeAffiliation challengeAffiliation; // 0xC8
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string summaryJson; // 0xD0

	// Properties
	public LocalizationDef LocTitle { get; } // 0x0000000180649510-0x00000001806495C0 
	public LocalizationDef LocDescription { get; } // 0x0000000180649300-0x00000001806493B0 
	public LocalizationDef LocLocation { get; } // 0x0000000180649460-0x0000000180649510 
	public LocalizationDef LocGiverName { get; } // 0x00000001806493B0-0x0000000180649460 
	public ImageDefComponent IconImage { get; } // 0x0000000180649270-0x0000000180649300 
	public ImageDefComponent GameImage { get; } // 0x00000001806491E0-0x0000000180649270 
	public ImageDefComponent BannerImage { get; } // 0x0000000180649150-0x00000001806491E0 
	public LootDefComponent AllCompleteLoot { get; } // 0x00000001806490C0-0x0000000180649150 

	// Nested types
	[Serializable]
	public class ObjectiveList // TypeDefIndex: 11707
	{
		// Fields
		[ChartList] // 0x00000001801DE450-0x00000001801DE460
		public List<QuestDefObjective> objectives; // 0x10

		// Constructors
		public ObjectiveList(); // 0x0000000180647A50-0x0000000180647AB0
	}

	// Constructors
	public QuestDefComponent(); // 0x0000000180649020-0x00000001806490C0
}

