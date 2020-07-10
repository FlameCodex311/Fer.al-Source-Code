/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800EE9C0-0x00000001800EEA20
	[Description] // 0x00000001800EE9C0-0x00000001800EEA20
	public class SetFloatRandom : ActionTask // TypeDefIndex: 14241
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018125F970-0x000000018125FC60 
	
		// Constructors
		public SetFloatRandom(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018125F8C0-0x000000018125F970
	}
}
