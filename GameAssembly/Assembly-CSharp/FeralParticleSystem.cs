/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x000000018025C440-0x000000018025C490
public class FeralParticleSystem : ManagedBehaviour // TypeDefIndex: 12982
{
	// Fields
	private ParticleSystem _particleSystem; // 0x50
	private ParticleSystemRenderer _particleSystemRenderer; // 0x58
	[RootSelector] // 0x000000018025C690-0x000000018025C6F0
	public string bundleId; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EEmit _emit; // 0x68

	// Nested types
	public enum EEmit // TypeDefIndex: 12983
	{
		AfterLoaded = 0
	}

	// Constructors
	public FeralParticleSystem(); // 0x000000018069E090-0x000000018069E0F0

	// Methods
	public override void MStart(); // 0x000000018069DD10-0x000000018069DF30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStart>b__5_0(Texture tex); // 0x000000018069DF30-0x000000018069E090
}

