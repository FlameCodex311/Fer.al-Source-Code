/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class FBBIKHeadEffector : UnityEngine.MonoBehaviour // TypeDefIndex: 9902
	{
		// Fields
		[Tooltip] // 0x000000018023F4D0-0x000000018023F500
		public FullBodyBipedIK ik; // 0x18
		[LargeHeader] // 0x000000018023F740-0x000000018023F7C0
		[Range] // 0x000000018023F740-0x000000018023F7C0
		[Tooltip] // 0x000000018023F740-0x000000018023F7C0
		public float positionWeight; // 0x20
		[Range] // 0x000000018023FA20-0x000000018023FA80
		[Tooltip] // 0x000000018023FA20-0x000000018023FA80
		public float bodyWeight; // 0x24
		[Range] // 0x000000018023FD70-0x000000018023FDD0
		[Tooltip] // 0x000000018023FD70-0x000000018023FDD0
		public float thighWeight; // 0x28
		[Tooltip] // 0x0000000180240070-0x00000001802400A0
		public bool handsPullBody; // 0x2C
		[LargeHeader] // 0x0000000180240180-0x0000000180240200
		[Range] // 0x0000000180240180-0x0000000180240200
		[Tooltip] // 0x0000000180240180-0x0000000180240200
		public float rotationWeight; // 0x30
		[Range] // 0x0000000180240530-0x0000000180240590
		[Tooltip] // 0x0000000180240530-0x0000000180240590
		public float bodyClampWeight; // 0x34
		[Range] // 0x0000000180240770-0x00000001802407D0
		[Tooltip] // 0x0000000180240770-0x00000001802407D0
		public float headClampWeight; // 0x38
		[Range] // 0x0000000180240A90-0x0000000180240AF0
		[Tooltip] // 0x0000000180240A90-0x0000000180240AF0
		public float bendWeight; // 0x3C
		[Tooltip] // 0x0000000180240CE0-0x0000000180240D10
		public BendBone[] bendBones; // 0x40
		[LargeHeader] // 0x0000000180240FE0-0x0000000180241060
		[Range] // 0x0000000180240FE0-0x0000000180241060
		[Tooltip] // 0x0000000180240FE0-0x0000000180241060
		public float CCDWeight; // 0x48
		[Range] // 0x00000001802413F0-0x0000000180241450
		[Tooltip] // 0x00000001802413F0-0x0000000180241450
		public float roll; // 0x4C
		[Range] // 0x00000001802415B0-0x0000000180241610
		[Tooltip] // 0x00000001802415B0-0x0000000180241610
		public float damper; // 0x50
		[Tooltip] // 0x0000000180241930-0x0000000180241960
		public Transform[] CCDBones; // 0x58
		[LargeHeader] // 0x0000000180241B10-0x0000000180241B90
		[Range] // 0x0000000180241B10-0x0000000180241B90
		[Tooltip] // 0x0000000180241B10-0x0000000180241B90
		public float postStretchWeight; // 0x60
		[Tooltip] // 0x0000000180241F50-0x0000000180241F80
		public float maxStretch; // 0x64
		[Tooltip] // 0x0000000180242040-0x0000000180242070
		public float stretchDamper; // 0x68
		[Tooltip] // 0x0000000180242300-0x0000000180242330
		public bool fixHead; // 0x6C
		[Tooltip] // 0x0000000180242590-0x00000001802425C0
		public Transform[] stretchBones; // 0x70
		[LargeHeader] // 0x00000001802427D0-0x0000000180242800
		public Vector3 chestDirection; // 0x78
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float chestDirectionWeight; // 0x84
		public Transform[] chestBones; // 0x88
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
		private Vector3 offset; // 0x98
		private Vector3 headToBody; // 0xA4
		private Vector3 shoulderCenterToHead; // 0xB0
		private Vector3 headToLeftThigh; // 0xBC
		private Vector3 headToRightThigh; // 0xC8
		private Vector3 leftShoulderPos; // 0xD4
		private Vector3 rightShoulderPos; // 0xE0
		private float shoulderDist; // 0xEC
		private float leftShoulderDist; // 0xF0
		private float rightShoulderDist; // 0xF4
		private Quaternion chestRotation; // 0xF8
		private Quaternion headRotationRelativeToRoot; // 0x108
		private Quaternion[] ccdDefaultLocalRotations; // 0x118
		private Vector3 headLocalPosition; // 0x120
		private Quaternion headLocalRotation; // 0x12C
		private Vector3[] stretchLocalPositions; // 0x140
		private Quaternion[] stretchLocalRotations; // 0x148
		private Vector3[] chestLocalPositions; // 0x150
		private Quaternion[] chestLocalRotations; // 0x158
		private int bendBonesCount; // 0x160
		private int ccdBonesCount; // 0x164
		private int stretchBonesCount; // 0x168
		private int chestBonesCount; // 0x16C
	
		// Nested types
		[Serializable]
		public class BendBone // TypeDefIndex: 9903
		{
			// Fields
			[Tooltip] // 0x0000000180242B40-0x0000000180242B70
			public Transform transform; // 0x10
			[Range] // 0x0000000180242C90-0x0000000180242CF0
			[Tooltip] // 0x0000000180242C90-0x0000000180242CF0
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone(); // 0x00000001814232E0-0x0000000181423350
			public BendBone(Transform transform, float weight); // 0x0000000181423250-0x00000001814232E0
	
			// Methods
			public void StoreDefaultLocalState(); // 0x0000000181423210-0x0000000181423250
			public void FixTransforms(); // 0x00000001814231D0-0x0000000181423210
		}
	
		// Constructors
		public FBBIKHeadEffector(); // 0x000000018142E1E0-0x000000018142E360
	
		// Methods
		private void Start(); // 0x000000018142DDB0-0x000000018142E1E0
		private void OnStoreDefaultLocalState(); // 0x000000018142CA60-0x000000018142D1E0
		private void OnFixTransforms(); // 0x000000018142B6E0-0x000000018142BD30
		private void OnPreRead(); // 0x000000018142BFC0-0x000000018142CA60
		private void SpineBend(); // 0x000000018142D930-0x000000018142DDB0
		private void CCDPass(); // 0x0000000181429A20-0x0000000181429F80
		private void Iterate(int iteration); // 0x000000018142A320-0x000000018142B1F0
		private void OnPostUpdate(); // 0x000000018142BD30-0x000000018142BFC0
		private void ChestDirection(); // 0x0000000181429F80-0x000000018142A320
		private void PostStretching(); // 0x000000018142D1E0-0x000000018142D730
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset); // 0x000000018142B1F0-0x000000018142B390
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance); // 0x000000018142D730-0x000000018142D930
		private void OnDestroy(); // 0x000000018142B390-0x000000018142B6E0
	}
}
