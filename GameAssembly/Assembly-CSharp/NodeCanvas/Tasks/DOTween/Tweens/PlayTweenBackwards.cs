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
	[Category] // 0x00000001801D5750-0x00000001801D5810
	[Description] // 0x00000001801D5750-0x00000001801D5810
	[Icon] // 0x00000001801D5750-0x00000001801D5810
	[Name] // 0x00000001801D5750-0x00000001801D5810
	public class PlayTweenBackwards : ActionTask // TypeDefIndex: 15599
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		public BBParameter<bool> WaitUntilFinished; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180805710-0x0000000180805810 
	
		// Constructors
		public PlayTweenBackwards(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180805600-0x0000000180805710
		private void OnTweenComplete(); // 0x000000018079F110-0x000000018079F120
	}
}
