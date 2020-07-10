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
	[Category] // 0x0000000180154720-0x00000001801547E0
	[Description] // 0x0000000180154720-0x00000001801547E0
	[Icon] // 0x0000000180154720-0x00000001801547E0
	[Name] // 0x0000000180154720-0x00000001801547E0
	public class PlaySequence : ActionTask // TypeDefIndex: 14548
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		public BBParameter<bool> WaitUntilFinished; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181259EC0-0x0000000181259FC0 
	
		// Constructors
		public PlaySequence(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181259DA0-0x0000000181259EC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__4_0(); // 0x0000000180E98B70-0x0000000180E98B80
	}
}
