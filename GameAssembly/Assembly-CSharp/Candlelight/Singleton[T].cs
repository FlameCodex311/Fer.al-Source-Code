/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public abstract class Singleton<T> // TypeDefIndex: 14496
		where T : Singleton<T>, new()
	{
		// Fields
		private static T s_Instance;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected Singleton();
		static Singleton();
	}
}
