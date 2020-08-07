/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802411E0-0x0000000180241240
	[Description] // 0x00000001802411E0-0x0000000180241240
	public class Probability : ConditionTask // TypeDefIndex: 15275
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180805D90-0x0000000180805E40 
	
		// Constructors
		public Probability(); // 0x0000000180805D20-0x0000000180805D90
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180805C90-0x0000000180805D20
	}
}
