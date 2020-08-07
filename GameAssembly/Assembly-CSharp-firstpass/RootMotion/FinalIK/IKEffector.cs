/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKEffector // TypeDefIndex: 9908
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float positionWeight; // 0x20
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isEndEffector>k__BackingField; // 0x50
		public bool effectChildNodes; // 0x51
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float maintainRelativePositionWeight; // 0x54
		public Transform[] childBones; // 0x58
		public Transform planeBone1; // 0x60
		public Transform planeBone2; // 0x68
		public Transform planeBone3; // 0x70
		public Quaternion planeRotationOffset; // 0x78
		private float posW; // 0x88
		private float rotW; // 0x8C
		private Vector3[] localPositions; // 0x90
		private bool usePlaneNodes; // 0x98
		private Quaternion animatedPlaneRotation; // 0x9C
		private Vector3 animatedPosition; // 0xAC
		private bool firstUpdate; // 0xB8
		private int chainIndex; // 0xBC
		private int nodeIndex; // 0xC0
		private int plane1ChainIndex; // 0xC4
		private int plane1NodeIndex; // 0xC8
		private int plane2ChainIndex; // 0xCC
		private int plane2NodeIndex; // 0xD0
		private int plane3ChainIndex; // 0xD4
		private int plane3NodeIndex; // 0xD8
		private int[] childChainIndexes; // 0xE0
		private int[] childNodeIndexes; // 0xE8
	
		// Properties
		public bool isEndEffector { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
	
		// Constructors
		public IKEffector(); // 0x00000001819E3000-0x00000001819E3150
		public IKEffector(Transform bone, Transform[] childBones); // 0x00000001819E2E90-0x00000001819E3000
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver); // 0x00000001819E0870-0x00000001819E08F0
		public void PinToBone(float positionWeight, float rotationWeight); // 0x00000001819E23C0-0x00000001819E24B0
		public bool IsValid(IKSolver solver, ref string message); // 0x00000001819E15F0-0x00000001819E1970
		public void Initiate(IKSolverFullBody solver); // 0x00000001819E10E0-0x00000001819E15F0
		public void ResetOffset(IKSolverFullBody solver); // 0x00000001819E24B0-0x00000001819E2730
		public void SetToTarget(); // 0x00000001819E2730-0x00000001819E27F0
		public void OnPreSolve(IKSolverFullBody solver); // 0x00000001819E19E0-0x00000001819E23C0
		public void OnPostWrite(); // 0x00000001819E1970-0x00000001819E19E0
		private Quaternion GetPlaneRotation(IKSolverFullBody solver); // 0x00000001819E08F0-0x00000001819E0CA0
		public void Update(IKSolverFullBody solver); // 0x00000001819E27F0-0x00000001819E2E90
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset); // 0x00000001819E0CA0-0x00000001819E10E0
	}
}
