/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[Serializable]
	public class PivotCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14525
	{
		// Fields
		[SerializeField] // 0x000000018024E020-0x000000018024E060
		[Tooltip] // 0x000000018024E020-0x000000018024E060
		private Transform _pivotHost; // 0x10
		[SerializeField] // 0x000000018024E250-0x000000018024E290
		[Tooltip] // 0x000000018024E250-0x000000018024E290
		private Vector3 _pivotHostOffset; // 0x18
		[SerializeField] // 0x000000018024D170-0x000000018024D1B0
		[Tooltip] // 0x000000018024D170-0x000000018024D1B0
		private bool _useCameraCollision; // 0x24
	
		// Properties
		public Transform PivotHost { get; } // 0x0000000180372440-0x0000000180372450 
		public Vector3 PivotHostOffset { get; } // 0x0000000180CB5AC0-0x0000000180CB5AE0 
		public bool UseCameraCollision { get; } // 0x00000001804F2E90-0x00000001804F2EA0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018040D640-0x000000018040D650 
	
		// Constructors
		public PivotCameraStateSettings(Transform pivotHost, Vector3 pivotHostOffset); // 0x0000000180CB6320-0x0000000180CB63A0
	}
}
