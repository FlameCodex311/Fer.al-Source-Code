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
	[AddComponentMenu] // 0x00000001800EF660-0x00000001800EF6D0
	[DisallowMultipleComponent] // 0x00000001800EF660-0x00000001800EF6D0
	[HelpURL] // 0x00000001800EF660-0x00000001800EF6D0
	public class InjectionDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.InjectionDetector> // TypeDefIndex: 7216
	{
		// Fields
		public const string ComponentName = "Injection Detector"; // Metadata: 0x007412F6
		internal const string FinalLogPrefix = "[ACTk] Injection Detector: "; // Metadata: 0x0074130C
	
		// Nested types
		public delegate void InjectionDetectedEventHandler(string reason); // TypeDefIndex: 7217; 0x0000000180786C90-0x0000000180787020
	
		// Constructors
		public InjectionDetector(); // 0x0000000181BACB50-0x0000000181BACB90
	
		// Methods
		public static InjectionDetector AddToSceneOrGetExisting(); // 0x0000000181BAC930-0x0000000181BAC990
		public static void StartDetection(); // 0x0000000181BACA60-0x0000000181BACAB0
		public static void StartDetection(Action<string> callback); // 0x0000000181BACAB0-0x0000000181BACB00
		public static void StopDetection(); // 0x0000000181BACB00-0x0000000181BACB50
		public static void Dispose(); // 0x0000000181BAC990-0x0000000181BAC9E0
		protected override void StartDetectionAutomatically(); // 0x0000000181BACA10-0x0000000181BACA60
		protected override string GetComponentName(); // 0x0000000181BAC9E0-0x0000000181BACA10
	}
}
