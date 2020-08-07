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
	[Category] // 0x00000001801FA490-0x00000001801FA550
	[Description] // 0x00000001801FA490-0x00000001801FA550
	[Icon] // 0x00000001801FA490-0x00000001801FA550
	[Name] // 0x00000001801FA490-0x00000001801FA550
	public class PlaySequenceBackwards : ActionTask // TypeDefIndex: 15655
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180805280-0x0000000180805300 
	
		// Constructors
		public PlaySequenceBackwards(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180805220-0x0000000180805280
	}
}
