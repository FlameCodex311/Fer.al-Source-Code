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
	[Category] // 0x00000001801CED40-0x00000001801CEDA0
	[Description] // 0x00000001801CED40-0x00000001801CEDA0
	public class WaitFrames : ActionTask // TypeDefIndex: 15574
	{
		// Fields
		public BBParameter<int> waitFrames; // 0x68
		private int _frameCount; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807ACDD0-0x00000001807ACE10 
	
		// Constructors
		public WaitFrames(); // 0x00000001807ACD80-0x00000001807ACDD0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807ACD00-0x00000001807ACD10
		protected override void OnUpdate(); // 0x00000001807ACD10-0x00000001807ACD80
	}
}
