/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 8758
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public Color topLeft; // 0x1C
		public Color topRight; // 0x2C
		public Color bottomLeft; // 0x3C
		public Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x00743446
		private static readonly Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient(); // 0x00000001810C3E50-0x00000001810C3F10
		public TMP_ColorGradient(Color color); // 0x00000001810C3F80-0x00000001810C3FD0
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3); // 0x00000001810C3F10-0x00000001810C3F80
		static TMP_ColorGradient(); // 0x00000001810C3E00-0x00000001810C3E50
	}
}
