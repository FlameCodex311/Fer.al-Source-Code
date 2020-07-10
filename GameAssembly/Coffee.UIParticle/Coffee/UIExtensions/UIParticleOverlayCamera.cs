/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 76: Coffee.UIParticle.dll - Assembly: Coffee.UIParticle, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8977-8982

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class UIParticleOverlayCamera : UnityEngine.MonoBehaviour // TypeDefIndex: 8982
	{
		// Fields
		private Camera m_Camera; // 0x18
		private static UIParticleOverlayCamera s_Instance; // 0x00
	
		// Properties
		public static UIParticleOverlayCamera instance { get; } // 0x00000001822C98F0-0x00000001822C9B30 
		private Camera cameraForOvrelay { get; } // 0x00000001822C9810-0x00000001822C98F0 
	
		// Constructors
		public UIParticleOverlayCamera(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		public static Camera GetCameraForOvrelay(Canvas canvas); // 0x00000001822C95B0-0x00000001822C9780
		private void Awake(); // 0x00000001822C9370-0x00000001822C95B0
		private void OnDestroy(); // 0x00000001822C9780-0x00000001822C9810
	}
}
