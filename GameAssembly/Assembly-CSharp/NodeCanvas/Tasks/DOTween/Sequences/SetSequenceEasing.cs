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
	[Category] // 0x0000000180157480-0x0000000180157540
	[Description] // 0x0000000180157480-0x0000000180157540
	[Icon] // 0x0000000180157480-0x0000000180157540
	[Name] // 0x0000000180157480-0x0000000180157540
	public class SetSequenceEasing : ActionTask // TypeDefIndex: 14551
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> EaseAmplitudeOrOvershoot; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> EasePeriod; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181262800-0x00000001812628C0 
	
		// Constructors
		public SetSequenceEasing(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181262710-0x0000000181262800
	}
}
