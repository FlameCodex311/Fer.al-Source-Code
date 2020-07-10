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
	public class HandPoser : Poser // TypeDefIndex: 9438
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser(); // 0x0000000181C175C0-0x0000000181C175D0
	
		// Methods
		public override void AutoMapping(); // 0x0000000181C22470-0x0000000181C22510
		protected override void InitiatePoser(); // 0x0000000181C22690-0x0000000181C226E0
		protected override void FixPoserTransforms(); // 0x0000000181C22510-0x0000000181C22690
		protected override void UpdatePoser(); // 0x0000000181C228D0-0x0000000181C22E20
		protected void StoreDefaultState(); // 0x0000000181C226E0-0x0000000181C228D0
	}
}
