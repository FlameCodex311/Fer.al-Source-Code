/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public class FBBIKHeadEffector : UnityEngine.MonoBehaviour // TypeDefIndex: 9368
	{
		// Fields
		[Tooltip] // 0x000000018013A470-0x000000018013A4A0
		public FullBodyBipedIK ik; // 0x18
		[LargeHeader] // 0x000000018013A500-0x000000018013A580
		[Range] // 0x000000018013A500-0x000000018013A580
		[Tooltip] // 0x000000018013A500-0x000000018013A580
		public float positionWeight; // 0x20
		[Range] // 0x000000018013A870-0x000000018013A8D0
		[Tooltip] // 0x000000018013A870-0x000000018013A8D0
		public float bodyWeight; // 0x24
		[Range] // 0x000000018013A920-0x000000018013A980
		[Tooltip] // 0x000000018013A920-0x000000018013A980
		public float thighWeight; // 0x28
		[Tooltip] // 0x000000018013AB30-0x000000018013AB60
		public bool handsPullBody; // 0x2C
		[LargeHeader] // 0x000000018013AC10-0x000000018013AC90
		[Range] // 0x000000018013AC10-0x000000018013AC90
		[Tooltip] // 0x000000018013AC10-0x000000018013AC90
		public float rotationWeight; // 0x30
		[Range] // 0x000000018013ADE0-0x000000018013AE40
		[Tooltip] // 0x000000018013ADE0-0x000000018013AE40
		public float bodyClampWeight; // 0x34
		[Range] // 0x000000018013B050-0x000000018013B0B0
		[Tooltip] // 0x000000018013B050-0x000000018013B0B0
		public float headClampWeight; // 0x38
		[Range] // 0x000000018013C510-0x000000018013C570
		[Tooltip] // 0x000000018013C510-0x000000018013C570
		public float bendWeight; // 0x3C
		[Tooltip] // 0x000000018013C6F0-0x000000018013C720
		public BendBone[] bendBones; // 0x40
		[LargeHeader] // 0x000000018013C7E0-0x000000018013C860
		[Range] // 0x000000018013C7E0-0x000000018013C860
		[Tooltip] // 0x000000018013C7E0-0x000000018013C860
		public float CCDWeight; // 0x48
		[Range] // 0x000000018013CB30-0x000000018013CB90
		[Tooltip] // 0x000000018013CB30-0x000000018013CB90
		public float roll; // 0x4C
		[Range] // 0x000000018013CC60-0x000000018013CCC0
		[Tooltip] // 0x000000018013CC60-0x000000018013CCC0
		public float damper; // 0x50
		[Tooltip] // 0x000000018013DF70-0x000000018013DFA0
		public Transform[] CCDBones; // 0x58
		[LargeHeader] // 0x000000018013E020-0x000000018013E0A0
		[Range] // 0x000000018013E020-0x000000018013E0A0
		[Tooltip] // 0x000000018013E020-0x000000018013E0A0
		public float postStretchWeight; // 0x60
		[Tooltip] // 0x000000018013E290-0x000000018013E2C0
		public float maxStretch; // 0x64
		[Tooltip] // 0x000000018013E470-0x000000018013E4A0
		public float stretchDamper; // 0x68
		[Tooltip] // 0x000000018013E520-0x000000018013E550
		public bool fixHead; // 0x6C
		[Tooltip] // 0x000000018013E580-0x000000018013E5B0
		public Transform[] stretchBones; // 0x70
		[LargeHeader] // 0x000000018013E670-0x000000018013E6A0
		public Vector3 chestDirection; // 0x78
		[Range] // 0x00000001800C20E0-0x00000001800C2100
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
		public class BendBone // TypeDefIndex: 9369
		{
			// Fields
			[Tooltip] // 0x000000018013E770-0x000000018013E7A0
			public Transform transform; // 0x10
			[Range] // 0x000000018013EA90-0x000000018013EAF0
			[Tooltip] // 0x000000018013EA90-0x000000018013EAF0
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone(); // 0x000000018181DB20-0x000000018181DB90
			public BendBone(Transform transform, float weight); // 0x000000018181DA90-0x000000018181DB20
	
			// Methods
			public void StoreDefaultLocalState(); // 0x000000018181DA50-0x000000018181DA90
			public void FixTransforms(); // 0x000000018181DA10-0x000000018181DA50
		}
	
		// Constructors
		public FBBIKHeadEffector(); // 0x0000000181829B20-0x0000000181829CA0
	
		// Methods
		private void Start(); // 0x00000001818296D0-0x0000000181829B20
		private void OnStoreDefaultLocalState(); // 0x00000001818282C0-0x0000000181828AB0
		private void OnFixTransforms(); // 0x0000000181826E50-0x00000001818274F0
		private void OnPreRead(); // 0x00000001818277A0-0x00000001818282C0
		private void SpineBend(); // 0x0000000181829220-0x00000001818296D0
		private void CCDPass(); // 0x0000000181825100-0x0000000181825690
		private void Iterate(int iteration); // 0x0000000181825A40-0x0000000181826950
		private void OnPostUpdate(); // 0x00000001818274F0-0x00000001818277A0
		private void ChestDirection(); // 0x0000000181825690-0x0000000181825A40
		private void PostStretching(); // 0x0000000181828AB0-0x0000000181829020
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset); // 0x0000000181826950-0x0000000181826AF0
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance); // 0x0000000181829020-0x0000000181829220
		private void OnDestroy(); // 0x0000000181826AF0-0x0000000181826E50
	}
}
