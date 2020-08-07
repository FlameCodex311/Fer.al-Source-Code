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
	[Category] // 0x00000001801D73C0-0x00000001801D7480
	[Description] // 0x00000001801D73C0-0x00000001801D7480
	[Icon] // 0x00000001801D73C0-0x00000001801D7480
	[Name] // 0x00000001801D73C0-0x00000001801D7480
	public class SetTweenEase : ActionTask // TypeDefIndex: 15604
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		public Ease EaseType; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001808069A0-0x0000000180806A40 
	
		// Constructors
		public SetTweenEase(); // 0x00000001807A30C0-0x00000001807A30D0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180806930-0x00000001808069A0
	}
}
