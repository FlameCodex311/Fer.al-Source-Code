/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace GaiaCommon1
{
	[Serializable]
	public class UBrush // TypeDefIndex: 8988
	{
		// Fields
		private float[] m_Strength; // 0x10
		private Texture2D m_Brush; // 0x18
		private const int MIN_BRUSH_SIZE = 3; // Metadata: 0x00743F83
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Size>k__BackingField; // 0x20
	
		// Properties
		public int Size { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
	
		// Constructors
		public UBrush(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public bool Load(Texture2D brushTex, int size); // 0x0000000181C07820-0x0000000181C07AE0
		public float GetStrengthAtCoords(int ix, int iy); // 0x0000000181C077C0-0x0000000181C07820
	}
}
