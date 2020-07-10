/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public struct CinemachineBlendDefinition // TypeDefIndex: 7338
	{
		// Fields
		[Tooltip] // 0x0000000180156FC0-0x0000000180156FF0
		public Style m_Style; // 0x00
		[Tooltip] // 0x00000001801571C0-0x00000001801571F0
		public float m_Time; // 0x04
		public AnimationCurve m_CustomCurve; // 0x08
		private static AnimationCurve[] sStandardCurves; // 0x00
	
		// Properties
		public AnimationCurve BlendCurve { get; } // 0x00000001802A3390-0x00000001802A3420 
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum Style // TypeDefIndex: 7339
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
		public CinemachineBlendDefinition(Style style, float time); // 0x00000001802A3370-0x00000001802A3390
	
		// Methods
		private void CreateStandardCurves(); // 0x00000001802A3360-0x00000001802A3370
	}
}
