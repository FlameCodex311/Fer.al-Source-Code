/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace GaiaCommon1
{
	[Serializable]
	public class UBrush // TypeDefIndex: 9154
	{
		// Fields
		private float[] m_Strength; // 0x10
		private Texture2D m_Brush; // 0x18
		private const int MIN_BRUSH_SIZE = 3; // Metadata: 0x00778C71
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Size>k__BackingField; // 0x20
	
		// Properties
		public int Size { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
	
		// Constructors
		public UBrush(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public bool Load(Texture2D brushTex, int size); // 0x00000001816FCA30-0x00000001816FCCE0
		public float GetStrengthAtCoords(int ix, int iy); // 0x00000001816FC9D0-0x00000001816FCA30
	}
}
