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

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801E4050-0x00000001801E4110
	[Description] // 0x00000001801E4050-0x00000001801E4110
	[Icon] // 0x00000001801E4050-0x00000001801E4110
	[Name] // 0x00000001801E4050-0x00000001801E4110
	public class CreateFadeTween : ActionTask<Renderer> // TypeDefIndex: 15622
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Opacity; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F9230-0x00000001807F92D0 
	
		// Constructors
		public CreateFadeTween(); // 0x00000001807F9150-0x00000001807F9190
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F9010-0x00000001807F9110
	}
}
