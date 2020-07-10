/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FastNoise // TypeDefIndex: 13763
{
	// Fields
	private const short FN_INLINE = 256; // Metadata: 0x00784028
	private const int FN_CELLULAR_INDEX_MAX = 3; // Metadata: 0x0078402A
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
	private const int X_PRIME = 1619; // Metadata: 0x0078402E
	private const int Y_PRIME = 31337; // Metadata: 0x00784032
	private const int Z_PRIME = 6971; // Metadata: 0x00784036
	private const int W_PRIME = 1013; // Metadata: 0x0078403A
	private const float F3 = 0.33333334f; // Metadata: 0x0078403E
	private const float G3 = 0.16666667f; // Metadata: 0x00784042
	private const float G33 = -0.5f; // Metadata: 0x00784046
	private const float F2 = 0.5f; // Metadata: 0x0078404A
	private const float G2 = 0.25f; // Metadata: 0x0078404E
	private static readonly byte[] SIMPLEX_4D; // 0x20
	private const float F4 = 0.309017f; // Metadata: 0x00784052
	private const float G4 = 0.1381966f; // Metadata: 0x00784056
	private const float CUBIC_3D_BOUNDING = 0.2962963f; // Metadata: 0x0078405A
	private const float CUBIC_2D_BOUNDING = 0.44444445f; // Metadata: 0x0078405E

	// Nested types
	public enum NoiseType // TypeDefIndex: 13764
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

	public enum Interp // TypeDefIndex: 13765
	{
		Linear = 0,
		Hermite = 1,
		Quintic = 2
	}

	public enum FractalType // TypeDefIndex: 13766
	{
		FBM = 0,
		Billow = 1,
		RigidMulti = 2
	}

	public enum CellularDistanceFunction // TypeDefIndex: 13767
	{
		Euclidean = 0,
		Manhattan = 1,
		Natural = 2
	}

	public enum CellularReturnType // TypeDefIndex: 13768
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

	private struct Float2 // TypeDefIndex: 13769
	{
		// Fields
		public readonly float x; // 0x00
		public readonly float y; // 0x04

		// Constructors
		public Float2(float x, float y); // 0x00000001800103E0-0x00000001800103F0
	}

	private struct Float3 // TypeDefIndex: 13770
	{
		// Fields
		public readonly float x; // 0x00
		public readonly float y; // 0x04
		public readonly float z; // 0x08

		// Constructors
		public Float3(float x, float y, float z); // 0x0000000180010720-0x0000000180010730
	}

	// Constructors
	public FastNoise(int seed = 1337 /* Metadata: 0x00784024 */); // 0x00000001814A67F0-0x00000001814A68A0
	static FastNoise(); // 0x000000018149E0B0-0x00000001814A67F0

	// Methods
	public static float GetDecimalType(); // 0x0000000180DD1F20-0x0000000180DD1F30
	public int GetSeed(); // 0x000000018036CFF0-0x000000018036D000
	public void SetSeed(int seed); // 0x000000018037AA40-0x000000018037AA50
	public void SetFrequency(float frequency); // 0x00000001805C1F50-0x00000001805C1F60
	public void SetInterp(Interp interp); // 0x000000018036B1F0-0x000000018036B200
	public void SetNoiseType(NoiseType noiseType); // 0x000000018037E600-0x000000018037E610
	public void SetFractalOctaves(int octaves); // 0x0000000181494B00-0x0000000181494B40
	public void SetFractalLacunarity(float lacunarity); // 0x00000001811F74C0-0x00000001811F74D0
	public void SetFractalGain(float gain); // 0x0000000181494AC0-0x0000000181494B00
	public void SetFractalType(FractalType fractalType); // 0x000000018036B760-0x000000018036B770
	public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction); // 0x000000018036C610-0x000000018036C620
	public void SetCellularReturnType(CellularReturnType cellularReturnType); // 0x000000018036C620-0x000000018036C630
	public void SetCellularDistance2Indicies(int cellularDistanceIndex0, int cellularDistanceIndex1); // 0x0000000181494A00-0x0000000181494AC0
	public void SetCellularJitter(float cellularJitter); // 0x0000000180DD2D90-0x0000000180DD2DA0
	public void SetCellularNoiseLookup(FastNoise noise); // 0x00000001803A2810-0x00000001803A2820
	public void SetGradientPerturbAmp(float gradientPerturbAmp); // 0x0000000180DD2D30-0x0000000180DD2D40
	private static int FastFloor(float f); // 0x0000000181492C30-0x0000000181492C40
	private static int FastRound(float f); // 0x0000000181492C40-0x0000000181492C70
	private static float Lerp(float a, float b, float t); // 0x00000001814949F0-0x0000000181494A00
	private static float InterpHermiteFunc(float t); // 0x0000000181494980-0x00000001814949B0
	private static float InterpQuinticFunc(float t); // 0x00000001814949B0-0x00000001814949F0
	private static float CubicLerp(float a, float b, float c, float d, float t); // 0x0000000181492BD0-0x0000000181492C30
	private void CalculateFractalBounding(); // 0x0000000181492B90-0x0000000181492BD0
	private static int Hash2D(int seed, int x, int y); // 0x00000001814948C0-0x00000001814948F0
	private static int Hash3D(int seed, int x, int y, int z); // 0x00000001814948F0-0x0000000181494930
	private static int Hash4D(int seed, int x, int y, int z, int w); // 0x0000000181494930-0x0000000181494980
	private static float ValCoord2D(int seed, int x, int y); // 0x000000018149DFE0-0x000000018149E020
	private static float ValCoord3D(int seed, int x, int y, int z); // 0x000000018149E020-0x000000018149E060
	private static float ValCoord4D(int seed, int x, int y, int z, int w); // 0x000000018149E060-0x000000018149E0B0
	private static float GradCoord2D(int seed, int x, int y, float xd, float yd); // 0x00000001814941C0-0x00000001814943A0
	private static float GradCoord3D(int seed, int x, int y, int z, float xd, float yd, float zd); // 0x00000001814943A0-0x00000001814945E0
	private static float GradCoord4D(int seed, int x, int y, int z, int w, float xd, float yd, float zd, float wd); // 0x00000001814945E0-0x00000001814946A0
	public float GetNoise(float x, float y, float z); // 0x0000000181492E40-0x00000001814932F0
	public float GetNoise(float x, float y); // 0x00000001814932F0-0x0000000181493750
	private int FloatCast2Int(float f); // 0x0000000181492C70-0x0000000181492CE0
	public float GetWhiteNoise(float x, float y, float z, float w); // 0x0000000181493C90-0x0000000181493EB0
	public float GetWhiteNoise(float x, float y, float z); // 0x0000000181494000-0x00000001814941C0
	public float GetWhiteNoise(float x, float y); // 0x0000000181493EB0-0x0000000181494000
	public float GetWhiteNoiseInt(int x, int y, int z, int w); // 0x0000000181493BE0-0x0000000181493C90
	public float GetWhiteNoiseInt(int x, int y, int z); // 0x0000000181493B30-0x0000000181493BE0
	public float GetWhiteNoiseInt(int x, int y); // 0x0000000181493AA0-0x0000000181493B30
	public float GetValueFractal(float x, float y, float z); // 0x00000001814939E0-0x0000000181493A30
	private float SingleValueFractalFBM(float x, float y, float z); // 0x000000018149D450-0x000000018149D550
	private float SingleValueFractalBillow(float x, float y, float z); // 0x000000018149D020-0x000000018149D1E0
	private float SingleValueFractalRigidMulti(float x, float y, float z); // 0x000000018149D6D0-0x000000018149D870
	public float GetValue(float x, float y, float z); // 0x0000000181493A60-0x0000000181493AA0
	private float SingleValue(int seed, float x, float y, float z); // 0x000000018149DB70-0x000000018149DFE0
	public float GetValueFractal(float x, float y); // 0x00000001814939A0-0x00000001814939E0
	private float SingleValueFractalFBM(float x, float y); // 0x000000018149D380-0x000000018149D450
	private float SingleValueFractalBillow(float x, float y); // 0x000000018149D1E0-0x000000018149D380
	private float SingleValueFractalRigidMulti(float x, float y); // 0x000000018149D550-0x000000018149D6D0
	public float GetValue(float x, float y); // 0x0000000181493A30-0x0000000181493A60
	private float SingleValue(int seed, float x, float y); // 0x000000018149D870-0x000000018149DB70
	public float GetPerlinFractal(float x, float y, float z); // 0x0000000181493790-0x00000001814937E0
	private float SinglePerlinFractalFBM(float x, float y, float z); // 0x000000018149A420-0x000000018149A520
	private float SinglePerlinFractalBillow(float x, float y, float z); // 0x000000018149A260-0x000000018149A420
	private float SinglePerlinFractalRigidMulti(float x, float y, float z); // 0x000000018149A5F0-0x000000018149A790
	public float GetPerlin(float x, float y, float z); // 0x0000000181493810-0x0000000181493850
	private float SinglePerlin(int seed, float x, float y, float z); // 0x000000018149AC30-0x000000018149B1A0
	public float GetPerlinFractal(float x, float y); // 0x0000000181493750-0x0000000181493790
	private float SinglePerlinFractalFBM(float x, float y); // 0x000000018149A520-0x000000018149A5F0
	private float SinglePerlinFractalBillow(float x, float y); // 0x000000018149A0C0-0x000000018149A260
	private float SinglePerlinFractalRigidMulti(float x, float y); // 0x000000018149A790-0x000000018149A910
	public float GetPerlin(float x, float y); // 0x00000001814937E0-0x0000000181493810
	private float SinglePerlin(int seed, float x, float y); // 0x000000018149A910-0x000000018149AC30
	public float GetSimplexFractal(float x, float y, float z); // 0x0000000181493890-0x00000001814938E0
	private float SingleSimplexFractalFBM(float x, float y, float z); // 0x000000018149B500-0x000000018149B600
	private float SingleSimplexFractalBillow(float x, float y, float z); // 0x000000018149B340-0x000000018149B500
	private float SingleSimplexFractalRigidMulti(float x, float y, float z); // 0x000000018149B6D0-0x000000018149B870
	public float GetSimplex(float x, float y, float z); // 0x0000000181493960-0x00000001814939A0
	private float SingleSimplex(int seed, float x, float y, float z); // 0x000000018149CA80-0x000000018149D020
	public float GetSimplexFractal(float x, float y); // 0x0000000181493850-0x0000000181493890
	private float SingleSimplexFractalFBM(float x, float y); // 0x000000018149B600-0x000000018149B6D0
	private float SingleSimplexFractalBillow(float x, float y); // 0x000000018149B1A0-0x000000018149B340
	private float SingleSimplexFractalRigidMulti(float x, float y); // 0x000000018149B870-0x000000018149B9F0
	public float GetSimplex(float x, float y); // 0x0000000181493930-0x0000000181493960
	private float SingleSimplex(int seed, float x, float y); // 0x000000018149C740-0x000000018149CA80
	public float GetSimplex(float x, float y, float z, float w); // 0x00000001814938E0-0x0000000181493930
	private float SingleSimplex(int seed, float x, float y, float z, float w); // 0x000000018149B9F0-0x000000018149C740
	public float GetCubicFractal(float x, float y, float z); // 0x0000000181492D80-0x0000000181492DD0
	private float SingleCubicFractalFBM(float x, float y, float z); // 0x0000000181497B00-0x0000000181497C00
	private float SingleCubicFractalBillow(float x, float y, float z); // 0x0000000181497870-0x0000000181497A30
	private float SingleCubicFractalRigidMulti(float x, float y, float z); // 0x0000000181497C00-0x0000000181497DA0
	public float GetCubic(float x, float y, float z); // 0x0000000181492DD0-0x0000000181492E10
	private float SingleCubic(int seed, float x, float y, float z); // 0x0000000181497F20-0x0000000181498F00
	public float GetCubicFractal(float x, float y); // 0x0000000181492D40-0x0000000181492D80
	private float SingleCubicFractalFBM(float x, float y); // 0x0000000181497A30-0x0000000181497B00
	private float SingleCubicFractalBillow(float x, float y); // 0x00000001814976D0-0x0000000181497870
	private float SingleCubicFractalRigidMulti(float x, float y); // 0x0000000181497DA0-0x0000000181497F20
	public float GetCubic(float x, float y); // 0x0000000181492E10-0x0000000181492E40
	private float SingleCubic(int seed, float x, float y); // 0x0000000181498F00-0x00000001814993C0
	public float GetCellular(float x, float y, float z); // 0x0000000181492CE0-0x0000000181492D20
	private float SingleCellular(float x, float y, float z); // 0x0000000181496D00-0x00000001814976D0
	private float SingleCellular2Edge(float x, float y, float z); // 0x0000000181494B40-0x00000001814959B0
	public float GetCellular(float x, float y); // 0x0000000181492D20-0x0000000181492D40
	private float SingleCellular(float x, float y); // 0x00000001814965D0-0x0000000181496D00
	private float SingleCellular2Edge(float x, float y); // 0x00000001814959B0-0x00000001814965D0
	public void GradientPerturb(ref float x, ref float y, ref float z); // 0x0000000181494850-0x0000000181494890
	public void GradientPerturbFractal(ref float x, ref float y, ref float z); // 0x0000000181494770-0x0000000181494850
	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y, ref float z); // 0x00000001814993C0-0x0000000181499C30
	public void GradientPerturb(ref float x, ref float y); // 0x0000000181494890-0x00000001814948C0
	public void GradientPerturbFractal(ref float x, ref float y); // 0x00000001814946A0-0x0000000181494770
	private void SingleGradientPerturb(int seed, float perturbAmp, float frequency, ref float x, ref float y); // 0x0000000181499C30-0x000000018149A0C0
}

