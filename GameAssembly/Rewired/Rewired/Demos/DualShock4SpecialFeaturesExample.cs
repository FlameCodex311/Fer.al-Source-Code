/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.ControllerExtensions;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class DualShock4SpecialFeaturesExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9233
	{
		// Fields
		private const int maxTouches = 2; // Metadata: 0x00744DD9
		public int playerId; // 0x18
		public Transform touchpadTransform; // 0x20
		public GameObject lightObject; // 0x28
		public Transform accelerometerTransform; // 0x30
		private List<Touch> touches; // 0x38
		private Queue<Touch> unusedTouches; // 0x40
		private bool isFlashing; // 0x48
		private GUIStyle textStyle; // 0x50
	
		// Properties
		private Player player { get; } // 0x00000001815B5320-0x00000001815B5390 
	
		// Nested types
		private class Touch // TypeDefIndex: 9234
		{
			// Fields
			public GameObject go; // 0x10
			public int touchId; // 0x18
	
			// Constructors
			public Touch(); // 0x00000001815C1C20-0x00000001815C1C30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 9235
		{
			// Fields
			public int touchId; // 0x10
	
			// Constructors
			public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <HandleTouchpad>b__0(Touch x); // 0x00000001815C21B0-0x00000001815C21D0
		}
	
		// Constructors
		public DualShock4SpecialFeaturesExample(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x00000001815B3900-0x00000001815B3910
		private void Update(); // 0x00000001815B4C60-0x00000001815B5320
		private void OnGUI(); // 0x00000001815B4290-0x00000001815B47E0
		private void ResetOrientation(); // 0x00000001815B47E0-0x00000001815B48A0
		private void SetRandomLightColor(); // 0x00000001815B48A0-0x00000001815B4AD0
		private void StartLightFlash(); // 0x00000001815B4AD0-0x00000001815B4BA0
		private void StopLightFlash(); // 0x00000001815B4BA0-0x00000001815B4C60
		private IDualShock4Extension GetFirstDS4(Player player); // 0x00000001815B3910-0x00000001815B3AC0
		private void InitializeTouchObjects(); // 0x00000001815B4020-0x00000001815B4290
		private void HandleTouchpad(IDualShock4Extension ds4); // 0x00000001815B3AC0-0x00000001815B4020
	}
}
