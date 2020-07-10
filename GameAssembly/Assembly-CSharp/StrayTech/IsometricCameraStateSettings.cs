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
	public class IsometricCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13856
	{
		// Fields
		[SerializeField] // 0x0000000180121F00-0x0000000180121F40
		[Tooltip] // 0x0000000180121F00-0x0000000180121F40
		private Vector3 _rotation; // 0x10
		[SerializeField] // 0x0000000180122170-0x00000001801221B0
		[Tooltip] // 0x0000000180122170-0x00000001801221B0
		private float _distance; // 0x1C
		[SerializeField] // 0x0000000180122380-0x00000001801223C0
		[Tooltip] // 0x0000000180122380-0x00000001801223C0
		private bool _useCameraCollision; // 0x20
	
		// Properties
		public Vector3 Rotation { get; } // 0x0000000180C49CA0-0x0000000180C49CC0 
		public float Distance { get; } // 0x00000001805D9070-0x00000001805D9080 
		public bool UseCameraCollision { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public IsometricCameraStateSettings(Vector3 rotation, float distance); // 0x0000000181200980-0x0000000181200A10
	}
}
