/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800EF380-0x00000001800EF3E0
	[Description] // 0x00000001800EF380-0x00000001800EF3E0
	public class SetOtherBlackboardVariable : ActionTask<Blackboard> // TypeDefIndex: 14244
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812615A0-0x0000000181261640 
	
		// Constructors
		public SetOtherBlackboardVariable(); // 0x0000000181261560-0x00000001812615A0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812614B0-0x0000000181261560
	}
}
