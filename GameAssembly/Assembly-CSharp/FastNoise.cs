/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FastNoise // TypeDefIndex: 11436
{
	// Fields
	private const short FN_INLINE = 256; // Metadata: 0x0077CAE7
	private const int FN_CELLULAR_INDEX_MAX = 3; // Metadata: 0x0077CAE9
	private int m_seed; // 0x10
	private float m_frequency; // 0x14
	private Interp m_interp; // 0x18
	private NoiseType m_noiseType; // 0x1C
	private int m_octaves; // 0x20
	private float m_lacunarity; // 0x24
	private float m_gain; // 0x28
	private FractalType m_fractalType; // 0x2C
	private float m_fractalBounding; // 0x30
	private CellularDistanceFunction m_cellularDistanceFunction; // 0x34
	private CellularReturnType m_cellularReturnType; // 0x38
	private FastNoise m_cellularNoiseLookup; // 0x40
	private int m_cellularDistanceIndex0; // 0x48
	private int m_cellularDistanceIndex1; // 0x4C
	private float m_cellularJitter; // 0x50
	private float m_gradientPerturbAmp; // 0x54
	private static readonly Float2[] GRAD_2D; // 0x00
	private static readonly Float3[] GRAD_3D; // 0x08
	private static readonly Float2[] CELL_2D; // 0x10
	private static readonly Float3[] CELL_3D; // 0x18
	private const int X_PRIME = 1619; // Metadata: 0x0077CAED
	private const int Y_PRIME = 31337; // Metadata: 0x0077CAF1
	private const int Z_PRIME = 6971; // Metadata: 0x0077CAF5
	private const int W_PRIME = 1013; // Metadata: 0x0077CAF9
	private const float F3 = 0.33333334f; // Metadata: 0x0077CAFD
	private const float G3 = 0.16666667f; // Metadata: 0x0077CB01
	private const float G33 = -0.5f; // Metadata: 0x0077CB05
	private const float F2 = 0.5f; // Metadata: 0x0077CB09
	private const float G2 = 0.25f; // Metadata: 0x0077CB0D
	private static readonly byte[] SIMPLEX_4D; // 0x20
	private const float F4 = 0.309017f; // Metadata: 0x0077CB11
	private const float G4 = 0.1381966f; // Metadata: 0x0077CB15
	private const float CUBIC_3D_BOUNDING = 0.2962963f; // Metadata: 0x0077CB19
	private const float CUBIC_2D_BOUNDING = 0.44444445f; // Metadata: 0x0077CB1D

	// Nested types
	public enum NoiseType // TypeDefIndex: 11437
	{
		Value = 0,
		ValueFractal = 1,
		Perlin = 2,
		PerlinFractal = 3,
		Simplex = 4,
		SimplexFractal = 5,
		Cellular = 6,
		WhiteNoise = 7,
		Cubic = 8,
		CubicFractal = 9
	}

	public enum Interp // TypeDefIndex: 11438
	{
		Linear = 0,
		Hermite = 1,
		Quintic = 2
	}

	public enum FractalType // TypeDefIndex: 11439
	{
		FBM = 0,
		Billow = 1,
		RigidMulti = 2
	}

	public enum CellularDistanceFunction // TypeDefIndex: 11440
	{
		Euclidean = 0,
		Manhattan = 1,
		Natural = 2
	}

	public enum CellularReturnType // TypeDefIndex: 11441
	{
		CellValue = 0,
		NoiseLookup = 1,
		Distance = 2,
		Distance2 = 3,
		Distance2Add = 4,
		Distance2Sub = 5,
		Distance2Mul = 6,
		Distance2Div = 7
	}

	private struct Float2 // TypeDefIndex: 11442
	{
		// Fields
		public readonly float x; // 0x00
		public readonly float y; // 0x04

		// Constructors
		public Float2(float x, float y); // 0x00000001800A1C30-0x00000001800A1C40
	}

	private struct Float3 // TypeDefIndex: 11443
	{
		// Fields
		public readonly float x; // 0x00
		public readonly float y; // 0x04
		public readonly float z; // 0x08

		// Constructors
		public Float3(float x, float y, float z); // 0x00000001800A1C40-0x00000001800A1C90
	}

	// Constructors
	public FastNoise(int seed = 1337 /* Metadata: 0x0077CAE3 */); // 0x0000000180E35AA0-0x0000000180E35B50
	static FastNoise(); // 0x0000000180E2DAF0-0x0000000180E35AA0

	// Methods
	public static float GetDecimalType(); // 0x000000018058C7E0-0x000000018058C7F0
	public int GetSeed(); // 0x0000000180387590-0x0000000180387930
	public void SetSeed(int seed); // 0x00000001803FEB70-0x00000001803FEB80
	public void SetFrequency(float frequency); // 0x000000018094A330-0x000000018094A340
	public void SetInterp(Interp interp); // 0x00000001803F46C0-0x00000001803F46D0
	public void SetNoiseType(NoiseType noiseType); // 0x000000018042D0F0-0x000000018042D100
	public void SetFractalOctaves(int octaves); // 0x0000000180E24690-0x0000000180E246D0
	public void SetFractalLacunarity(float lacunarity); // 0x000000018094A6A0-0x000000018094A6B0
	public void SetFractalGain(float gain); // 0x0000000180E24650-0x0000000180E24690
	public void SetFractalType(FractalType fractalType); // 0x000000018041A370-0x000000018041A380
	public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction); // 0x000000018041B180-0x000000018041B190
	public void SetCellularReturnType(CellularReturnType cellularReturnType); // 0x000000018041B190-0x000000018041B1A0
	public void SetCellularDistance2Indicies(int cellularDistanceIndex0, int cellularDistanceIndex1); // 0x0000000180E24590-0x0000000180E24650
	public void SetCellularJitter(float cellularJitter); // 0x00000001807E32A0-0x00000001807E32B0
	public void SetCellularNoiseLookup(FastNoise noise); // 0x00000001804CD6C0-0x00000001804CD6D0
	public void SetGradientPerturbAmp(float gradientPerturbAmp); // 0x0000000180A506C0-0x0000000180A506D0
	private static int FastFloor(float f); // 0x0000000180E227E0-0x0000000180E227F0
	private static int FastRound(float f); // 0x0000000180E227F0-0x0000000180E22820
	private static float Lerp(float a, float b, float t); // 0x0000000180E24580-0x0000000180E24590
	private static float InterpHermiteFunc(float t); // 0x0000000180E24510-0x0000000180E24540
	private static float InterpQuinticFunc(float t); // 0x0000000180E24540-0x0000000180E24580
	private static float CubicLerp(float a, float b, float c, float d, float t); // 0x0000000180E22780-0x0000000180E227E0
	private void CalculateFractalBounding(); // 0x0000000180E22740-0x0000000180E22780
	private static int Hash2D(int seed, int x, int y); // 0x0000000180E24450-0x0000000180E24480
	private static int Hash3D(int seed, int x, int y, int z); // 0x0000000180E24480-0x0000000180E244C0
	private static int Hash4D(int seed, int x, int y, int z, int w); // 0x0000000180E244C0-0x0000000180E24510
	private static float ValCoord2D(int seed, int x, int y); // 0x0000000180E2DA20-0x0000000180E2DA60
	private static float ValCoord3D(int seed, int x, int y, int z); // 0x0000000180E2DA60-0x0000000180E2DAA0
	private static float ValCoord4D(int seed, int x, int y, int z, int w); // 0x0000000180E2DAA0-0x0000000180E2DAF0
	private static float GradCoord2D(int seed, int x, int y, float xd, float yd); // 0x0000000180E23D70-0x0000000180E23F50
	private static float GradCoord3D(int seed, int x, int y, int z, float xd, float yd, float zd); // 0x0000000180E23F50-0x0000000180E24170
	private static float GradCoord4D(int seed, int x, int y, int z, int w, float xd, float yd, float zd, float wd); // 0x0000000180E24170-0x0000000180E24230
	public float GetNoise(float x, float y, float z); // 0x0000000180E229F0-0x0000000180E22EA0
	public float GetNoise(float x, float y); // 0x0000000180E22EA0-0x0000000180E23300
	private int FloatCast2Int(float f); // 0x0000000180E22820-0x0000000180E22890
	public float GetWhiteNoise(float x, float y, float z, float w); // 0x0000000180E23840-0x0000000180E23A60
	public float GetWhiteNoise(float x, float y, float z); // 0x0000000180E23BB0-0x0000000180E23D70
	public float GetWhiteNoise(float x, float y); // 0x0000000180E23A60-0x0000000180E23BB0
	public float GetWhiteNoiseInt(int x, int y, int z, int w); // 0x0000000180E23790-0x0000000180E23840
	public float GetWhiteNoiseInt(int x, int y, int z); // 0x0000000180E236E0-0x0000000180E23790
	public float GetWhiteNoiseInt(int x, int y); // 0x0000000180E23650-0x0000000180E236E0
	public float GetValueFractal(float x, float y, float z); // 0x0000000180E23590-0x0000000180E235E0
	private float SingleValueFractalFBM(float x, float y, float z); // 0x0000000180E2CE90-0x0000000180E2CF90
	private float SingleValueFractalBillow(float x, float y, float z); // 0x0000000180E2CA60-0x0000000180E2CC20
	private float SingleValueFractalRigidMulti(float x, float y, float z); // 0x0000000180E2D110-0x0000000180E2D2B0
	public float GetValue(float x, float y, float z); // 0x0000000180E23610-0x0000000180E23650
	private float SingleValue(int seed, float x, float y, float z); // 0x0000000180E2D5B0-0x0000000180E2DA20
	public float GetValueFractal(float x, float y); // 0x0000000180E23550-0x0000000180E23590
	private float SingleValueFractalFBM(float x, float y); // 0x0000000180E2CDC0-0x0000000180E2CE90
	private float SingleValueFractalBillow(float x, float y); // 0x0000000180E2CC20-0x0000000180E2CDC0
	private float SingleValueFractalRigidMulti(float x, float y); // 0x0000000180E2CF90-0x0000000180E2D110
	public float GetValue(float x, float y); // 0x0000000180E235E0-0x0000000180E23610
	private float SingleValue(int seed, float x, float y); // 0x0000000180E2D2B0-0x0000000180E2D5B0
	public float GetPerlinFractal(float x, float y, float z); // 0x0000000180E23340-0x0000000180E23390
	private float SinglePerlinFractalFBM(float x, float y, float z); // 0x0000000180E29E80-0x0000000180E29F80
	private float SinglePerlinFractalBillow(float x, float y, float z); // 0x0000000180E29CC0-0x0000000180E29E80
	private float SinglePerlinFractalRigidMulti(float x, float y, float z); // 0x0000000180E2A050-0x0000000180E2A1F0
	public float GetPerlin(float x, float y, float z); // 0x0000000180E233C0-0x0000000180E23400
	private float SinglePerlin(int seed, float x, float y, float z); // 0x0000000180E2A690-0x0000000180E2AC00
	public float GetPerlinFractal(float x, float y); // 0x0000000180E23300-0x0000000180E23340
	private float SinglePerlinFractalFBM(float x, float y); // 0x0000000180E29F80-0x0000000180E2A050
	private float SinglePerlinFractalBillow(float x, float y); // 0x0000000180E29B20-0x0000000180E29CC0
	private float SinglePerlinFractalRigidMulti(float x, float y); // 0x0000000180E2A1F0-0x0000000180E2A370
	public float GetPerlin(float x, float y); // 0x0000000180E23390-0x0000000180E233C0
	private float SinglePerlin(int seed, float x, float y); // 0x0000000180E2A370-0x0000000180E2A690
	public float GetSimplexFractal(float x, float y, float z); // 0x0000000180E23440-0x0000000180E23490
	private float SingleSimplexFractalFBM(float x, float y, float z); // 0x0000000180E2AF60-0x0000000180E2B060
	private float SingleSimplexFractalBillow(float x, float y, float z); // 0x0000000180E2ADA0-0x0000000180E2AF60
	private float SingleSimplexFractalRigidMulti(float x, float y, float z); // 0x0000000180E2B130-0x0000000180E2B2D0
	public float GetSimplex(float x, float y, float z); // 0x0000000180E23510-0x0000000180E23550
	private float SingleSimplex(int seed, float x, float y, float z); // 0x0000000180E2C4C0-0x0000000180E2CA60
	public float GetSimplexFractal(float x, float y); // 0x0000000180E23400-0x0000000180E23440
	private float SingleSimplexFractalFBM(float x, float y); // 0x0000000180E2B060-0x0000000180E2B130
	private float SingleSimplexFractalBillow(float x, float y); // 0x0000000180E2AC00-0x0000000180E2ADA0
	private float SingleSimplexFractalRigidMulti(float x, float y); // 0x0000000180E2B2D0-0x0000000180E2B450
	public float GetSimplex(float x, float y); // 0x0000000180E234E0-0x0000000180E23510
	private float SingleSimplex(int seed, float x, float y); // 0x0000000180E2C180-0x0000000180E2C4C0
	public float GetSimplex(float x, float y, float z, float w); // 0x0000000180E23490-0x0000000180E234E0
	private float SingleSimplex(int seed, float x, float y, float z, float w); // 0x0000000180E2B450-0x0000000180E2C180
	public float GetCubicFractal(float x, float y, float z); // 0x0000000180E22930-0x0000000180E22980
	private float SingleCubicFractalFBM(float x, float y, float z); // 0x0000000180E275A0-0x0000000180E276A0
	private float SingleCubicFractalBillow(float x, float y, float z); // 0x0000000180E27310-0x0000000180E274D0
	private float SingleCubicFractalRigidMulti(float x, float y, float z); // 0x0000000180E276A0-0x0000000180E27840
	public float GetCubic(float x, float y, float z); // 0x0000000180E22980-0x0000000180E229C0
	private float SingleCubic(int seed, float x, float y, float z); // 0x0000000180E279C0-0x0000000180E289A0
	public float GetCubicFractal(float x, float y); // 0x0000000180E228F0-0x0000000180E22930
	private float SingleCubicFractalFBM(float x, float y); // 0x0000000180E274D0-0x0000000180E275A0
	private float SingleCubicFractalBillow(float x, float y); // 0x0000000180E27170-0x0000000180E27310
	private float SingleCubicFractalRigidMulti(float x, float y); // 0x0000000180E27840-0x0000000180E279C0
	public float GetCubic(float x, float y); // 0x0000000180E229C0-0x0000000180E229F0
	private float SingleCubic(int seed, float x, float y); // 0x0000000180E289A0-0x0000000180E28E60
	public float GetCellular(float x, float y, float z); // 0x0000000180E22890-0x0000000180E228D0
	private float SingleCellular(float x, float y, float z); // 0x0000000180E267B0-0x0000000180E27170
	private float SingleCellular2Edge(float x, float y, float z); // 0x0000000180E246D0-0x0000000180E254E0
	public float GetCellular(float x, float y); // 0x0000000180E228D0-0x0000000180E228F0
	private float SingleCellular(float x, float y); // 0x0000000180E26090-0x0000000180E267B0
	private float SingleCellular2Edge(float x, float y); // 0x0000000180E254E0-0x0000000180E26090
	public void GradientPerturb(ref float x, ref float y, ref float z); // 0x0000000180E243E0-0x0000000180E24420
	public void GradientPerturbFractal(ref float x, ref float y, ref float z); // 0x0000000180E24300-0x0000000180E243E0
	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y, ref float z); // 0x0000000180E28E60-0x0000000180E296A0
	public void GradientPerturb(ref float x, ref float y); // 0x0000000180E24420-0x0000000180E24450
	public void GradientPerturbFractal(ref float x, ref float y); // 0x0000000180E24230-0x0000000180E24300
	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y); // 0x0000000180E296A0-0x0000000180E29B20
}

