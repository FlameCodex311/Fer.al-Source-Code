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
	[Category] // 0x0000000180153D40-0x0000000180153E00
	[Description] // 0x0000000180153D40-0x0000000180153E00
	[Icon] // 0x0000000180153D40-0x0000000180153E00
	[Name] // 0x0000000180153D40-0x0000000180153E00
	public class PlaySequenceBackwards : ActionTask // TypeDefIndex: 14546
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181259C20-0x0000000181259CB0 
	
		// Constructors
		public PlaySequenceBackwards(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181259BC0-0x0000000181259C20
	}
}
