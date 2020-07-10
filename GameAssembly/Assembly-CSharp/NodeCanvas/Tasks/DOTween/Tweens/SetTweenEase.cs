/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x00000001801340B0-0x0000000180134170
	[Description] // 0x00000001801340B0-0x0000000180134170
	[Icon] // 0x00000001801340B0-0x0000000180134170
	[Name] // 0x00000001801340B0-0x0000000180134170
	public class SetTweenEase : ActionTask // TypeDefIndex: 14495
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x68
		public Ease EaseType; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180E995E0-0x0000000180E99680 
	
		// Constructors
		public SetTweenEase(); // 0x0000000180E995D0-0x0000000180E995E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E99560-0x0000000180E995D0
	}
}
