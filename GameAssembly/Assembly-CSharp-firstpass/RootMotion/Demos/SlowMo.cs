/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class SlowMo : UnityEngine.MonoBehaviour // TypeDefIndex: 9859
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private KeyCode[] keyCodes; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool mouse0; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool mouse1; // 0x21
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float slowMoTimeScale; // 0x24
	
		// Constructors
		public SlowMo(); // 0x000000018143E930-0x000000018143E940
	
		// Methods
		private void Update(); // 0x000000018143E860-0x000000018143E930
		private bool IsSlowMotion(); // 0x000000018143E7A0-0x000000018143E860
	}
}
