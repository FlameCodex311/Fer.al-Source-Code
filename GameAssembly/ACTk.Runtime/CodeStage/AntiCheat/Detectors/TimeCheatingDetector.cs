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
	[AddComponentMenu] // 0x00000001802540A0-0x0000000180254110
	[DisallowMultipleComponent] // 0x00000001802540A0-0x0000000180254110
	[HelpURL] // 0x00000001802540A0-0x0000000180254110
	public class TimeCheatingDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.TimeCheatingDetector> // TypeDefIndex: 7386
	{
		// Fields
		public const string ComponentName = "Time Cheating Detector"; // Metadata: 0x00776095
		private const string FinalLogPrefix = "[ACTk] Time Cheating Detector: "; // Metadata: 0x007760AF
		private const int DefaultTimeoutSeconds = 10; // Metadata: 0x007760D2
		private const string ErrorMessage = "[ACTk] Time Cheating Detector:  is disabled with ACTK_PREVENT_INTERNET_PERMISSION conditional or is not supported on current platform!"; // Metadata: 0x007760D6
	
		// Nested types
		public delegate void OnlineTimeCallback(OnlineTimeResult result); // TypeDefIndex: 7387; 0x00000001817FFEA0-0x0000000181800260
	
		public delegate void TimeCheatingDetectorEventHandler(CheckResult result, ErrorKind error); // TypeDefIndex: 7388; 0x00000001818872A0-0x0000000181887580
	
		public struct OnlineTimeResult // TypeDefIndex: 7389
		{
			// Fields
			public bool success; // 0x00
			public string error; // 0x08
			public long errorResponseCode; // 0x10
			public double onlineSecondsUtc; // 0x18
	
			// Methods
			internal void SetTime(double secondsUtc); // 0x00000001800F4740-0x00000001800F4760
			internal void SetError(string errorText, long responseCode = -1 /* Metadata: 0x00776160 */); // 0x00000001800F4720-0x00000001800F4740
			public override string ToString(); // 0x00000001800F4760-0x00000001800F4890
		}
	
		public enum CheckResult // TypeDefIndex: 7390
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}
	
		public enum ErrorKind // TypeDefIndex: 7391
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}
	
		public enum RequestMethod // TypeDefIndex: 7392
		{
			Head = 0,
			Get = 1
		}
	
		// Constructors
		public TimeCheatingDetector(); // 0x0000000181887600-0x0000000181887640
	
		// Methods
		protected override string GetComponentName(); // 0x0000000181887580-0x00000001818875B0
		protected override void StartDetectionAutomatically(); // 0x00000001818875B0-0x0000000181887600
	}
}
