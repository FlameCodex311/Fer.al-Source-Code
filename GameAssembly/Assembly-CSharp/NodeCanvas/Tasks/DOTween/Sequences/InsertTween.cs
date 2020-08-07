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
	[Category] // 0x00000001801F76D0-0x00000001801F7790
	[Description] // 0x00000001801F76D0-0x00000001801F7790
	[Icon] // 0x00000001801F76D0-0x00000001801F7790
	[Name] // 0x00000001801F76D0-0x00000001801F7790
	public class InsertTween : ActionTask // TypeDefIndex: 15652
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> TimePosition; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807FE140-0x00000001807FE1E0 
	
		// Constructors
		public InsertTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FE080-0x00000001807FE140
	}
}
