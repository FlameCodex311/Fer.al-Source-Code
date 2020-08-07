/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180248DC0-0x0000000180248E20
	[Description] // 0x0000000180248DC0-0x0000000180248E20
	public class DecomposeVector : ActionTask // TypeDefIndex: 15314
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> x; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> y; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> z; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180CC28F0-0x0000000180CC2930 
	
		// Constructors
		public DecomposeVector(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC27D0-0x0000000180CC28F0
	}
}
