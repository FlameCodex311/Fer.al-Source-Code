/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x00000001800F16C0-0x00000001800F1730
	[DisallowMultipleComponent] // 0x00000001800F16C0-0x00000001800F1730
	[HelpURL] // 0x00000001800F16C0-0x00000001800F1730
	public class SpeedHackDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.SpeedHackDetector> // TypeDefIndex: 7219
	{
		// Fields
		public const string ComponentName = "Speed Hack Detector"; // Metadata: 0x00741370
		internal const string FinalLogPrefix = "[ACTk] Speed Hack Detector: "; // Metadata: 0x00741387
		[Tooltip] // 0x00000001800F1B80-0x00000001800F1BB0
		public float interval; // 0x48
		[Range] // 0x00000001800F1D00-0x00000001800F1D60
		[Tooltip] // 0x00000001800F1D00-0x00000001800F1D60
		public float threshold; // 0x4C
		[Tooltip] // 0x00000001800F1EB0-0x00000001800F1EE0
		public byte maxFalsePositives; // 0x50
		[Tooltip] // 0x00000001800F20B0-0x00000001800F20E0
		public int coolDown; // 0x54
		private byte currentFalsePositives; // 0x58
		private int currentCooldownShots; // 0x5C
		private long previousReliableTicks; // 0x60
		private long previousVulnerableEnvironmentTicks; // 0x68
		private long previousVulnerableRealtimeTicks; // 0x70
	
		// Constructors
		private SpeedHackDetector(); // 0x0000000181BB67E0-0x0000000181BB6840
	
		// Methods
		public static SpeedHackDetector AddToSceneOrGetExisting(); // 0x0000000181BB5BB0-0x0000000181BB5BE0
		public static SpeedHackDetector StartDetection(); // 0x0000000181BB6090-0x0000000181BB62E0
		public static SpeedHackDetector StartDetection(Action callback); // 0x0000000181BB5F60-0x0000000181BB6090
		public static SpeedHackDetector StartDetection(Action callback, float interval); // 0x0000000181BB62E0-0x0000000181BB63E0
		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives); // 0x0000000181BB63E0-0x0000000181BB64A0
		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown); // 0x0000000181BB64A0-0x0000000181BB6530
		public static void StopDetection(); // 0x0000000181BB6530-0x0000000181BB6630
		public static void Dispose(); // 0x0000000181BB5BE0-0x0000000181BB5CE0
		private void OnApplicationPause(bool pause); // 0x0000000181BB5D10-0x0000000181BB5D50
		private void Update(); // 0x0000000181BB6630-0x0000000181BB67E0
		private SpeedHackDetector StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown); // 0x0000000181BB5DB0-0x0000000181BB5F60
		protected override void StartDetectionAutomatically(); // 0x0000000181BB5D80-0x0000000181BB5DB0
		protected override string GetComponentName(); // 0x0000000181BB5CE0-0x0000000181BB5D10
		private void ResetLastTicks(); // 0x0000000181BB5D50-0x0000000181BB5D80
	}
}
