/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[DocumentationSorting] // 0x0000000180205D10-0x0000000180205D40
	[SaveDuringPlay] // 0x0000000180205D10-0x0000000180205D40
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 7552
	{
		// Fields
		[Header] // 0x0000000180207E80-0x0000000180207EE0
		[Tooltip] // 0x0000000180207E80-0x0000000180207EE0
		public LayerMask m_LayerMask; // 0x20
		[TagField] // 0x0000000180208170-0x00000001802081C0
		[Tooltip] // 0x0000000180208170-0x00000001802081C0
		public string m_IgnoreTag; // 0x28
		[Header] // 0x0000000180208400-0x0000000180208460
		[Tooltip] // 0x0000000180208400-0x0000000180208460
		public bool m_UseImpactDirection; // 0x30
		[Tooltip] // 0x00000001802086A0-0x00000001802086D0
		public bool m_ScaleImpactWithMass; // 0x31
		[Tooltip] // 0x0000000180208970-0x00000001802089A0
		public bool m_ScaleImpactWithSpeed; // 0x32
		private Rigidbody mRigidBody; // 0x38
		private Rigidbody2D mRigidBody2D; // 0x40
	
		// Constructors
		public CinemachineCollisionImpulseSource(); // 0x00000001813587B0-0x0000000181358810
	
		// Methods
		private void Start(); // 0x0000000181358760-0x00000001813587B0
		private void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
		private void OnCollisionEnter(Collision c); // 0x00000001813585C0-0x0000000181358640
		private void OnTriggerEnter(Collider c); // 0x00000001813586D0-0x0000000181358760
		private float GetMassAndVelocity(Collider other, ref Vector3 vel); // 0x00000001813581E0-0x00000001813584F0
		private void GenerateImpactEvent(Collider other, Vector3 vel); // 0x0000000181357C50-0x0000000181357EB0
		private void OnCollisionEnter2D(Collision2D c); // 0x00000001813584F0-0x00000001813585C0
		private void OnTriggerEnter2D(Collider2D c); // 0x0000000181358640-0x00000001813586D0
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel); // 0x0000000181357EB0-0x00000001813581E0
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel); // 0x00000001813579F0-0x0000000181357C50
	}
}
