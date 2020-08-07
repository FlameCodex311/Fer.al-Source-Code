/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class SpectrumVisualizer : UnityEngine.MonoBehaviour // TypeDefIndex: 9751
	{
		// Fields
		[Tooltip] // 0x00000001802002D0-0x0000000180200300
		public FFTAnalyzer Analyzer; // 0x18
		[Tooltip] // 0x00000001802004E0-0x0000000180200510
		public GameObject VisualPrefab; // 0x20
		[Tooltip] // 0x0000000180200670-0x00000001802006A0
		public float Width; // 0x28
		[Tooltip] // 0x0000000180200890-0x00000001802008C0
		public float Gain; // 0x2C
		[Tooltip] // 0x00000001802009B0-0x00000001802009E0
		public bool LeftToRight; // 0x30
		[Range] // 0x0000000180200C20-0x0000000180200C80
		[Tooltip] // 0x0000000180200C20-0x0000000180200C80
		public float Opacity; // 0x34
		private Transform tf; // 0x38
		private Transform[] visualTransforms; // 0x40
		private Vector3 visualPos; // 0x48
		private int samplesPerChannel; // 0x54
	
		// Constructors
		public SpectrumVisualizer(); // 0x000000018108BDB0-0x000000018108BE40
	
		// Methods
		public void Start(); // 0x000000018108B7C0-0x000000018108BC80
		public void Update(); // 0x000000018108BC80-0x000000018108BDB0
	}
}
