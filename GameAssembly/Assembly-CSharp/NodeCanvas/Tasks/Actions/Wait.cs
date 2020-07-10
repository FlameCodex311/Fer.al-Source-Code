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
	[Category] // 0x0000000180108220-0x0000000180108250
	public class Wait : ActionTask // TypeDefIndex: 14346
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812691C0-0x0000000181269200 
	
		// Constructors
		public Wait(); // 0x0000000181269160-0x00000001812691C0
	
		// Methods
		protected override void OnUpdate(); // 0x00000001812690E0-0x0000000181269160
	}
}
