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
	public class CameraCollision : MonoBehaviourSingleton<StrayTech.CameraCollision> // TypeDefIndex: 13852
	{
		// Fields
		private float? _lastDistance; // 0x20
		private float _currentSmoothDampVelocity; // 0x28
		[SerializeField] // 0x000000018011E630-0x000000018011E670
		[Tooltip] // 0x000000018011E630-0x000000018011E670
		private bool _useCameraCollision; // 0x2C
		[SerializeField] // 0x000000018011E870-0x000000018011E8B0
		[Tooltip] // 0x000000018011E870-0x000000018011E8B0
		private CollisionTestType _testType; // 0x30
		[SerializeField] // 0x000000018011EB90-0x000000018011EBD0
		[Tooltip] // 0x000000018011EB90-0x000000018011EBD0
		private float _sphereRadius; // 0x34
		[SerializeField] // 0x000000018011EDA0-0x000000018011EDE0
		[Tooltip] // 0x000000018011EDA0-0x000000018011EDE0
		private float _smoothingTime; // 0x38
		[SerializeField] // 0x000000018011F060-0x000000018011F0A0
		[Tooltip] // 0x000000018011F060-0x000000018011F0A0
		private LayerMask _collisionLayerMask; // 0x3C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform _editorDebugCollisionTransform; // 0x40
	
		// Properties
		public bool UseCameraCollision { get; set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620
		public CollisionTestType TestType { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		public float SphereRadius { get; } // 0x00000001804C16A0-0x00000001804C16B0 
		public LayerMask CollisionLayerMask { get; } // 0x0000000180487DC0-0x0000000180487DD0 
	
		// Nested types
		public enum CollisionTestType // TypeDefIndex: 13853
		{
			SphereCast = 0,
			RayCast = 1
		}
	
		// Constructors
		public CameraCollision(); // 0x0000000181348FF0-0x0000000181349040
	
		// Methods
		public void PreventCameraCollision(Camera camera); // 0x0000000181348B30-0x0000000181348FF0
	}
}
