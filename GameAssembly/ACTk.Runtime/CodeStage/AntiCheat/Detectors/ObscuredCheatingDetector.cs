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
	[AddComponentMenu] // 0x00000001802525B0-0x0000000180252620
	[DisallowMultipleComponent] // 0x00000001802525B0-0x0000000180252620
	[HelpURL] // 0x00000001802525B0-0x0000000180252620
	public class ObscuredCheatingDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector> // TypeDefIndex: 7384
	{
		// Fields
		public const string ComponentName = "Obscured Cheating Detector"; // Metadata: 0x00776019
		internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: "; // Metadata: 0x00776037
		[Tooltip] // 0x0000000180252A10-0x0000000180252A40
		public double doubleEpsilon; // 0x48
		[Tooltip] // 0x0000000180252C80-0x0000000180252CB0
		public float floatEpsilon; // 0x50
		[Tooltip] // 0x0000000180252EA0-0x0000000180252ED0
		public float vector2Epsilon; // 0x54
		[Tooltip] // 0x00000001802530F0-0x0000000180253120
		public float vector3Epsilon; // 0x58
		[Tooltip] // 0x0000000180253270-0x00000001802532A0
		public float quaternionEpsilon; // 0x5C
	
		// Properties
		internal static bool ExistsAndIsRunning { get; } // 0x000000018187F740-0x000000018187F810 
	
		// Constructors
		private ObscuredCheatingDetector(); // 0x000000018187F6D0-0x000000018187F740
	
		// Methods
		public static ObscuredCheatingDetector AddToSceneOrGetExisting(); // 0x000000018187F190-0x000000018187F1C0
		public static ObscuredCheatingDetector StartDetection(); // 0x000000018187F460-0x000000018187F580
		public static ObscuredCheatingDetector StartDetection(Action callback); // 0x000000018187F580-0x000000018187F5D0
		public static void StopDetection(); // 0x000000018187F5D0-0x000000018187F6D0
		public static void Dispose(); // 0x000000018187F1C0-0x000000018187F2C0
		private ObscuredCheatingDetector StartDetectionInternal(Action callback); // 0x000000018187F300-0x000000018187F460
		protected override void StartDetectionAutomatically(); // 0x000000018187F2F0-0x000000018187F300
		protected override string GetComponentName(); // 0x000000018187F2C0-0x000000018187F2F0
	}
}
