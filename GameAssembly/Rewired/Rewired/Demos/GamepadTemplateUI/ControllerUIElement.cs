/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos.GamepadTemplateUI
{
	[RequireComponent] // 0x000000018026A840-0x000000018026A890
	public class ControllerUIElement : UnityEngine.MonoBehaviour // TypeDefIndex: 9424
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _highlightColor; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIEffect _positiveUIEffect; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIEffect _negativeUIEffect; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text _label; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text _positiveLabel; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text _negativeLabel; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ControllerUIElement[] _childElements; // 0x50
		private Image _image; // 0x58
		private Color _color; // 0x60
		private Color _origColor; // 0x70
		private bool _isActive; // 0x80
		private float _highlightAmount; // 0x84
	
		// Properties
		private bool hasEffects { get; } // 0x0000000180DCBD30-0x0000000180DCBDE0 
	
		// Constructors
		public ControllerUIElement(); // 0x0000000180DCBCD0-0x0000000180DCBD30
	
		// Methods
		private void Awake(); // 0x0000000180DCB5B0-0x0000000180DCB630
		public void Activate(float amount); // 0x0000000180DCB1F0-0x0000000180DCB5B0
		public void Deactivate(); // 0x0000000180DCB8A0-0x0000000180DCBAC0
		public void SetLabel(string text, AxisRange labelType); // 0x0000000180DCBB00-0x0000000180DCBCD0
		public void ClearLabels(); // 0x0000000180DCB630-0x0000000180DCB8A0
		private void RedrawImage(); // 0x0000000180DCBAC0-0x0000000180DCBB00
	}
}
