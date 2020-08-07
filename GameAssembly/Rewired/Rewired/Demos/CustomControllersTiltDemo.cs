/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class CustomControllersTiltDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9394
	{
		// Fields
		public Transform target; // 0x18
		public float speed; // 0x20
		private CustomController controller; // 0x28
		private Player player; // 0x30
	
		// Constructors
		public CustomControllersTiltDemo(); // 0x0000000180DCD2A0-0x0000000180DCD2B0
	
		// Methods
		private void Awake(); // 0x0000000180DCCED0-0x0000000180DCCFF0
		private void Update(); // 0x0000000180DCD080-0x0000000180DCD2A0
		private void OnInputUpdate(); // 0x0000000180DCCFF0-0x0000000180DCD080
	}
}
