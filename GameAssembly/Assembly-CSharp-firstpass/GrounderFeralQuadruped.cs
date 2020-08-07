/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public class GrounderFeralQuadruped : Grounder // TypeDefIndex: 9704
{
	// Fields
	public IK[] legs; // 0x40
	public Transform hierarchyRootBone; // 0x48
	public Transform rootBone; // 0x50
	public Transform collarBone; // 0x58
	public Transform pelvisBone; // 0x60
	[Range] // 0x00000001801E92A0-0x00000001801E9300
	[Tooltip] // 0x00000001801E92A0-0x00000001801E9300
	public float rootRotationWeight; // 0x68
	[Tooltip] // 0x00000001801E9500-0x00000001801E9530
	public float rootRotationSpeed; // 0x6C
	[Tooltip] // 0x00000001801E96E0-0x00000001801E9710
	public float maxRootRotationAngle; // 0x70
	private Transform[] feet; // 0x78
	private Quaternion[] footRotations; // 0x80
	private Vector3 animatedPelvisLocalPosition; // 0x88
	private Vector3 solvedPelvisLocalPosition; // 0x94
	private int solvedFeet; // 0xA0
	private bool solved; // 0xA4
	private float lastWeight; // 0xA8
	private float _currentPitch; // 0xAC
	private float _currentOffset; // 0xB0
	public float maxBodyOffset; // 0xB4

	// Constructors
	public GrounderFeralQuadruped(); // 0x0000000180D28790-0x0000000180D28810

	// Methods
	[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
	protected override void OpenUserManual(); // 0x0000000180D27990-0x0000000180D279D0
	[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
	protected override void OpenScriptReference(); // 0x0000000180D27950-0x0000000180D27990
	public override void ResetPosition(); // 0x00000001803774A0-0x00000001803774B0
	public void LateUpdate(); // 0x0000000180D26DC0-0x0000000180D27020
	private bool IsReadyToInitiate(); // 0x0000000180D26BC0-0x0000000180D26DC0
	private void OnDisable(); // 0x0000000180D27240-0x0000000180D27390
	private void Update(); // 0x0000000180D27F20-0x0000000180D28790
	public void OnDrawGizmos(); // 0x0000000180D27390-0x0000000180D274D0
	private void Initiate(); // 0x0000000180D26650-0x0000000180D26BC0
	private void OnSolverUpdate(); // 0x0000000180D27730-0x0000000180D27950
	private void SetLegIK(int index); // 0x0000000180D279D0-0x0000000180D27F20
	private void OnPostSolverUpdate(); // 0x0000000180D274D0-0x0000000180D27730
	private void OnDestroy(); // 0x0000000180D27020-0x0000000180D27240
}

