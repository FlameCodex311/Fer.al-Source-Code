/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DD750-0x00000001800DD7B0
	[Description] // 0x00000001800DD750-0x00000001800DD7B0
	public class Timeout : ConditionTask // TypeDefIndex: 14173
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812655F0-0x0000000181265670 
	
		// Constructors
		public Timeout(); // 0x00000001812655A0-0x00000001812655F0
	
		// Methods
		protected override void OnEnable(); // 0x0000000181265590-0x00000001812655A0
		protected override bool OnCheck(); // 0x0000000181265500-0x0000000181265590
	}
}
