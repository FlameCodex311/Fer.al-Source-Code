/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	internal struct FloatTween : ITweenValue // TypeDefIndex: 8763
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x000000018020A590-0x000000018020A5A0 0x000000018001FC20-0x000000018001FC30
		public float targetValue { get; set; } // 0x000000018020A5A0-0x000000018020A5B0 0x000000018001FC40-0x000000018001FC50
		public float duration { get; set; } // 0x000000018020A4C0-0x000000018020A4D0 0x000000018020A5B0-0x000000018020A5C0
		public bool ignoreTimeScale { get; set; } // 0x000000018020A4D0-0x000000018020A4E0 0x000000018020A5C0-0x000000018020A5F0
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 8764
		{
			// Constructors
			public FloatTweenCallback(); // 0x00000001810BE630-0x00000001810BE7F0
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018020A4E0-0x000000018020A590
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018020A4B0-0x000000018020A4C0
		public bool GetIgnoreTimescale(); // 0x000000018020A4D0-0x000000018020A4E0
		public float GetDuration(); // 0x000000018020A4C0-0x000000018020A4D0
		public bool ValidTarget(); // 0x000000018020A430-0x000000018020A440
	}
}
