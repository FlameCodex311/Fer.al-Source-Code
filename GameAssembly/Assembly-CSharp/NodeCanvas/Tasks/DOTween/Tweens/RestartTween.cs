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

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x00000001801D5CD0-0x00000001801D5D90
	[Description] // 0x00000001801D5CD0-0x00000001801D5D90
	[Icon] // 0x00000001801D5CD0-0x00000001801D5D90
	[Name] // 0x00000001801D5CD0-0x00000001801D5D90
	public class RestartTween : ActionTask // TypeDefIndex: 15600
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Tween> Tween; // 0x68
		public BBParameter<bool> IncludeDelay; // 0x70
		public BBParameter<bool> WaitUntilFinished; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001808060F0-0x00000001808061F0 
	
		// Constructors
		public RestartTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180805FB0-0x00000001808060F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__5_0(); // 0x000000018079F110-0x000000018079F120
	}
}
