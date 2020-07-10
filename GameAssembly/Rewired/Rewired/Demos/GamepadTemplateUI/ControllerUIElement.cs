/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos.GamepadTemplateUI
{
	[RequireComponent] // 0x00000001801087A0-0x00000001801087F0
	public class ControllerUIElement : UnityEngine.MonoBehaviour // TypeDefIndex: 9258
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _highlightColor; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIEffect _positiveUIEffect; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIEffect _negativeUIEffect; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text _label; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text _positiveLabel; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text _negativeLabel; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ControllerUIElement[] _childElements; // 0x50
		private Image _image; // 0x58
		private Color _color; // 0x60
		private Color _origColor; // 0x70
		private bool _isActive; // 0x80
		private float _highlightAmount; // 0x84
	
		// Properties
		private bool hasEffects { get; } // 0x00000001815B1820-0x00000001815B18D0 
	
		// Constructors
		public ControllerUIElement(); // 0x00000001815B17C0-0x00000001815B1820
	
		// Methods
		private void Awake(); // 0x00000001815B1070-0x00000001815B10F0
		public void Activate(float amount); // 0x00000001815B0CA0-0x00000001815B1070
		public void Deactivate(); // 0x00000001815B1370-0x00000001815B15A0
		public void SetLabel(string text, AxisRange labelType); // 0x00000001815B15E0-0x00000001815B17C0
		public void ClearLabels(); // 0x00000001815B10F0-0x00000001815B1370
		private void RedrawImage(); // 0x00000001815B15A0-0x00000001815B15E0
	}
}
