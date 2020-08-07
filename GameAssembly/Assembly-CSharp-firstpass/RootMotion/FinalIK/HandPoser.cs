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
	public class HandPoser : Poser // TypeDefIndex: 9972
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser(); // 0x00000001814359F0-0x0000000181435A00
	
		// Methods
		public override void AutoMapping(); // 0x00000001819DCDE0-0x00000001819DCE80
		protected override void InitiatePoser(); // 0x00000001819DCFF0-0x00000001819DD040
		protected override void FixPoserTransforms(); // 0x00000001819DCE80-0x00000001819DCFF0
		protected override void UpdatePoser(); // 0x00000001819DD210-0x00000001819DD730
		protected void StoreDefaultState(); // 0x00000001819DD040-0x00000001819DD210
	}
}
