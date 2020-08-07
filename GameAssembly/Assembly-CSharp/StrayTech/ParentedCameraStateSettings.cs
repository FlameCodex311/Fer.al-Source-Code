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
	public class ParentedCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14524
	{
		// Fields
		[SerializeField] // 0x000000018024D320-0x000000018024D360
		[Tooltip] // 0x000000018024D320-0x000000018024D360
		private GameObject _parent; // 0x10
		[SerializeField] // 0x000000018024D560-0x000000018024D5A0
		[Tooltip] // 0x000000018024D560-0x000000018024D5A0
		private Vector3 _positionOffset; // 0x18
		[SerializeField] // 0x000000018024D780-0x000000018024D7C0
		[Tooltip] // 0x000000018024D780-0x000000018024D7C0
		private Vector3 _rotationOffset; // 0x24
		[SerializeField] // 0x000000018024D170-0x000000018024D1B0
		[Tooltip] // 0x000000018024D170-0x000000018024D1B0
		private bool _useCameraCollision; // 0x30
	
		// Properties
		public GameObject Parent { get; } // 0x0000000180372440-0x0000000180372450 
		public Vector3 PositionOffset { get; } // 0x0000000180CB5AC0-0x0000000180CB5AE0 
		public Vector3 RotationOffset { get; } // 0x00000001806757C0-0x00000001806757E0 
		public bool UseCameraCollision { get; } // 0x0000000180455B90-0x0000000180455BA0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180765950-0x0000000180765960 
	
		// Constructors
		public ParentedCameraStateSettings(GameObject parent, Vector3 positionOffset, Vector3 rotationOffset); // 0x0000000180CB5DF0-0x0000000180CB5EC0
	}
}
