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
	[Category] // 0x00000001801589F0-0x0000000180158AB0
	[Description] // 0x00000001801589F0-0x0000000180158AB0
	[Icon] // 0x00000001801589F0-0x0000000180158AB0
	[Name] // 0x00000001801589F0-0x0000000180158AB0
	public class ToggleSequencePause : ActionTask // TypeDefIndex: 14553
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001812656D0-0x0000000181265760 
	
		// Constructors
		public ToggleSequencePause(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181265670-0x00000001812656D0
	}
}
