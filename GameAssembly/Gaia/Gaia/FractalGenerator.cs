/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class FractalGenerator // TypeDefIndex: 9079
	{
		// Fields
		private float m_seed; // 0x10
		private int m_octaves; // 0x14
		private float m_persistence; // 0x18
		private float m_frequency; // 0x1C
		private float m_lacunarity; // 0x20
		private float m_XOffset; // 0x24
		private float m_ZOffset; // 0x28
		private float m_YOffset; // 0x2C
		private Fractals m_fractalType; // 0x30
		private float[] m_spectralWeights; // 0x38
		private GetCalcValue m_noiseCalculator; // 0x40
	
		// Properties
		public float Seed { get; set; } // 0x0000000180493360-0x0000000180493370 0x0000000180BD7F10-0x0000000180BD7F20
		public int Octaves { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		public float Persistence { get; set; } // 0x00000001805D9080-0x00000001805D9090 0x00000001805D90C0-0x00000001805D90D0
		public float Frequency { get; set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001805D90A0-0x00000001805D90B0
		public float Lacunarity { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x00000001805D9090-0x00000001805D90A0
		public float XOffset { get; set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001811F74C0-0x00000001811F74D0
		public float ZOffset { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
		public float YOffset { get; set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0
		public Fractals FractalType { get; set; } // 0x000000018043DDC0-0x000000018043DDD0 0x00000001818E4420-0x00000001818E44C0
	
		// Nested types
		public enum Fractals // TypeDefIndex: 9080
		{
			Perlin = 0,
			Billow = 1,
			RidgeMulti = 2
		}
	
		private delegate float GetCalcValue(float x, float z); // TypeDefIndex: 9081; 0x00000001818E65A0-0x00000001818E6890
	
		// Constructors
		public FractalGenerator(); // 0x00000001818E4250-0x00000001818E4300
		public FractalGenerator(float frequency, float lacunarity, int octaves, float persistance, float seed, Fractals type); // 0x00000001818E4300-0x00000001818E4420
	
		// Methods
		public void SetDefaults(); // 0x00000001818E4150-0x00000001818E4250
		public float GetValue(float x, float z); // 0x00000001818E4130-0x00000001818E4150
		public double GetValue(double x, double z); // 0x00000001818E4100-0x00000001818E4130
		public float GetNormalisedValue(float x, float z); // 0x00000001818E3BC0-0x00000001818E3C60
		public double GetNormalisedValue(double x, double z); // 0x00000001818E3B10-0x00000001818E3BC0
		public float GetValue_Perlin(float x, float z); // 0x00000001818E3DF0-0x00000001818E3F10
		public float GetValue_Billow(float x, float z); // 0x00000001818E3C60-0x00000001818E3DF0
		public float GetValue_RidgedMulti(float x, float z); // 0x00000001818E3F10-0x00000001818E4100
		private void CalcSpectralWeights(); // 0x00000001818E3A00-0x00000001818E3B10
	}
}
