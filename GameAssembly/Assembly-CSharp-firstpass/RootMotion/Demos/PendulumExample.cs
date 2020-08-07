/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x0000000180213DA0-0x0000000180213DF0
	public class PendulumExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9821
	{
		// Fields
		[Range] // 0x00000001802140C0-0x0000000180214120
		[Tooltip] // 0x00000001802140C0-0x0000000180214120
		public float weight; // 0x18
		[Tooltip] // 0x0000000180214330-0x0000000180214360
		public float hangingDistanceMlp; // 0x1C
		[HideInInspector] // 0x00000001802145A0-0x00000001802145F0
		[Tooltip] // 0x00000001802145A0-0x00000001802145F0
		public Vector3 rootTargetPosition; // 0x20
		[HideInInspector] // 0x0000000180214940-0x0000000180214990
		[Tooltip] // 0x0000000180214940-0x0000000180214990
		public Quaternion rootTargetRotation; // 0x2C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform target; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform leftHandTarget; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform rightHandTarget; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform leftFootTarget; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform rightFootTarget; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform pelvisTarget; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform bodyTarget; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform headTarget; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 pelvisDownAxis; // 0x80
		private FullBodyBipedIK ik; // 0x90
		private Quaternion rootRelativeToPelvis; // 0x98
		private Vector3 pelvisToRoot; // 0xA8
		private float lastWeight; // 0xB4
	
		// Constructors
		public PendulumExample(); // 0x0000000181380170-0x00000001813801F0
	
		// Methods
		private void Start(); // 0x000000018137FD40-0x0000000181380170
		private void LateUpdate(); // 0x000000018137F2A0-0x000000018137FD40
	}
}
