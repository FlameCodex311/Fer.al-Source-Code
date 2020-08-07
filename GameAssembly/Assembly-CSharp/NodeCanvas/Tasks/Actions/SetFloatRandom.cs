/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180252AB0-0x0000000180252B10
	[Description] // 0x0000000180252AB0-0x0000000180252B10
	public class SetFloatRandom : ActionTask // TypeDefIndex: 15341
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A4770-0x00000001807A4A30 
	
		// Constructors
		public SetFloatRandom(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A46C0-0x00000001807A4770
	}
}
