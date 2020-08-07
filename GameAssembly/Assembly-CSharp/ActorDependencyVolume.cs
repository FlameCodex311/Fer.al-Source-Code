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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorDependencyVolume : ManagedBehaviour // TypeDefIndex: 11888
{
	// Fields
	[FormerlySerializedAs] // 0x00000001801DA6A0-0x00000001801DA6E0
	[SerializeField] // 0x00000001801DA6A0-0x00000001801DA6E0
	public float sphereScale; // 0x50
	[FormerlySerializedAs] // 0x00000001801DAB90-0x00000001801DABD0
	[SerializeField] // 0x00000001801DAB90-0x00000001801DABD0
	public Vector3 rectangleScale; // 0x54
	[FormerlySerializedAs] // 0x00000001801DADD0-0x00000001801DAE10
	[SerializeField] // 0x00000001801DADD0-0x00000001801DAE10
	public ActorDependencyVolumeController.EShape shape; // 0x60
	[FormerlySerializedAs] // 0x00000001801DB000-0x00000001801DB040
	[SerializeField] // 0x00000001801DB000-0x00000001801DB040
	public ActorDependencyVolumeController.Dependencies dependencies; // 0x68
	private float? _sphereRangeSq; // 0x70
	private Bounds? _bounds; // 0x78
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public ActorDependencyVolumeController.EState desiredState; // 0x94
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public ActorDependencyVolumeController.EState currentState; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnEnter; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnExit; // 0xA8
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public List<ActorBase> actorsInVolume; // 0xB0

	// Properties
	public float sphereRangeSq { get; } // 0x00000001821D7ED0-0x00000001821D7F40 
	public Bounds bounds { get; } // 0x00000001821D7D90-0x00000001821D7ED0 

	// Constructors
	public ActorDependencyVolume(); // 0x00000001821D7CD0-0x00000001821D7D90

	// Methods
	public override void MOnEnable(); // 0x00000001821D7AF0-0x00000001821D7B80
	public override void MOnDisable(); // 0x00000001821D7A60-0x00000001821D7AF0
	public void VolumeEnter(); // 0x00000001821D7C90-0x00000001821D7CB0
	public void VolumeExit(); // 0x00000001821D7CB0-0x00000001821D7CD0
	private void OnDrawGizmos(); // 0x00000001821D7B80-0x00000001821D7C90
}

