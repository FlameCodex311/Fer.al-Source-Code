/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	internal struct ColorTween : ITweenValue // TypeDefIndex: 8922
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private Color m_StartColor; // 0x08
		private Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public Color startColor { get; set; } // 0x0000000180006C40-0x0000000180006C50 0x0000000180006C90-0x0000000180006CA0
		public Color targetColor { get; set; } // 0x0000000180006C50-0x0000000180006C60 0x0000000180006CA0-0x0000000180006CB0
		public ColorTweenMode tweenMode { get; set; } // 0x0000000180006C60-0x0000000180006C70 0x0000000180006CB0-0x0000000180006CE0
		public float duration { get; set; } // 0x0000000180006B10-0x0000000180006B20 0x0000000180006C70-0x0000000180006C80
		public bool ignoreTimeScale { get; set; } // 0x0000000180006B20-0x0000000180006B30 0x0000000180006C80-0x0000000180006C90
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 8923
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 8924
		{
			// Constructors
			public ColorTweenCallback(); // 0x0000000180568A40-0x0000000180568A80
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x0000000180006B30-0x0000000180006C30
		public void AddOnChangedCallback(UnityAction<Color> callback); // 0x0000000180006A60-0x0000000180006B10
		public bool GetIgnoreTimescale(); // 0x0000000180006B20-0x0000000180006B30
		public float GetDuration(); // 0x0000000180006B10-0x0000000180006B20
		public bool ValidTarget(); // 0x0000000180006C30-0x0000000180006C40
	}
}
