/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class SpectrumVisualizer : UnityEngine.MonoBehaviour // TypeDefIndex: 9965
	{
		// Fields
		[Tooltip] // 0x000000018011B350-0x000000018011B380
		public FFTAnalyzer Analyzer; // 0x18
		[Tooltip] // 0x000000018011B510-0x000000018011B540
		public GameObject VisualPrefab; // 0x20
		[Tooltip] // 0x000000018011B570-0x000000018011B5A0
		public float Width; // 0x28
		[Tooltip] // 0x000000018011B680-0x000000018011B6B0
		public float Gain; // 0x2C
		[Tooltip] // 0x000000018011B7A0-0x000000018011B7D0
		public bool LeftToRight; // 0x30
		[Range] // 0x000000018011B8F0-0x000000018011B950
		[Tooltip] // 0x000000018011B8F0-0x000000018011B950
		public float Opacity; // 0x34
		private Transform tf; // 0x38
		private Transform[] visualTransforms; // 0x40
		private Vector3 visualPos; // 0x48
		private int samplesPerChannel; // 0x54
	
		// Constructors
		public SpectrumVisualizer(); // 0x00000001815EC100-0x00000001815EC190
	
		// Methods
		public void Start(); // 0x00000001815EBAF0-0x00000001815EBFC0
		public void Update(); // 0x00000001815EBFC0-0x00000001815EC100
	}
}
