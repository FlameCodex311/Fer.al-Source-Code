/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x00000001800BCB00-0x00000001800BCB50
public class FeralParticleSystem : ManagedBehaviour // TypeDefIndex: 11461
{
	// Fields
	private ParticleSystem _particleSystem; // 0x50
	private ParticleSystemRenderer _particleSystemRenderer; // 0x58
	[RootSelector] // 0x00000001800BCE80-0x00000001800BCEE0
	public string bundleId; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EEmit _emit; // 0x68

	// Nested types
	public enum EEmit // TypeDefIndex: 11462
	{
		AfterLoaded = 0
	}

	// Constructors
	public FeralParticleSystem(); // 0x0000000181108480-0x00000001811084E0

	// Methods
	public override void MStart(); // 0x0000000181108100-0x0000000181108320
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStart>b__5_0(Texture tex); // 0x0000000181108320-0x0000000181108480
}

