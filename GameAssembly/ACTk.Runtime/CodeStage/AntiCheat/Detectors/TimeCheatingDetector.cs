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
	[AddComponentMenu] // 0x00000001800F2280-0x00000001800F22F0
	[DisallowMultipleComponent] // 0x00000001800F2280-0x00000001800F22F0
	[HelpURL] // 0x00000001800F2280-0x00000001800F22F0
	public class TimeCheatingDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.TimeCheatingDetector> // TypeDefIndex: 7220
	{
		// Fields
		public const string ComponentName = "Time Cheating Detector"; // Metadata: 0x007413A7
		private const string FinalLogPrefix = "[ACTk] Time Cheating Detector: "; // Metadata: 0x007413C1
		private const int DefaultTimeoutSeconds = 10; // Metadata: 0x007413E4
		private const string ErrorMessage = "[ACTk] Time Cheating Detector:  is disabled with ACTK_PREVENT_INTERNET_PERMISSION conditional or is not supported on current platform!"; // Metadata: 0x007413E8
	
		// Nested types
		public delegate void OnlineTimeCallback(OnlineTimeResult result); // TypeDefIndex: 7221; 0x0000000181BB5630-0x0000000181BB5BB0
	
		public delegate void TimeCheatingDetectorEventHandler(CheckResult result, ErrorKind error); // TypeDefIndex: 7222; 0x0000000181BB71E0-0x0000000181BB74B0
	
		public struct OnlineTimeResult // TypeDefIndex: 7223
		{
			// Fields
			public bool success; // 0x00
			public string error; // 0x08
			public long errorResponseCode; // 0x10
			public double onlineSecondsUtc; // 0x18
	
			// Methods
			internal void SetTime(double secondsUtc); // 0x00000001802E03D0-0x00000001802E03F0
			internal void SetError(string errorText, long responseCode = -1 /* Metadata: 0x00741472 */); // 0x00000001802E03B0-0x00000001802E03D0
			public override string ToString(); // 0x00000001802E03F0-0x00000001802E1FB0
		}
	
		public enum CheckResult // TypeDefIndex: 7224
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}
	
		public enum ErrorKind // TypeDefIndex: 7225
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}
	
		public enum RequestMethod // TypeDefIndex: 7226
		{
			Head = 0,
			Get = 1
		}
	
		// Constructors
		public TimeCheatingDetector(); // 0x0000000181BB7530-0x0000000181BB7570
	
		// Methods
		protected override string GetComponentName(); // 0x0000000181BB74B0-0x0000000181BB74E0
		protected override void StartDetectionAutomatically(); // 0x0000000181BB74E0-0x0000000181BB7530
	}
}
