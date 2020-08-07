/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category] // 0x00000001801F9CF0-0x00000001801F9DB0
	[Description] // 0x00000001801F9CF0-0x00000001801F9DB0
	[Icon] // 0x00000001801F9CF0-0x00000001801F9DB0
	[Name] // 0x00000001801F9CF0-0x00000001801F9DB0
	public class PauseSequence : ActionTask // TypeDefIndex: 15654
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180804FE0-0x0000000180805060 
	
		// Constructors
		public PauseSequence(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180804F80-0x0000000180804FE0
	}
}
