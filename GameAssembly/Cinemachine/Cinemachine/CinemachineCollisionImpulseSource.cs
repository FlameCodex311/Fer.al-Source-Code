/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[DocumentationSorting] // 0x000000018011FBE0-0x000000018011FC10
	[SaveDuringPlay] // 0x000000018011FBE0-0x000000018011FC10
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 7386
	{
		// Fields
		[Header] // 0x0000000180165100-0x0000000180165160
		[Tooltip] // 0x0000000180165100-0x0000000180165160
		public LayerMask m_LayerMask; // 0x20
		[TagField] // 0x00000001801652E0-0x0000000180165330
		[Tooltip] // 0x00000001801652E0-0x0000000180165330
		public string m_IgnoreTag; // 0x28
		[Header] // 0x0000000180165680-0x00000001801656E0
		[Tooltip] // 0x0000000180165680-0x00000001801656E0
		public bool m_UseImpactDirection; // 0x30
		[Tooltip] // 0x0000000180165980-0x00000001801659B0
		public bool m_ScaleImpactWithMass; // 0x31
		[Tooltip] // 0x0000000180165B90-0x0000000180165BC0
		public bool m_ScaleImpactWithSpeed; // 0x32
		private Rigidbody mRigidBody; // 0x38
		private Rigidbody2D mRigidBody2D; // 0x40
	
		// Constructors
		public CinemachineCollisionImpulseSource(); // 0x00000001818B2400-0x00000001818B2460
	
		// Methods
		private void Start(); // 0x00000001818B23B0-0x00000001818B2400
		private void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
		private void OnCollisionEnter(Collision c); // 0x00000001818B2210-0x00000001818B2290
		private void OnTriggerEnter(Collider c); // 0x00000001818B2320-0x00000001818B23B0
		private float GetMassAndVelocity(Collider other, ref Vector3 vel); // 0x00000001818B1E30-0x00000001818B2140
		private void GenerateImpactEvent(Collider other, Vector3 vel); // 0x00000001818B1890-0x00000001818B1AF0
		private void OnCollisionEnter2D(Collision2D c); // 0x00000001818B2140-0x00000001818B2210
		private void OnTriggerEnter2D(Collider2D c); // 0x00000001818B2290-0x00000001818B2320
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel); // 0x00000001818B1AF0-0x00000001818B1E30
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel); // 0x00000001818B1630-0x00000001818B1890
	}
}
