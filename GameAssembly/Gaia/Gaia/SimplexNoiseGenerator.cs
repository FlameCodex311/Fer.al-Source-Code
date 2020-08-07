/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class SimplexNoiseGenerator // TypeDefIndex: 9259
	{
		// Fields
		public static byte[] perm; // 0x00
	
		// Constructors
		public SimplexNoiseGenerator(); // 0x0000000180373240-0x0000000180373250
		static SimplexNoiseGenerator(); // 0x0000000181561070-0x00000001815610D0
	
		// Methods
		public static float Generate(float x); // 0x000000018155FEA0-0x0000000181560010
		public static float Generate(float x, float y); // 0x0000000181560930-0x0000000181560E80
		public static float Generate(float x, float y, float z); // 0x0000000181560010-0x0000000181560930
		private static int FastFloor(float x); // 0x000000018155FE90-0x000000018155FEA0
		private static int Mod(int x, int m); // 0x0000000181561050-0x0000000181561070
		private static float Grad(int hash, float x); // 0x0000000181560F30-0x0000000181560F60
		private static float Grad(int hash, float x, float y); // 0x0000000181560FB0-0x0000000181561000
		private static float Grad(int hash, float x, float y, float z); // 0x0000000181561000-0x0000000181561050
		private static float Grad(int hash, float x, float y, float z, float t); // 0x0000000181560F60-0x0000000181560FB0
		public static float GetNormalisedValue(float x, float y); // 0x0000000181560E80-0x0000000181560F30
	}
}
