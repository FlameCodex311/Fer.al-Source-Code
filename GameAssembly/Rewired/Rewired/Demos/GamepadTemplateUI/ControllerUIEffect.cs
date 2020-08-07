/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos.GamepadTemplateUI
{
	[RequireComponent] // 0x000000018026A4A0-0x000000018026A4F0
	public class ControllerUIEffect : UnityEngine.MonoBehaviour // TypeDefIndex: 9423
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _highlightColor; // 0x18
		private Image _image; // 0x28
		private Color _color; // 0x30
		private Color _origColor; // 0x40
		private bool _isActive; // 0x50
		private float _highlightAmount; // 0x54
	
		// Constructors
		public ControllerUIEffect(); // 0x0000000180DCB1C0-0x0000000180DCB1F0
	
		// Methods
		private void Awake(); // 0x0000000180DCB070-0x0000000180DCB0E0
		public void Activate(float amount); // 0x0000000180DCAF70-0x0000000180DCB070
		public void Deactivate(); // 0x0000000180DCB0E0-0x0000000180DCB160
		private void RedrawImage(); // 0x0000000180DCB160-0x0000000180DCB1C0
	}
}
