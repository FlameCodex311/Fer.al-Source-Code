/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Puzzle
{
	public class RingStatue : WorldPuzzle // TypeDefIndex: 14681
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
		public RingStatue(); // 0x000000018197E770-0x000000018197E7D0
	
		// Methods
		internal override void InitializePuzzle(); // 0x000000018197E270-0x000000018197E410
		internal void Rotate(GameObject ring, int direction); // 0x000000018197E4B0-0x000000018197E5D0
		public void LeftControlClicked(int ringIndex); // 0x000000018197E410-0x000000018197E460
		public void RightControlClicked(int ringIndex); // 0x000000018197E460-0x000000018197E4B0
		public void ExitClicked(); // 0x000000018197E200-0x000000018197E240
		private GameObject GetRingByIndex(int ringIndex); // 0x000000018197E240-0x000000018197E270
		private void CheckState(); // 0x000000018197DF90-0x000000018197E200
		private void UpdateColor(GameObject ring, bool state); // 0x000000018197E5D0-0x000000018197E770
	}
}
