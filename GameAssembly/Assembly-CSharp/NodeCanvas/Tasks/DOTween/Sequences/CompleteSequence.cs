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
	[Category] // 0x0000000180150B10-0x0000000180150BD0
	[Description] // 0x0000000180150B10-0x0000000180150BD0
	[Icon] // 0x0000000180150B10-0x0000000180150BD0
	[Name] // 0x0000000180150B10-0x0000000180150BD0
	public class CompleteSequence : ActionTask // TypeDefIndex: 14540
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181256110-0x00000001812561A0 
	
		// Constructors
		public CompleteSequence(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x00000001812560B0-0x0000000181256110
	}
}
