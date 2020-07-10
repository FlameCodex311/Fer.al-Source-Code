/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class UserVarXtHandler // TypeDefIndex: 11276
{
	// Fields
	private static CachedUserVar availabilityBypassUserVar; // 0x00

	// Properties
	[DebugField] // 0x0000000180145E30-0x0000000180145E90
	public static bool IsAvailabilityBypassed { get; set; } // 0x0000000181220EC0-0x0000000181220F30 0x0000000181220F30-0x0000000181220FB0

	// Constructors
	static UserVarXtHandler(); // 0x0000000181220E60-0x0000000181220EC0

	// Methods
	[MessageSender] // 0x00000001801457D0-0x00000001801457F0
	public static void RequestUserVarSet(string defId, long value, int value2, int index); // 0x0000000181220D40-0x0000000181220E60
	[MessageSender] // 0x0000000180145940-0x0000000180145960
	public static void RequestUserVarSetBatch(string defId, List<UserVarSetOperation> inSetOperations); // 0x00000001812209B0-0x0000000181220D40
	[MessageRoute] // 0x0000000180145A50-0x0000000180145A70
	private static void HandleUserVarSet(UserVarSetMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180145BD0-0x0000000180145BF0
	private static void HandleUserVarSetBatch(UserVarSetBatchMessage message); // 0x00000001803581E0-0x00000001803581F0
}

