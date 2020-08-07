/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.TrailRenderer
{
	[Category] // 0x00000001801DA740-0x00000001801DA800
	[Description] // 0x00000001801DA740-0x00000001801DA800
	[Icon] // 0x00000001801DA740-0x00000001801DA800
	[Name] // 0x00000001801DA740-0x00000001801DA800
	public class CreateTimeTween : ActionTask<TrailRenderer> // TypeDefIndex: 15610
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> EndValue; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807FD970-0x00000001807FDA10 
	
		// Constructors
		public CreateTimeTween(); // 0x00000001807FD930-0x00000001807FD970
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FD850-0x00000001807FD930
	}
}
