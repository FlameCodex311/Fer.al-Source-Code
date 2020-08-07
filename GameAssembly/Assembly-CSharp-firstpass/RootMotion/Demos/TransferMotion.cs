/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class TransferMotion : UnityEngine.MonoBehaviour // TypeDefIndex: 9833
	{
		// Fields
		[Tooltip] // 0x0000000180217BE0-0x0000000180217C10
		public Transform to; // 0x18
		[Range] // 0x0000000180217EB0-0x0000000180217F10
		[Tooltip] // 0x0000000180217EB0-0x0000000180217F10
		public float transferMotion; // 0x20
		private Vector3 lastPosition; // 0x24
	
		// Constructors
		public TransferMotion(); // 0x000000018143F550-0x000000018143F560
	
		// Methods
		private void OnEnable(); // 0x000000018143F340-0x000000018143F380
		private void Update(); // 0x000000018143F380-0x000000018143F550
	}
}
