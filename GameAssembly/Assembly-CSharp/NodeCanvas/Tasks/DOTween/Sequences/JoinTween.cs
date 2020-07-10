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
	[Category] // 0x0000000180153140-0x0000000180153200
	[Description] // 0x0000000180153140-0x0000000180153200
	[Icon] // 0x0000000180153140-0x0000000180153200
	[Name] // 0x0000000180153140-0x0000000180153200
	public class JoinTween : ActionTask // TypeDefIndex: 14544
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812578A0-0x0000000181257940 
	
		// Constructors
		public JoinTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181257810-0x00000001812578A0
	}
}
