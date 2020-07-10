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
	[Category] // 0x0000000180154100-0x00000001801541C0
	[Description] // 0x0000000180154100-0x00000001801541C0
	[Icon] // 0x0000000180154100-0x00000001801541C0
	[Name] // 0x0000000180154100-0x00000001801541C0
	public class PlaySequenceForward : ActionTask // TypeDefIndex: 14547
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181259D10-0x0000000181259DA0 
	
		// Constructors
		public PlaySequenceForward(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181259CB0-0x0000000181259D10
	}
}
