/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Stage_DyeShop : UI_Stage // TypeDefIndex: 13847
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private StageCameraSetting _cameraSetting_Default; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MeshRenderer[] _cauldronLiquidRenderers; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Light _cauldronLight; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ParticleSystem[] _particleSystems; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _particleSystemGroup; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ActorNPCSpawner _shopkeep; // 0x60

	// Properties
	public override StageCameraSetting ActiveCameraSetting { get; } // 0x00000001803743D0-0x00000001803743E0 
	public override Transform SpinTarget { get; } // 0x000000018037DDC0-0x000000018037DDD0 

	// Constructors
	public UI_Stage_DyeShop(); // 0x00000001804D0D40-0x00000001804D0D50

	// Methods
	public void SetCurrentDye(BaseDef inItem); // 0x00000001804D0F60-0x00000001804D13F0
	public override void RemoveScene(); // 0x00000001804D0F00-0x00000001804D0F60
	public void SetIsCrafting(bool inIsCrafting); // 0x00000001804D13F0-0x00000001804D1460
	protected override void Start(); // 0x00000001804D1460-0x00000001804D1500
}

