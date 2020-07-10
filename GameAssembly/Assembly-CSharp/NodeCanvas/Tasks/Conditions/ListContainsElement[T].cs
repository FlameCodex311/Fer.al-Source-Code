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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C77C0-0x00000001800C7820
	[Description] // 0x00000001800C77C0-0x00000001800C7820
	public class ListContainsElement<T> : ConditionTask // TypeDefIndex: 14129
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<List<T>> targetList;
		public BBParameter<T> checkElement;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public ListContainsElement();
	
		// Methods
		protected override bool OnCheck();
	}
}
