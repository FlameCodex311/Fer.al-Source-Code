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
	[Category] // 0x00000001801FEBB0-0x00000001801FEC70
	[Description] // 0x00000001801FEBB0-0x00000001801FEC70
	[Icon] // 0x00000001801FEBB0-0x00000001801FEC70
	[Name] // 0x00000001801FEBB0-0x00000001801FEC70
	public class SetSequenceLoopType : ActionTask // TypeDefIndex: 15661
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<int> Loops; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public LoopType LoopType; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180806770-0x0000000180806820 
	
		// Constructors
		public SetSequenceLoopType(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001808066E0-0x0000000180806770
	}
}
