/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x000000018016BA70-0x000000018016BAA0
public class QuestDefComponent : DefComponent // TypeDefIndex: 10215
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool disabled; // 0x18
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public QuestDifficultyLevel difficultyLevel; // 0x1C
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isPlatformer; // 0x20
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool playAsPet; // 0x21
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool noLobby; // 0x22
	[ChartDef] // 0x000000018016C5E0-0x000000018016C670
	public string locTitleDefID; // 0x28
	private LocalizationDef _locTitleDef; // 0x30
	[ChartDef] // 0x000000018016C820-0x000000018016C8B0
	public string locDescriptionDefID; // 0x38
	private LocalizationDef _locDescriptionDef; // 0x40
	[ChartDef] // 0x000000018016DC60-0x000000018016DCF0
	public string locLocationDefID; // 0x48
	private LocalizationDef _locLocationDef; // 0x50
	[ChartDef] // 0x000000018016E0B0-0x000000018016E140
	public string locGiverNameDefID; // 0x58
	private LocalizationDef _locGiverNameDef; // 0x60
	[ChartDef] // 0x000000018016E400-0x000000018016E480
	[ChartList] // 0x000000018016E400-0x000000018016E480
	public ChartDefList baseRooms; // 0x68
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<QuestDefObjective> primaryObjectives; // 0x70
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ObjectiveList> secondaryObjectiveLists; // 0x78
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int minPlayers; // 0x80
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int maxPlayers; // 0x84
	[ChartDef] // 0x000000018016ED50-0x000000018016EDE0
	public string iconImageDefId; // 0x88
	private ImageDefComponent _iconImageDef; // 0x90
	[ChartDef] // 0x000000018016F300-0x000000018016F390
	public string gameImageDefId; // 0x98
	private ImageDefComponent _gameImageDef; // 0xA0
	[ChartDef] // 0x000000018016F810-0x000000018016F8A0
	public string bannerImageDefId; // 0xA8
	private ImageDefComponent _bannerImageDef; // 0xB0
	[ChartDef] // 0x000000018016FC60-0x000000018016FCF0
	public string allCompleteLootDefId; // 0xB8
	private LootDefComponent _allCompleteLootDef; // 0xC0
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ChallengeAffiliation challengeAffiliation; // 0xC8
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string summaryJson; // 0xD0

	// Properties
	public LocalizationDef LocTitle { get; } // 0x0000000181005890-0x0000000181005940 
	public LocalizationDef LocDescription { get; } // 0x0000000181005680-0x0000000181005730 
	public LocalizationDef LocLocation { get; } // 0x00000001810057E0-0x0000000181005890 
	public LocalizationDef LocGiverName { get; } // 0x0000000181005730-0x00000001810057E0 
	public ImageDefComponent IconImage { get; } // 0x00000001810055F0-0x0000000181005680 
	public ImageDefComponent GameImage { get; } // 0x0000000181005560-0x00000001810055F0 
	public ImageDefComponent BannerImage { get; } // 0x00000001810054D0-0x0000000181005560 
	public LootDefComponent AllCompleteLoot { get; } // 0x0000000181005440-0x00000001810054D0 

	// Nested types
	[Serializable]
	public class ObjectiveList // TypeDefIndex: 10216
	{
		// Fields
		[ChartList] // 0x00000001800B5960-0x00000001800B5970
		public List<QuestDefObjective> objectives; // 0x10

		// Constructors
		public ObjectiveList(); // 0x0000000181004DD0-0x0000000181004E30
	}

	// Constructors
	public QuestDefComponent(); // 0x00000001810053A0-0x0000000181005440
}

