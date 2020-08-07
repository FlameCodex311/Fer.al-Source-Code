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
	[Category] // 0x000000018027DC70-0x000000018027DCD0
	[Description] // 0x000000018027DC70-0x000000018027DCD0
	public class LocalPlayerAnimations : ActionTask // TypeDefIndex: 15470
	{
		// Fields
		public BBParameter<EAnimationControlType> animationControlType; // 0x68
		public BBParameter<EAnimation> animation; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB43A0-0x0000000180BB4440 
	
		// Nested types
		public enum EAnimationControlType // TypeDefIndex: 15471
		{
			play = 0,
			stop = 1
		}
	
		public enum EAnimation // TypeDefIndex: 15472
		{
			NONE = 0,
			dig = 1
		}
	
		// Constructors
		public LocalPlayerAnimations(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB42C0-0x0000000180BB43A0
	}
}
