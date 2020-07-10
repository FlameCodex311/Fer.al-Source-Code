/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorDependencyVolume : ManagedBehaviour // TypeDefIndex: 10400
{
	// Fields
	[FormerlySerializedAs] // 0x000000018010BAB0-0x000000018010BAF0
	[SerializeField] // 0x000000018010BAB0-0x000000018010BAF0
	public float sphereScale; // 0x50
	[FormerlySerializedAs] // 0x000000018010BC50-0x000000018010BC90
	[SerializeField] // 0x000000018010BC50-0x000000018010BC90
	public Vector3 rectangleScale; // 0x54
	[FormerlySerializedAs] // 0x000000018010BED0-0x000000018010BF10
	[SerializeField] // 0x000000018010BED0-0x000000018010BF10
	public ActorDependencyVolumeController.EShape shape; // 0x60
	[FormerlySerializedAs] // 0x000000018010C110-0x000000018010C150
	[SerializeField] // 0x000000018010C110-0x000000018010C150
	public ActorDependencyVolumeController.Dependencies dependencies; // 0x68
	private float? _sphereRangeSq; // 0x70
	private Bounds? _bounds; // 0x78
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public ActorDependencyVolumeController.EState desiredState; // 0x94
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public ActorDependencyVolumeController.EState currentState; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnEnter; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnExit; // 0xA8
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public List<ActorBase> actorsInVolume; // 0xB0

	// Properties
	public float sphereRangeSq { get; } // 0x0000000181406190-0x0000000181406200 
	public Bounds bounds { get; } // 0x0000000181406050-0x0000000181406190 

	// Constructors
	public ActorDependencyVolume(); // 0x0000000181405F90-0x0000000181406050

	// Methods
	public override void MOnEnable(); // 0x0000000181405D90-0x0000000181405E30
	public override void MOnDisable(); // 0x0000000181405CF0-0x0000000181405D90
	public void VolumeEnter(); // 0x0000000181405F50-0x0000000181405F70
	public void VolumeExit(); // 0x0000000181405F70-0x0000000181405F90
	private void OnDrawGizmos(); // 0x0000000181405E30-0x0000000181405F50
}

