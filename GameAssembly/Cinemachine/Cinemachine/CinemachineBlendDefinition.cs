/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public struct CinemachineBlendDefinition // TypeDefIndex: 7504
	{
		// Fields
		[Tooltip] // 0x00000001801F48E0-0x00000001801F4910
		public Style m_Style; // 0x00
		[Tooltip] // 0x00000001801F4BC0-0x00000001801F4BF0
		public float m_Time; // 0x04
		public AnimationCurve m_CustomCurve; // 0x08
		private static AnimationCurve[] sStandardCurves; // 0x00
	
		// Properties
		public AnimationCurve BlendCurve { get; } // 0x00000001800C0D00-0x00000001800C0D90 
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum Style // TypeDefIndex: 7505
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6,
			Custom = 7
		}
	
		// Constructors
		public CinemachineBlendDefinition(Style style, float time); // 0x00000001800C0CE0-0x00000001800C0D00
	
		// Methods
		private void CreateStandardCurves(); // 0x00000001800C0CD0-0x00000001800C0CE0
	}
}
