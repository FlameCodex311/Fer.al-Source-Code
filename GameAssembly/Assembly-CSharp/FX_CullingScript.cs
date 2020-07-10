/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_CullingScript : MonoBehaviour // TypeDefIndex: 12770
{
	// Fields
	public float cullingRadius; // 0x20
	public ParticleSystem target; // 0x28
	private CullingGroup m_CullingGroup; // 0x30
	private Renderer[] m_ParticleRenderers; // 0x38

	// Constructors
	public FX_CullingScript(); // 0x0000000181195CE0-0x0000000181195CF0

	// Methods
	private void OnEnable(); // 0x0000000181195930-0x0000000181195BE0
	private void OnDisable(); // 0x0000000181195870-0x00000001811958C0
	private void OnDestroy(); // 0x0000000181195850-0x0000000181195870
	private void OnStateChanged(CullingGroupEvent sphere); // 0x0000000181195BE0-0x0000000181195C60
	private void Cull(bool visible); // 0x00000001811957F0-0x0000000181195850
	private void SetRenderers(bool enable); // 0x0000000181195C60-0x0000000181195CE0
	private void OnDrawGizmos(); // 0x00000001811958C0-0x0000000181195930
}

