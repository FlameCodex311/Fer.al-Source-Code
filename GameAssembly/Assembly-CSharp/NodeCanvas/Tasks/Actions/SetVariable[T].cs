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
	[Category] // 0x00000001800C38F0-0x00000001800C3920
	public class SetVariable<T> : ActionTask // TypeDefIndex: 14245
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SetVariable();
	
		// Methods
		protected override void OnExecute();
	}
}
