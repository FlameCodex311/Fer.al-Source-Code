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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180108890-0x00000001801088F0
	[Description] // 0x0000000180108890-0x00000001801088F0
	public class DebugLogVariable : ActionTask // TypeDefIndex: 14330
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x000000018174E8A0-0x000000018174EAC0 
	
		// Constructors
		public DebugLogVariable(); // 0x000000018174E880-0x000000018174E8A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018174E590-0x000000018174E840
		protected override void OnUpdate(); // 0x000000018174E840-0x000000018174E880
	}
}
