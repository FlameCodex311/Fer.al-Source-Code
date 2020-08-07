/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RoomJoinMessage : ServerMessage // TypeDefIndex: 12898
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <ErrorMessage>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <RoomDefId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RoomType <RoomType>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <IssRoomId>k__BackingField; // 0x44
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <SanctuaryJoinOwnerUUID>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <GoToPlayerUUID>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <NewNodeIpOnNodeHop>k__BackingField; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LanguageId <LanguageOnLanguageChange>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <RoomConversationId>k__BackingField; // 0x68

	// Properties
	public string ErrorMessage { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	public bool Success { get; } // 0x00000001804ADA90-0x00000001804ADAA0 
	public string RoomDefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public RoomType RoomType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379F10-0x0000000180379F20 0x00000001804ADAD0-0x00000001804ADAE0
	public int IssRoomId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804ADA70-0x00000001804ADA80 0x00000001804ADAA0-0x00000001804ADAB0
	public string SanctuaryJoinOwnerUUID { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	public string GoToPlayerUUID { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
	public string NewNodeIpOnNodeHop { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	public LanguageId LanguageOnLanguageChange { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804ADA80-0x00000001804ADA90 0x00000001804ADAB0-0x00000001804ADAC0
	public string RoomConversationId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0

	// Constructors
	public RoomJoinMessage(XtReader data); // 0x00000001804AD900-0x00000001804ADA70
}

