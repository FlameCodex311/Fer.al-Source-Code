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

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x0000000180132290-0x0000000180132350
	[Description] // 0x0000000180132290-0x0000000180132350
	[Icon] // 0x0000000180132290-0x0000000180132350
	[Name] // 0x0000000180132290-0x0000000180132350
	public class RestartTween : ActionTask // TypeDefIndex: 14491
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x68
		public BBParameter<bool> IncludeDelay; // 0x70
		public BBParameter<bool> WaitUntilFinished; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E98FE0-0x0000000180E990E0 
	
		// Constructors
		public RestartTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E98EA0-0x0000000180E98FE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__5_0(); // 0x0000000180E98B70-0x0000000180E98B80
	}
}
