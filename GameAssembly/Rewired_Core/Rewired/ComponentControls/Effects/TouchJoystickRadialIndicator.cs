/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000180206150-0x00000001802061D0
	[ExecuteInEditMode] // 0x0000000180206150-0x00000001802061D0
	[RequireComponent] // 0x0000000180206150-0x00000001802061D0
	public sealed class TouchJoystickRadialIndicator : UnityEngine.MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator> // TypeDefIndex: 6003
	{
		// Fields
		[Tooltip] // 0x0000000180206620-0x0000000180206650
		public bool _scale; // 0x18
		[Tooltip] // 0x0000000180206820-0x0000000180206850
		public bool _preserveSpriteAspectRatio; // 0x19
		[Range] // 0x0000000180206920-0x0000000180206980
		[Tooltip] // 0x0000000180206920-0x0000000180206980
		public float _scaleRatio; // 0x1C
		[Range] // 0x0000000180206C50-0x0000000180206CB0
		[Tooltip] // 0x0000000180206C50-0x0000000180206CB0
		public float _aspectRatioX; // 0x20
		[Range] // 0x00000001802070B0-0x0000000180207110
		[Tooltip] // 0x00000001802070B0-0x0000000180207110
		public float _aspectRatioY; // 0x24
		[Tooltip] // 0x00000001802074A0-0x00000001802074D0
		public float _offset; // 0x28
		private static readonly Vector2 vuqfEIdhGneUoobbMaOQeOJhzfVK; // 0x00
		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs; // 0x30
		private List<TouchJoystickAngleIndicator> nkgGgWbemvNFIZKwdNkahUpHjymJ; // 0x38
	
		// Properties
		public bool scale { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001809241D0-0x0000000180924210
		public bool preserveSpriteAspectRatio { get; set; } // 0x0000000180690340-0x0000000180690350 0x0000000180924120-0x0000000180924180
		public float scaleRatio { get; set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180924180-0x00000001809241D0
		public float aspectRatioX { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180923FF0-0x0000000180924070
		public float aspectRatioY { get; set; } // 0x000000018090BD10-0x000000018090BD20 0x0000000180924070-0x00000001809240C0
		public float offset { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x00000001809240C0-0x0000000180924120
		private RectTransform rectTransform { get; } // 0x0000000180923E00-0x0000000180923E50 
	
		// Constructors
		public TouchJoystickRadialIndicator(); // 0x0000000180923D80-0x0000000180923E00
		static TouchJoystickRadialIndicator(); // 0x0000000180923D10-0x0000000180923D80
	
		// Methods
		void IRegistrar<TouchJoystickAngleIndicator>.Register(TouchJoystickAngleIndicator param_0000ca29); // 0x0000000180923C20-0x0000000180923D10
		void IRegistrar<TouchJoystickAngleIndicator>.Deregister(TouchJoystickAngleIndicator param_0000ca2a); // 0x0000000180923B90-0x0000000180923C20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Update(); // 0x00000001809239C0-0x00000001809239D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnValidate(); // 0x00000001809239D0-0x0000000180923B90
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnEnable(); // 0x00000001809239C0-0x00000001809239D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDestroy(); // 0x0000000180923970-0x00000001809239C0
		private void AdSCOdhklchquRUjivKFFmxhnObU(); // 0x0000000180923820-0x0000000180923970
		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(TouchJoystickAngleIndicator param_0000ca2b); // 0x0000000180923140-0x0000000180923820
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001809239C0-0x00000001809239D0
		private void hVKLcQTGLcFAhfcrfXDLktdTfuXX(); // 0x0000000180923E50-0x0000000180923FF0
	}
}
