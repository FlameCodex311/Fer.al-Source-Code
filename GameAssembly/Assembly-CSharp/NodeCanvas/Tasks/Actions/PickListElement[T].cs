﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180228A40-0x0000000180228A70
	public class PickListElement<T> : ActionTask // TypeDefIndex: 15326
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public PickListElement();
	
		// Methods
		protected override void OnExecute();
	}
}
