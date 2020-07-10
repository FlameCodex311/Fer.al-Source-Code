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
	public class WaterFlowMap // TypeDefIndex: 9099
	{
		// Fields
		public float m_dropletVolume; // 0x10
		public float m_dropletAbsorbtionRate; // 0x14
		public int m_waterflowSmoothIterations; // 0x18
		private UnityHeightMap m_heightMap; // 0x20
		private HeightMap m_waterFlowMap; // 0x28
	
		// Constructors
		public WaterFlowMap(); // 0x0000000181C0EA50-0x0000000181C0EA70
	
		// Methods
		public void CreateWaterFlowMap(Terrain terrain); // 0x0000000181C0E690-0x0000000181C0E7D0
		private void TraceWaterFlow(int startX, int startZ, int width, int height); // 0x0000000181C0E810-0x0000000181C0EA50
		public void ExportWaterMapToPath(string path); // 0x0000000181C0E7D0-0x0000000181C0E810
	}
}
