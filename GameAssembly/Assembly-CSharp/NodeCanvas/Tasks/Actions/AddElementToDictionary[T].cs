/*
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
	[Category] // 0x0000000180226B10-0x0000000180226B40
	public class AddElementToDictionary<T> : ActionTask // TypeDefIndex: 15315
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public AddElementToDictionary();
	
		// Methods
		protected override void OnExecute();
	}
}
