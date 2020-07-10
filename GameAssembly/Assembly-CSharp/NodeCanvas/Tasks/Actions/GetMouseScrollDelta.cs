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
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 14281
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181549C50-0x0000000181549C90 
	
		// Constructors
		public GetMouseScrollDelta(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181549C40-0x0000000181549C50
		protected override void OnUpdate(); // 0x0000000181549C40-0x0000000181549C50
		private void Do(); // 0x0000000181549BC0-0x0000000181549C40
	}
}
