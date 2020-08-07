/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class UIConfiguration : UnityEngine.MonoBehaviour // TypeDefIndex: 9273
	{
		// Fields
		[Header] // 0x00000001802531D0-0x0000000180253230
		[Tooltip] // 0x00000001802531D0-0x0000000180253230
		public Color32 m_uiTextColor; // 0x18
		[Tooltip] // 0x0000000180253430-0x0000000180253460
		public KeyCode m_uiToggleButton; // 0x1C
		private UnityEngine.UI.Text m_textContent; // 0x20
		private Color32 storedColor; // 0x28
		private bool storedUIStatus; // 0x2C
	
		// Constructors
		public UIConfiguration(); // 0x00000001816FD000-0x00000001816FD050
	
		// Methods
		private void Start(); // 0x00000001816FCF50-0x00000001816FD000
		private void OnEnable(); // 0x00000001816FCE80-0x00000001816FCF50
		private void LateUpdate(); // 0x00000001816FCCE0-0x00000001816FCE80
	}
}
