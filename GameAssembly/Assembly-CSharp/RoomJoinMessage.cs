/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RoomJoinMessage : ServerMessage // TypeDefIndex: 11368
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <ErrorMessage>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <RoomDefId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RoomType <RoomType>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <IssRoomId>k__BackingField; // 0x44
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <SanctuaryJoinOwnerUUID>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3? <GoToPlayerPosition>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Quaternion? <GoToPlayerRotation>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <NewNodeIpOnNodeHop>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LanguageId <LanguageOnLanguageChange>k__BackingField; // 0x80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <RoomConversationId>k__BackingField; // 0x88

	// Properties
	public string ErrorMessage { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	public bool Success { get; } // 0x0000000180FCC700-0x0000000180FCC710 
	public string RoomDefId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public RoomType RoomType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001804D0BC0-0x00000001804D0BD0
	public int IssRoomId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180478650-0x0000000180478660 0x00000001804D0BD0-0x00000001804D0BE0
	public string SanctuaryJoinOwnerUUID { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
	public Vector3? GoToPlayerPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A53C0-0x00000001804A53D0 0x0000000180FCC710-0x0000000180FCC720
	public Quaternion? GoToPlayerRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180FCC6E0-0x0000000180FCC700 0x0000000180FCC720-0x0000000180FCC730
	public string NewNodeIpOnNodeHop { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	public LanguageId LanguageOnLanguageChange { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804241F0-0x0000000180424200 0x0000000180423A40-0x0000000180423A50
	public string RoomConversationId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710

	// Constructors
	public RoomJoinMessage(XtReader data); // 0x0000000180FCC4E0-0x0000000180FCC6E0
}

