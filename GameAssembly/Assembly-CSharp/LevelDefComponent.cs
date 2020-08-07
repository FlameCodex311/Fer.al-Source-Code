/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x0000000180205920-0x0000000180205950
public class LevelDefComponent : DefComponent // TypeDefIndex: 11010
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool topLevel; // 0x18
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isSecretArea; // 0x19
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool disabled; // 0x1A
	[ChartDef] // 0x0000000180205EC0-0x0000000180205F40
	[ChartList] // 0x0000000180205EC0-0x0000000180205F40
	public ChartDefList levelOverrides; // 0x20
	[ChartDef] // 0x0000000180206370-0x00000001802063F0
	[ChartList] // 0x0000000180206370-0x00000001802063F0
	public ChartDefList networkedObjects; // 0x28
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<WorldMapInfo> worldMapInfos; // 0x30
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string _unityLevelName; // 0x38
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ELevelType levelType; // 0x40
	[ChartDef] // 0x0000000180206D00-0x0000000180206D70
	public string _socialExpanseDefId; // 0x48
	[ChartDef] // 0x0000000180207210-0x0000000180207280
	public string _socialExpanseAreaIdentifierLevelDefId; // 0x50
	[ChartDef] // 0x00000001802075F0-0x0000000180207660
	public string tempImageBundleID; // 0x58
	[ChartDef] // 0x0000000180207A20-0x0000000180207A90
	public string localizedNameID; // 0x60
	[ChartDef] // 0x0000000180207D60-0x0000000180207DD0
	public string calendarDefID; // 0x68
	private AvailabilityDefComponent _calendarDef; // 0x70
	[ChartDef] // 0x0000000180208010-0x0000000180208080
	public string minimapBundleIdRef; // 0x78

	// Properties
	public string UnityLevelName { get; set; } // 0x000000018087D400-0x000000018087D570 0x00000001803FEB60-0x00000001803FEB70
	public List<string> AdditiveUnityLevelNames { get; } // 0x000000018087D050-0x000000018087D220 
	public List<string> AdditiveBundleIDs { get; } // 0x000000018087CE50-0x000000018087D050 
	public AvailabilityDefComponent CalendarDef { get; } // 0x000000018087D220-0x000000018087D2A0 
	public bool IsAvailable { get; } // 0x000000018087D3B0-0x000000018087D400 
	public List<LevelOverrideDefComponent> CurrentOverrideDefs { get; } // 0x000000018087D2A0-0x000000018087D3B0 

	// Nested types
	[Serializable]
	public class WorldMapInfo // TypeDefIndex: 11011
	{
		// Fields
		[ChartDef] // 0x0000000180208390-0x0000000180208400
		public string level; // 0x10
		[ChartString] // 0x00000001801DE450-0x00000001801DE460
		public string uniqueMapId; // 0x18
		[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
		public MinimapManager.EBlipType worldBlipType; // 0x20
		[ChartDef] // 0x0000000180208A50-0x0000000180208AC0
		public string localization; // 0x28
		[ChartVector2] // 0x00000001801DE450-0x00000001801DE460
		public Vector2 worldMapPosition; // 0x30
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 scenePosition; // 0x38
		[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
		public Vector3 sceneRotation; // 0x44

		// Constructors
		public WorldMapInfo(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public LevelDefComponent(); // 0x000000018087CDB0-0x000000018087CE50
}

