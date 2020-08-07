/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Time
{
	[AddComponentMenu] // 0x0000000180232C10-0x0000000180232C60
	[DisallowMultipleComponent] // 0x0000000180232C10-0x0000000180232C60
	public class SpeedHackProofTime : KeepAliveBehaviour<CodeStage.AntiCheat.Time.SpeedHackProofTime> // TypeDefIndex: 7338
	{
		// Fields
		private static bool inited; // 0x00
		private static bool speedHackDetected; // 0x01
		private static float reliableTime; // 0x04
		private static float reliableDeltaTime; // 0x08
		private static float reliableUnscaledTime; // 0x0C
		private static float reliableUnscaledDeltaTime; // 0x10
		private static float reliableRealtimeSinceStartup; // 0x14
		private static float reliableTimeSinceLevelLoad; // 0x18
		private static bool warningShot; // 0x1C
		private long currentReliableTicks; // 0x20
		private long lastFrameReliableTicks; // 0x28
		private long reliableTicksDelta; // 0x30
	
		// Properties
		public static float time { get; } // 0x0000000182009C40-0x0000000182009CB0 
		public static float unscaledTime { get; } // 0x0000000182009D20-0x0000000182009D90 
		public static float deltaTime { get; } // 0x0000000182009AF0-0x0000000182009B60 
		public static float unscaledDeltaTime { get; } // 0x0000000182009CB0-0x0000000182009D20 
		public static float realtimeSinceStartup { get; } // 0x0000000182009B60-0x0000000182009BD0 
		public static float timeSinceLevelLoad { get; } // 0x0000000182009BD0-0x0000000182009C40 
	
		// Constructors
		public SpeedHackProofTime(); // 0x0000000182009AB0-0x0000000182009AF0
	
		// Methods
		protected override string GetComponentName(); // 0x0000000182009210-0x0000000182009240
		private void Update(); // 0x00000001820098A0-0x0000000182009AB0
		public static void Init(); // 0x00000001820093E0-0x00000001820095C0
		public static void Dispose(); // 0x0000000182008FD0-0x0000000182009210
		private bool InitInternal(); // 0x0000000182009240-0x00000001820093E0
		private void UpdateTimeValuesFromUnityTime(); // 0x00000001820097E0-0x00000001820098A0
		private void UpdateReliableTimeValues(); // 0x00000001820096D0-0x00000001820097E0
		private void OnSpeedHackDetected(); // 0x0000000182009630-0x00000001820096D0
		protected override void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x00000001820095C0-0x0000000182009630
	}
}
