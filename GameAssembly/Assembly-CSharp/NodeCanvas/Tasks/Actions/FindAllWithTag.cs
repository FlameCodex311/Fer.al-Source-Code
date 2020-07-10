/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F54A0-0x00000001800F5500
	[Description] // 0x00000001800F54A0-0x00000001800F5500
	public class FindAllWithTag : ActionTask // TypeDefIndex: 14261
	{
		// Fields
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		[TagField] // 0x00000001800B4050-0x00000001800B4080
		public string searchTag; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001815454F0-0x00000001815456D0 
	
		// Constructors
		public FindAllWithTag(); // 0x00000001815454B0-0x00000001815454F0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181545400-0x00000001815454B0
	}
}
