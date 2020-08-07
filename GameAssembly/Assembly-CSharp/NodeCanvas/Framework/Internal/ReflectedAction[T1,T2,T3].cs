/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper // TypeDefIndex: 15766
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}
}
