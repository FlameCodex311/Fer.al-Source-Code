/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class SimplexNoiseGenerator // TypeDefIndex: 9093
	{
		// Fields
		public static byte[] perm; // 0x00
	
		// Constructors
		public SimplexNoiseGenerator(); // 0x000000018036B6C0-0x000000018036B6D0
		static SimplexNoiseGenerator(); // 0x0000000181798630-0x0000000181798690
	
		// Methods
		public static float Generate(float x); // 0x00000001817973F0-0x0000000181797570
		public static float Generate(float x, float y); // 0x0000000181797ED0-0x0000000181798440
		public static float Generate(float x, float y, float z); // 0x0000000181797570-0x0000000181797ED0
		private static int FastFloor(float x); // 0x00000001817973E0-0x00000001817973F0
		private static int Mod(int x, int m); // 0x0000000181798610-0x0000000181798630
		private static float Grad(int hash, float x); // 0x00000001817984F0-0x0000000181798520
		private static float Grad(int hash, float x, float y); // 0x0000000181798570-0x00000001817985C0
		private static float Grad(int hash, float x, float y, float z); // 0x00000001817985C0-0x0000000181798610
		private static float Grad(int hash, float x, float y, float z, float t); // 0x0000000181798520-0x0000000181798570
		public static float GetNormalisedValue(float x, float y); // 0x0000000181798440-0x00000001817984F0
	}
}
