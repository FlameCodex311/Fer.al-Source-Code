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
	[Category] // 0x00000001801F9390-0x00000001801F9450
	[Description] // 0x00000001801F9390-0x00000001801F9450
	[Icon] // 0x00000001801F9390-0x00000001801F9450
	[Name] // 0x00000001801F9390-0x00000001801F9450
	public class JoinTween : ActionTask // TypeDefIndex: 15653
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Sequence> Sequence; // 0x68
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807FFE10-0x00000001807FFEB0 
	
		// Constructors
		public JoinTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FFD80-0x00000001807FFE10
	}
}
