/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class CameraController : UnityEngine.MonoBehaviour // TypeDefIndex: 9755
	{
		// Fields
		public Transform target; // 0x18
		public Transform rotationSpace; // 0x20
		public UpdateMode updateMode; // 0x28
		public bool lockCursor; // 0x2C
		[Header] // 0x00000001801E71F0-0x00000001801E7220
		public bool smoothFollow; // 0x2D
		public Vector3 offset; // 0x30
		public float followSpeed; // 0x3C
		[Header] // 0x00000001801E7730-0x00000001801E7760
		public float rotationSensitivity; // 0x40
		public float yMinLimit; // 0x44
		public float yMaxLimit; // 0x48
		public bool rotateAlways; // 0x4C
		public bool rotateOnLeftButton; // 0x4D
		public bool rotateOnRightButton; // 0x4E
		public bool rotateOnMiddleButton; // 0x4F
		[Header] // 0x00000001802023F0-0x0000000180202420
		public float distance; // 0x50
		public float minDistance; // 0x54
		public float maxDistance; // 0x58
		public float zoomSpeed; // 0x5C
		public float zoomSensitivity; // 0x60
		[Header] // 0x00000001802025B0-0x00000001802025E0
		public LayerMask blockingLayers; // 0x64
		public float blockingRadius; // 0x68
		public float blockingSmoothTime; // 0x6C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float blockedOffset; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <x>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <y>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <distanceTarget>k__BackingField; // 0x7C
		private Vector3 targetDistance; // 0x80
		private Vector3 position; // 0x8C
		private Quaternion rotation; // 0x98
		private Vector3 smoothPosition; // 0xA8
		private Camera cam; // 0xB8
		private bool fixedFrame; // 0xC0
		private float fixedDeltaTime; // 0xC4
		private Quaternion r; // 0xC8
		private Vector3 lastUp; // 0xD8
		private float blockedDistance; // 0xE4
		private float blockedDistanceV; // 0xE8
	
		// Properties
		public float x { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180F8A040-0x0000000180F8A050 0x0000000180F8A050-0x0000000180F8A060
		public float y { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180780010-0x0000000180780020 0x000000018136DA00-0x000000018136DA10
		public float distanceTarget { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180780020-0x0000000180780030 0x0000000180CCDB60-0x0000000180CCDB70
		private float zoomAdd { get; } // 0x000000018136D9A0-0x000000018136DA00 
	
		// Nested types
		[Serializable]
		public enum UpdateMode // TypeDefIndex: 9756
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
			FixedLateUpdate = 3
		}
	
		// Constructors
		public CameraController(); // 0x000000018136D870-0x000000018136D9A0
	
		// Methods
		protected virtual void Awake(); // 0x000000018136CB10-0x000000018136CC70
		protected virtual void Update(); // 0x000000018136D840-0x000000018136D870
		protected virtual void FixedUpdate(); // 0x000000018136CD10-0x000000018136CD70
		protected virtual void LateUpdate(); // 0x000000018136CD70-0x000000018136CDE0
		public void UpdateInput(); // 0x000000018136CDE0-0x000000018136D030
		public void UpdateTransform(); // 0x000000018136D030-0x000000018136D060
		public void UpdateTransform(float deltaTime); // 0x000000018136D060-0x000000018136D840
		private float ClampAngle(float angle, float min, float max); // 0x000000018136CC70-0x000000018136CD10
	}
}
