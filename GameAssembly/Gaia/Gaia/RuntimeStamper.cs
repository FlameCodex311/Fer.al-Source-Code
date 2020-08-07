/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class RuntimeStamper : UnityEngine.MonoBehaviour // TypeDefIndex: 9241
	{
		// Fields
		public bool m_showGUI; // 0x18
		public bool m_showDebug; // 0x19
		public string m_stampAddress; // 0x20
		public string m_currentProgress; // 0x28
		private Rect m_currentPosition; // 0x30
		private Stamper m_stamper; // 0x40
	
		// Constructors
		public RuntimeStamper(); // 0x000000018155B9C0-0x000000018155BA10
	
		// Methods
		private void Awake(); // 0x000000018155B430-0x000000018155B470
		private void Start(); // 0x000000018155B9B0-0x000000018155B9C0
		private void LateUpdate(); // 0x000000018155B780-0x000000018155B930
		private void OnGUI(); // 0x000000018155B930-0x000000018155B9B0
		private void CreateStamper(); // 0x000000018155B470-0x000000018155B780
	}
}
