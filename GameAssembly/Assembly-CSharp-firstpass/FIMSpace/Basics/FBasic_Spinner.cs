/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_Spinner : FBasic_Rotator // TypeDefIndex: 9898
	{
		// Fields
		[Tooltip] // 0x0000000180106540-0x0000000180106570
		public float DeceleratePower; // 0x30
	
		// Constructors
		public FBasic_Spinner(); // 0x00000001815D91F0-0x00000001815D9260
	
		// Methods
		private void Start(); // 0x00000001815D9090-0x00000001815D90A0
		protected override void Update(); // 0x00000001815D90A0-0x00000001815D91F0
		public void Spin(float power = 500f /* Metadata: 0x00745FFF */); // 0x00000001811F74C0-0x00000001811F74D0
	}
}
