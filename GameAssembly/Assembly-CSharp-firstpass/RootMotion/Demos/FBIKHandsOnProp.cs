/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class FBIKHandsOnProp : UnityEngine.MonoBehaviour // TypeDefIndex: 9518
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool leftHanded; // 0x20
	
		// Constructors
		public FBIKHandsOnProp(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x000000018182EFA0-0x000000018182F090
		private void OnPreRead(); // 0x000000018182F950-0x000000018182FA30
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand); // 0x000000018182F090-0x000000018182F840
		private void OnDestroy(); // 0x000000018182F840-0x000000018182F950
	}
}
