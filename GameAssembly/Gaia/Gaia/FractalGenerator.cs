/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class FractalGenerator // TypeDefIndex: 9245
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
		public float Seed { get; set; } // 0x0000000180373AA0-0x0000000180373AB0 0x0000000180373AB0-0x0000000180373AC0
		public int Octaves { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public float Persistence { get; set; } // 0x000000018049DFC0-0x000000018049DFD0 0x0000000180956BE0-0x0000000180956BF0
		public float Frequency { get; set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180918CF0-0x0000000180918D00
		public float Lacunarity { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180373B00-0x0000000180373B10
		public float XOffset { get; set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018094A6A0-0x000000018094A6B0
		public float ZOffset { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
		public float YOffset { get; set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50
		public Fractals FractalType { get; set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018150B710-0x000000018150B7B0
	
		// Nested types
		public enum Fractals // TypeDefIndex: 9246
		{
			Perlin = 0,
			Billow = 1,
			RidgeMulti = 2
		}
	
		private delegate float GetCalcValue(float x, float z); // TypeDefIndex: 9247; 0x000000018150D590-0x000000018150D8E0
	
		// Constructors
		public FractalGenerator(); // 0x000000018150B540-0x000000018150B5F0
		public FractalGenerator(float frequency, float lacunarity, int octaves, float persistance, float seed, Fractals type); // 0x000000018150B5F0-0x000000018150B710
	
		// Methods
		public void SetDefaults(); // 0x000000018150B440-0x000000018150B540
		public float GetValue(float x, float z); // 0x000000018150B420-0x000000018150B440
		public double GetValue(double x, double z); // 0x000000018150B3F0-0x000000018150B420
		public float GetNormalisedValue(float x, float z); // 0x000000018150AEC0-0x000000018150AF60
		public double GetNormalisedValue(double x, double z); // 0x000000018150AE10-0x000000018150AEC0
		public float GetValue_Perlin(float x, float z); // 0x000000018150B0F0-0x000000018150B210
		public float GetValue_Billow(float x, float z); // 0x000000018150AF60-0x000000018150B0F0
		public float GetValue_RidgedMulti(float x, float z); // 0x000000018150B210-0x000000018150B3F0
		private void CalcSpectralWeights(); // 0x000000018150AD10-0x000000018150AE10
	}
}
