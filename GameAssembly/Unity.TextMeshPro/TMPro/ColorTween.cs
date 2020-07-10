/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	internal struct ColorTween : ITweenValue // TypeDefIndex: 8760
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private Color m_StartColor; // 0x08
		private Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public Color startColor { get; set; } // 0x0000000180004CB0-0x0000000180004CC0 0x0000000180004CF0-0x0000000180004F50
		public Color targetColor { get; set; } // 0x000000018020A440-0x000000018020A450 0x000000018020A470-0x000000018020A4A0
		public ColorTweenMode tweenMode { get; set; } // 0x000000018000A170-0x000000018000A180 0x000000018000A240-0x000000018000A310
		public float duration { get; set; } // 0x000000018020A310-0x000000018020A320 0x000000018020A450-0x000000018020A460
		public bool ignoreTimeScale { get; set; } // 0x000000018020A320-0x000000018020A330 0x000000018020A460-0x000000018020A470
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 8761
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 8762
		{
			// Constructors
			public ColorTweenCallback(); // 0x00000001810BDE10-0x00000001810BDE50
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018020A330-0x000000018020A430
		public void AddOnChangedCallback(UnityAction<Color> callback); // 0x000000018020A260-0x000000018020A310
		public bool GetIgnoreTimescale(); // 0x000000018020A320-0x000000018020A330
		public float GetDuration(); // 0x000000018020A310-0x000000018020A320
		public bool ValidTarget(); // 0x000000018020A430-0x000000018020A440
	}
}
