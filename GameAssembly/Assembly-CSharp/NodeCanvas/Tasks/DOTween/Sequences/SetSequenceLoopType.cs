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
	[Category] // 0x0000000180158000-0x00000001801580C0
	[Description] // 0x0000000180158000-0x00000001801580C0
	[Icon] // 0x0000000180158000-0x00000001801580C0
	[Name] // 0x0000000180158000-0x00000001801580C0
	public class SetSequenceLoopType : ActionTask // TypeDefIndex: 14552
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<int> Loops; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public LoopType LoopType; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181262950-0x0000000181262A00 
	
		// Constructors
		public SetSequenceLoopType(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x00000001812628C0-0x0000000181262950
	}
}
