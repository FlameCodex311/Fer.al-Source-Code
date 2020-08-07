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
	[Category] // 0x00000001802695F0-0x00000001802696D0
	[Description] // 0x00000001802695F0-0x00000001802696D0
	[fsMigrateVersions] // 0x00000001802695F0-0x00000001802696D0
	[Name] // 0x00000001802695F0-0x00000001802696D0
	public class GetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.GetField_0> // TypeDefIndex: 15414
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedFieldInfo field; // 0x68
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected BBObjectParameter saveAs; // 0x70
	
		// Properties
		private FieldInfo targetField { get; } // 0x0000000180796EB0-0x0000000180796EC0 
		public override Type agentType { get; } // 0x0000000180BAE010-0x0000000180BAE0F0 
		protected override string info { get; } // 0x0000000180BAE0F0-0x0000000180BAE290 
	
		// Constructors
		public GetField(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		void IMigratable<GetField_0>.Migrate(GetField_0 model); // 0x0000000180BADEA0-0x0000000180BADF60
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		protected override string OnInit(); // 0x0000000180BADE00-0x0000000180BADEA0
		protected override void OnExecute(); // 0x0000000180BADD30-0x0000000180BADE00
		private void SetTargetField(FieldInfo newField); // 0x0000000180BADF60-0x0000000180BAE010
	}
}
