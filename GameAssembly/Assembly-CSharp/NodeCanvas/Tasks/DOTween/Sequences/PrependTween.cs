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

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category] // 0x0000000180156A30-0x0000000180156AF0
	[Description] // 0x0000000180156A30-0x0000000180156AF0
	[Icon] // 0x0000000180156A30-0x0000000180156AF0
	[Name] // 0x0000000180156A30-0x0000000180156AF0
	public class PrependTween : ActionTask // TypeDefIndex: 14550
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125A180-0x000000018125A220 
	
		// Constructors
		public PrependTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018125A0F0-0x000000018125A180
	}
}
