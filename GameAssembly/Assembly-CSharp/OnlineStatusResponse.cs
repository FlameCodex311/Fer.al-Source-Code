/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180245880-0x00000001802458A0
public class OnlineStatusResponse : ServerMessage, ITaggedMessage // TypeDefIndex: 12881
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <userUUID>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private OnlineStatus <onlineStatus>k__BackingField; // 0x38

	// Properties
	public string userUUID { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	public OnlineStatus onlineStatus { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018057D1C0-0x000000018057D1D0 0x000000018041B190-0x000000018041B1A0

	// Constructors
	public OnlineStatusResponse(INetMessageReader data); // 0x00000001806CD0A0-0x00000001806CD180

	// Methods
	public string GetTag(); // 0x00000001803745C0-0x00000001803745D0
}

