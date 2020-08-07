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
	[AddComponentMenu] // 0x0000000180251FF0-0x0000000180252060
	[DisallowMultipleComponent] // 0x0000000180251FF0-0x0000000180252060
	[HelpURL] // 0x0000000180251FF0-0x0000000180252060
	public class InjectionDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.InjectionDetector> // TypeDefIndex: 7382
	{
		// Fields
		public const string ComponentName = "Injection Detector"; // Metadata: 0x00775FE4
		internal const string FinalLogPrefix = "[ACTk] Injection Detector: "; // Metadata: 0x00775FFA
	
		// Nested types
		public delegate void InjectionDetectedEventHandler(string reason); // TypeDefIndex: 7383; 0x00000001803F4920-0x00000001803F4CE0
	
		// Constructors
		public InjectionDetector(); // 0x000000018187E3F0-0x000000018187E430
	
		// Methods
		public static InjectionDetector AddToSceneOrGetExisting(); // 0x000000018187E1D0-0x000000018187E230
		public static void StartDetection(); // 0x000000018187E300-0x000000018187E350
		public static void StartDetection(Action<string> callback); // 0x000000018187E350-0x000000018187E3A0
		public static void StopDetection(); // 0x000000018187E3A0-0x000000018187E3F0
		public static void Dispose(); // 0x000000018187E230-0x000000018187E280
		protected override void StartDetectionAutomatically(); // 0x000000018187E2B0-0x000000018187E300
		protected override string GetComponentName(); // 0x000000018187E280-0x000000018187E2B0
	}
}
