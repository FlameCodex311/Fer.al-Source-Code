/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class UserVarXtHandler // TypeDefIndex: 12804
{
	// Fields
	private static CachedUserVar availabilityBypassUserVar; // 0x00

	// Properties
	[DebugField] // 0x000000018022E7C0-0x000000018022E820
	public static bool IsAvailabilityBypassed { get; set; } // 0x000000018066CCC0-0x000000018066CD30 0x000000018066CD30-0x000000018066CDB0

	// Constructors
	static UserVarXtHandler(); // 0x000000018066CC60-0x000000018066CCC0

	// Methods
	[MessageSender] // 0x000000018022E190-0x000000018022E1B0
	public static void RequestUserVarSet(string defId, long value, int value2, int index); // 0x000000018066CB50-0x000000018066CC60
	[MessageSender] // 0x000000018022E340-0x000000018022E360
	public static void RequestUserVarSetBatch(string defId, List<UserVarSetOperation> inSetOperations); // 0x000000018066C7D0-0x000000018066CB50
	[MessageRoute] // 0x000000018022E5B0-0x000000018022E5D0
	private static void HandleUserVarSet(UserVarSetMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x000000018022E6B0-0x000000018022E6D0
	private static void HandleUserVarSetBatch(UserVarSetBatchMessage message); // 0x00000001803774A0-0x00000001803774B0
}

