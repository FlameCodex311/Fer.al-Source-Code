/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SimpleGameObjectPool : MonoBehaviour // TypeDefIndex: 13420
{
	// Fields
	private GameObject _prefabInstance; // 0x20
	private string _poolID; // 0x28
	private static GameObject _poolGroup; // 0x00
	private static Dictionary<string, SimpleGameObjectPool> _poolsByID; // 0x08
	private List<GameObject> _poolClients; // 0x30
	private bool _isReady; // 0x38
	private List<PooledObject> _inactiveObjects; // 0x40
	private List<PooledObject> _activeObjects; // 0x48
	private float _objectDestroyTime; // 0x50
	private float _poolDestroyTime; // 0x54
	private float _poolDestroyTimer; // 0x58
	private int _minimumPooled; // 0x5C

	// Properties
	private static GameObject PoolGroup { get; } // 0x000000018076D7F0-0x000000018076D940 
	public bool IsReady { get; } // 0x0000000180379B20-0x0000000180379B30 

	// Nested types
	private class PooledObject // TypeDefIndex: 13421
	{
		// Fields
		public GameObject gameObject; // 0x10
		public float inactiveTime; // 0x18

		// Constructors
		public PooledObject(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 13422
	{
		// Fields
		public SimpleGameObjectPool nPool; // 0x10
		public string inBundleID; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <CreatePoolWithBundle>b__0(GameObject inLoadedAsset); // 0x0000000180777220-0x0000000180777510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CreatePoolWithBundle>d__19 : IEnumerator<object> // TypeDefIndex: 13423
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inBundleID; // 0x20
		public GameObject inClient; // 0x28
		public int inMinimum; // 0x30
		public float inPoolDestroyTime; // 0x34
		public float inObjectDestroyTime; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CreatePoolWithBundle>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180774270-0x0000000180774690
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180774690-0x00000001807746E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InstantiateWhenReady>d__25 : IEnumerator<object> // TypeDefIndex: 13424
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SimpleGameObjectPool <>4__this; // 0x20
		public Vector3 inPos; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InstantiateWhenReady>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807746E0-0x0000000180774770
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180774770-0x00000001807747C0
	}

	// Constructors
	public SimpleGameObjectPool(); // 0x000000018076D740-0x000000018076D7F0
	static SimpleGameObjectPool(); // 0x000000018076D6D0-0x000000018076D740

	// Methods
	public static bool HasPool(string inID); // 0x000000018076CB90-0x000000018076CC10
	public static SimpleGameObjectPool GetPool(string inID, GameObject inClient); // 0x000000018076CA80-0x000000018076CB90
	[IteratorStateMachine] // 0x0000000180233720-0x0000000180233770
	public static IEnumerator CreatePoolWithBundle(string inBundleID, GameObject inClient, int inMinimum = -1 /* Metadata: 0x007BA365 */, float inObjectDestroyTime = 5f /* Metadata: 0x007BA369 */, float inPoolDestroyTime = 30f /* Metadata: 0x007BA36D */); // 0x000000018076C680-0x000000018076C720
	public static SimpleGameObjectPool CreatePoolWithGameObject(string inID, GameObject inClient, GameObject inPrefabInstance, int inMinimum = -1 /* Metadata: 0x007BA371 */, float inObjectDestroyTime = 5f /* Metadata: 0x007BA375 */, float inPoolDestroyTime = 30f /* Metadata: 0x007BA379 */); // 0x000000018076C720-0x000000018076CA80
	private void Prime(); // 0x000000018076CFE0-0x000000018076D110
	private void OnDestroy(); // 0x000000018076CF60-0x000000018076CFE0
	public void RegisterPoolClient(GameObject inGameObject); // 0x000000018076D110-0x000000018076D1C0
	public void UnregisterPoolClient(GameObject inGameObject); // 0x000000018076D1C0-0x000000018076D270
	[IteratorStateMachine] // 0x0000000180233A00-0x0000000180233A50
	public IEnumerator InstantiateWhenReady(Vector3 inPos = default, Quaternion inRot = default, Action<GameObject> inResult = null); // 0x000000018076CC10-0x000000018076CC90
	public void Instantiate(Vector3 inPos = default, Quaternion inRot = default, Action<GameObject> inResult = null); // 0x000000018076CC90-0x000000018076CF60
	private void Update(); // 0x000000018076D270-0x000000018076D6D0
}

