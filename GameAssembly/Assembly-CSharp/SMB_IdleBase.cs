/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SMB_IdleBase : StateMachineBehaviour // TypeDefIndex: 11527
{
	// Fields
	public float idleBreakMinTime; // 0x18
	public float idleBreakMaxTime; // 0x1C
	public int idleAdditiveLayerIndex; // 0x20
	public int moveAdditiveLayerIndex; // 0x24
	private float timer; // 0x28
	private ActorBase _cachedActor; // 0x30

	// Constructors
	public SMB_IdleBase(); // 0x0000000180745C80-0x0000000180745CB0

	// Methods
	private ActorBase GetActor(Animator animator); // 0x0000000180745960-0x0000000180745A00
	private void SetIdleAdditiveLayerVisible(Animator animator, bool inVisible); // 0x0000000180745B60-0x0000000180745C80
	private void SetMoveAdditiveLayerVisible(Animator animator, bool visible); // 0x00000001803774A0-0x00000001803774B0
	private void ChooseIdleBreakTime(); // 0x0000000180745930-0x0000000180745960
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000180745A00-0x0000000180745AA0
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000180745AA0-0x0000000180745B60
}

