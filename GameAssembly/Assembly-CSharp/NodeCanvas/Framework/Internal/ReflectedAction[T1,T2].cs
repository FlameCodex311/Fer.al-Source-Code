/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper // TypeDefIndex: 14624
	{
		// Fields
		private ActionCall<T1, T2> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}
}
