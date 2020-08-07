/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class XorshiftPlus // TypeDefIndex: 9266
	{
		// Fields
		private const ulong m_A_Init = 181353; // Metadata: 0x00778F7D
		private const ulong m_B_Init = 7; // Metadata: 0x00778F85
		public int m_seed; // 0x10
		public ulong m_stateA; // 0x18
		public ulong m_stateB; // 0x20
	
		// Constructors
		public XorshiftPlus(int seed = 1 /* Metadata: 0x00778F79 */); // 0x0000000181704530-0x0000000181704580
	
		// Methods
		public void Reset(); // 0x00000001817042A0-0x00000001817042C0
		public void Reset(int seed); // 0x0000000181704500-0x0000000181704530
		public void Reset(ulong stateA, ulong stateB); // 0x00000001817042C0-0x0000000181704500
		public void GetState(out int seed, out ulong stateA, out ulong stateB); // 0x0000000181703E00-0x0000000181703E20
		public float Next(); // 0x00000001817041C0-0x0000000181704230
		public int NextInt(); // 0x0000000181703E20-0x0000000181703E90
		public float Next(float min, float max); // 0x0000000181704230-0x00000001817042A0
		public int Next(int min, int max); // 0x0000000181704120-0x00000001817041C0
		public Vector3 NextVector(); // 0x0000000181703E90-0x0000000181703FC0
		public Vector3 NextVector(float min, float max); // 0x0000000181703FC0-0x0000000181704120
	}
}
