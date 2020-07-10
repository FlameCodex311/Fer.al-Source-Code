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
	[Category] // 0x000000018010D9B0-0x000000018010D9E0
	public class DOTweenAnimatorNode : ActionTask // TypeDefIndex: 14353
	{
		// Fields
		public EDoTweenAnimatorAction tweenAction; // 0x68
		public BBParameter<DOTweenAnimator> _tweenAnimator; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018174D0E0-0x000000018174D470 
	
		// Nested types
		public enum EDoTweenAnimatorAction // TypeDefIndex: 14354
		{
			PlayForward = 0,
			PlayBackward = 1
		}
	
		// Constructors
		public DOTweenAnimatorNode(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018174CFC0-0x000000018174D0E0
	}
}
