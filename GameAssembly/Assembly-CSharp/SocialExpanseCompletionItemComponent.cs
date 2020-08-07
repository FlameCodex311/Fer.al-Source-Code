/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class SocialExpanseCompletionItemComponent : ItemComponent // TypeDefIndex: 12029
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool completedQuest; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Dictionary<string, int> acquiredLockpicks; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Dictionary<string, int> unlockedChests; // 0x30

	// Properties
	public SocialExpanseDefComponent SocialExpanseDef { get; } // 0x0000000180771B90-0x0000000180771BE0 
	public TimestampItemComponent TimestampDef { get; } // 0x0000000180771BE0-0x0000000180771C30 

	// Constructors
	public SocialExpanseCompletionItemComponent(); // 0x0000000180771B10-0x0000000180771B90

	// Methods
	public override void OnLoaded(); // 0x0000000180373240-0x0000000180373250
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x00000001807711A0-0x0000000180771700
	protected override JsonData ToJsonOverride(); // 0x0000000180771700-0x0000000180771B10
	public bool HasCompletedQuest(); // 0x00000001803FA090-0x00000001803FA0A0
	public bool HasAcquiredLockpick(string lockpickUUID); // 0x0000000180771080-0x0000000180771110
	public bool HasUnlockedChest(string chestUUID); // 0x0000000180771110-0x00000001807711A0
}

