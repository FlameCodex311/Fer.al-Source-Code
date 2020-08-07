/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class RoomXtHandler // TypeDefIndex: 12762
{
	// Fields
	public static ReconnectionType reconnectType; // 0x00

	// Nested types
	public enum ReconnectionType // TypeDefIndex: 12763
	{
		None = 0,
		Normal = 1,
		Sanctuary = 2,
		User = 3
	}

	// Methods
	public static void RequestJoinRoom(LevelDefComponent levelDef); // 0x00000001804AFD90-0x00000001804AFFC0
	[MessageSender] // 0x000000018021E870-0x000000018021E890
	private static void RequestJoinRoom(string roomDefId, bool isNodeHop); // 0x00000001804AFC10-0x00000001804AFD90
	[MessageSender] // 0x000000018021EAE0-0x000000018021EB00
	public static void RequestJoinRoomTutorial(); // 0x00000001804AFB70-0x00000001804AFC10
	[DebugButton] // 0x000000018021EB90-0x000000018021EC10
	[MessageSender] // 0x000000018021EB90-0x000000018021EC10
	public static void RequestJoinRoomSocialExpanse(string socialExpanseArea); // 0x00000001804AFAE0-0x00000001804AFB70
	[DebugButton] // 0x000000018021F090-0x000000018021F110
	[MessageSender] // 0x000000018021F090-0x000000018021F110
	public static void RequestJoinPreviousRoom(); // 0x00000001804AFA90-0x00000001804AFAE0
	[MessageRoute] // 0x000000018021F330-0x000000018021F350
	private static void HandleRoomJoin(RoomJoinMessage message); // 0x00000001804AF660-0x00000001804AFA90
	[MessageRoute] // 0x000000018021F4B0-0x000000018021F4D0
	private static void HandleRoomJoinTutorial(RoomJoinTutorialMessage message); // 0x00000001804AF5B0-0x00000001804AF660
}

