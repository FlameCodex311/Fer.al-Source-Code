/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class BBParameter // TypeDefIndex: 14600
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _name; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _targetVariableID; // 0x18
		[NonSerialized]
		private IBlackboard _bb; // 0x20
		[NonSerialized]
		private Variable _varRef; // 0x28
	
		// Properties
		private string targetVariableID { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public Variable varRef { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000181560020-0x0000000181560040
		public IBlackboard bb { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018155FEA0-0x000000018155FEF0
		public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018155FEF0-0x000000018155FF60
		public bool useBlackboard { get; set; } // 0x00000001806F12E0-0x00000001806F12F0 0x000000018155FF60-0x0000000181560020
		public bool isNone { get; } // 0x000000018155FD00-0x000000018155FD50 
		public bool isDefined { get; } // 0x000000018155FCE0-0x000000018155FD00 
		public bool isNull { get; } // 0x000000018155FD50-0x000000018155FE80 
		public Type refType { get; } // 0x000000018155FE80-0x000000018155FEA0 
		public object value { get; set; } // 0x0000000180B2D770-0x0000000180B2D790 0x0000000180DDBD70-0x0000000180DDBD90
		protected abstract object objectValue { get; set; }
		public abstract Type varType { get; }
	
		// Constructors
		public BBParameter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static BBParameter CreateInstance(Type t, IBlackboard bb); // 0x000000018155EB60-0x000000018155ED80
		public static void SetBBFields(object o, IBlackboard bb); // 0x000000018155F920-0x000000018155FA40
		public static List<BBParameter> GetObjectBBParameters(object o); // 0x000000018155ED80-0x000000018155F400
		protected abstract void Bind(Variable data);
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID); // 0x000000018155F750-0x000000018155F920
		public Variable PromoteToVariable(IBlackboard targetBB); // 0x000000018155F400-0x000000018155F750
		public sealed override string ToString(); // 0x000000018155FA40-0x000000018155FCE0
	}
}
