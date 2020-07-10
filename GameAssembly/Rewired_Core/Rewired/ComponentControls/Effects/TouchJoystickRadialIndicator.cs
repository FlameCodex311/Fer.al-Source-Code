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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000180165500-0x0000000180165580
	[ExecuteInEditMode] // 0x0000000180165500-0x0000000180165580
	[RequireComponent] // 0x0000000180165500-0x0000000180165580
	public sealed class TouchJoystickRadialIndicator : UnityEngine.MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator> // TypeDefIndex: 5844
	{
		// Fields
		[Tooltip] // 0x0000000180165860-0x0000000180165890
		public bool _scale; // 0x18
		[Tooltip] // 0x0000000180165A80-0x0000000180165AB0
		public bool _preserveSpriteAspectRatio; // 0x19
		[Range] // 0x0000000180165C90-0x0000000180165CF0
		[Tooltip] // 0x0000000180165C90-0x0000000180165CF0
		public float _scaleRatio; // 0x1C
		[Range] // 0x0000000180166000-0x0000000180166060
		[Tooltip] // 0x0000000180166000-0x0000000180166060
		public float _aspectRatioX; // 0x20
		[Range] // 0x0000000180166270-0x00000001801662D0
		[Tooltip] // 0x0000000180166270-0x00000001801662D0
		public float _aspectRatioY; // 0x24
		[Tooltip] // 0x00000001801677F0-0x0000000180167820
		public float _offset; // 0x28
		private static readonly Vector2 vuqfEIdhGneUoobbMaOQeOJhzfVK; // 0x00
		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs; // 0x30
		private List<TouchJoystickAngleIndicator> nkgGgWbemvNFIZKwdNkahUpHjymJ; // 0x38
	
		// Properties
		public bool scale { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x0000000181446A40-0x0000000181446A80
		public bool preserveSpriteAspectRatio { get; set; } // 0x000000018048F440-0x000000018048F450 0x0000000181446990-0x00000001814469F0
		public float scaleRatio { get; set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001814469F0-0x0000000181446A40
		public float aspectRatioX { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x0000000181446860-0x00000001814468E0
		public float aspectRatioY { get; set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001814468E0-0x0000000181446930
		public float offset { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x0000000181446930-0x0000000181446990
		private RectTransform rectTransform { get; } // 0x0000000181446670-0x00000001814466C0 
	
		// Constructors
		public TouchJoystickRadialIndicator(); // 0x00000001814465F0-0x0000000181446670
		static TouchJoystickRadialIndicator(); // 0x0000000181446580-0x00000001814465F0
	
		// Methods
		void IRegistrar<TouchJoystickAngleIndicator>.Register(TouchJoystickAngleIndicator param_0000c7b9); // 0x0000000181446490-0x0000000181446580
		void IRegistrar<TouchJoystickAngleIndicator>.Deregister(TouchJoystickAngleIndicator param_0000c7ba); // 0x0000000181446400-0x0000000181446490
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Update(); // 0x0000000181446230-0x0000000181446240
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnValidate(); // 0x0000000181446240-0x0000000181446400
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnEnable(); // 0x0000000181446230-0x0000000181446240
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnDestroy(); // 0x00000001814461E0-0x0000000181446230
		private void AdSCOdhklchquRUjivKFFmxhnObU(); // 0x0000000181446090-0x00000001814461E0
		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(TouchJoystickAngleIndicator param_0000c7bb); // 0x00000001814459A0-0x0000000181446090
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x0000000181446230-0x0000000181446240
		private void hVKLcQTGLcFAhfcrfXDLktdTfuXX(); // 0x00000001814466C0-0x0000000181446860
	}
}
