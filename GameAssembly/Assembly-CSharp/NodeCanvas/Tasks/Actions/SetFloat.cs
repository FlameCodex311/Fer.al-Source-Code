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
	[Category] // 0x00000001800EE640-0x00000001800EE6A0
	[Description] // 0x00000001800EE640-0x00000001800EE6A0
	public class SetFloat : ActionTask // TypeDefIndex: 14240
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<float> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018125FD60-0x000000018125FF50 
	
		// Constructors
		public SetFloat(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018125FC60-0x000000018125FD60
	}
}
