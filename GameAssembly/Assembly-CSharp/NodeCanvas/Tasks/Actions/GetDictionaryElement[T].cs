/*
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
	[Category] // 0x00000001800C6E10-0x00000001800C6E40
	public class GetDictionaryElement<T> : ActionTask // TypeDefIndex: 14216
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public GetDictionaryElement();
	
		// Methods
		protected override void OnExecute();
	}
}
