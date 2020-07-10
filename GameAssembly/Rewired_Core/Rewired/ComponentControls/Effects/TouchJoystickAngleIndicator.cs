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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000180162940-0x00000001801629E0
	[ExecuteInEditMode] // 0x0000000180162940-0x00000001801629E0
	[RequireComponent] // 0x0000000180162940-0x00000001801629E0
	[RequireComponent] // 0x0000000180162940-0x00000001801629E0
	public sealed class TouchJoystickAngleIndicator : UnityEngine.MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler // TypeDefIndex: 5843
	{
		// Fields
		[CustomObfuscation] // 0x0000000180162E60-0x0000000180162EC0
		[SerializeField] // 0x0000000180162E60-0x0000000180162EC0
		[Tooltip] // 0x0000000180162E60-0x0000000180162EC0
		private bool _visible; // 0x18
		[CustomObfuscation] // 0x0000000180163120-0x0000000180163180
		[SerializeField] // 0x0000000180163120-0x0000000180163180
		[Tooltip] // 0x0000000180163120-0x0000000180163180
		private bool _targetAngleFromRotation; // 0x19
		[CustomObfuscation] // 0x0000000180163370-0x00000001801633F0
		[Range] // 0x0000000180163370-0x00000001801633F0
		[SerializeField] // 0x0000000180163370-0x00000001801633F0
		[Tooltip] // 0x0000000180163370-0x00000001801633F0
		private float _targetAngle; // 0x1C
		[CustomObfuscation] // 0x0000000180163770-0x00000001801637D0
		[SerializeField] // 0x0000000180163770-0x00000001801637D0
		[Tooltip] // 0x0000000180163770-0x00000001801637D0
		private bool _fadeWithValue; // 0x20
		[CustomObfuscation] // 0x0000000180163AA0-0x0000000180163B00
		[SerializeField] // 0x0000000180163AA0-0x0000000180163B00
		[Tooltip] // 0x0000000180163AA0-0x0000000180163B00
		private bool _fadeWithAngle; // 0x21
		[CustomObfuscation] // 0x0000000180163E90-0x0000000180163F10
		[Range] // 0x0000000180163E90-0x0000000180163F10
		[SerializeField] // 0x0000000180163E90-0x0000000180163F10
		[Tooltip] // 0x0000000180163E90-0x0000000180163F10
		private float _fadeRange; // 0x24
		[CustomObfuscation] // 0x0000000180164310-0x0000000180164370
		[SerializeField] // 0x0000000180164310-0x0000000180164370
		[Tooltip] // 0x0000000180164310-0x0000000180164370
		private Color _activeColor; // 0x28
		[CustomObfuscation] // 0x00000001801647E0-0x0000000180164840
		[SerializeField] // 0x00000001801647E0-0x0000000180164840
		[Tooltip] // 0x00000001801647E0-0x0000000180164840
		private Color _normalColor; // 0x38
		private Image MOnzScNGMahVsBwRiTKJfENaPkWK; // 0x48
		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs; // 0x50
		private Vector2 PIlMIZoBefVCXhAtsFBXAwIVCuP; // 0x58
		private bool dqRDuLqtLVFLDdtJiDwKDVlcZyx; // 0x60
		private IRegistrar<TouchJoystickAngleIndicator> QBLgWjrWdUafnBNnIsAvJHdsCHAQ; // 0x68
	
		// Properties
		public bool visible { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x0000000181445980-0x00000001814459A0
		public bool targetAngleFromRotation { get; set; } // 0x000000018048F440-0x000000018048F450 0x0000000181445930-0x0000000181445940
		public float targetAngle { get; set; } // 0x00000001814455F0-0x0000000181445640 0x0000000181445940-0x0000000181445980
		public bool fadeWithValue { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x0000000181445920-0x0000000181445930
		public bool fadeWithAngle { get; set; } // 0x00000001803C19F0-0x00000001803C1A00 0x0000000181445910-0x0000000181445920
		public float fadeRange { get; set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001814458E0-0x0000000181445910
		public Color activeColor { get; set; } // 0x000000018036CB50-0x000000018036CB60 0x000000018036CC20-0x000000018036CC30
		public Color normalColor { get; set; } // 0x000000018036CB40-0x000000018036CB50 0x000000018036CC10-0x000000018036CC20
		internal Image image { get; } // 0x0000000181445550-0x00000001814455A0 
		internal Sprite currentSprite { get; } // 0x0000000181445420-0x0000000181445550 
		internal RectTransform rectTransform { get; } // 0x00000001814455A0-0x00000001814455F0 
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchJoystickAngleIndicator(); // 0x0000000181445370-0x0000000181445420
	
		// Methods
		internal bool VyvsGUCvHlsGSuXsSdCadpjceAY(out Vector2 param_0000c7ac); // 0x0000000181445150-0x0000000181445370
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Awake(); // 0x0000000181444C80-0x0000000181444CF0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnEnable(); // 0x0000000181444E90-0x0000000181444F00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnDisable(); // 0x0000000181444E80-0x0000000181444E90
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnValidate(); // 0x0000000181444FD0-0x0000000181445130
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnTransformParentChanged(); // 0x0000000181444FC0-0x0000000181444FD0
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000c7ad, bool param_0000c7ae); // 0x0000000181444CF0-0x0000000181444E00
		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(Vector2 param_0000c7af); // 0x0000000181444750-0x0000000181444C80
		private void mqiaGywLlRymbsGGeFSVkHQPXjn(); // 0x00000001814458D0-0x00000001814458E0
		private void ixjtpheoJlhcHpvQksvNDhgeKCH(); // 0x0000000181445790-0x00000001814458D0
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803581E0-0x00000001803581F0
		private void iVXfGQBKzGTKsBObZnbsqtAcvNp(); // 0x0000000181445640-0x0000000181445790
		private void HwCTaCdGhAcPRVMVfQOqLnRcdEb(); // 0x0000000181444E00-0x0000000181444E80
		public void OnVisibilityChanged(bool state); // 0x0000000181445130-0x0000000181445140
		public void OnTouchJoystickStickPositionChanged(Vector2 value); // 0x0000000181444F00-0x0000000181444FC0
		void Rewired.ComponentControls.TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 param_0000c7b2); // 0x0000000181445140-0x0000000181445150
	}
}
