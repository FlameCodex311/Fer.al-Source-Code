/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x000000018015E850-0x000000018015E880
public class SocialExpanseDefComponent : DefComponent // TypeDefIndex: 10145
{
	// Fields
	[ChartDef] // 0x000000018015E9E0-0x000000018015EA70
	public string baseRoomDefId; // 0x18
	private LevelDefComponent _baseRoomDef; // 0x20
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool alwaysActive; // 0x28
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public SocialExpanseArea socialExpanseArea; // 0x2C
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<QuestDefObjective> primaryObjectives; // 0x30
	[ChartDef] // 0x000000018015F110-0x000000018015F190
	[ChartList] // 0x000000018015F110-0x000000018015F190
	public ChartDefList requiredAvatarDefIds; // 0x38

	// Properties
	public LevelDefComponent BaseRoomDef { get; } // 0x000000018135B570-0x000000018135B5F0 

	// Constructors
	public SocialExpanseDefComponent(); // 0x000000018135B4F0-0x000000018135B570
}

