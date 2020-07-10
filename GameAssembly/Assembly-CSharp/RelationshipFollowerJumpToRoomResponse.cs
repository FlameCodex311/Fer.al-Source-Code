/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018015F2D0-0x000000018015F2F0
public class RelationshipFollowerJumpToRoomResponse : ServerMessage // TypeDefIndex: 11352
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <roomIssId>k__BackingField; // 0x34
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <otherNode>k__BackingField; // 0x38

	// Properties
	public bool success { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048B840-0x000000018048B850 0x000000018048B850-0x000000018048B860
	public int roomIssId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018043E170-0x000000018043E180 0x000000018036C610-0x000000018036C620
	public string otherNode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830

	// Constructors
	public RelationshipFollowerJumpToRoomResponse(INetMessageReader data); // 0x0000000181011E80-0x0000000181011FF0
}

