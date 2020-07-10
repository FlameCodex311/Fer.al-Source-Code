/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using FMOD.Studio;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001800F2A90-0x00000001800F2AC0
	public class StudioGlobalParameterTrigger : EventHandler // TypeDefIndex: 9858
	{
		// Fields
		[ParamRef] // 0x00000001800BDB50-0x00000001800BDB60
		public string parameter; // 0x20
		public EmitterGameEvent TriggerEvent; // 0x28
		public float value; // 0x2C
		private PARAMETER_DESCRIPTION parameterDescription; // 0x30
	
		// Properties
		public PARAMETER_DESCRIPTION ParameterDesctription { get; } // 0x00000001816599F0-0x0000000181659A10 
	
		// Constructors
		public StudioGlobalParameterTrigger(); // 0x00000001816599E0-0x00000001816599F0
	
		// Methods
		private RESULT Lookup(); // 0x0000000181659870-0x00000001816598F0
		private void Awake(); // 0x00000001816596D0-0x0000000181659770
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000181659770-0x0000000181659870
		public void TriggerParameters(); // 0x00000001816598F0-0x00000001816599E0
	}
}
