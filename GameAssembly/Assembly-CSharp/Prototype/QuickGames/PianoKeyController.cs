/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PianoKeyController : MonoBehaviour // TypeDefIndex: 16197
	{
		// Fields
		public Color upColor; // 0x20
		public Color downColor; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Index>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsDown>k__BackingField; // 0x44
		private Image image; // 0x48
	
		// Properties
		public int Index { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001804D0BC0-0x00000001804D0BD0
		public bool IsDown { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018061F620-0x000000018061F630 0x000000018061F6D0-0x000000018061F6E0
	
		// Constructors
		public PianoKeyController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void Awake(); // 0x000000018152D290-0x000000018152D300
		public void Press(); // 0x000000018152D300-0x000000018152D340
		public void Release(); // 0x000000018152D340-0x000000018152D380
	}
}
