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
	[Category] // 0x0000000180110CB0-0x0000000180110D10
	[Description] // 0x0000000180110CB0-0x0000000180110D10
	public class LocalPlayerAnimations : ActionTask // TypeDefIndex: 14367
	{
		// Fields
		public BBParameter<EAnimationControlType> animationControlType; // 0x68
		public BBParameter<EAnimation> animation; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154E5C0-0x000000018154E660 
	
		// Nested types
		public enum EAnimationControlType // TypeDefIndex: 14368
		{
			play = 0,
			stop = 1
		}
	
		public enum EAnimation // TypeDefIndex: 14369
		{
			NONE = 0,
			dig = 1
		}
	
		// Constructors
		public LocalPlayerAnimations(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154E4E0-0x000000018154E5C0
	}
}
