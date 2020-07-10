/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos.GamepadTemplateUI
{
	[RequireComponent] // 0x00000001801082D0-0x0000000180108320
	public class ControllerUIEffect : UnityEngine.MonoBehaviour // TypeDefIndex: 9257
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _highlightColor; // 0x18
		private Image _image; // 0x28
		private Color _color; // 0x30
		private Color _origColor; // 0x40
		private bool _isActive; // 0x50
		private float _highlightAmount; // 0x54
	
		// Constructors
		public ControllerUIEffect(); // 0x00000001815B0C70-0x00000001815B0CA0
	
		// Methods
		private void Awake(); // 0x00000001815B0B20-0x00000001815B0B90
		public void Activate(float amount); // 0x00000001815B0A20-0x00000001815B0B20
		public void Deactivate(); // 0x00000001815B0B90-0x00000001815B0C10
		private void RedrawImage(); // 0x00000001815B0C10-0x00000001815B0C70
	}
}
