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
	[Category] // 0x00000001801FB0D0-0x00000001801FB190
	[Description] // 0x00000001801FB0D0-0x00000001801FB190
	[Icon] // 0x00000001801FB0D0-0x00000001801FB190
	[Name] // 0x00000001801FB0D0-0x00000001801FB190
	public class PlaySequence : ActionTask // TypeDefIndex: 15657
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		public BBParameter<bool> WaitUntilFinished; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180805500-0x0000000180805600 
	
		// Constructors
		public PlaySequence(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001808053E0-0x0000000180805500
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__4_0(); // 0x000000018079F110-0x000000018079F120
	}
}
