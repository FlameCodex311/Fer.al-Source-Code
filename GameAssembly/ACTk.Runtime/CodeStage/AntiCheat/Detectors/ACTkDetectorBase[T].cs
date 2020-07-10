/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Events;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public abstract class ACTkDetectorBase<T> : KeepAliveBehaviour<T> // TypeDefIndex: 7215
		where T : ACTkDetectorBase<T>
	{
		// Fields
		protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/"; // Metadata: 0x007412D4
		[Tooltip] // 0x00000001800EEA50-0x00000001800EEA80
		public bool autoStart;
		[Tooltip] // 0x00000001800EEBF0-0x00000001800EEC20
		public bool autoDispose;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action CheatDetected;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsCheatDetected>k__BackingField;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected UnityEvent detectionEvent;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool detectionEventHasListener;
		protected bool started;
		protected bool isRunning;
	
		// Properties
		public bool IsCheatDetected { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; }
		public bool IsStarted { get; }
		public bool IsRunning { get; }
	
		// Events
		public event Action CheatDetected {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		protected ACTkDetectorBase();
	
		// Methods
		protected override void Start();
		private void OnEnable();
		private void OnDisable();
		private void OnApplicationQuit();
		protected override void OnDestroy();
		internal virtual void OnCheatingDetected();
		protected virtual bool DetectorHasCallbacks();
		protected virtual void StopDetectionInternal();
		protected virtual void PauseDetector();
		protected virtual bool ResumeDetector();
		protected abstract void StartDetectionAutomatically();
	}
}
