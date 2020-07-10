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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

internal static class QGjnOCnHKfrjIqlAonYthHKMREQ // TypeDefIndex: 6854
{
	// Nested types
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value); // TypeDefIndex: 6855; 0x00000000-0x00000000

	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	public class HierarchyEventHelper<THandler, TValue> // TypeDefIndex: 6856
		where THandler : class
	{
		// Fields
		private readonly EventFunction<THandler, TValue> FmqYEzWbIgTCCwgwZlMrEZtvHDl;
		private readonly List<THandler> tTpxikyFxoYOndRtafIKiJduzRC;
		private readonly mNUzMnNqQkhDwviritXNCuEbBBq nTTqWZpCcVRhACCitBSNVDOCEsKf;

		// Nested types
		[Flags] // 0x00000001800B36B0-0x00000001800B36C0
		public enum mNUzMnNqQkhDwviritXNCuEbBBq // TypeDefIndex: 6857
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
	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(T param_0000ee10, TArgs param_0000ee11, EventFunction<T, TArgs> param_0000ee12)
		where T : class;
	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(IList<T> param_0000ee13, TArgs param_0000ee14, EventFunction<T, TArgs> param_0000ee15)
		where T : class;
	public static void wJzrdYArvEbReVrBiirmhwJTecP<T, TArgs>(IList<T> param_0000ee16, TArgs param_0000ee17, EventFunction<T, TArgs> param_0000ee18, bool param_0000ee19)
		where T : class;
}

