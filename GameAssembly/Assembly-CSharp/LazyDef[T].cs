/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LazyDef<T> // TypeDefIndex: 11005
	where T : BaseDef
{
	// Fields
	private Func<string, T> _getFunc;
	private string _defID;
	private T _def;

	// Properties
	public string DefID { get; }
	public T Def { get; }

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 11006
	{
		// Fields
		public Type inChartType;
		public string inDefID;

		// Constructors
		public <>c__DisplayClass10_0();

		// Methods
		internal T <.ctor>b__0(string defIDs);
	}

	// Constructors
	public LazyDef(string inDefID, Func<string, T> inGetFunc);
	public LazyDef(string inDefID, Type inChartType);

	// Methods
	public static implicit operator T(LazyDef<T> inDef);
	public static implicit operator string(LazyDef<T> inDef);
}

