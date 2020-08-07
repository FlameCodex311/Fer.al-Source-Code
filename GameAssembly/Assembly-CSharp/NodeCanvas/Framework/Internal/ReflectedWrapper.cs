/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	public abstract class ReflectedWrapper : IReflectedWrapper // TypeDefIndex: 15777
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Constructors
		public ReflectedWrapper(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb); // 0x0000000180CCE740-0x0000000180CCE830
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000180372440-0x0000000180372450
		public void SetVariablesBB(IBlackboard bb); // 0x0000000180CCE850-0x0000000180CCE8E0
		public SerializedMethodInfo GetSerializedMethod(); // 0x0000000180372440-0x0000000180372450
		public MethodInfo GetMethod(); // 0x0000000180CCE830-0x0000000180CCE840
		public bool HasChanged(); // 0x0000000180CCE840-0x0000000180CCE850
		public string AsString(); // 0x0000000180CCE720-0x0000000180CCE740
		public override string ToString(); // 0x0000000180CCE720-0x0000000180CCE740
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}
}
