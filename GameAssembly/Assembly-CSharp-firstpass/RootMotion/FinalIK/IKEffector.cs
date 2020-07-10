/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKEffector // TypeDefIndex: 9374
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float positionWeight; // 0x20
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isEndEffector>k__BackingField; // 0x50
		public bool effectChildNodes; // 0x51
		[Range] // 0x00000001800C20E0-0x00000001800C2100
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
		public bool isEndEffector { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
	
		// Constructors
		public IKEffector(); // 0x0000000181C28140-0x0000000181C28290
		public IKEffector(Transform bone, Transform[] childBones); // 0x0000000181C27FD0-0x0000000181C28140
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver); // 0x0000000181C26050-0x0000000181C260E0
		public void PinToBone(float positionWeight, float rotationWeight); // 0x0000000181C27770-0x0000000181C27870
		public bool IsValid(IKSolver solver, ref string message); // 0x0000000181C26AF0-0x0000000181C26E80
		public void Initiate(IKSolverFullBody solver); // 0x0000000181C26750-0x0000000181C26AF0
		public void ResetOffset(IKSolverFullBody solver); // 0x0000000181C27870-0x0000000181C27A40
		public void SetToTarget(); // 0x0000000181C27A40-0x0000000181C27B00
		public void OnPreSolve(IKSolverFullBody solver); // 0x0000000181C26EF0-0x0000000181C27770
		public void OnPostWrite(); // 0x0000000181C26E80-0x0000000181C26EF0
		private Quaternion GetPlaneRotation(IKSolverFullBody solver); // 0x0000000181C260E0-0x0000000181C26360
		public void Update(IKSolverFullBody solver); // 0x0000000181C27B00-0x0000000181C27FD0
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset); // 0x0000000181C26360-0x0000000181C26750
	}
}
