/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x000000018010F1E0-0x000000018010F210
public class DynamicBone : MonoBehaviour // TypeDefIndex: 13788
{
	// Fields
	[Tooltip] // 0x000000018010F350-0x000000018010F380
	public Transform m_Root; // 0x20
	[Tooltip] // 0x000000018010F500-0x000000018010F530
	public float m_UpdateRate; // 0x28
	public UpdateMode m_UpdateMode; // 0x2C
	[Range] // 0x000000018010F710-0x000000018010F770
	[Tooltip] // 0x000000018010F710-0x000000018010F770
	public float m_Damping; // 0x30
	public AnimationCurve m_DampingDistrib; // 0x38
	[Range] // 0x000000018010FAA0-0x000000018010FB00
	[Tooltip] // 0x000000018010FAA0-0x000000018010FB00
	public float m_Elasticity; // 0x40
	public AnimationCurve m_ElasticityDistrib; // 0x48
	[Range] // 0x000000018010FCF0-0x000000018010FD50
	[Tooltip] // 0x000000018010FCF0-0x000000018010FD50
	public float m_Stiffness; // 0x50
	public AnimationCurve m_StiffnessDistrib; // 0x58
	[Range] // 0x000000018010FFB0-0x0000000180110010
	[Tooltip] // 0x000000018010FFB0-0x0000000180110010
	public float m_Inert; // 0x60
	public AnimationCurve m_InertDistrib; // 0x68
	[Tooltip] // 0x00000001801102E0-0x0000000180110310
	public float m_Friction; // 0x70
	public AnimationCurve m_FrictionDistrib; // 0x78
	[Tooltip] // 0x00000001801104C0-0x00000001801104F0
	public float m_Radius; // 0x80
	public AnimationCurve m_RadiusDistrib; // 0x88
	[Tooltip] // 0x0000000180110750-0x0000000180110780
	public float m_EndLength; // 0x90
	[Tooltip] // 0x0000000180110990-0x00000001801109C0
	public Vector3 m_EndOffset; // 0x94
	[Tooltip] // 0x0000000180110C30-0x0000000180110C60
	public Vector3 m_Gravity; // 0xA0
	[Tooltip] // 0x0000000180110E90-0x0000000180110EC0
	public Vector3 m_Force; // 0xAC
	[Tooltip] // 0x00000001801110D0-0x0000000180111100
	public List<DynamicBoneColliderBase> m_Colliders; // 0xB8
	[Tooltip] // 0x0000000180111310-0x0000000180111340
	public List<Transform> m_Exclusions; // 0xC0
	[Tooltip] // 0x0000000180111430-0x0000000180111460
	public FreezeAxis m_FreezeAxis; // 0xC8
	[Tooltip] // 0x0000000180111530-0x0000000180111560
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
	public enum UpdateMode // TypeDefIndex: 13789
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2
	}

	public enum FreezeAxis // TypeDefIndex: 13790
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3
	}

	private class Particle // TypeDefIndex: 13791
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
		public Particle(); // 0x00000001811997E0-0x00000001811998E0
	}

	// Constructors
	public DynamicBone(); // 0x000000018118FCC0-0x000000018118FE40

	// Methods
	public void Reset(); // 0x000000018118D7C0-0x000000018118D7F0
	private void Start(); // 0x000000018118E350-0x000000018118E360
	private void FixedUpdate(); // 0x000000018118CF20-0x000000018118CFA0
	private void Update(); // 0x000000018118FC40-0x000000018118FCC0
	private void LateUpdate(); // 0x00000001803581E0-0x00000001803581F0
	private void PreUpdate(); // 0x000000018118D590-0x000000018118D5C0
	private void CheckDistance(); // 0x000000018118CD00-0x000000018118CF20
	private void OnEnable(); // 0x000000018118D470-0x000000018118D480
	private void OnDisable(); // 0x000000018118D220-0x000000018118D230
	private void OnValidate(); // 0x000000018118D480-0x000000018118D590
	private void OnDrawGizmosSelected(); // 0x000000018118D230-0x000000018118D470
	public void SetWeight(float w); // 0x000000018118D7F0-0x000000018118D860
	public float GetWeight(); // 0x000000018118CFA0-0x000000018118CFB0
	private void UpdateDynamicBones(float t); // 0x000000018118E360-0x000000018118E620
	private void SetupParticles(); // 0x000000018118D860-0x000000018118DA60
	private void AppendParticles(Transform b, int parentIndex, float boneLength); // 0x000000018118BFC0-0x000000018118C8C0
	public void UpdateParameters(); // 0x000000018118E620-0x000000018118EA70
	private void InitTransforms(); // 0x000000018118CFB0-0x000000018118D110
	private void ResetParticlesPosition(); // 0x000000018118D5C0-0x000000018118D7C0
	private void UpdateParticles1(); // 0x000000018118EA70-0x000000018118EFF0
	private void UpdateParticles2(); // 0x000000018118EFF0-0x000000018118FC40
	private void SkipUpdateParticles(); // 0x000000018118DA60-0x000000018118E350
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis); // 0x000000018118D110-0x000000018118D220
	private void ApplyParticlesToTransforms(); // 0x000000018118C8C0-0x000000018118CD00
}

