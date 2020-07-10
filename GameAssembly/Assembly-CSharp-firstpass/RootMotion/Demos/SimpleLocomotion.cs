/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001800E4290-0x00000001800E42E0
	public class SimpleLocomotion : UnityEngine.MonoBehaviour // TypeDefIndex: 9566
	{
		// Fields
		[SerializeField] // 0x00000001800E45E0-0x00000001800E4630
		[Tooltip] // 0x00000001800E45E0-0x00000001800E4630
		private CameraController cameraController; // 0x18
		[SerializeField] // 0x00000001800E48E0-0x00000001800E4930
		[Tooltip] // 0x00000001800E48E0-0x00000001800E4930
		private float accelerationTime; // 0x20
		[SerializeField] // 0x00000001800E4BF0-0x00000001800E4C40
		[Tooltip] // 0x00000001800E4BF0-0x00000001800E4C40
		private float turnTime; // 0x24
		[SerializeField] // 0x00000001800E4F80-0x00000001800E4FD0
		[Tooltip] // 0x00000001800E4F80-0x00000001800E4FD0
		private bool walkByDefault; // 0x28
		[SerializeField] // 0x00000001800E5200-0x00000001800E5250
		[Tooltip] // 0x00000001800E5200-0x00000001800E5250
		private RotationMode rotationMode; // 0x2C
		[SerializeField] // 0x00000001800E5800-0x00000001800E5850
		[Tooltip] // 0x00000001800E5800-0x00000001800E5850
		private float moveSpeed; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isGrounded>k__BackingField; // 0x34
		private Animator animator; // 0x38
		private float speed; // 0x40
		private float angleVel; // 0x44
		private float speedVel; // 0x48
		private Vector3 linearTargetDirection; // 0x4C
		private CharacterController characterController; // 0x58
	
		// Properties
		public bool isGrounded { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357070-0x0000000180357080 0x0000000180425360-0x00000001804253A0
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 9567
		{
			Smooth = 0,
			Linear = 1
		}
	
		// Constructors
		public SimpleLocomotion(); // 0x000000018183CF60-0x000000018183CF80
	
		// Methods
		private void Start(); // 0x000000018183CE90-0x000000018183CF00
		private void Update(); // 0x000000018183CF00-0x000000018183CF60
		private void LateUpdate(); // 0x000000018183C5F0-0x000000018183C630
		private void Rotate(); // 0x000000018183C970-0x000000018183CE90
		private void Move(); // 0x000000018183C630-0x000000018183C970
		private Vector3 GetInputVector(); // 0x000000018183C500-0x000000018183C5F0
		private Vector3 GetInputVectorRaw(); // 0x000000018183C480-0x000000018183C500
	}
}
