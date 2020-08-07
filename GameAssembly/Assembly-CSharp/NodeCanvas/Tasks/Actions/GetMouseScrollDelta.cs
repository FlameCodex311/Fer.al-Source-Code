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
	[Category] // 0x000000018022FCD0-0x000000018022FD00
	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 15384
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAFD20-0x0000000180BAFD60 
	
		// Constructors
		public GetMouseScrollDelta(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAFD10-0x0000000180BAFD20
		protected override void OnUpdate(); // 0x0000000180BAFD10-0x0000000180BAFD20
		private void Do(); // 0x0000000180BAFC90-0x0000000180BAFD10
	}
}
