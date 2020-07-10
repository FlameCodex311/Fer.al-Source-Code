/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class TransferMotion : UnityEngine.MonoBehaviour // TypeDefIndex: 9546
	{
		// Fields
		[Tooltip] // 0x00000001800DE6F0-0x00000001800DE720
		public Transform to; // 0x18
		[Range] // 0x00000001800DE8C0-0x00000001800DE920
		[Tooltip] // 0x00000001800DE8C0-0x00000001800DE920
		public float transferMotion; // 0x20
		private Vector3 lastPosition; // 0x24
	
		// Constructors
		public TransferMotion(); // 0x000000018183DD00-0x000000018183DD10
	
		// Methods
		private void OnEnable(); // 0x000000018183DAE0-0x000000018183DB30
		private void Update(); // 0x000000018183DB30-0x000000018183DD00
	}
}
