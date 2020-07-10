/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Time
{
	[AddComponentMenu] // 0x00000001800D1750-0x00000001800D17A0
	[DisallowMultipleComponent] // 0x00000001800D1750-0x00000001800D17A0
	public class SpeedHackProofTime : KeepAliveBehaviour<CodeStage.AntiCheat.Time.SpeedHackProofTime> // TypeDefIndex: 7172
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
		public static float time { get; } // 0x000000018229E6B0-0x000000018229E720 
		public static float unscaledTime { get; } // 0x000000018229E790-0x000000018229E800 
		public static float deltaTime { get; } // 0x000000018229E560-0x000000018229E5D0 
		public static float unscaledDeltaTime { get; } // 0x000000018229E720-0x000000018229E790 
		public static float realtimeSinceStartup { get; } // 0x000000018229E5D0-0x000000018229E640 
		public static float timeSinceLevelLoad { get; } // 0x000000018229E640-0x000000018229E6B0 
	
		// Constructors
		public SpeedHackProofTime(); // 0x000000018229E520-0x000000018229E560
	
		// Methods
		protected override string GetComponentName(); // 0x000000018229DC80-0x000000018229DCB0
		private void Update(); // 0x000000018229E310-0x000000018229E520
		public static void Init(); // 0x000000018229DE50-0x000000018229E030
		public static void Dispose(); // 0x000000018229DA40-0x000000018229DC80
		private bool InitInternal(); // 0x000000018229DCB0-0x000000018229DE50
		private void UpdateTimeValuesFromUnityTime(); // 0x000000018229E250-0x000000018229E310
		private void UpdateReliableTimeValues(); // 0x000000018229E140-0x000000018229E250
		private void OnSpeedHackDetected(); // 0x000000018229E0A0-0x000000018229E140
		protected override void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x000000018229E030-0x000000018229E0A0
	}
}
