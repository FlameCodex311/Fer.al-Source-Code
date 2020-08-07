/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Components
{
	[Serializable]
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public abstract class ComponentWrapper<T> : UnityEngine.MonoBehaviour // TypeDefIndex: 6032
		where T : class
	{
		// Fields
		[NonSerialized]
		private T JEVAvDAWidJhVxFUpAPvixPZmfz;
		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;
	
		// Properties
		protected T source { get; }
		protected bool initialized { get; }
	
		// Constructors
		protected ComponentWrapper();
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Awake();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Start();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnEnable();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDisable();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDestroy();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Reset();
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnValidate();
		protected virtual void OnAwake();
		protected virtual void OnAwakeFinished();
		protected virtual void OnStart();
		protected virtual void OnEnabled();
		protected virtual void OnDisabled();
		protected virtual void OnDestroyed();
		protected virtual void OnReset();
		protected virtual void OnValidated();
		protected virtual void Initialize();
		protected virtual bool TryInitialize();
		protected abstract T CreateSource(object args);
		protected abstract object GetCreateSourceArgs();
		protected virtual void PostInitialize();
		protected virtual void Deinitialize();
		protected virtual void Subscribe();
		protected virtual void Unsubscribe();
		private void VboHevouBTahrKAQtPDcSpQdKzMg();
		private void DVKPVAcCkxaPBjRrGgxBdrguwNl();
	}
}
