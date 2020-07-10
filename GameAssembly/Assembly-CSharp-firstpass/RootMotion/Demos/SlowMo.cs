/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class SlowMo : UnityEngine.MonoBehaviour // TypeDefIndex: 9572
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private KeyCode[] keyCodes; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool mouse0; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool mouse1; // 0x21
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float slowMoTimeScale; // 0x24
	
		// Constructors
		public SlowMo(); // 0x000000018183D110-0x000000018183D120
	
		// Methods
		private void Update(); // 0x000000018183D040-0x000000018183D110
		private bool IsSlowMotion(); // 0x000000018183CF80-0x000000018183D040
	}
}
