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
	[Category] // 0x0000000180131B90-0x0000000180131C50
	[Description] // 0x0000000180131B90-0x0000000180131C50
	[Icon] // 0x0000000180131B90-0x0000000180131C50
	[Name] // 0x0000000180131B90-0x0000000180131C50
	public class PlayTweenBackwards : ActionTask // TypeDefIndex: 14490
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x68
		public BBParameter<bool> WaitUntilFinished; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180E98B80-0x0000000180E98C80 
	
		// Constructors
		public PlayTweenBackwards(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E98A60-0x0000000180E98B70
		private void OnTweenComplete(); // 0x0000000180E98B70-0x0000000180E98B80
	}
}
