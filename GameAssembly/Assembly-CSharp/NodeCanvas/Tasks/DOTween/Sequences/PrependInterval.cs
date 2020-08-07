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
	[Category] // 0x00000001801FCB60-0x00000001801FCC20
	[Description] // 0x00000001801FCB60-0x00000001801FCC20
	[Icon] // 0x00000001801FCB60-0x00000001801FCC20
	[Name] // 0x00000001801FCB60-0x00000001801FCC20
	public class PrependInterval : ActionTask // TypeDefIndex: 15658
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Interval; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180805AC0-0x0000000180805B60 
	
		// Constructors
		public PrependInterval(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180805A30-0x0000000180805AC0
	}
}
