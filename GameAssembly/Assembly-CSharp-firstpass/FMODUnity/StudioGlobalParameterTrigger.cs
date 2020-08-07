/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using FMOD.Studio;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001801D0530-0x00000001801D0560
	public class StudioGlobalParameterTrigger : EventHandler // TypeDefIndex: 10312
	{
		// Fields
		[ParamRef] // 0x00000001801CEA70-0x00000001801CEA80
		public string parameter; // 0x20
		public EmitterGameEvent TriggerEvent; // 0x28
		public float value; // 0x2C
		private PARAMETER_DESCRIPTION parameterDescription; // 0x30
	
		// Properties
		public PARAMETER_DESCRIPTION ParameterDesctription { get; } // 0x0000000180D34B10-0x0000000180D34B30 
	
		// Constructors
		public StudioGlobalParameterTrigger(); // 0x0000000180D21920-0x0000000180D21960
	
		// Methods
		private RESULT Lookup(); // 0x0000000180D34900-0x0000000180D349D0
		private void Awake(); // 0x0000000180D346C0-0x0000000180D347B0
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000180D347B0-0x0000000180D34900
		public void TriggerParameters(); // 0x0000000180D349D0-0x0000000180D34B10
	}
}
