/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	public class HeadingTracker // TypeDefIndex: 7574
	{
		// Fields
		private Item[] mHistory; // 0x10
		private int mTop; // 0x18
		private int mBottom; // 0x1C
		private int mCount; // 0x20
		private Vector3 mHeadingSum; // 0x24
		private float mWeightSum; // 0x30
		private float mWeightTime; // 0x34
		private Vector3 mLastGoodHeading; // 0x38
		private static float mDecayExponent; // 0x00
	
		// Properties
		public int FilterSize { get; } // 0x00000001810CA9D0-0x00000001810CA9F0 
	
		// Nested types
		private struct Item // TypeDefIndex: 7575
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker(int filterSize); // 0x0000000181FF6950-0x0000000181FF6AA0
	
		// Methods
		private void ClearHistory(); // 0x0000000181FF6430-0x0000000181FF64A0
		private static float Decay(float time); // 0x0000000181FF6590-0x0000000181FF6610
		public void Add(Vector3 velocity); // 0x0000000181FF6070-0x0000000181FF6430
		private void PopBottom(); // 0x0000000181FF67A0-0x0000000181FF6950
		public void DecayHistory(); // 0x0000000181FF64A0-0x0000000181FF6590
		public Vector3 GetReliableHeading(); // 0x0000000181FF6610-0x0000000181FF67A0
	}
}
