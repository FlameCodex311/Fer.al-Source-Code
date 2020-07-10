/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[Serializable]
	public class PivotCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13858
	{
		// Fields
		[SerializeField] // 0x0000000180122EF0-0x0000000180122F30
		[Tooltip] // 0x0000000180122EF0-0x0000000180122F30
		private Transform _pivotHost; // 0x10
		[SerializeField] // 0x00000001801245B0-0x00000001801245F0
		[Tooltip] // 0x00000001801245B0-0x00000001801245F0
		private Vector3 _pivotHostOffset; // 0x18
		[SerializeField] // 0x0000000180122380-0x00000001801223C0
		[Tooltip] // 0x0000000180122380-0x00000001801223C0
		private bool _useCameraCollision; // 0x24
	
		// Properties
		public Transform PivotHost { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Vector3 PivotHostOffset { get; } // 0x0000000181200DA0-0x0000000181200DC0 
		public bool UseCameraCollision { get; } // 0x0000000180487D80-0x0000000180487D90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018035E180-0x000000018035E190 
	
		// Constructors
		public PivotCameraStateSettings(Transform pivotHost, Vector3 pivotHostOffset); // 0x00000001812017B0-0x0000000181201830
	}
}
