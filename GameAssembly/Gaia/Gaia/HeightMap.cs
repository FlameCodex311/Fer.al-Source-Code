/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class HeightMap // TypeDefIndex: 9086
	{
		// Fields
		protected int m_widthX; // 0x10
		protected int m_depthZ; // 0x14
		protected float[,] m_heights; // 0x18
		protected bool m_isPowerOf2; // 0x20
		protected float m_widthInvX; // 0x24
		protected float m_depthInvZ; // 0x28
		protected float m_statMinVal; // 0x2C
		protected float m_statMaxVal; // 0x30
		protected double m_statSumVals; // 0x38
		protected bool m_isDirty; // 0x40
		protected byte[] m_metaData; // 0x48
		private const int LEFT = 0; // Metadata: 0x0074424B
		private const int RIGHT = 1; // Metadata: 0x0074424F
		private const int BOTTOM = 2; // Metadata: 0x00744253
		private const int TOP = 3; // Metadata: 0x00744257
		private const float TIME = 0.2f; // Metadata: 0x0074425B
	
		// Properties
		public float this[int x, int z] { get => default; set {} } // 0x000000018178EB20-0x000000018178EB90 0x000000018178EC40-0x000000018178ECB0
		public float this[float x, float z] { get => default; set {} } // 0x000000018178EB90-0x000000018178EBA0 0x000000018178EBA0-0x000000018178EC40
	
		// Nested types
		public enum CopyType // TypeDefIndex: 9087
		{
			AlwaysCopy = 0,
			CopyIfLessThan = 1,
			CopyIfGreaterThan = 2
		}
	
		// Constructors
		public HeightMap(); // 0x000000018178E5E0-0x000000018178E630
		public HeightMap(int width, int depth); // 0x000000018178E2B0-0x000000018178E3B0
		public HeightMap(float[,] source); // 0x000000018178E7F0-0x000000018178E940
		public HeightMap(float[,,] source, int slice); // 0x000000018178E630-0x000000018178E7F0
		public HeightMap(int[,] source); // 0x000000018178E3B0-0x000000018178E570
		public HeightMap(HeightMap source); // 0x000000018178E940-0x000000018178EAB0
		public HeightMap(string sourceFile); // 0x000000018178EAB0-0x000000018178EB20
		public HeightMap(byte[] sourceBytes); // 0x000000018178E570-0x000000018178E5E0
	
		// Methods
		public int Width(); // 0x000000018036CFF0-0x000000018036D000
		public int Depth(); // 0x0000000180372360-0x0000000180372370
		public float MinVal(); // 0x0000000180487D70-0x0000000180487D80
		public float MaxVal(); // 0x0000000180485990-0x00000001804859A0
		public double SumVal(); // 0x000000018178DC20-0x000000018178DC30
		public byte[] GetMetaData(); // 0x0000000180369C40-0x0000000180369C50
		public bool IsDirty(); // 0x0000000180478660-0x0000000180478670
		public void SetDirty(bool dirty = true /* Metadata: 0x00744246 */); // 0x00000001807009C0-0x00000001807009D0
		public void ClearDirty(); // 0x00000001816A79B0-0x00000001816A79C0
		public void SetMetaData(byte[] metadata); // 0x000000018178CBE0-0x000000018178CC60
		public float[,] Heights(); // 0x000000018038B150-0x000000018038B160
		public float[] Heights1D(); // 0x000000018178A900-0x000000018178A980
		public void SetHeights(float[] heights); // 0x000000018178CAF0-0x000000018178CBE0
		public void SetHeights(float[,] heights); // 0x000000018178C9F0-0x000000018178CAF0
		public float GetSafeHeight(int x, int z); // 0x000000018178A0F0-0x000000018178A180
		public void SetSafeHeight(int x, int z, float height); // 0x000000018178CD10-0x000000018178CDA0
		protected float GetInterpolatedHeight(float x, float z); // 0x0000000181789DD0-0x000000018178A010
		public HeightMap SetHeight(float height); // 0x000000018178C960-0x000000018178C9F0
		public void GetHeightRange(ref float minHeight, ref float maxHeight); // 0x0000000181789D30-0x0000000181789DD0
		public float GetSlope(int x, int z); // 0x000000018178A3C0-0x000000018178A580
		public float GetSlope(float x, float z); // 0x000000018178A580-0x000000018178A6E0
		public float GetSlope_a(float x, float z); // 0x000000018178A250-0x000000018178A3C0
		public float GetBaseLevel(); // 0x0000000181789A40-0x0000000181789C50
		public bool HasData(); // 0x000000018178A8A0-0x000000018178A900
		public float[] GetRow(int rowX); // 0x000000018178A010-0x000000018178A0F0
		public void SetRow(int rowX, float[] values); // 0x000000018178CC60-0x000000018178CD10
		public float[] GetColumn(int columnZ); // 0x0000000181789C50-0x0000000181789D30
		public void SetColumn(int columnZ, float[] values); // 0x000000018178C8B0-0x000000018178C960
		public void Reset(); // 0x000000018178C700-0x000000018178C780
		public void UpdateStats(); // 0x000000018178DCB0-0x000000018178DD50
		public HeightMap Smooth(int iterations); // 0x000000018178D5C0-0x000000018178D740
		public HeightMap SmoothRadius(int radius); // 0x000000018178D300-0x000000018178D5C0
		public HeightMap Convolve(float[,] kernel); // 0x0000000181786B80-0x0000000181786EB0
		public HeightMap DeNoise(int radius); // 0x00000001817878F0-0x0000000181787AA0
		public HeightMap GrowEdges(int radius); // 0x000000018178A6E0-0x000000018178A8A0
		public HeightMap ShrinkEdges(int radius); // 0x000000018178CDA0-0x000000018178CF60
		public HeightMap GetSlopeMap(); // 0x000000018178A180-0x000000018178A250
		public HeightMap Copy(HeightMap heightMap, CopyType copyType = CopyType.AlwaysCopy /* Metadata: 0x00744247 */); // 0x0000000181787050-0x0000000181787470
		public HeightMap CopyClamped(HeightMap heightMap, float min, float max); // 0x0000000181786EB0-0x0000000181787050
		public HeightMap Duplicate(); // 0x00000001817886C0-0x0000000181788720
		public HeightMap Invert(); // 0x000000018178AA40-0x000000018178AB00
		public HeightMap Flip(); // 0x0000000181789080-0x0000000181789200
		public HeightMap Normalise(); // 0x000000018178BF60-0x000000018178C090
		public HeightMap ErodeThermal(int iterations, float talusMin, float talusMax, HeightMap hardnessMask); // 0x0000000181788C80-0x0000000181788FF0
		public HeightMap Quantize(float divisor); // 0x000000018178C5E0-0x000000018178C700
		public HeightMap Quantize(float[] startHeights, AnimationCurve[] curves); // 0x000000018178C2E0-0x000000018178C5E0
		public HeightMap CurvatureMap(GaiaConstants.CurvatureType curvatureType); // 0x0000000181787470-0x00000001817878F0
		private float HorizontalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x000000018178A980-0x000000018178AA40
		private float VerticalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x000000018178E1F0-0x000000018178E2B0
		private float AverageCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x0000000181785BD0-0x0000000181785CC0
		public HeightMap Aspect(GaiaConstants.AspectType aspectType); // 0x0000000181785710-0x0000000181785BD0
		private float Sign(float v); // 0x000000018178CF60-0x000000018178CF80
		public HeightMap ErodeHydraulic(int iterations, HeightMap hardnessMap, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate, ref HeightMap sedimentMap); // 0x0000000181788720-0x0000000181788C80
		private void CalculateWaterOutflow(HeightMap heightMap, HeightMap waterMap, float[,,] outFlow); // 0x0000000181785FF0-0x0000000181786520
		private void UpdateWaterMap(HeightMap waterMap, float[,,] outFlow); // 0x000000018178DD50-0x000000018178DFB0
		public HeightMap FlowMap(int iterations); // 0x0000000181789200-0x0000000181789A40
		private void FillWaterMap(float amount, float[,] waterMap, int width, int height); // 0x0000000181788FF0-0x0000000181789080
		private void ComputeOutflow(float[,] waterMap, float[,,] outFlow, float[] heightMap, int width, int height); // 0x0000000181786520-0x0000000181786AB0
		private void UpdateWaterMap(float[,] waterMap, float[,,] outFlow, int width, int height); // 0x000000018178DFB0-0x000000018178E1F0
		private void CalculateVelocityField(float[,] velocityMap, float[,,] outFlow, int width, int height); // 0x0000000181785D50-0x0000000181785FF0
		private void NormalizeMap(float[,] map, int width, int height); // 0x000000018178C090-0x000000018178C1C0
		public HeightMap SlopeMap(); // 0x000000018178CF80-0x000000018178D300
		public HeightMap Add(float value); // 0x0000000181785690-0x0000000181785710
		public HeightMap Add(HeightMap heightMap); // 0x0000000181785520-0x0000000181785690
		public HeightMap AddClamped(float value, float min, float max); // 0x0000000181785240-0x0000000181785330
		public HeightMap AddClamped(HeightMap heightMap, float min, float max); // 0x0000000181785330-0x0000000181785520
		public HeightMap Subtract(float value); // 0x000000018178DBA0-0x000000018178DC20
		public HeightMap Subtract(HeightMap heightMap); // 0x000000018178DA30-0x000000018178DBA0
		public HeightMap SubtractClamped(float value, float min, float max); // 0x000000018178D940-0x000000018178DA30
		public HeightMap SubtractClamped(HeightMap heightMap, float min, float max); // 0x000000018178D740-0x000000018178D940
		public HeightMap Multiply(float value); // 0x000000018178BEE0-0x000000018178BF60
		public HeightMap Multiply(HeightMap heightMap); // 0x000000018178BD70-0x000000018178BEE0
		public HeightMap MultiplyClamped(float value, float min, float max); // 0x000000018178BA90-0x000000018178BB80
		public HeightMap MultiplyClamped(HeightMap heightMap, float min, float max); // 0x000000018178BB80-0x000000018178BD70
		public HeightMap Divide(float value); // 0x0000000181787F00-0x0000000181787F80
		public HeightMap Divide(HeightMap heightMap); // 0x0000000181787D90-0x0000000181787F00
		public HeightMap DivideClamped(float value, float min, float max); // 0x0000000181787AA0-0x0000000181787B90
		public HeightMap DivideClamped(HeightMap heightMap, float min, float max); // 0x0000000181787B90-0x0000000181787D90
		public HeightMap Lerp(HeightMap hmNewValues, HeightMap hmLerpMask); // 0x000000018178AB00-0x000000018178AFE0
		public float Sum(); // 0x000000018178DC30-0x000000018178DCB0
		public float Average(); // 0x0000000181785CC0-0x0000000181785D50
		public HeightMap Power(float exponent); // 0x000000018178C1C0-0x000000018178C2E0
		public HeightMap Contrast(float contrast); // 0x0000000181786AB0-0x0000000181786B80
		public void SaveToBinaryFile(string fileName); // 0x000000018178C780-0x000000018178C8B0
		public void LoadFromBinaryFile(string fileName); // 0x000000018178AFE0-0x000000018178B290
		public void LoadFromByteArray(byte[] source); // 0x000000018178B290-0x000000018178B520
		public void LoadFromRawFile(string fileName, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution); // 0x000000018178B520-0x000000018178BA90
		public void DumpMap(float scaleValue, int precision, string spacer, bool flip); // 0x0000000181788210-0x0000000181788430
		public void DumpRow(int rowX, float scaleValue, int precision, string spacer); // 0x0000000181788430-0x00000001817886C0
		public void DumpColumn(int columnZ, float scaleValue, int precision, string spacer); // 0x0000000181787F80-0x0000000181788210
	}
}
