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
	public class IsometricCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14523
	{
		// Fields
		[SerializeField] // 0x000000018024CD00-0x000000018024CD40
		[Tooltip] // 0x000000018024CD00-0x000000018024CD40
		private Vector3 _rotation; // 0x10
		[SerializeField] // 0x000000018024CF10-0x000000018024CF50
		[Tooltip] // 0x000000018024CF10-0x000000018024CF50
		private float _distance; // 0x1C
		[SerializeField] // 0x000000018024D170-0x000000018024D1B0
		[Tooltip] // 0x000000018024D170-0x000000018024D1B0
		private bool _useCameraCollision; // 0x20
	
		// Properties
		public Vector3 Rotation { get; } // 0x0000000180CB5720-0x0000000180CB5740 
		public float Distance { get; } // 0x0000000180918C20-0x0000000180918C30 
		public bool UseCameraCollision { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public IsometricCameraStateSettings(Vector3 rotation, float distance); // 0x0000000180CB5690-0x0000000180CB5720
	}
}
