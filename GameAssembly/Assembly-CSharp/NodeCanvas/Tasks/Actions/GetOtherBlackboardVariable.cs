﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E8A30-0x00000001800E8A90
	[Description] // 0x00000001800E8A30-0x00000001800E8A90
	public class GetOtherBlackboardVariable : ActionTask<Blackboard> // TypeDefIndex: 14218
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> targetVariableName; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181549DB0-0x0000000181549DF0 
	
		// Constructors
		public GetOtherBlackboardVariable(); // 0x0000000181549D70-0x0000000181549DB0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181549C90-0x0000000181549D70
	}
}
