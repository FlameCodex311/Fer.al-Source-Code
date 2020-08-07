/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001801D0940-0x00000001801D0970
	public class StudioParameterTrigger : EventHandler // TypeDefIndex: 10315
	{
		// Fields
		public EmitterRef[] Emitters; // 0x20
		public EmitterGameEvent TriggerEvent; // 0x28
	
		// Constructors
		public StudioParameterTrigger(); // 0x0000000180D21920-0x0000000180D21960
	
		// Methods
		private void Awake(); // 0x0000000180D35070-0x0000000180D35320
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000180D35320-0x0000000180D35330
		public void TriggerParameters(); // 0x0000000180D35330-0x0000000180D35610
	}
}
