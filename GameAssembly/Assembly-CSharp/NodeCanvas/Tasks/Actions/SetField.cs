/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018026BF40-0x000000018026C020
	[Description] // 0x000000018026BF40-0x000000018026C020
	[fsMigrateVersions] // 0x000000018026BF40-0x000000018026C020
	[Name] // 0x000000018026BF40-0x000000018026C020
	public class SetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.SetField_0> // TypeDefIndex: 15421
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedFieldInfo field; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected BBObjectParameter setValue; // 0x70
	
		// Properties
		private FieldInfo targetField { get; } // 0x0000000180796EB0-0x0000000180796EC0 
		public override Type agentType { get; } // 0x00000001807A4460-0x00000001807A4540 
		protected override string info { get; } // 0x00000001807A4540-0x00000001807A46C0 
	
		// Constructors
		public SetField(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		void IMigratable<SetField_0>.Migrate(SetField_0 model); // 0x00000001807A42F0-0x00000001807A43B0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		protected override string OnInit(); // 0x00000001807A4250-0x00000001807A42F0
		protected override void OnExecute(); // 0x00000001807A4190-0x00000001807A4250
		private void SetTargetField(FieldInfo newField); // 0x00000001807A43B0-0x00000001807A4460
	}
}
