/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Events;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public abstract class ACTkDetectorBase<T> : KeepAliveBehaviour<T> // TypeDefIndex: 7381
		where T : ACTkDetectorBase<T>
	{
		// Fields
		protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/"; // Metadata: 0x00775FC2
		[Tooltip] // 0x000000018024F8A0-0x000000018024F8D0
		public bool autoStart;
		[Tooltip] // 0x000000018024FB30-0x000000018024FB60
		public bool autoDispose;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action CheatDetected;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsCheatDetected>k__BackingField;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected UnityEvent detectionEvent;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool detectionEventHasListener;
		protected bool started;
		protected bool isRunning;
	
		// Properties
		public bool IsCheatDetected { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; }
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
