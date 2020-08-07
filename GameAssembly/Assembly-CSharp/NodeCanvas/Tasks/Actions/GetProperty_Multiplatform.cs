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
	[Category] // 0x000000018026A180-0x000000018026A200
	[Description] // 0x000000018026A180-0x000000018026A200
	[Name] // 0x000000018026A180-0x000000018026A200
	public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 15415
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x0000000180BB05A0-0x0000000180BB0680 
		protected override string info { get; } // 0x0000000180BB0680-0x0000000180BB0820 
	
		// Constructors
		public GetProperty_Multiplatform(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BB0420-0x0000000180BB04F0
		protected override string OnInit(); // 0x0000000180BB0390-0x0000000180BB0420
		protected override void OnExecute(); // 0x0000000180BB02C0-0x0000000180BB0390
		private void SetMethod(MethodInfo method); // 0x0000000180BB04F0-0x0000000180BB05A0
	}
}
