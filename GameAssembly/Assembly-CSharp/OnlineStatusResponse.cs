/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018015E8B0-0x000000018015E8D0
public class OnlineStatusResponse : ServerMessage, ITaggedMessage // TypeDefIndex: 11351
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <userUUID>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private OnlineStatus <onlineStatus>k__BackingField; // 0x38

	// Properties
	public string userUUID { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	public OnlineStatus onlineStatus { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018036C620-0x000000018036C630

	// Constructors
	public OnlineStatusResponse(INetMessageReader data); // 0x0000000180E96DE0-0x0000000180E96E60

	// Methods
	public string GetTag(); // 0x0000000180397720-0x0000000180397730
}

