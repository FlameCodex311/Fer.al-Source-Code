/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FX_CullingScript : MonoBehaviour // TypeDefIndex: 10427
{
	// Fields
	public float cullingRadius; // 0x20
	public ParticleSystem target; // 0x28
	private CullingGroup m_CullingGroup; // 0x30
	private Renderer[] m_ParticleRenderers; // 0x38

	// Constructors
	public FX_CullingScript(); // 0x0000000180862E00-0x0000000180862E10

	// Methods
	private void OnEnable(); // 0x0000000180862A60-0x0000000180862D00
	private void OnDisable(); // 0x00000001808629A0-0x00000001808629F0
	private void OnDestroy(); // 0x0000000180862980-0x00000001808629A0
	private void OnStateChanged(CullingGroupEvent sphere); // 0x0000000180862D00-0x0000000180862D80
	private void Cull(bool visible); // 0x0000000180862920-0x0000000180862980
	private void SetRenderers(bool enable); // 0x0000000180862D80-0x0000000180862E00
	private void OnDrawGizmos(); // 0x00000001808629F0-0x0000000180862A60
}

