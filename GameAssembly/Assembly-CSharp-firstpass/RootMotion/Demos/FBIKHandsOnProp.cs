/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class FBIKHandsOnProp : UnityEngine.MonoBehaviour // TypeDefIndex: 9805
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool leftHanded; // 0x20
	
		// Constructors
		public FBIKHandsOnProp(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000181375B20-0x0000000181375C10
		private void OnPreRead(); // 0x00000001813764B0-0x0000000181376580
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand); // 0x0000000181375C10-0x00000001813763A0
		private void OnDestroy(); // 0x00000001813763A0-0x00000001813764B0
	}
}
