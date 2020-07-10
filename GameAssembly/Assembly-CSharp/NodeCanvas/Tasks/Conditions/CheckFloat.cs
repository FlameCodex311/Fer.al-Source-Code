/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C38F0-0x00000001800C3920
	public class CheckFloat : ConditionTask // TypeDefIndex: 14122
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		[SliderField] // 0x00000001800C58A0-0x00000001800C58C0
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181250B60-0x0000000181250BA0 
	
		// Constructors
		public CheckFloat(); // 0x0000000181250B40-0x0000000181250B60
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181250AB0-0x0000000181250B40
	}
}
