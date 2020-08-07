/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018026A720-0x000000018026A7A0
	[Description] // 0x000000018026A720-0x000000018026A7A0
	[Name] // 0x000000018026A720-0x000000018026A7A0
	public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 15416
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<BBObjectParameter> parameters; // 0x70
		private Status actionStatus; // 0x78
		private object[] args; // 0x80
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x0000000180BB2190-0x0000000180BB2270 
		protected override string info { get; } // 0x0000000180BB2270-0x0000000180BB2460 
	
		// Constructors
		public ImplementedAction_Multiplatform(); // 0x0000000180BB2120-0x0000000180BB2190
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BB1F30-0x0000000180BB1F70
		protected override string OnInit(); // 0x0000000180BB1C40-0x0000000180BB1D20
		protected override void OnUpdate(); // 0x0000000180BB1D30-0x0000000180BB1F30
		protected override void OnStop(); // 0x0000000180BB1D20-0x0000000180BB1D30
		private void SetMethod(MethodInfo method); // 0x0000000180BB1F70-0x0000000180BB2120
	}
}
