/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class RuntimeStamper : UnityEngine.MonoBehaviour // TypeDefIndex: 9075
	{
		// Fields
		public bool m_showGUI; // 0x18
		public bool m_showDebug; // 0x19
		public string m_stampAddress; // 0x20
		public string m_currentProgress; // 0x28
		private Rect m_currentPosition; // 0x30
		private Stamper m_stamper; // 0x40
	
		// Constructors
		public RuntimeStamper(); // 0x0000000181792AB0-0x0000000181792B00
	
		// Methods
		private void Awake(); // 0x0000000181792510-0x0000000181792550
		private void Start(); // 0x0000000181792AA0-0x0000000181792AB0
		private void LateUpdate(); // 0x0000000181792870-0x0000000181792A20
		private void OnGUI(); // 0x0000000181792A20-0x0000000181792AA0
		private void CreateStamper(); // 0x0000000181792550-0x0000000181792870
	}
}
