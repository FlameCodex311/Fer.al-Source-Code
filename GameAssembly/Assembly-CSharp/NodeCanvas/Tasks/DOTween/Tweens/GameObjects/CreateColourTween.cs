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
	[Category] // 0x00000001801E3790-0x00000001801E3850
	[Description] // 0x00000001801E3790-0x00000001801E3850
	[Icon] // 0x00000001801E3790-0x00000001801E3850
	[Name] // 0x00000001801E3790-0x00000001801E3850
	public class CreateColourTween : ActionTask<Renderer> // TypeDefIndex: 15621
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> NewColour; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F8E00-0x00000001807F8F30 
	
		// Constructors
		public CreateColourTween(); // 0x00000001807F8A30-0x00000001807F8A70
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F86F0-0x00000001807F87F0
	}
}
