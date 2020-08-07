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
	[Category] // 0x00000001801FF550-0x00000001801FF610
	[Description] // 0x00000001801FF550-0x00000001801FF610
	[Icon] // 0x00000001801FF550-0x00000001801FF610
	[Name] // 0x00000001801FF550-0x00000001801FF610
	public class ToggleSequencePause : ActionTask // TypeDefIndex: 15662
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180807640-0x00000001808076C0 
	
		// Constructors
		public ToggleSequencePause(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001808075E0-0x0000000180807640
	}
}
