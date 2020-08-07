/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801ECBB0-0x00000001801ECBE0
public class DynamicBone : MonoBehaviour // TypeDefIndex: 11461
{
	// Fields
	[Tooltip] // 0x00000001801ECD60-0x00000001801ECD90
	public Transform m_Root; // 0x20
	[Tooltip] // 0x00000001801ECE50-0x00000001801ECE80
	public float m_UpdateRate; // 0x28
	public UpdateMode m_UpdateMode; // 0x2C
	[Range] // 0x00000001801ED150-0x00000001801ED1B0
	[Tooltip] // 0x00000001801ED150-0x00000001801ED1B0
	public float m_Damping; // 0x30
	public AnimationCurve m_DampingDistrib; // 0x38
	[Range] // 0x00000001801ED350-0x00000001801ED3B0
	[Tooltip] // 0x00000001801ED350-0x00000001801ED3B0
	public float m_Elasticity; // 0x40
	public AnimationCurve m_ElasticityDistrib; // 0x48
	[Range] // 0x00000001801ED640-0x00000001801ED6A0
	[Tooltip] // 0x00000001801ED640-0x00000001801ED6A0
	public float m_Stiffness; // 0x50
	public AnimationCurve m_StiffnessDistrib; // 0x58
	[Range] // 0x00000001801ED820-0x00000001801ED880
	[Tooltip] // 0x00000001801ED820-0x00000001801ED880
	public float m_Inert; // 0x60
	public AnimationCurve m_InertDistrib; // 0x68
	[Tooltip] // 0x00000001801EDAF0-0x00000001801EDB20
	public float m_Friction; // 0x70
	public AnimationCurve m_FrictionDistrib; // 0x78
	[Tooltip] // 0x00000001801EDBF0-0x00000001801EDC20
	public float m_Radius; // 0x80
	public AnimationCurve m_RadiusDistrib; // 0x88
	[Tooltip] // 0x00000001801EDD60-0x00000001801EDD90
	public float m_EndLength; // 0x90
	[Tooltip] // 0x00000001801EDFA0-0x00000001801EDFD0
	public Vector3 m_EndOffset; // 0x94
	[Tooltip] // 0x00000001801EE020-0x00000001801EE050
	public Vector3 m_Gravity; // 0xA0
	[Tooltip] // 0x00000001801EE270-0x00000001801EE2A0
	public Vector3 m_Force; // 0xAC
	[Tooltip] // 0x00000001801EE460-0x00000001801EE490
	public List<DynamicBoneColliderBase> m_Colliders; // 0xB8
	[Tooltip] // 0x00000001801EE670-0x00000001801EE6A0
	public List<Transform> m_Exclusions; // 0xC0
	[Tooltip] // 0x00000001801EE850-0x00000001801EE880
	public FreezeAxis m_FreezeAxis; // 0xC8
	[Tooltip] // 0x00000001801EEB30-0x00000001801EEB60
	public bool m_DistantDisable; // 0xCC
	public Transform m_ReferenceObject; // 0xD0
	public float m_DistanceToObject; // 0xD8
	private Vector3 m_LocalGravity; // 0xDC
	private Vector3 m_ObjectMove; // 0xE8
	private Vector3 m_ObjectPrevPosition; // 0xF4
	private float m_BoneTotalLength; // 0x100
	private float m_ObjectScale; // 0x104
	private float m_Time; // 0x108
	private float m_Weight; // 0x10C
	private bool m_DistantDisabled; // 0x110
	private List<Particle> m_Particles; // 0x118

	// Nested types
	public enum UpdateMode // TypeDefIndex: 11462
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum FreezeAxis // TypeDefIndex: 11463
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3
	}

	private class Particle // TypeDefIndex: 11464
	{
		// Fields
		public Transform m_Transform; // 0x10
		public int m_ParentIndex; // 0x18
		public float m_Damping; // 0x1C
		public float m_Elasticity; // 0x20
		public float m_Stiffness; // 0x24
		public float m_Inert; // 0x28
		public float m_Friction; // 0x2C
		public float m_Radius; // 0x30
		public float m_BoneLength; // 0x34
		public bool m_isCollide; // 0x38
		public Vector3 m_Position; // 0x3C
		public Vector3 m_PrevPosition; // 0x48
		public Vector3 m_EndOffset; // 0x54
		public Vector3 m_InitLocalPosition; // 0x60
		public Quaternion m_InitLocalRotation; // 0x6C

		// Constructors
		public Particle(); // 0x0000000180869E50-0x0000000180869F50
	}

	// Constructors
	public DynamicBone(); // 0x000000018085C930-0x000000018085CAB0

	// Methods
	public void Reset(); // 0x000000018085A460-0x000000018085A490
	private void Start(); // 0x000000018085AFC0-0x000000018085AFD0
	private void FixedUpdate(); // 0x0000000180859B90-0x0000000180859C60
	private void Update(); // 0x000000018085C860-0x000000018085C930
	private void LateUpdate(); // 0x00000001803774A0-0x00000001803774B0
	private void PreUpdate(); // 0x000000018085A240-0x000000018085A270
	private void CheckDistance(); // 0x0000000180859970-0x0000000180859B90
	private void OnEnable(); // 0x000000018085A120-0x000000018085A130
	private void OnDisable(); // 0x0000000180859EE0-0x0000000180859EF0
	private void OnValidate(); // 0x000000018085A130-0x000000018085A240
	private void OnDrawGizmosSelected(); // 0x0000000180859EF0-0x000000018085A120
	public void SetWeight(float w); // 0x000000018085A490-0x000000018085A500
	public float GetWeight(); // 0x0000000180859C60-0x0000000180859C70
	private void UpdateDynamicBones(float t); // 0x000000018085AFD0-0x000000018085B280
	private void SetupParticles(); // 0x000000018085A500-0x000000018085A6F0
	private void AppendParticles(Transform b, int parentIndex, float boneLength); // 0x0000000180858C60-0x0000000180859550
	public void UpdateParameters(); // 0x000000018085B280-0x000000018085B6C0
	private void InitTransforms(); // 0x0000000180859C70-0x0000000180859DD0
	private void ResetParticlesPosition(); // 0x000000018085A270-0x000000018085A460
	private void UpdateParticles1(); // 0x000000018085B6C0-0x000000018085BC30
	private void UpdateParticles2(); // 0x000000018085BC30-0x000000018085C860
	private void SkipUpdateParticles(); // 0x000000018085A6F0-0x000000018085AFC0
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis); // 0x0000000180859DD0-0x0000000180859EE0
	private void ApplyParticlesToTransforms(); // 0x0000000180859550-0x0000000180859970
}

