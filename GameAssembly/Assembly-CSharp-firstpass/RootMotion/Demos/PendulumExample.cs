/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001800DA3D0-0x00000001800DA420
	public class PendulumExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9534
	{
		// Fields
		[Range] // 0x00000001800DA760-0x00000001800DA7C0
		[Tooltip] // 0x00000001800DA760-0x00000001800DA7C0
		public float weight; // 0x18
		[Tooltip] // 0x00000001800DA9E0-0x00000001800DAA10
		public float hangingDistanceMlp; // 0x1C
		[HideInInspector] // 0x00000001800DAB40-0x00000001800DAB90
		[Tooltip] // 0x00000001800DAB40-0x00000001800DAB90
		public Vector3 rootTargetPosition; // 0x20
		[HideInInspector] // 0x00000001800DAD60-0x00000001800DADB0
		[Tooltip] // 0x00000001800DAD60-0x00000001800DADB0
		public Quaternion rootTargetRotation; // 0x2C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform target; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform leftHandTarget; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform rightHandTarget; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform leftFootTarget; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform rightFootTarget; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform pelvisTarget; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform bodyTarget; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform headTarget; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 pelvisDownAxis; // 0x80
		private FullBodyBipedIK ik; // 0x90
		private Quaternion rootRelativeToPelvis; // 0x98
		private Vector3 pelvisToRoot; // 0xA8
		private float lastWeight; // 0xB4
	
		// Constructors
		public PendulumExample(); // 0x0000000181839930-0x00000001818399B0
	
		// Methods
		private void Start(); // 0x00000001818394E0-0x0000000181839930
		private void LateUpdate(); // 0x00000001818389F0-0x00000001818394E0
	}
}
