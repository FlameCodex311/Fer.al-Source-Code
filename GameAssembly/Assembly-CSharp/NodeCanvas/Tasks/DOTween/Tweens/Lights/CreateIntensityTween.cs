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

namespace NodeCanvas.Tasks.DOTween.Tweens.Lights
{
	[Category] // 0x00000001801E0710-0x00000001801E07D0
	[Description] // 0x00000001801E0710-0x00000001801E07D0
	[Icon] // 0x00000001801E0710-0x00000001801E07D0
	[Name] // 0x00000001801E0710-0x00000001801E07D0
	public class CreateIntensityTween : ActionTask<Light> // TypeDefIndex: 15618
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Intensity; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F9850-0x00000001807F98F0 
	
		// Constructors
		public CreateIntensityTween(); // 0x00000001807F9810-0x00000001807F9850
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F9730-0x00000001807F9810
	}
}
