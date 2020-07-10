/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Stage_DyeShop : UI_Stage // TypeDefIndex: 12657
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private MeshRenderer[] _cauldronLiquidRenderers; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Light _cauldronLight; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ParticleSystem[] _particleSystems; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _particleSystemGroup; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ActorNPCSpawner _shopkeep; // 0x60

	// Properties
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public override Transform SpinTarget { get; } // 0x000000018035FCC0-0x000000018035FCD0 

	// Constructors
	public UI_Stage_DyeShop(); // 0x0000000180F907A0-0x0000000180F907B0

	// Methods
	public void SetCurrentDye(BaseDef inItem); // 0x0000000180F90930-0x0000000180F90DE0
	public override void RemoveScene(); // 0x0000000180F908D0-0x0000000180F90930
	public void SetIsCrafting(bool inIsCrafting); // 0x0000000180F90DE0-0x0000000180F90E50
	protected override void Start(); // 0x0000000180F90E50-0x0000000180F90EF0
}

