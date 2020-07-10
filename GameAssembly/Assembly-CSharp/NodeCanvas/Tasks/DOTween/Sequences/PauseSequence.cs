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
	[Category] // 0x0000000180153930-0x00000001801539F0
	[Description] // 0x0000000180153930-0x00000001801539F0
	[Icon] // 0x0000000180153930-0x00000001801539F0
	[Name] // 0x0000000180153930-0x00000001801539F0
	public class PauseSequence : ActionTask // TypeDefIndex: 14545
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181259B30-0x0000000181259BC0 
	
		// Constructors
		public PauseSequence(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181259AD0-0x0000000181259B30
	}
}
