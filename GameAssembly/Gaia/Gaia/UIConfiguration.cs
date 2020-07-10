/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class UIConfiguration : UnityEngine.MonoBehaviour // TypeDefIndex: 9107
	{
		// Fields
		[Header] // 0x00000001800F3410-0x00000001800F3470
		[Tooltip] // 0x00000001800F3410-0x00000001800F3470
		public Color32 m_uiTextColor; // 0x18
		[Tooltip] // 0x00000001800F37B0-0x00000001800F37E0
		public KeyCode m_uiToggleButton; // 0x1C
		private UnityEngine.UI.Text m_textContent; // 0x20
		private Color32 storedColor; // 0x28
		private bool storedUIStatus; // 0x2C
	
		// Constructors
		public UIConfiguration(); // 0x0000000181C07E00-0x0000000181C07E50
	
		// Methods
		private void Start(); // 0x0000000181C07D50-0x0000000181C07E00
		private void OnEnable(); // 0x0000000181C07C80-0x0000000181C07D50
		private void LateUpdate(); // 0x0000000181C07AE0-0x0000000181C07C80
	}
}
