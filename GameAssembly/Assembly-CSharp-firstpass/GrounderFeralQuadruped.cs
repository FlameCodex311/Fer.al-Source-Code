/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public class GrounderFeralQuadruped : Grounder // TypeDefIndex: 9300
{
	// Fields
	public IK[] legs; // 0x40
	public Transform hierarchyRootBone; // 0x48
	public Transform rootBone; // 0x50
	public Transform collarBone; // 0x58
	public Transform pelvisBone; // 0x60
	[Range] // 0x0000000180119860-0x00000001801198C0
	[Tooltip] // 0x0000000180119860-0x00000001801198C0
	public float rootRotationWeight; // 0x68
	[Tooltip] // 0x0000000180119AB0-0x0000000180119AE0
	public float rootRotationSpeed; // 0x6C
	[Tooltip] // 0x0000000180119C20-0x0000000180119C50
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
	public GrounderFeralQuadruped(); // 0x0000000181654B60-0x0000000181654BE0

	// Methods
	[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
	protected override void OpenUserManual(); // 0x0000000181653D10-0x0000000181653D50
	[ContextMenu] // 0x000000018011A010-0x000000018011A040
	protected override void OpenScriptReference(); // 0x0000000181653CD0-0x0000000181653D10
	public override void ResetPosition(); // 0x00000001803581E0-0x00000001803581F0
	public void LateUpdate(); // 0x00000001816530F0-0x0000000181653360
	private bool IsReadyToInitiate(); // 0x0000000181652EF0-0x00000001816530F0
	private void OnDisable(); // 0x0000000181653580-0x00000001816536F0
	private void Update(); // 0x00000001816542D0-0x0000000181654B60
	public void OnDrawGizmos(); // 0x00000001816536F0-0x0000000181653830
	private void Initiate(); // 0x0000000181652940-0x0000000181652EF0
	private void OnSolverUpdate(); // 0x0000000181653AA0-0x0000000181653CD0
	private void SetLegIK(int index); // 0x0000000181653D50-0x00000001816542D0
	private void OnPostSolverUpdate(); // 0x0000000181653830-0x0000000181653AA0
	private void OnDestroy(); // 0x0000000181653360-0x0000000181653580
}

