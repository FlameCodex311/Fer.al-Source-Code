/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions.Demos
{
	public class SoftMask_Demo : MonoBehaviour // TypeDefIndex: 16355
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawImage[] softMaskBufferViewer; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SoftMask[] softMask; // 0x28
	
		// Constructors
		public SoftMask_Demo(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void OnEnable(); // 0x0000000180785280-0x0000000180785360
		private void Update(); // 0x00000001803774A0-0x00000001803774B0
		public void SetWorldSpase(bool flag); // 0x0000000180785440-0x0000000180785580
		public void SetScreenSpase(bool flag); // 0x00000001807853D0-0x0000000180785440
		public void SetOverlay(bool flag); // 0x0000000180785360-0x00000001807853D0
	}
}
