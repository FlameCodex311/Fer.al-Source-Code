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
	[Category] // 0x00000001801E2C80-0x00000001801E2D40
	[Description] // 0x00000001801E2C80-0x00000001801E2D40
	[Icon] // 0x00000001801E2C80-0x00000001801E2D40
	[Name] // 0x00000001801E2C80-0x00000001801E2D40
	public class CreateColourPropertyTween : ActionTask<Renderer> // TypeDefIndex: 15620
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> NewColour; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> PropertyName; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F8420-0x00000001807F8510 
	
		// Constructors
		public CreateColourPropertyTween(); // 0x00000001807F82F0-0x00000001807F8330
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F8080-0x00000001807F81C0
	}
}
