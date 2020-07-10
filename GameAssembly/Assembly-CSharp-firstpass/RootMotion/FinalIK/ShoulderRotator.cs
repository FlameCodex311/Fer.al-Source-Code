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
	public class ShoulderRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 9489
	{
		// Fields
		[Tooltip] // 0x00000001800CB730-0x00000001800CB760
		public float weight; // 0x18
		[Tooltip] // 0x00000001800CBA80-0x00000001800CBAB0
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator(); // 0x0000000182289F50-0x0000000182289F70
	
		// Methods
		private void Start(); // 0x0000000182289E60-0x0000000182289F50
		private void RotateShoulders(); // 0x0000000182289D50-0x0000000182289E60
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset); // 0x0000000182289690-0x0000000182289D50
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain); // 0x0000000182289540-0x0000000182289590
		private void OnDestroy(); // 0x0000000182289590-0x0000000182289690
	}
}
