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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180271340-0x0000000180271370
	public class Wait : ActionTask // TypeDefIndex: 15449
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807AD4F0-0x00000001807AD530 
	
		// Constructors
		public Wait(); // 0x00000001807AD490-0x00000001807AD4F0
	
		// Methods
		protected override void OnUpdate(); // 0x00000001807AD410-0x00000001807AD490
	}
}
