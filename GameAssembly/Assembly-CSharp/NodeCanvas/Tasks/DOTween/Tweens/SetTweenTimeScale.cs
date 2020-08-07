/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x00000001801D6810-0x00000001801D68D0
	[Description] // 0x00000001801D6810-0x00000001801D68D0
	[Icon] // 0x00000001801D6810-0x00000001801D68D0
	[Name] // 0x00000001801D6810-0x00000001801D68D0
	public class SetTweenTimeScale : ActionTask // TypeDefIndex: 15608
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> TimeScale; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180806E30-0x0000000180806ED0 
	
		// Constructors
		public SetTweenTimeScale(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180806DA0-0x0000000180806E30
	}
}
