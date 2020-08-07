/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x0000000180253460-0x00000001802534D0
	[DisallowMultipleComponent] // 0x0000000180253460-0x00000001802534D0
	[HelpURL] // 0x0000000180253460-0x00000001802534D0
	public class SpeedHackDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.SpeedHackDetector> // TypeDefIndex: 7385
	{
		// Fields
		public const string ComponentName = "Speed Hack Detector"; // Metadata: 0x0077605E
		internal const string FinalLogPrefix = "[ACTk] Speed Hack Detector: "; // Metadata: 0x00776075
		[Tooltip] // 0x0000000180253740-0x0000000180253770
		public float interval; // 0x48
		[Range] // 0x00000001802538B0-0x0000000180253910
		[Tooltip] // 0x00000001802538B0-0x0000000180253910
		public float threshold; // 0x4C
		[Tooltip] // 0x0000000180253C70-0x0000000180253CA0
		public byte maxFalsePositives; // 0x50
		[Tooltip] // 0x0000000180253EA0-0x0000000180253ED0
		public int coolDown; // 0x54
		private byte currentFalsePositives; // 0x58
		private int currentCooldownShots; // 0x5C
		private long previousReliableTicks; // 0x60
		private long previousVulnerableEnvironmentTicks; // 0x68
		private long previousVulnerableRealtimeTicks; // 0x70
	
		// Constructors
		private SpeedHackDetector(); // 0x00000001818868C0-0x0000000181886920
	
		// Methods
		public static SpeedHackDetector AddToSceneOrGetExisting(); // 0x0000000181885CA0-0x0000000181885CD0
		public static SpeedHackDetector StartDetection(); // 0x0000000181886180-0x00000001818863D0
		public static SpeedHackDetector StartDetection(Action callback); // 0x0000000181886050-0x0000000181886180
		public static SpeedHackDetector StartDetection(Action callback, float interval); // 0x00000001818863D0-0x00000001818864C0
		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives); // 0x00000001818864C0-0x0000000181886580
		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown); // 0x0000000181886580-0x0000000181886610
		public static void StopDetection(); // 0x0000000181886610-0x0000000181886710
		public static void Dispose(); // 0x0000000181885CD0-0x0000000181885DD0
		private void OnApplicationPause(bool pause); // 0x0000000181885E00-0x0000000181885E40
		private void Update(); // 0x0000000181886710-0x00000001818868C0
		private SpeedHackDetector StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown); // 0x0000000181885EA0-0x0000000181886050
		protected override void StartDetectionAutomatically(); // 0x0000000181885E70-0x0000000181885EA0
		protected override string GetComponentName(); // 0x0000000181885DD0-0x0000000181885E00
		private void ResetLastTicks(); // 0x0000000181885E40-0x0000000181885E70
	}
}
