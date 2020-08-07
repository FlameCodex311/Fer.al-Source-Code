/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PianoKeyController : MonoBehaviour // TypeDefIndex: 14938
	{
		// Fields
		public Color upColor; // 0x20
		public Color downColor; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Index>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsDown>k__BackingField; // 0x44
		private Image image; // 0x48
	
		// Properties
		public int Index { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379F10-0x0000000180379F20 0x00000001804ADAD0-0x00000001804ADAE0
		public bool IsDown { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EB0-0x0000000180379EC0 0x0000000180A4F950-0x0000000180A4F960
	
		// Constructors
		public PianoKeyController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void Awake(); // 0x0000000180A4F860-0x0000000180A4F8D0
		public void Press(); // 0x0000000180A4F8D0-0x0000000180A4F910
		public void Release(); // 0x0000000180A4F910-0x0000000180A4F950
	}
}
