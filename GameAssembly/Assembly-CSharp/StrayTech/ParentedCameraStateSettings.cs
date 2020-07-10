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
	public class ParentedCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13857
	{
		// Fields
		[SerializeField] // 0x0000000180122660-0x00000001801226A0
		[Tooltip] // 0x0000000180122660-0x00000001801226A0
		private GameObject _parent; // 0x10
		[SerializeField] // 0x0000000180122840-0x0000000180122880
		[Tooltip] // 0x0000000180122840-0x0000000180122880
		private Vector3 _positionOffset; // 0x18
		[SerializeField] // 0x0000000180122A80-0x0000000180122AC0
		[Tooltip] // 0x0000000180122A80-0x0000000180122AC0
		private Vector3 _rotationOffset; // 0x24
		[SerializeField] // 0x0000000180122380-0x00000001801223C0
		[Tooltip] // 0x0000000180122380-0x00000001801223C0
		private bool _useCameraCollision; // 0x30
	
		// Properties
		public GameObject Parent { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Vector3 PositionOffset { get; } // 0x0000000181200DA0-0x0000000181200DC0 
		public Vector3 RotationOffset { get; } // 0x00000001807A1520-0x00000001807A1540 
		public bool UseCameraCollision { get; } // 0x000000018048B840-0x000000018048B850 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180855970-0x0000000180855980 
	
		// Constructors
		public ParentedCameraStateSettings(GameObject parent, Vector3 positionOffset, Vector3 rotationOffset); // 0x00000001812013D0-0x00000001812014A0
	}
}
