/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x00000001801294B0-0x00000001801294E0
public class LevelDefComponent : DefComponent // TypeDefIndex: 13339
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool topLevel; // 0x18
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isSecretArea; // 0x19
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool disabled; // 0x1A
	[ChartDef] // 0x00000001801297B0-0x0000000180129830
	[ChartList] // 0x00000001801297B0-0x0000000180129830
	public ChartDefList levelOverrides; // 0x20
	[ChartDef] // 0x0000000180129A90-0x0000000180129B10
	[ChartList] // 0x0000000180129A90-0x0000000180129B10
	public ChartDefList networkedObjects; // 0x28
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<WorldMapInfo> worldMapInfos; // 0x30
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string _unityLevelName; // 0x38
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ELevelType levelType; // 0x40
	[ChartDef] // 0x0000000180129F50-0x0000000180129FC0
	public string _socialExpanseDefId; // 0x48
	[ChartDef] // 0x000000018012A320-0x000000018012A390
	public string tempImageBundleID; // 0x50
	[ChartDef] // 0x000000018012A6E0-0x000000018012A750
	public string localizedNameID; // 0x58
	[ChartDef] // 0x000000018012A9B0-0x000000018012AA20
	public string calendarDefID; // 0x60
	private AvailabilityDefComponent _calendarDef; // 0x68
	[ChartDef] // 0x000000018012C0A0-0x000000018012C110
	public string minimapBundleIdRef; // 0x70

	// Properties
	public string UnityLevelName { get; set; } // 0x00000001812CE210-0x00000001812CE390 0x00000001803A2820-0x00000001803A2830
	public List<string> AdditiveUnityLevelNames { get; } // 0x00000001812CDD40-0x00000001812CDF20 
	public List<string> AdditiveBundleIDs { get; } // 0x00000001812CDB30-0x00000001812CDD40 
	public AvailabilityDefComponent CalendarDef { get; } // 0x00000001812CDF20-0x00000001812CDFA0 
	public bool IsAvailable { get; } // 0x00000001812CE1C0-0x00000001812CE210 
	public List<LevelOverrideDefComponent> CurrentOverrideDefs { get; } // 0x00000001812CDFA0-0x00000001812CE1C0 

	// Nested types
	[Serializable]
	public class WorldMapInfo // TypeDefIndex: 13340
	{
		// Fields
		[ChartDef] // 0x000000018012C4F0-0x000000018012C560
		public string level; // 0x10
		[ChartString] // 0x00000001800B5960-0x00000001800B5970
		public string uniqueMapId; // 0x18
		[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
		public MinimapManager.EBlipType worldBlipType; // 0x20
		[ChartDef] // 0x000000018012CB30-0x000000018012CBA0
		public string localization; // 0x28
		[ChartVector2] // 0x00000001800B5960-0x00000001800B5970
		public Vector2 worldMapPosition; // 0x30

		// Constructors
		public WorldMapInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public LevelDefComponent(); // 0x00000001812CDA90-0x00000001812CDB30
}

