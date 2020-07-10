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
	[Category] // 0x00000001800DD2D0-0x00000001800DD330
	[Description] // 0x00000001800DD2D0-0x00000001800DD330
	public class Probability : ConditionTask // TypeDefIndex: 14172
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125A320-0x000000018125A3D0 
	
		// Constructors
		public Probability(); // 0x000000018125A2B0-0x000000018125A320
	
		// Methods
		protected override bool OnCheck(); // 0x000000018125A220-0x000000018125A2B0
	}
}
