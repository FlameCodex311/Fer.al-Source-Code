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
	[Category] // 0x00000001801D9D10-0x00000001801D9DD0
	[Description] // 0x00000001801D9D10-0x00000001801D9DD0
	[Icon] // 0x00000001801D9D10-0x00000001801D9DD0
	[Name] // 0x00000001801D9D10-0x00000001801D9DD0
	public class CreateResizeTween : ActionTask<TrailRenderer> // TypeDefIndex: 15609
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> StartSize; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> EndSize; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807FC1E0-0x00000001807FC290 
	
		// Constructors
		public CreateResizeTween(); // 0x00000001807FC1A0-0x00000001807FC1E0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FC080-0x00000001807FC1A0
	}
}
