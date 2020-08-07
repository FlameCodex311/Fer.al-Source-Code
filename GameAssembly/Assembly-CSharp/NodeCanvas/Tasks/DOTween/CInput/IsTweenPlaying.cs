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

namespace NodeCanvas.Tasks.DOTween.CInput
{
	[Category] // 0x00000001801D2280-0x00000001801D2340
	[Description] // 0x00000001801D2280-0x00000001801D2340
	[Icon] // 0x00000001801D2280-0x00000001801D2340
	[Name] // 0x00000001801D2280-0x00000001801D2340
	public class IsTweenPlaying : ConditionTask // TypeDefIndex: 15592
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
	
		// Constructors
		public IsTweenPlaying(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807FFC60-0x00000001807FFCB0
	}
}
