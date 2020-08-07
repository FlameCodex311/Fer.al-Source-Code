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
	[Category] // 0x00000001801F39A0-0x00000001801F3A60
	[Description] // 0x00000001801F39A0-0x00000001801F3A60
	[Icon] // 0x00000001801F39A0-0x00000001801F3A60
	[Name] // 0x00000001801F39A0-0x00000001801F3A60
	public class AppendTween : ActionTask // TypeDefIndex: 15648
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> Tween; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807F2250-0x00000001807F22F0 
	
		// Constructors
		public AppendTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F21C0-0x00000001807F2250
	}
}
