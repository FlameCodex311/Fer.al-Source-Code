/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	internal struct FloatTween : ITweenValue // TypeDefIndex: 8925
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x0000000180006DE0-0x0000000180006DF0 0x0000000180006E20-0x0000000180006E30
		public float targetValue { get; set; } // 0x0000000180006DF0-0x0000000180006E00 0x0000000180006E30-0x0000000180006E60
		public float duration { get; set; } // 0x0000000180006D10-0x0000000180006D20 0x0000000180006E00-0x0000000180006E10
		public bool ignoreTimeScale { get; set; } // 0x0000000180006D20-0x0000000180006D30 0x0000000180006E10-0x0000000180006E20
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 8926
		{
			// Constructors
			public FloatTweenCallback(); // 0x0000000180569280-0x0000000180569440
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x0000000180006D30-0x0000000180006DE0
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x0000000180006D00-0x0000000180006D10
		public bool GetIgnoreTimescale(); // 0x0000000180006D20-0x0000000180006D30
		public float GetDuration(); // 0x0000000180006D10-0x0000000180006D20
		public bool ValidTarget(); // 0x0000000180006C30-0x0000000180006C40
	}
}
