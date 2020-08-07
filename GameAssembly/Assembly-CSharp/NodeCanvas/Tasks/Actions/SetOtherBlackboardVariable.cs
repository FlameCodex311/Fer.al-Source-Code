/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180253910-0x0000000180253970
	[Description] // 0x0000000180253910-0x0000000180253970
	public class SetOtherBlackboardVariable : ActionTask<Blackboard> // TypeDefIndex: 15344
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A6420-0x00000001807A64C0 
	
		// Constructors
		public SetOtherBlackboardVariable(); // 0x00000001807A63E0-0x00000001807A6420
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A6330-0x00000001807A63E0
	}
}
