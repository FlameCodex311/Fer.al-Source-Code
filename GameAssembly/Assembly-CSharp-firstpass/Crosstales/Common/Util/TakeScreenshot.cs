/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class TakeScreenshot : UnityEngine.MonoBehaviour // TypeDefIndex: 9942
	{
		// Fields
		[Tooltip] // 0x000000018010E1F0-0x000000018010E220
		public string Prefix; // 0x18
		[Tooltip] // 0x000000018010E4A0-0x000000018010E4D0
		public int Scale; // 0x20
		[Tooltip] // 0x000000018010E6D0-0x000000018010E700
		public KeyCode KeyCode; // 0x24
		[Tooltip] // 0x000000018010E9A0-0x000000018010E9D0
		public bool ShowFileLocation; // 0x28
		private Texture2D texture; // 0x30
		private bool locationShown; // 0x38
	
		// Constructors
		public TakeScreenshot(); // 0x00000001815ECDD0-0x00000001815ECE20
	
		// Methods
		public void Start(); // 0x00000001815ECD10-0x00000001815ECDA0
		public void Update(); // 0x00000001815ECDA0-0x00000001815ECDD0
		public void Capture(); // 0x00000001815EC9D0-0x00000001815ECD10
	}
}
