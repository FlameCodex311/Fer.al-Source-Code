﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800EBE60-0x00000001800EBEC0
	[Description] // 0x00000001800EBE60-0x00000001800EBEC0
	public class RemoveElementFromList<T> : ActionTask // TypeDefIndex: 14228
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveElementFromList();
	
		// Methods
		protected override void OnExecute();
	}
}