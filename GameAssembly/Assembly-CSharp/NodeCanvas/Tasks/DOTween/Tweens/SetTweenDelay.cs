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
	[Category] // 0x00000001801D6CD0-0x00000001801D6D90
	[Description] // 0x00000001801D6CD0-0x00000001801D6D90
	[Icon] // 0x00000001801D6CD0-0x00000001801D6D90
	[Name] // 0x00000001801D6CD0-0x00000001801D6D90
	public class SetTweenDelay : ActionTask // TypeDefIndex: 15603
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Delay; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001808068B0-0x0000000180806930 
	
		// Constructors
		public SetTweenDelay(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180806820-0x00000001808068B0
	}
}
