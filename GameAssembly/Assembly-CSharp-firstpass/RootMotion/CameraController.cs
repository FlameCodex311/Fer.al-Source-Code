/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class CameraController : UnityEngine.MonoBehaviour // TypeDefIndex: 9301
	{
		// Fields
		public Transform target; // 0x18
		public Transform rotationSpace; // 0x20
		public UpdateMode updateMode; // 0x28
		public bool lockCursor; // 0x2C
		[Header] // 0x0000000180108D40-0x0000000180108D70
		public bool smoothFollow; // 0x2D
		public Vector3 offset; // 0x30
		public float followSpeed; // 0x3C
		[Header] // 0x00000001800E34E0-0x00000001800E3510
		public float rotationSensitivity; // 0x40
		public float yMinLimit; // 0x44
		public float yMaxLimit; // 0x48
		public bool rotateAlways; // 0x4C
		public bool rotateOnLeftButton; // 0x4D
		public bool rotateOnRightButton; // 0x4E
		public bool rotateOnMiddleButton; // 0x4F
		[Header] // 0x000000018011A7E0-0x000000018011A810
		public float distance; // 0x50
		public float minDistance; // 0x54
		public float maxDistance; // 0x58
		public float zoomSpeed; // 0x5C
		public float zoomSensitivity; // 0x60
		[Header] // 0x000000018011A9C0-0x000000018011A9F0
		public LayerMask blockingLayers; // 0x64
		public float blockingRadius; // 0x68
		public float blockingSmoothTime; // 0x6C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float blockedOffset; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <x>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <y>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public float x { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181411C40-0x0000000181411C50 0x0000000181646E90-0x0000000181646EA0
		public float y { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181411C20-0x0000000181411C30 0x0000000181646EA0-0x0000000181646EB0
		public float distanceTarget { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181411C30-0x0000000181411C40 0x0000000181646E80-0x0000000181646E90
		private float zoomAdd { get; } // 0x0000000181646E20-0x0000000181646E80 
	
		// Nested types
		[Serializable]
		public enum UpdateMode // TypeDefIndex: 9302
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
			FixedLateUpdate = 3
		}
	
		// Constructors
		public CameraController(); // 0x0000000181646CF0-0x0000000181646E20
	
		// Methods
		protected virtual void Awake(); // 0x0000000181645F70-0x00000001816460E0
		protected virtual void Update(); // 0x0000000181646CC0-0x0000000181646CF0
		protected virtual void FixedUpdate(); // 0x0000000181646180-0x00000001816461E0
		protected virtual void LateUpdate(); // 0x00000001816461E0-0x0000000181646250
		public void UpdateInput(); // 0x0000000181646250-0x00000001816464A0
		public void UpdateTransform(); // 0x00000001816464A0-0x00000001816464D0
		public void UpdateTransform(float deltaTime); // 0x00000001816464D0-0x0000000181646CC0
		private float ClampAngle(float angle, float min, float max); // 0x00000001816460E0-0x0000000181646180
	}
}
