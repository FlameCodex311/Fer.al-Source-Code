/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MyUserInfo : UserInfo // TypeDefIndex: 14242
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly Inventory <Inventory>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private AvatarLookItemComponent <ActiveAvatarLookItem>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryLookItemComponent <ActiveSanctuaryLookItem>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <EmailAddress>k__BackingField; // 0x48
	private ItemComponentRef<QuantityItemComponent> _likeQuantity; // 0x50
	private ItemComponentRef<QuantityItemComponent> _starFragmentQuantity; // 0x58
	private ItemComponentRef<QuantityItemComponent> _lockpickQuantity; // 0x60
	private uint _pendingFlags; // 0x68

	// Properties
	public Inventory Inventory { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803745C0-0x00000001803745D0 
	public AvatarLookItemComponent ActiveAvatarLookItem { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public ActorInfo ActiveAvatarAppearance { get; set; } // 0x00000001807C92C0-0x00000001807C92D0 0x00000001807C97A0-0x00000001807C97B0
	public SanctuaryLookItemComponent ActiveSanctuaryLookItem { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
	public string EmailAddress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	[DebugField] // 0x00000001801F2F70-0x00000001801F2FD0
	private static string PlayerID { get; } // 0x00000001807C9610-0x00000001807C9650 
	[DebugField] // 0x00000001801F2F70-0x00000001801F2FD0
	private static string Email { get; } // 0x00000001807C9310-0x00000001807C9350 
	[DebugField] // 0x00000001801F2F70-0x00000001801F2FD0
	private static string DisplayName { get; } // 0x00000001807C92D0-0x00000001807C9310 
	public int Likes { get; } // 0x00000001807C9370-0x00000001807C94C0 
	public int StarFragments { get; } // 0x00000001807C9650-0x00000001807C97A0 
	public int Lockpicks { get; set; } // 0x00000001807C94C0-0x00000001807C9610 0x00000001807C97B0-0x00000001807C9810
	public bool IsGuest { get; } // 0x00000001807C9360-0x00000001807C9370 
	public bool HasCompletedTutorial { get; } // 0x00000001807C9350-0x00000001807C9360 

	// Constructors
	public MyUserInfo(string uuid, string email, string name = null); // 0x00000001807C9230-0x00000001807C92C0

	// Methods
	public bool HasUnlocked(string unlockableDefId); // 0x00000001807C8A70-0x00000001807C8AA0
	public Dictionary<int, ObscuredLong> GetUserVar(string defId); // 0x00000001807C89F0-0x00000001807C8A70
	public void UpdateUserVar(string defId, int index, long newValue); // 0x00000001807C9150-0x00000001807C9230
	public void ParseLoginData(LoginData data); // 0x00000001807C8FB0-0x00000001807C9150
	public void OnLoginComplete(LoginData data); // 0x00000001807C8AB0-0x00000001807C8FB0
	public void MarkTutorialComplete(); // 0x00000001807C8AA0-0x00000001807C8AB0
	public int GetAttributeValue(string inAttributeDefId); // 0x000000018058C710-0x000000018058C720
}

