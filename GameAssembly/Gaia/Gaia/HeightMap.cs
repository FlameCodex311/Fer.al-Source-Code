/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class HeightMap // TypeDefIndex: 9252
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
		private const int LEFT = 0; // Metadata: 0x00778F39
		private const int RIGHT = 1; // Metadata: 0x00778F3D
		private const int BOTTOM = 2; // Metadata: 0x00778F41
		private const int TOP = 3; // Metadata: 0x00778F45
		private const float TIME = 0.2f; // Metadata: 0x00778F49
	
		// Properties
		public float this[int x, int z] { get => default; set {} } // 0x00000001819A3630-0x00000001819A3690 0x00000001819A3740-0x00000001819A37B0
		public float this[float x, float z] { get => default; set {} } // 0x00000001819A3690-0x00000001819A36A0 0x00000001819A36A0-0x00000001819A3740
	
		// Nested types
		public enum CopyType // TypeDefIndex: 9253
		{
			AlwaysCopy = 0,
			CopyIfLessThan = 1,
			CopyIfGreaterThan = 2
		}
	
		// Constructors
		public HeightMap(); // 0x00000001819A30F0-0x00000001819A3140
		public HeightMap(int width, int depth); // 0x00000001819A2DD0-0x00000001819A2ED0
		public HeightMap(float[,] source); // 0x00000001819A3300-0x00000001819A3450
		public HeightMap(float[,,] source, int slice); // 0x00000001819A3140-0x00000001819A3300
		public HeightMap(int[,] source); // 0x00000001819A2ED0-0x00000001819A3080
		public HeightMap(HeightMap source); // 0x00000001819A3450-0x00000001819A35C0
		public HeightMap(string sourceFile); // 0x00000001819A35C0-0x00000001819A3630
		public HeightMap(byte[] sourceBytes); // 0x00000001819A3080-0x00000001819A30F0
	
		// Methods
		public int Width(); // 0x0000000180387590-0x0000000180387930
		public int Depth(); // 0x00000001803FD2F0-0x00000001803FD300
		public float MinVal(); // 0x00000001807DDA30-0x00000001807DDA40
		public float MaxVal(); // 0x00000001806757B0-0x00000001806757C0
		public double SumVal(); // 0x00000001819A2740-0x00000001819A2750
		public byte[] GetMetaData(); // 0x00000001803743E0-0x00000001803743F0
		public bool IsDirty(); // 0x0000000180455BA0-0x0000000180455BB0
		public void SetDirty(bool dirty = true /* Metadata: 0x00778F34 */); // 0x0000000180455C20-0x0000000180455C30
		public void ClearDirty(); // 0x0000000180DFE4B0-0x0000000180DFE4C0
		public void SetMetaData(byte[] metadata); // 0x00000001819A1710-0x00000001819A1790
		public float[,] Heights(); // 0x0000000180372430-0x0000000180372440
		public float[] Heights1D(); // 0x000000018199F4A0-0x000000018199F520
		public void SetHeights(float[] heights); // 0x00000001819A1620-0x00000001819A1710
		public void SetHeights(float[,] heights); // 0x00000001819A1520-0x00000001819A1620
		public float GetSafeHeight(int x, int z); // 0x000000018199ECA0-0x000000018199ED30
		public void SetSafeHeight(int x, int z, float height); // 0x00000001819A1830-0x00000001819A18C0
		protected float GetInterpolatedHeight(float x, float z); // 0x000000018199E9A0-0x000000018199EBC0
		public HeightMap SetHeight(float height); // 0x00000001819A1490-0x00000001819A1520
		public void GetHeightRange(ref float minHeight, ref float maxHeight); // 0x000000018199E900-0x000000018199E9A0
		public float GetSlope(int x, int z); // 0x000000018199EF70-0x000000018199F120
		public float GetSlope(float x, float z); // 0x000000018199F120-0x000000018199F280
		public float GetSlope_a(float x, float z); // 0x000000018199EE00-0x000000018199EF70
		public float GetBaseLevel(); // 0x000000018199E630-0x000000018199E830
		public bool HasData(); // 0x000000018199F440-0x000000018199F4A0
		public float[] GetRow(int rowX); // 0x000000018199EBC0-0x000000018199ECA0
		public void SetRow(int rowX, float[] values); // 0x00000001819A1790-0x00000001819A1830
		public float[] GetColumn(int columnZ); // 0x000000018199E830-0x000000018199E900
		public void SetColumn(int columnZ, float[] values); // 0x00000001819A13F0-0x00000001819A1490
		public void Reset(); // 0x00000001819A1240-0x00000001819A12C0
		public void UpdateStats(); // 0x00000001819A27D0-0x00000001819A2870
		public HeightMap Smooth(int iterations); // 0x00000001819A20D0-0x00000001819A2260
		public HeightMap SmoothRadius(int radius); // 0x00000001819A1E10-0x00000001819A20D0
		public HeightMap Convolve(float[,] kernel); // 0x000000018199B780-0x000000018199BB20
		public HeightMap DeNoise(int radius); // 0x000000018199C530-0x000000018199C6E0
		public HeightMap GrowEdges(int radius); // 0x000000018199F280-0x000000018199F440
		public HeightMap ShrinkEdges(int radius); // 0x00000001819A18C0-0x00000001819A1A80
		public HeightMap GetSlopeMap(); // 0x000000018199ED30-0x000000018199EE00
		public HeightMap Copy(HeightMap heightMap, CopyType copyType = CopyType.AlwaysCopy /* Metadata: 0x00778F35 */); // 0x000000018199BCC0-0x000000018199C0D0
		public HeightMap CopyClamped(HeightMap heightMap, float min, float max); // 0x000000018199BB20-0x000000018199BCC0
		public HeightMap Duplicate(); // 0x000000018199D2E0-0x000000018199D340
		public HeightMap Invert(); // 0x000000018199F5E0-0x000000018199F6A0
		public HeightMap Flip(); // 0x000000018199DC90-0x000000018199DE10
		public HeightMap Normalise(); // 0x00000001819A0AC0-0x00000001819A0BF0
		public HeightMap ErodeThermal(int iterations, float talusMin, float talusMax, HeightMap hardnessMask); // 0x000000018199D890-0x000000018199DC00
		public HeightMap Quantize(float divisor); // 0x00000001819A1120-0x00000001819A1240
		public HeightMap Quantize(float[] startHeights, AnimationCurve[] curves); // 0x00000001819A0E30-0x00000001819A1120
		public HeightMap CurvatureMap(GaiaConstants.CurvatureType curvatureType); // 0x000000018199C0D0-0x000000018199C530
		private float HorizontalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x000000018199F520-0x000000018199F5E0
		private float VerticalCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x00000001819A2D10-0x00000001819A2DD0
		private float AverageCurve(float limit, float dx, float dy, float dxx, float dyy, float dxy); // 0x000000018199A7F0-0x000000018199A8E0
		public HeightMap Aspect(GaiaConstants.AspectType aspectType); // 0x000000018199A340-0x000000018199A7F0
		private float Sign(float v); // 0x00000001819A1A80-0x00000001819A1AA0
		public HeightMap ErodeHydraulic(int iterations, HeightMap hardnessMap, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate, ref HeightMap sedimentMap); // 0x000000018199D340-0x000000018199D890
		private void CalculateWaterOutflow(HeightMap heightMap, HeightMap waterMap, float[,,] outFlow); // 0x000000018199AC00-0x000000018199B130
		private void UpdateWaterMap(HeightMap waterMap, float[,,] outFlow); // 0x00000001819A2870-0x00000001819A2AD0
		public HeightMap FlowMap(int iterations); // 0x000000018199DE10-0x000000018199E630
		private void FillWaterMap(float amount, float[,] waterMap, int width, int height); // 0x000000018199DC00-0x000000018199DC90
		private void ComputeOutflow(float[,] waterMap, float[,,] outFlow, float[] heightMap, int width, int height); // 0x000000018199B130-0x000000018199B6B0
		private void UpdateWaterMap(float[,] waterMap, float[,,] outFlow, int width, int height); // 0x00000001819A2AD0-0x00000001819A2D10
		private void CalculateVelocityField(float[,] velocityMap, float[,,] outFlow, int width, int height); // 0x000000018199A970-0x000000018199AC00
		private void NormalizeMap(float[,] map, int width, int height); // 0x00000001819A0BF0-0x00000001819A0D20
		public HeightMap SlopeMap(); // 0x00000001819A1AA0-0x00000001819A1E10
		public HeightMap Add(float value); // 0x000000018199A2C0-0x000000018199A340
		public HeightMap Add(HeightMap heightMap); // 0x000000018199A150-0x000000018199A2C0
		public HeightMap AddClamped(float value, float min, float max); // 0x0000000181999E70-0x0000000181999F60
		public HeightMap AddClamped(HeightMap heightMap, float min, float max); // 0x0000000181999F60-0x000000018199A150
		public HeightMap Subtract(float value); // 0x00000001819A26C0-0x00000001819A2740
		public HeightMap Subtract(HeightMap heightMap); // 0x00000001819A2550-0x00000001819A26C0
		public HeightMap SubtractClamped(float value, float min, float max); // 0x00000001819A2460-0x00000001819A2550
		public HeightMap SubtractClamped(HeightMap heightMap, float min, float max); // 0x00000001819A2260-0x00000001819A2460
		public HeightMap Multiply(float value); // 0x00000001819A0A40-0x00000001819A0AC0
		public HeightMap Multiply(HeightMap heightMap); // 0x00000001819A08D0-0x00000001819A0A40
		public HeightMap MultiplyClamped(float value, float min, float max); // 0x00000001819A05F0-0x00000001819A06E0
		public HeightMap MultiplyClamped(HeightMap heightMap, float min, float max); // 0x00000001819A06E0-0x00000001819A08D0
		public HeightMap Divide(float value); // 0x000000018199CB40-0x000000018199CBC0
		public HeightMap Divide(HeightMap heightMap); // 0x000000018199C9D0-0x000000018199CB40
		public HeightMap DivideClamped(float value, float min, float max); // 0x000000018199C6E0-0x000000018199C7D0
		public HeightMap DivideClamped(HeightMap heightMap, float min, float max); // 0x000000018199C7D0-0x000000018199C9D0
		public HeightMap Lerp(HeightMap hmNewValues, HeightMap hmLerpMask); // 0x000000018199F6A0-0x000000018199FB70
		public float Sum(); // 0x00000001819A2750-0x00000001819A27D0
		public float Average(); // 0x000000018199A8E0-0x000000018199A970
		public HeightMap Power(float exponent); // 0x00000001819A0D20-0x00000001819A0E30
		public HeightMap Contrast(float contrast); // 0x000000018199B6B0-0x000000018199B780
		public void SaveToBinaryFile(string fileName); // 0x00000001819A12C0-0x00000001819A13F0
		public void LoadFromBinaryFile(string fileName); // 0x000000018199FB70-0x000000018199FE10
		public void LoadFromByteArray(byte[] source); // 0x000000018199FE10-0x00000001819A0090
		public void LoadFromRawFile(string fileName, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution); // 0x00000001819A0090-0x00000001819A05F0
		public void DumpMap(float scaleValue, int precision, string spacer, bool flip); // 0x000000018199CE40-0x000000018199D060
		public void DumpRow(int rowX, float scaleValue, int precision, string spacer); // 0x000000018199D060-0x000000018199D2E0
		public void DumpColumn(int columnZ, float scaleValue, int precision, string spacer); // 0x000000018199CBC0-0x000000018199CE40
	}
}
