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
	[AddComponentMenu] // 0x00000001800EF8F0-0x00000001800EF960
	[DisallowMultipleComponent] // 0x00000001800EF8F0-0x00000001800EF960
	[HelpURL] // 0x00000001800EF8F0-0x00000001800EF960
	public class ObscuredCheatingDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector> // TypeDefIndex: 7218
	{
		// Fields
		public const string ComponentName = "Obscured Cheating Detector"; // Metadata: 0x0074132B
		internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: "; // Metadata: 0x00741349
		[Tooltip] // 0x00000001800EFCA0-0x00000001800EFCD0
		public double doubleEpsilon; // 0x48
		[Tooltip] // 0x00000001800EFDB0-0x00000001800EFDE0
		public float floatEpsilon; // 0x50
		[Tooltip] // 0x00000001800EFE90-0x00000001800EFEC0
		public float vector2Epsilon; // 0x54
		[Tooltip] // 0x00000001800F0090-0x00000001800F00C0
		public float vector3Epsilon; // 0x58
		[Tooltip] // 0x00000001800F14E0-0x00000001800F1510
		public float quaternionEpsilon; // 0x5C
	
		// Properties
		internal static bool ExistsAndIsRunning { get; } // 0x0000000181BADED0-0x0000000181BADFA0 
	
		// Constructors
		private ObscuredCheatingDetector(); // 0x0000000181BADE60-0x0000000181BADED0
	
		// Methods
		public static ObscuredCheatingDetector AddToSceneOrGetExisting(); // 0x0000000181BAD920-0x0000000181BAD950
		public static ObscuredCheatingDetector StartDetection(); // 0x0000000181BADBF0-0x0000000181BADD10
		public static ObscuredCheatingDetector StartDetection(Action callback); // 0x0000000181BADD10-0x0000000181BADD60
		public static void StopDetection(); // 0x0000000181BADD60-0x0000000181BADE60
		public static void Dispose(); // 0x0000000181BAD950-0x0000000181BADA50
		private ObscuredCheatingDetector StartDetectionInternal(Action callback); // 0x0000000181BADA90-0x0000000181BADBF0
		protected override void StartDetectionAutomatically(); // 0x0000000181BADA80-0x0000000181BADA90
		protected override string GetComponentName(); // 0x0000000181BADA50-0x0000000181BADA80
	}
}
