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
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018026C9D0-0x000000018026CA50
	[Description] // 0x000000018026C9D0-0x000000018026CA50
	[Name] // 0x000000018026C9D0-0x000000018026CA50
	public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 15422
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x00000001807A6850-0x00000001807A6930 
		protected override string info { get; } // 0x00000001807A6930-0x00000001807A6AE0 
	
		// Constructors
		public SetProperty_Multiplatform(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001807A6650-0x00000001807A6760
		protected override string OnInit(); // 0x00000001807A65C0-0x00000001807A6650
		protected override void OnExecute(); // 0x00000001807A64C0-0x00000001807A65C0
		private void SetMethod(MethodInfo method); // 0x00000001807A6760-0x00000001807A6850
	}
}
