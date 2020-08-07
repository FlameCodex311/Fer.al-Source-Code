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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180228F10-0x0000000180228F70
	[Name] // 0x0000000180228F10-0x0000000180228F70
	public class BBVariableChanged : ConditionTask // TypeDefIndex: 15213
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBObjectParameter targetVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180792490-0x00000001807924D0 
	
		// Constructors
		public BBVariableChanged(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override string OnInit(); // 0x0000000180792410-0x0000000180792470
		protected override void OnEnable(); // 0x0000000180792370-0x0000000180792410
		protected override void OnDisable(); // 0x00000001807922D0-0x0000000180792370
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void OnValueChanged(object varValue); // 0x0000000180792470-0x0000000180792480
	}
}
