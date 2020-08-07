/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public class ClockSynchronizer : MonoBehaviour // TypeDefIndex: 12411
{
	// Fields
	private const int NumClockSyncIntervalTrips = 10; // Metadata: 0x007B9864
	private const long MaxClockSyncIntervalTripMs = 2000; // Metadata: 0x007B9868
	public Action<long> onCompleteEvent; // 0x20
	private long _lastClockSyncSendTime; // 0x28
	private int _numClockSyncTrips; // 0x30
	private List<ClockSyncInterval> _clockSyncData; // 0x38
	private static long _syncedServerTimeOffset; // 0x00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static ClockSynchronizer <instance>k__BackingField; // 0x08

	// Properties
	public static ClockSynchronizer instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805239B0-0x0000000180523A10 0x0000000180523A10-0x0000000180523A70

	// Nested types
	private class ClockSyncIntervalResponse : ServerMessage // TypeDefIndex: 12412
	{
		// Fields
		public readonly long ServerTime; // 0x30

		// Constructors
		public ClockSyncIntervalResponse(INetMessageReader data); // 0x0000000180523000-0x00000001805230C0
	}

	private struct ClockSyncInterval // TypeDefIndex: 12413
	{
		// Fields
		public readonly long myStartTime; // 0x00
		public readonly long serverMidTime; // 0x08
		public readonly long myRecvTime; // 0x10

		// Constructors
		public ClockSyncInterval(long myStartTime, long serverTime, long myRecvTime); // 0x00000001800064E0-0x00000001800064F0
	}

	// Constructors
	public ClockSynchronizer(); // 0x00000001803743C0-0x00000001803743D0
	static ClockSynchronizer(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public static void Begin(Action<long> onCompletedCallback); // 0x00000001805230C0-0x0000000180523180
	private void OnEnable(); // 0x00000001805235C0-0x0000000180523660
	private void SynchronizeClock(); // 0x0000000180523920-0x00000001805239B0
	private void OnInterval(ClockSyncIntervalResponse response); // 0x0000000180523660-0x0000000180523790
	[MessageRoute] // 0x00000001801CE4A0-0x00000001801CE4C0
	private static void HandleClockSyncInterval(ClockSyncIntervalResponse response); // 0x00000001805233F0-0x00000001805235C0
	[MessageSender] // 0x00000001801CE6E0-0x00000001801CE700
	private static void RequestClockSyncInterval(); // 0x0000000180523790-0x0000000180523920
	private void CalculateClockSyncOffset(); // 0x0000000180523180-0x00000001805233F0
}

