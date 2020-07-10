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
	[Category] // 0x000000018012CA80-0x000000018012CAE0
	[Description] // 0x000000018012CA80-0x000000018012CAE0
	public class WaitFrames : ActionTask // TypeDefIndex: 14468
	{
		// Fields
		public BBParameter<int> waitFrames; // 0x68
		private int _frameCount; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181268A90-0x0000000181268AD0 
	
		// Constructors
		public WaitFrames(); // 0x0000000181268A40-0x0000000181268A90
	
		// Methods
		protected override void OnExecute(); // 0x00000001812689C0-0x00000001812689D0
		protected override void OnUpdate(); // 0x00000001812689D0-0x0000000181268A40
	}
}
