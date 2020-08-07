/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802236C0-0x00000001802236F0
	public class CheckFloat : ConditionTask // TypeDefIndex: 15204
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		[SliderField] // 0x0000000180225480-0x00000001802254A0
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018079B710-0x000000018079B750 
	
		// Constructors
		public CheckFloat(); // 0x000000018079B6F0-0x000000018079B710
	
		// Methods
		protected override bool OnCheck(); // 0x000000018079B660-0x000000018079B6F0
	}
}
