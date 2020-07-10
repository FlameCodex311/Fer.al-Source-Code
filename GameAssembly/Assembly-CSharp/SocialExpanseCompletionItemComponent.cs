/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class SocialExpanseCompletionItemComponent : ItemComponent // TypeDefIndex: 10541
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool completedQuest; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Dictionary<string, int> acquiredLockpicks; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Dictionary<string, int> unlockedChests; // 0x30

	// Properties
	public SocialExpanseDefComponent SocialExpanseDef { get; } // 0x000000018135B340-0x000000018135B390 
	public TimestampItemComponent TimestampDef { get; } // 0x000000018135B390-0x000000018135B3E0 

	// Constructors
	public SocialExpanseCompletionItemComponent(); // 0x000000018135B2C0-0x000000018135B340

	// Methods
	public override void OnLoaded(); // 0x000000018036B6C0-0x000000018036B6D0
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018135A920-0x000000018135AEA0
	protected override JsonData ToJsonOverride(); // 0x000000018135AEA0-0x000000018135B2C0
	public bool HasCompletedQuest(); // 0x00000001803C19E0-0x00000001803C19F0
	public bool HasAcquiredLockpick(string lockpickUUID); // 0x000000018135A800-0x000000018135A890
	public bool HasUnlockedChest(string chestUUID); // 0x000000018135A890-0x000000018135A920
}

