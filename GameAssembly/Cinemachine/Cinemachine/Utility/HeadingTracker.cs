/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.Utility
{
	public class HeadingTracker // TypeDefIndex: 7408
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
		public int FilterSize { get; } // 0x00000001807F44E0-0x00000001807F4500 
	
		// Nested types
		private struct Item // TypeDefIndex: 7409
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker(int filterSize); // 0x00000001817E6AF0-0x00000001817E6C40
	
		// Methods
		private void ClearHistory(); // 0x00000001817E65F0-0x00000001817E6660
		private static float Decay(float time); // 0x00000001817E6750-0x00000001817E67D0
		public void Add(Vector3 velocity); // 0x00000001817E6220-0x00000001817E65F0
		private void PopBottom(); // 0x00000001817E6940-0x00000001817E6AF0
		public void DecayHistory(); // 0x00000001817E6660-0x00000001817E6750
		public Vector3 GetReliableHeading(); // 0x00000001817E67D0-0x00000001817E6940
	}
}
