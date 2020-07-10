/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class CustomControllersTiltDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9228
	{
		// Fields
		public Transform target; // 0x18
		public float speed; // 0x20
		private CustomController controller; // 0x28
		private Player player; // 0x30
	
		// Constructors
		public CustomControllersTiltDemo(); // 0x00000001815B2CF0-0x00000001815B2D00
	
		// Methods
		private void Awake(); // 0x00000001815B2920-0x00000001815B2A40
		private void Update(); // 0x00000001815B2AD0-0x00000001815B2CF0
		private void OnInputUpdate(); // 0x00000001815B2A40-0x00000001815B2AD0
	}
}
