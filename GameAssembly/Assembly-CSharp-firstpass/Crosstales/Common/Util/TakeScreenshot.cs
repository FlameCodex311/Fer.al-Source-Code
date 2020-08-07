/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class TakeScreenshot : UnityEngine.MonoBehaviour // TypeDefIndex: 9728
	{
		// Fields
		[Tooltip] // 0x00000001801EF720-0x00000001801EF750
		public string Prefix; // 0x18
		[Tooltip] // 0x00000001801EF8C0-0x00000001801EF8F0
		public int Scale; // 0x20
		[Tooltip] // 0x00000001801EF9E0-0x00000001801EFA10
		public KeyCode KeyCode; // 0x24
		[Tooltip] // 0x00000001801EFC20-0x00000001801EFC50
		public bool ShowFileLocation; // 0x28
		private Texture2D texture; // 0x30
		private bool locationShown; // 0x38
	
		// Constructors
		public TakeScreenshot(); // 0x000000018108CA50-0x000000018108CAA0
	
		// Methods
		public void Start(); // 0x000000018108C990-0x000000018108CA20
		public void Update(); // 0x000000018108CA20-0x000000018108CA50
		public void Capture(); // 0x000000018108C670-0x000000018108C990
	}
}
