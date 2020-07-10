/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class FindWithTag : ActionTask // TypeDefIndex: 14268
	{
		// Fields
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		[TagField] // 0x00000001800B4050-0x00000001800B4080
		public string searchTag; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181546730-0x0000000181546910 
	
		// Constructors
		public FindWithTag(); // 0x00000001815466F0-0x0000000181546730
	
		// Methods
		protected override void OnExecute(); // 0x0000000181546680-0x00000001815466F0
	}
}
