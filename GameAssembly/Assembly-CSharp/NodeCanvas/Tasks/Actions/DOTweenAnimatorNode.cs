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
	[Category] // 0x00000001802799E0-0x0000000180279A10
	public class DOTweenAnimatorNode : ActionTask // TypeDefIndex: 15453
	{
		// Fields
		public EDoTweenAnimatorAction tweenAction; // 0x68
		public BBParameter<DOTweenAnimator> _tweenAnimator; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180CC1420-0x0000000180CC1780 
	
		// Nested types
		public enum EDoTweenAnimatorAction // TypeDefIndex: 15454
		{
			PlayForward = 0,
			PlayBackward = 1
		}
	
		// Constructors
		public DOTweenAnimatorNode(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC1310-0x0000000180CC1420
	}
}
