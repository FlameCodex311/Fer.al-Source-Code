/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls;
using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000180200DA0-0x0000000180200E40
	[ExecuteInEditMode] // 0x0000000180200DA0-0x0000000180200E40
	[RequireComponent] // 0x0000000180200DA0-0x0000000180200E40
	[RequireComponent] // 0x0000000180200DA0-0x0000000180200E40
	public sealed class TouchJoystickAngleIndicator : UnityEngine.MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler // TypeDefIndex: 6002
	{
		// Fields
		[CustomObfuscation] // 0x0000000180202390-0x00000001802023F0
		[SerializeField] // 0x0000000180202390-0x00000001802023F0
		[Tooltip] // 0x0000000180202390-0x00000001802023F0
		private bool _visible; // 0x18
		[CustomObfuscation] // 0x00000001802026E0-0x0000000180202740
		[SerializeField] // 0x00000001802026E0-0x0000000180202740
		[Tooltip] // 0x00000001802026E0-0x0000000180202740
		private bool _targetAngleFromRotation; // 0x19
		[CustomObfuscation] // 0x0000000180202BC0-0x0000000180202C40
		[Range] // 0x0000000180202BC0-0x0000000180202C40
		[SerializeField] // 0x0000000180202BC0-0x0000000180202C40
		[Tooltip] // 0x0000000180202BC0-0x0000000180202C40
		private float _targetAngle; // 0x1C
		[CustomObfuscation] // 0x0000000180203000-0x0000000180203060
		[SerializeField] // 0x0000000180203000-0x0000000180203060
		[Tooltip] // 0x0000000180203000-0x0000000180203060
		private bool _fadeWithValue; // 0x20
		[CustomObfuscation] // 0x00000001802033E0-0x0000000180203440
		[SerializeField] // 0x00000001802033E0-0x0000000180203440
		[Tooltip] // 0x00000001802033E0-0x0000000180203440
		private bool _fadeWithAngle; // 0x21
		[CustomObfuscation] // 0x0000000180203860-0x00000001802038E0
		[Range] // 0x0000000180203860-0x00000001802038E0
		[SerializeField] // 0x0000000180203860-0x00000001802038E0
		[Tooltip] // 0x0000000180203860-0x00000001802038E0
		private float _fadeRange; // 0x24
		[CustomObfuscation] // 0x0000000180205170-0x00000001802051D0
		[SerializeField] // 0x0000000180205170-0x00000001802051D0
		[Tooltip] // 0x0000000180205170-0x00000001802051D0
		private Color _activeColor; // 0x28
		[CustomObfuscation] // 0x0000000180205470-0x00000001802054D0
		[SerializeField] // 0x0000000180205470-0x00000001802054D0
		[Tooltip] // 0x0000000180205470-0x00000001802054D0
		private Color _normalColor; // 0x38
		private Image MOnzScNGMahVsBwRiTKJfENaPkWK; // 0x48
		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs; // 0x50
		private Vector2 PIlMIZoBefVCXhAtsFBXAwIVCuP; // 0x58
		private bool dqRDuLqtLVFLDdtJiDwKDVlcZyx; // 0x60
		private IRegistrar<TouchJoystickAngleIndicator> QBLgWjrWdUafnBNnIsAvJHdsCHAQ; // 0x68
	
		// Properties
		public bool visible { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x0000000180923120-0x0000000180923140
		public bool targetAngleFromRotation { get; set; } // 0x0000000180690340-0x0000000180690350 0x00000001809230D0-0x00000001809230E0
		public float targetAngle { get; set; } // 0x0000000180922D90-0x0000000180922DE0 0x00000001809230E0-0x0000000180923120
		public bool fadeWithValue { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001809230C0-0x00000001809230D0
		public bool fadeWithAngle { get; set; } // 0x00000001804F2E80-0x00000001804F2E90 0x00000001809230B0-0x00000001809230C0
		public float fadeRange { get; set; } // 0x000000018090BD10-0x000000018090BD20 0x0000000180923080-0x00000001809230B0
		public Color activeColor { get; set; } // 0x0000000180379E90-0x0000000180379EA0 0x000000018041B740-0x000000018041B750
		public Color normalColor { get; set; } // 0x000000018041B670-0x000000018041B680 0x000000018041B730-0x000000018041B740
		internal Image image { get; } // 0x0000000180922CF0-0x0000000180922D40 
		internal Sprite currentSprite { get; } // 0x0000000180922BC0-0x0000000180922CF0 
		internal RectTransform rectTransform { get; } // 0x0000000180922D40-0x0000000180922D90 
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchJoystickAngleIndicator(); // 0x0000000180922B10-0x0000000180922BC0
	
		// Methods
		internal bool VyvsGUCvHlsGSuXsSdCadpjceAY(out Vector2 param_0000ca1c); // 0x0000000180922900-0x0000000180922B10
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Awake(); // 0x0000000180922430-0x00000001809224A0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnEnable(); // 0x0000000180922640-0x00000001809226B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDisable(); // 0x0000000180922630-0x0000000180922640
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnValidate(); // 0x0000000180922780-0x00000001809228E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnTransformParentChanged(); // 0x0000000180922770-0x0000000180922780
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000ca1d, bool param_0000ca1e); // 0x00000001809224A0-0x00000001809225B0
		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(Vector2 param_0000ca1f); // 0x0000000180921F00-0x0000000180922430
		private void mqiaGywLlRymbsGGeFSVkHQPXjn(); // 0x0000000180923070-0x0000000180923080
		private void ixjtpheoJlhcHpvQksvNDhgeKCH(); // 0x0000000180922F30-0x0000000180923070
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803774A0-0x00000001803774B0
		private void iVXfGQBKzGTKsBObZnbsqtAcvNp(); // 0x0000000180922DE0-0x0000000180922F30
		private void HwCTaCdGhAcPRVMVfQOqLnRcdEb(); // 0x00000001809225B0-0x0000000180922630
		public void OnVisibilityChanged(bool state); // 0x00000001809228E0-0x00000001809228F0
		public void OnTouchJoystickStickPositionChanged(Vector2 value); // 0x00000001809226B0-0x0000000180922770
		void Rewired.ComponentControls.TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 param_0000ca22); // 0x00000001809228F0-0x0000000180922900
	}
}
