/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions.Demos
{
	public class SoftMask_Demo : MonoBehaviour // TypeDefIndex: 15516
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage[] softMaskBufferViewer; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SoftMask[] softMask; // 0x28
	
		// Constructors
		public SoftMask_Demo(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void OnEnable(); // 0x000000018127FD10-0x000000018127FE00
		private void Update(); // 0x00000001803581E0-0x00000001803581F0
		public void SetWorldSpase(bool flag); // 0x000000018127FEE0-0x0000000181280020
		public void SetScreenSpase(bool flag); // 0x000000018127FE70-0x000000018127FEE0
		public void SetOverlay(bool flag); // 0x000000018127FE00-0x000000018127FE70
	}
}
