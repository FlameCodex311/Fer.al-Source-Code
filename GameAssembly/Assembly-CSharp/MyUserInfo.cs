/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MyUserInfo : UserInfo // TypeDefIndex: 12673
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private AvatarLookItemComponent <ActiveAvatarLookItem>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryLookItemComponent <ActiveSanctuaryLookItem>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <EmailAddress>k__BackingField; // 0x40
	private ItemComponentRef<QuantityItemComponent> _likeQuantity; // 0x48
	private ItemComponentRef<QuantityItemComponent> _starFragmentQuantity; // 0x50
	private ItemComponentRef<QuantityItemComponent> _lockpickQuantity; // 0x58
	private uint _pendingFlags; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly Inventory <Inventory>k__BackingField; // 0x68

	// Properties
	public AvatarLookItemComponent ActiveAvatarLookItem { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	public ActorInfo ActiveAvatarAppearance { get; set; } // 0x00000001812E3790-0x00000001812E37A0 0x00000001812E3C70-0x00000001812E3C80
	public SanctuaryLookItemComponent ActiveSanctuaryLookItem { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public string EmailAddress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
	[DebugField] // 0x000000018010AFD0-0x000000018010B030
	private static string PlayerID { get; } // 0x00000001812E3AE0-0x00000001812E3B20 
	[DebugField] // 0x000000018010AFD0-0x000000018010B030
	private static string Email { get; } // 0x00000001812E37E0-0x00000001812E3820 
	[DebugField] // 0x000000018010AFD0-0x000000018010B030
	private static string DisplayName { get; } // 0x00000001812E37A0-0x00000001812E37E0 
	public int Likes { get; } // 0x00000001812E3840-0x00000001812E3990 
	public int StarFragments { get; } // 0x00000001812E3B20-0x00000001812E3C70 
	public int Lockpicks { get; set; } // 0x00000001812E3990-0x00000001812E3AE0 0x00000001812E3C80-0x00000001812E3CE0
	public bool IsGuest { get; } // 0x00000001812E3830-0x00000001812E3840 
	public bool HasCompletedTutorial { get; } // 0x00000001812E3820-0x00000001812E3830 
	public Inventory Inventory { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180358970-0x0000000180358980 

	// Constructors
	public MyUserInfo(string uuid, string email, string name = null); // 0x00000001812E3700-0x00000001812E3790

	// Methods
	public void ParseLoginData(LoginData data); // 0x00000001812E3470-0x00000001812E3610
	public void OnLoginComplete(LoginData data); // 0x00000001812E2F50-0x00000001812E3470
	public void MarkTutorialComplete(); // 0x00000001812E2F40-0x00000001812E2F50
	public int GetAttributeValue(string inAttributeDefId); // 0x000000018042E670-0x000000018042E680
	public bool HasUnlocked(string unlockableDefId); // 0x00000001812E2F10-0x00000001812E2F40
	public Dictionary<int, ObscuredLong> GetUserVar(string defId); // 0x00000001812E2E90-0x00000001812E2F10
	public void UpdateUserVar(string defId, int index, long newValue); // 0x00000001812E3610-0x00000001812E3700
}

