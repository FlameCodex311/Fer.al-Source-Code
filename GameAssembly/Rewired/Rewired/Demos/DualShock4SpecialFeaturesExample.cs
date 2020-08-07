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

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class DualShock4SpecialFeaturesExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9399
	{
		// Fields
		private const int maxTouches = 2; // Metadata: 0x00779AC7
		public int playerId; // 0x18
		public Transform touchpadTransform; // 0x20
		public GameObject lightObject; // 0x28
		public Transform accelerometerTransform; // 0x30
		private List<Touch> touches; // 0x38
		private Queue<Touch> unusedTouches; // 0x40
		private bool isFlashing; // 0x48
		private GUIStyle textStyle; // 0x50
	
		// Properties
		private Player player { get; } // 0x0000000180DCFBF0-0x0000000180DCFC60 
	
		// Nested types
		private class Touch // TypeDefIndex: 9400
		{
			// Fields
			public GameObject go; // 0x10
			public int touchId; // 0x18
	
			// Constructors
			public Touch(); // 0x0000000180DD81B0-0x0000000180DD81C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 9401
		{
			// Fields
			public int touchId; // 0x10
	
			// Constructors
			public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <HandleTouchpad>b__0(Touch x); // 0x0000000180DD8300-0x0000000180DD8320
		}
	
		// Constructors
		public DualShock4SpecialFeaturesExample(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180DCDEB0-0x0000000180DCDEC0
		private void Update(); // 0x0000000180DCF360-0x0000000180DCFBF0
		private void OnGUI(); // 0x0000000180DCE820-0x0000000180DCEEF0
		private void ResetOrientation(); // 0x0000000180DCEEF0-0x0000000180DCEFA0
		private void SetRandomLightColor(); // 0x0000000180DCEFA0-0x0000000180DCF1D0
		private void StartLightFlash(); // 0x0000000180DCF1D0-0x0000000180DCF2A0
		private void StopLightFlash(); // 0x0000000180DCF2A0-0x0000000180DCF360
		private IDualShock4Extension GetFirstDS4(Player player); // 0x0000000180DCDEC0-0x0000000180DCE060
		private void InitializeTouchObjects(); // 0x0000000180DCE5B0-0x0000000180DCE820
		private void HandleTouchpad(IDualShock4Extension ds4); // 0x0000000180DCE060-0x0000000180DCE5B0
	}
}
