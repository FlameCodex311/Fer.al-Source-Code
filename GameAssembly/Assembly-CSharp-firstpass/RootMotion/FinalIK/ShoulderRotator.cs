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
	public class ShoulderRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 10023
	{
		// Fields
		[Tooltip] // 0x000000018028AFA0-0x000000018028AFD0
		public float weight; // 0x18
		[Tooltip] // 0x000000018028B120-0x000000018028B150
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator(); // 0x0000000182022630-0x0000000182022650
	
		// Methods
		private void Start(); // 0x0000000182022540-0x0000000182022630
		private void RotateShoulders(); // 0x0000000182022430-0x0000000182022540
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset); // 0x0000000182021DA0-0x0000000182022430
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain); // 0x0000000182021C50-0x0000000182021CA0
		private void OnDestroy(); // 0x0000000182021CA0-0x0000000182021DA0
	}
}
