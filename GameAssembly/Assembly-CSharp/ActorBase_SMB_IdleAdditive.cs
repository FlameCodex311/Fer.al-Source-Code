/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorBase_SMB_IdleAdditive : StateMachineBehaviour // TypeDefIndex: 11525
{
	// Fields
	public float minBaseTime; // 0x18
	public float maxBaseTime; // 0x1C
	public int idleBaseLayerIndex; // 0x20
	[EnumList] // 0x0000000180214A90-0x0000000180214AF0
	public List<float> weights; // 0x28
	private IdleAdditiveState _currentState; // 0x30
	private float noAdditiveTimer; // 0x34
	private const string baseIdleName = "Idle Base Add"; // Metadata: 0x0077CD50

	// Nested types
	public enum IdleAdditiveState // TypeDefIndex: 11526
	{
		BaseAdditive = 0,
		LookLeftAdd = 1,
		LookRightAdd = 2,
		LookAroundAdd = 3
	}

	// Constructors
	public ActorBase_SMB_IdleAdditive(); // 0x00000001821D3710-0x00000001821D3720

	// Methods
	private void OnEnable(); // 0x00000001821D3530-0x00000001821D3540
	private IdleAdditiveState ChooseNewState(); // 0x00000001821D3280-0x00000001821D3490
	private void HandleStateSelection(Animator animator); // 0x00000001821D3490-0x00000001821D3530
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001821D3540-0x00000001821D35E0
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001821D35E0-0x00000001821D3710
}

