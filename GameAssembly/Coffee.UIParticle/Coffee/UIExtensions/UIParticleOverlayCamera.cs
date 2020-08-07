/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Coffee.UIParticle.dll - Assembly: Coffee.UIParticle, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9143-9148

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class UIParticleOverlayCamera : UnityEngine.MonoBehaviour // TypeDefIndex: 9148
	{
		// Fields
		private Camera m_Camera; // 0x18
		private static UIParticleOverlayCamera s_Instance; // 0x00
	
		// Properties
		public static UIParticleOverlayCamera instance { get; } // 0x00000001820C1690-0x00000001820C18C0 
		private Camera cameraForOvrelay { get; } // 0x00000001820C15B0-0x00000001820C1690 
	
		// Constructors
		public UIParticleOverlayCamera(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		public static Camera GetCameraForOvrelay(Canvas canvas); // 0x00000001820C1350-0x00000001820C1520
		private void Awake(); // 0x00000001820C1110-0x00000001820C1350
		private void OnDestroy(); // 0x00000001820C1520-0x00000001820C15B0
	}
}
