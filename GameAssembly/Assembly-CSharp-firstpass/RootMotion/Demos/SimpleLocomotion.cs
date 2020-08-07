/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018021FCF0-0x000000018021FD40
	public class SimpleLocomotion : UnityEngine.MonoBehaviour // TypeDefIndex: 9853
	{
		// Fields
		[SerializeField] // 0x000000018021FF60-0x000000018021FFB0
		[Tooltip] // 0x000000018021FF60-0x000000018021FFB0
		private CameraController cameraController; // 0x18
		[SerializeField] // 0x0000000180220190-0x00000001802201E0
		[Tooltip] // 0x0000000180220190-0x00000001802201E0
		private float accelerationTime; // 0x20
		[SerializeField] // 0x00000001802205F0-0x0000000180220640
		[Tooltip] // 0x00000001802205F0-0x0000000180220640
		private float turnTime; // 0x24
		[SerializeField] // 0x0000000180220820-0x0000000180220870
		[Tooltip] // 0x0000000180220820-0x0000000180220870
		private bool walkByDefault; // 0x28
		[SerializeField] // 0x0000000180220B80-0x0000000180220BD0
		[Tooltip] // 0x0000000180220B80-0x0000000180220BD0
		private RotationMode rotationMode; // 0x2C
		[SerializeField] // 0x0000000180220E40-0x0000000180220E90
		[Tooltip] // 0x0000000180220E40-0x0000000180220E90
		private float moveSpeed; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isGrounded>k__BackingField; // 0x34
		private Animator animator; // 0x38
		private float speed; // 0x40
		private float angleVel; // 0x44
		private float speedVel; // 0x48
		private Vector3 linearTargetDirection; // 0x4C
		private CharacterController characterController; // 0x58
	
		// Properties
		public bool isGrounded { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180406600-0x0000000180406610 0x0000000180830BC0-0x0000000180830C00
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 9854
		{
			Smooth = 0,
			Linear = 1
		}
	
		// Constructors
		public SimpleLocomotion(); // 0x00000001813832B0-0x00000001813832D0
	
		// Methods
		private void Start(); // 0x00000001813831E0-0x0000000181383250
		private void Update(); // 0x0000000181383250-0x00000001813832B0
		private void LateUpdate(); // 0x0000000181382940-0x0000000181382990
		private void Rotate(); // 0x0000000181382CD0-0x00000001813831E0
		private void Move(); // 0x0000000181382990-0x0000000181382CD0
		private Vector3 GetInputVector(); // 0x0000000181382850-0x0000000181382940
		private Vector3 GetInputVectorRaw(); // 0x00000001813827D0-0x0000000181382850
	}
}
