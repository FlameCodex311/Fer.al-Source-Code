﻿/*
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
	[Category] // 0x00000001801D8800-0x00000001801D88C0
	[Description] // 0x00000001801D8800-0x00000001801D88C0
	[Icon] // 0x00000001801D8800-0x00000001801D88C0
	[Name] // 0x00000001801D8800-0x00000001801D88C0
	public class SetTweenRelativity : ActionTask // TypeDefIndex: 15606
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<bool> IsRelative; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180806C10-0x0000000180806C90 
	
		// Constructors
		public SetTweenRelativity(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180806B80-0x0000000180806C10
	}
}
