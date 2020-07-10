/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001800F2F60-0x00000001800F2F90
	public class StudioParameterTrigger : EventHandler // TypeDefIndex: 9861
	{
		// Fields
		public EmitterRef[] Emitters; // 0x20
		public EmitterGameEvent TriggerEvent; // 0x28
	
		// Constructors
		public StudioParameterTrigger(); // 0x00000001816599E0-0x00000001816599F0
	
		// Methods
		private void Awake(); // 0x0000000181659C60-0x0000000181659F30
		protected override void HandleGameEvent(EmitterGameEvent gameEvent); // 0x0000000181659F30-0x0000000181659F40
		public void TriggerParameters(); // 0x0000000181659F40-0x000000018165A240
	}
}
