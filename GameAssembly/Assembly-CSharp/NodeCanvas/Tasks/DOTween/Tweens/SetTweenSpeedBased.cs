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
	[Category] // 0x00000001801D8F80-0x00000001801D9040
	[Description] // 0x00000001801D8F80-0x00000001801D9040
	[Icon] // 0x00000001801D8F80-0x00000001801D9040
	[Name] // 0x00000001801D8F80-0x00000001801D9040
	public class SetTweenSpeedBased : ActionTask // TypeDefIndex: 15607
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<bool> IsSpeedBased; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180806D20-0x0000000180806DA0 
	
		// Constructors
		public SetTweenSpeedBased(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180806C90-0x0000000180806D20
	}
}
