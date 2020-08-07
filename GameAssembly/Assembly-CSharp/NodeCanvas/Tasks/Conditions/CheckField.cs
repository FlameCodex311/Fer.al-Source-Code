/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180234850-0x0000000180234930
	[Description] // 0x0000000180234850-0x0000000180234930
	[fsMigrateVersions] // 0x0000000180234850-0x0000000180234930
	[Name] // 0x0000000180234850-0x0000000180234930
	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0> // TypeDefIndex: 15245
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected BBObjectParameter checkValue; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected CompareMethod comparison; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedFieldInfo field; // 0x78
	
		// Properties
		private FieldInfo targetField { get; } // 0x000000018079B650-0x000000018079B660 
		public override Type agentType { get; } // 0x000000018079B290-0x000000018079B370 
		protected override string info { get; } // 0x000000018079B370-0x000000018079B650 
	
		// Constructors
		public CheckField(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		void IMigratable<CheckField_0>.Migrate(CheckField_0 model); // 0x000000018079B070-0x000000018079B1D0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000180418A40-0x0000000180418A50
		protected override string OnInit(); // 0x000000018079AFD0-0x000000018079B070
		protected override bool OnCheck(); // 0x000000018079AC60-0x000000018079AFD0
		private void SetTargetField(FieldInfo newField); // 0x000000018079B1D0-0x000000018079B290
	}
}
