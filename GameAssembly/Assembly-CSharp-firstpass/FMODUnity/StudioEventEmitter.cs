/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001801D01F0-0x00000001801D0220
	public class StudioEventEmitter : EventHandler // TypeDefIndex: 10311
	{
		// Fields
		[EventRef] // 0x00000001801CEA70-0x00000001801CEA80
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
		private const string SnapshotString = "snapshot"; // Metadata: 0x0077BA83
	
		// Properties
		public EventDescription EventDescription { get; } // 0x0000000180378320-0x0000000180378330 
		public EventInstance EventInstance { get; } // 0x00000001803A1580-0x00000001803A1590 
	
		// Constructors
		public StudioEventEmitter(); // 0x0000000180D34630-0x0000000180D346C0
	
		// Methods
		private void Start(); // 0x0000000180D34440-0x0000000180D345D0
		private void OnApplicationQuit(); // 0x0000000180D33E40-0x0000000180D33E50
		private void OnDestroy(); // 0x0000000180D33E50-0x0000000180D34040
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000180D33C10-0x0000000180D33C80
		private void Lookup(); // 0x0000000180D33CD0-0x0000000180D33E40
		public void Play(); // 0x0000000180D34040-0x0000000180D343E0
		public void Stop(); // 0x0000000180D345D0-0x0000000180D34630
		public void SetParameter(PARAMETER_ID id, float value); // 0x0000000180D343E0-0x0000000180D34440
		public bool IsPlaying(); // 0x0000000180D33C80-0x0000000180D33CD0
	}
}
