/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SimpleGameObjectPool : MonoBehaviour // TypeDefIndex: 11884
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
	private static GameObject PoolGroup { get; } // 0x0000000180EC4000-0x0000000180EC4150 
	public bool IsReady { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 

	// Nested types
	private class PooledObject // TypeDefIndex: 11885
	{
		// Fields
		public GameObject gameObject; // 0x10
		public float inactiveTime; // 0x18

		// Constructors
		public PooledObject(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 11886
	{
		// Fields
		public SimpleGameObjectPool nPool; // 0x10
		public string inBundleID; // 0x18

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <CreatePoolWithBundle>b__0(GameObject inLoadedAsset); // 0x0000000180EC8AA0-0x0000000180EC8DA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CreatePoolWithBundle>d__19 : IEnumerator<object> // TypeDefIndex: 11887
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CreatePoolWithBundle>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EC4150-0x0000000180EC4580
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EC4580-0x0000000180EC4870
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InstantiateWhenReady>d__25 : IEnumerator<object> // TypeDefIndex: 11888
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SimpleGameObjectPool <>4__this; // 0x20
		public Vector3 inPos; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InstantiateWhenReady>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EC54B0-0x0000000180EC5540
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EC5540-0x0000000180EC8630
	}

	// Constructors
	public SimpleGameObjectPool(); // 0x0000000180EC3F50-0x0000000180EC4000
	static SimpleGameObjectPool(); // 0x0000000180EC3EE0-0x0000000180EC3F50

	// Methods
	public static bool HasPool(string inID); // 0x0000000180EC3370-0x0000000180EC33F0
	public static SimpleGameObjectPool GetPool(string inID, GameObject inClient); // 0x0000000180EC3260-0x0000000180EC3370
	[IteratorStateMachine] // 0x000000018014BB70-0x000000018014BBC0
	public static IEnumerator CreatePoolWithBundle(string inBundleID, GameObject inClient, int inMinimum = -1 /* Metadata: 0x00782C57 */, float inObjectDestroyTime = 5f /* Metadata: 0x00782C5B */, float inPoolDestroyTime = 30f /* Metadata: 0x00782C5F */); // 0x0000000180EC2E50-0x0000000180EC2EF0
	public static SimpleGameObjectPool CreatePoolWithGameObject(string inID, GameObject inClient, GameObject inPrefabInstance, int inMinimum = -1 /* Metadata: 0x00782C63 */, float inObjectDestroyTime = 5f /* Metadata: 0x00782C67 */, float inPoolDestroyTime = 30f /* Metadata: 0x00782C6B */); // 0x0000000180EC2EF0-0x0000000180EC3260
	private void Prime(); // 0x0000000180EC37D0-0x0000000180EC3900
	private void OnDestroy(); // 0x0000000180EC3750-0x0000000180EC37D0
	public void RegisterPoolClient(GameObject inGameObject); // 0x0000000180EC3900-0x0000000180EC39B0
	public void UnregisterPoolClient(GameObject inGameObject); // 0x0000000180EC39B0-0x0000000180EC3A60
	[IteratorStateMachine] // 0x000000018014BE60-0x000000018014BEB0
	public IEnumerator InstantiateWhenReady(Vector3 inPos = default, Quaternion inRot = default, Action<GameObject> inResult = null); // 0x0000000180EC33F0-0x0000000180EC3470
	public void Instantiate(Vector3 inPos = default, Quaternion inRot = default, Action<GameObject> inResult = null); // 0x0000000180EC3470-0x0000000180EC3750
	private void Update(); // 0x0000000180EC3A60-0x0000000180EC3EE0
}

