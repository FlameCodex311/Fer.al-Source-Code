/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class RoomXtHandler // TypeDefIndex: 11236
{
	// Fields
	public static ReconnectionType reconnectType; // 0x00

	// Nested types
	public enum ReconnectionType // TypeDefIndex: 11237
	{
		None = 0,
		Normal = 1,
		Sanctuary = 2,
		User = 3
	}

	// Methods
	public static void RequestJoinRoom(LevelDefComponent levelDef); // 0x0000000180FCE940-0x0000000180FCEB70
	[MessageSender] // 0x0000000180136CB0-0x0000000180136CD0
	private static void RequestJoinRoom(string roomDefId, bool isNodeHop); // 0x0000000180FCE7C0-0x0000000180FCE940
	[MessageSender] // 0x0000000180136E80-0x0000000180136EA0
	public static void RequestJoinRoomTutorial(); // 0x0000000180FCE720-0x0000000180FCE7C0
	[DebugButton] // 0x0000000180136EA0-0x0000000180136F20
	[MessageSender] // 0x0000000180136EA0-0x0000000180136F20
	public static void RequestJoinRoomSocialExpanse(string socialExpanseArea); // 0x0000000180FCE690-0x0000000180FCE720
	[DebugButton] // 0x0000000180137140-0x00000001801371C0
	[MessageSender] // 0x0000000180137140-0x00000001801371C0
	public static void RequestJoinPreviousRoom(); // 0x0000000180FCE640-0x0000000180FCE690
	[MessageRoute] // 0x0000000180137210-0x0000000180137230
	private static void HandleRoomJoin(RoomJoinMessage message); // 0x0000000180FCE200-0x0000000180FCE640
	[MessageRoute] // 0x00000001801373D0-0x00000001801373F0
	private static void HandleRoomJoinTutorial(RoomJoinTutorialMessage message); // 0x0000000180FCE140-0x0000000180FCE200
}

