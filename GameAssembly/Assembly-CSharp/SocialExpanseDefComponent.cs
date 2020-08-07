/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x00000001802361B0-0x00000001802361E0
public class SocialExpanseDefComponent : DefComponent // TypeDefIndex: 11636
{
	// Fields
	[ChartDef] // 0x00000001802363B0-0x0000000180236440
	public string baseRoomDefId; // 0x18
	private LevelDefComponent _baseRoomDef; // 0x20
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool alwaysActive; // 0x28
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public SocialExpanseArea socialExpanseArea; // 0x2C
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<QuestDefObjective> primaryObjectives; // 0x30
	[ChartDef] // 0x0000000180236E00-0x0000000180236E80
	[ChartList] // 0x0000000180236E00-0x0000000180236E80
	public ChartDefList requiredAvatarDefIds; // 0x38

	// Properties
	public LevelDefComponent BaseRoomDef { get; } // 0x0000000180771DB0-0x0000000180771E30 

	// Constructors
	public SocialExpanseDefComponent(); // 0x0000000180771D30-0x0000000180771DB0
}

