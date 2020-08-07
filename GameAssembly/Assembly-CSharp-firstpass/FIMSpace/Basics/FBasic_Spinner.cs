/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_Spinner : FBasic_Rotator // TypeDefIndex: 10352
	{
		// Fields
		[Tooltip] // 0x00000001801E74C0-0x00000001801E74F0
		public float DeceleratePower; // 0x30
	
		// Constructors
		public FBasic_Spinner(); // 0x0000000181728810-0x0000000181728820
	
		// Methods
		private void Start(); // 0x00000001817286B0-0x00000001817286C0
		protected override void Update(); // 0x00000001817286C0-0x0000000181728810
		public void Spin(float power = 500f /* Metadata: 0x0077BAB1 */); // 0x000000018094A6A0-0x000000018094A6B0
	}
}
