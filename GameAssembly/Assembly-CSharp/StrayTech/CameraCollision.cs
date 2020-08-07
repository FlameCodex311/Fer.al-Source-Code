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
	public class CameraCollision : MonoBehaviourSingleton<StrayTech.CameraCollision> // TypeDefIndex: 14519
	{
		// Fields
		private float? _lastDistance; // 0x20
		private float _currentSmoothDampVelocity; // 0x28
		[SerializeField] // 0x000000018024ACD0-0x000000018024AD10
		[Tooltip] // 0x000000018024ACD0-0x000000018024AD10
		private bool _useCameraCollision; // 0x2C
		[SerializeField] // 0x000000018024AEA0-0x000000018024AEE0
		[Tooltip] // 0x000000018024AEA0-0x000000018024AEE0
		private CollisionTestType _testType; // 0x30
		[SerializeField] // 0x000000018024B010-0x000000018024B050
		[Tooltip] // 0x000000018024B010-0x000000018024B050
		private float _sphereRadius; // 0x34
		[SerializeField] // 0x000000018024B250-0x000000018024B290
		[Tooltip] // 0x000000018024B250-0x000000018024B290
		private float _smoothingTime; // 0x38
		[SerializeField] // 0x000000018024B500-0x000000018024B540
		[Tooltip] // 0x000000018024B500-0x000000018024B540
		private LayerMask _collisionLayerMask; // 0x3C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _editorDebugCollisionTransform; // 0x40
	
		// Properties
		public bool UseCameraCollision { get; set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260
		public CollisionTestType TestType { get; } // 0x00000001804AA650-0x00000001804AA660 
		public float SphereRadius { get; } // 0x00000001806CEAE0-0x00000001806CEAF0 
		public LayerMask CollisionLayerMask { get; } // 0x000000018099EBE0-0x000000018099EBF0 
	
		// Nested types
		public enum CollisionTestType // TypeDefIndex: 14520
		{
			SphereCast = 0,
			RayCast = 1
		}
	
		// Constructors
		public CameraCollision(); // 0x0000000180CA7720-0x0000000180CA7770
	
		// Methods
		public void PreventCameraCollision(Camera camera); // 0x0000000180CA7260-0x0000000180CA7720
	}
}
