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
	[Category] // 0x00000001801356C0-0x0000000180135780
	[Description] // 0x00000001801356C0-0x0000000180135780
	[Icon] // 0x00000001801356C0-0x0000000180135780
	[Name] // 0x00000001801356C0-0x0000000180135780
	public class SetTweenLoopType : ActionTask // TypeDefIndex: 14496
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<int> Loops; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public LoopType LoopType; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E99710-0x0000000180E997C0 
	
		// Constructors
		public SetTweenLoopType(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E99680-0x0000000180E99710
	}
}
