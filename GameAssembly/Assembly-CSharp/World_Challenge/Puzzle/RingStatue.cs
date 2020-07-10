/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Puzzle
{
	public class RingStatue : WorldPuzzle // TypeDefIndex: 15526
	{
		// Fields
		public Color onColor; // 0x70
		public Color offColor; // 0x80
		private GameObject baseRing; // 0x90
		private GameObject bottomRing; // 0x98
		private GameObject middleRing; // 0xA0
		private GameObject topRing; // 0xA8
		private float rotationIncrement; // 0xB0
		private float targetRotation; // 0xB4
	
		// Constructors
		public RingStatue(); // 0x0000000181F328B0-0x0000000181F32910
	
		// Methods
		internal override void InitializePuzzle(); // 0x0000000181F32370-0x0000000181F32520
		internal void Rotate(GameObject ring, int direction); // 0x0000000181F325C0-0x0000000181F326F0
		public void LeftControlClicked(int ringIndex); // 0x0000000181F32520-0x0000000181F32570
		public void RightControlClicked(int ringIndex); // 0x0000000181F32570-0x0000000181F325C0
		public void ExitClicked(); // 0x0000000181F32300-0x0000000181F32340
		private GameObject GetRingByIndex(int ringIndex); // 0x0000000181F32340-0x0000000181F32370
		private void CheckState(); // 0x0000000181F32090-0x0000000181F32300
		private void UpdateColor(GameObject ring, bool state); // 0x0000000181F326F0-0x0000000181F328B0
	}
}
