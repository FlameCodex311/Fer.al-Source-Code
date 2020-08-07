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
	[Category] // 0x00000001801FD6E0-0x00000001801FD7A0
	[Description] // 0x00000001801FD6E0-0x00000001801FD7A0
	[Icon] // 0x00000001801FD6E0-0x00000001801FD7A0
	[Name] // 0x00000001801FD6E0-0x00000001801FD7A0
	public class PrependTween : ActionTask // TypeDefIndex: 15659
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180805BF0-0x0000000180805C90 
	
		// Constructors
		public PrependTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180805B60-0x0000000180805BF0
	}
}
