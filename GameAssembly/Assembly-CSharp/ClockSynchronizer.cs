/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public class ClockSynchronizer : MonoBehaviour // TypeDefIndex: 10888
{
	// Fields
	private const int NumClockSyncIntervalTrips = 10; // Metadata: 0x00782120
	private const long MaxClockSyncIntervalTripMs = 2000; // Metadata: 0x00782124
	public Action<long> onCompleteEvent; // 0x20
	private long _lastClockSyncSendTime; // 0x28
	private int _numClockSyncTrips; // 0x30
	private List<ClockSyncInterval> _clockSyncData; // 0x38
	private static long _syncedServerTimeOffset; // 0x00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static ClockSynchronizer <instance>k__BackingField; // 0x08

	// Properties
	public static ClockSynchronizer instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018126B1F0-0x000000018126B250 0x000000018126B250-0x000000018126B2B0

	// Nested types
	private class ClockSyncIntervalResponse : ServerMessage // TypeDefIndex: 10889
	{
		// Fields
		public readonly long ServerTime; // 0x30

		// Constructors
		public ClockSyncIntervalResponse(INetMessageReader data); // 0x000000018126A820-0x000000018126A8E0
	}

	private struct ClockSyncInterval // TypeDefIndex: 10890
	{
		// Fields
		public readonly long myStartTime; // 0x00
		public readonly long serverMidTime; // 0x08
		public readonly long myRecvTime; // 0x10

		// Constructors
		public ClockSyncInterval(long myStartTime, long serverTime, long myRecvTime); // 0x0000000180005C50-0x0000000180005C60
	}

	// Constructors
	public ClockSynchronizer(); // 0x0000000180E095D0-0x0000000180E095E0
	static ClockSynchronizer(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public static void Begin(Action<long> onCompletedCallback); // 0x000000018126A8E0-0x000000018126A9B0
	private void OnEnable(); // 0x000000018126AE00-0x000000018126AEA0
	private void SynchronizeClock(); // 0x000000018126B160-0x000000018126B1F0
	private void OnInterval(ClockSyncIntervalResponse response); // 0x000000018126AEA0-0x000000018126AFD0
	[MessageRoute] // 0x00000001800F4640-0x00000001800F4660
	private static void HandleClockSyncInterval(ClockSyncIntervalResponse response); // 0x000000018126AC20-0x000000018126AE00
	[MessageSender] // 0x00000001800F4720-0x00000001800F4740
	private static void RequestClockSyncInterval(); // 0x000000018126AFD0-0x000000018126B160
	private void CalculateClockSyncOffset(); // 0x000000018126A9B0-0x000000018126AC20
}

