/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

internal static class QGjnOCnHKfrjIqlAonYthHKMREQ // TypeDefIndex: 7013
{
	// Nested types
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value); // TypeDefIndex: 7014; 0x00000000-0x00000000

	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	public class HierarchyEventHelper<THandler, TValue> // TypeDefIndex: 7015
		where THandler : class
	{
		// Fields
		private readonly EventFunction<THandler, TValue> FmqYEzWbIgTCCwgwZlMrEZtvHDl;
		private readonly List<THandler> tTpxikyFxoYOndRtafIKiJduzRC;
		private readonly mNUzMnNqQkhDwviritXNCuEbBBq nTTqWZpCcVRhACCitBSNVDOCEsKf;

		// Nested types
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		public enum mNUzMnNqQkhDwviritXNCuEbBBq // TypeDefIndex: 7016
		{
			vzMMxueJoLYorCLLdhgKRypSGMx = -1,
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			reutqBoSDFHzdRdatgCOBTMjhdTc = 1,
			LigEtlOuYTjsfZpmMXVZLQEijfx = 4,
			mGkdKoxcxeNOsPnVWJQusKcKhEH = 8
		}

		// Constructors
		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate);
		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate, mNUzMnNqQkhDwviritXNCuEbBBq executeOn);

		// Methods
		public void ExecuteOnAll(TValue value);
		public void GetHandlers(Transform transform);
	}

	// Methods
	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(T param_0000f080, TArgs param_0000f081, EventFunction<T, TArgs> param_0000f082)
		where T : class;
	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(IList<T> param_0000f083, TArgs param_0000f084, EventFunction<T, TArgs> param_0000f085)
		where T : class;
	public static void wJzrdYArvEbReVrBiirmhwJTecP<T, TArgs>(IList<T> param_0000f086, TArgs param_0000f087, EventFunction<T, TArgs> param_0000f088, bool param_0000f089)
		where T : class;
}

