/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class XorshiftPlus // TypeDefIndex: 9100
	{
		// Fields
		private const ulong m_A_Init = 181353; // Metadata: 0x0074428F
		private const ulong m_B_Init = 7; // Metadata: 0x00744297
		public int m_seed; // 0x10
		public ulong m_stateA; // 0x18
		public ulong m_stateB; // 0x20
	
		// Constructors
		public XorshiftPlus(int seed = 1 /* Metadata: 0x0074428B */); // 0x0000000181C0F1B0-0x0000000181C0FFD0
	
		// Methods
		public void Reset(); // 0x0000000181C0EF10-0x0000000181C0EF30
		public void Reset(int seed); // 0x0000000181C0F180-0x0000000181C0F1B0
		public void Reset(ulong stateA, ulong stateB); // 0x0000000181C0EF30-0x0000000181C0F180
		public void GetState(out int seed, out ulong stateA, out ulong stateB); // 0x0000000181C0EA70-0x0000000181C0EA90
		public float Next(); // 0x0000000181C0EE30-0x0000000181C0EEA0
		public int NextInt(); // 0x0000000181C0EA90-0x0000000181C0EB00
		public float Next(float min, float max); // 0x0000000181C0EEA0-0x0000000181C0EF10
		public int Next(int min, int max); // 0x0000000181C0ED90-0x0000000181C0EE30
		public Vector3 NextVector(); // 0x0000000181C0EB00-0x0000000181C0EC30
		public Vector3 NextVector(float min, float max); // 0x0000000181C0EC30-0x0000000181C0ED90
	}
}
