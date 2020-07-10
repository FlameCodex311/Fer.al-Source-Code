/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SMB_IdleBase : StateMachineBehaviour // TypeDefIndex: 10036
{
	// Fields
	public float idleBreakMinTime; // 0x18
	public float idleBreakMaxTime; // 0x1C
	public int idleAdditiveLayerIndex; // 0x20
	public int moveAdditiveLayerIndex; // 0x24
	private float timer; // 0x28
	private ActorBase _cachedActor; // 0x30

	// Constructors
	public SMB_IdleBase(); // 0x0000000180E13E40-0x0000000180E13E70

	// Methods
	private ActorBase GetActor(Animator animator); // 0x0000000180E13B20-0x0000000180E13BC0
	private void SetIdleAdditiveLayerVisible(Animator animator, bool inVisible); // 0x0000000180E13D20-0x0000000180E13E40
	private void SetMoveAdditiveLayerVisible(Animator animator, bool visible); // 0x00000001803581E0-0x00000001803581F0
	private void ChooseIdleBreakTime(); // 0x0000000180E13AF0-0x0000000180E13B20
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000180E13BC0-0x0000000180E13C60
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000180E13C60-0x0000000180E13D20
}

