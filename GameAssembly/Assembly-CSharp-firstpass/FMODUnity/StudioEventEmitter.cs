/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001800F27A0-0x00000001800F27D0
	public class StudioEventEmitter : EventHandler // TypeDefIndex: 9857
	{
		// Fields
		[EventRef] // 0x00000001800BDB50-0x00000001800BDB60
		public string Event; // 0x20
		public EmitterGameEvent PlayEvent; // 0x28
		public EmitterGameEvent StopEvent; // 0x2C
		public bool AllowFadeout; // 0x30
		public bool TriggerOnce; // 0x31
		public bool Preload; // 0x32
		public ParamRef[] Params; // 0x38
		public bool OverrideAttenuation; // 0x40
		public float OverrideMinDistance; // 0x44
		public float OverrideMaxDistance; // 0x48
		protected EventDescription eventDescription; // 0x50
		protected EventInstance instance; // 0x58
		private bool hasTriggered; // 0x60
		private bool isQuitting; // 0x61
		private bool isOneshot; // 0x62
		private const string SnapshotString = "snapshot"; // Metadata: 0x00745FD1
	
		// Properties
		public EventDescription EventDescription { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public EventInstance EventInstance { get; } // 0x0000000180357120-0x0000000180357130 
	
		// Constructors
		public StudioEventEmitter(); // 0x0000000181659660-0x00000001816596D0
	
		// Methods
		private void Start(); // 0x0000000181659500-0x0000000181659600
		private void OnApplicationQuit(); // 0x0000000181659010-0x0000000181659020
		private void OnDestroy(); // 0x0000000181659020-0x0000000181659100
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000181658DD0-0x0000000181658E40
		private void Lookup(); // 0x0000000181658E90-0x0000000181659010
		public void Play(); // 0x0000000181659100-0x00000001816594A0
		public void Stop(); // 0x0000000181659600-0x0000000181659660
		public void SetParameter(PARAMETER_ID id, float value); // 0x00000001816594A0-0x0000000181659500
		public bool IsPlaying(); // 0x0000000181658E40-0x0000000181658E90
	}
}
