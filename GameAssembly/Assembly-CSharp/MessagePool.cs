/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MessagePool // TypeDefIndex: 13544
{
	// Fields
	private Dictionary<Type, Stack<Message>> _messagePool; // 0x10
	private Dictionary<Type, int> _poolSizes; // 0x18
	private int _defaultPoolSize; // 0x20

	// Constructors
	public MessagePool(int inDefaultPoolSize); // 0x00000001810AEC80-0x00000001810AED10

	// Methods
	public void SetPoolSize<T>(int inPoolSize)
		where T : Message;
	public void AddMessageToPool<T>(T inMessage)
		where T : Message;
	public T RemoveMessageFromPool<T>()
		where T : Message;
	private Stack<Message> CreatePool(Type inType, int inCapacity); // 0x00000001810AEB20-0x00000001810AEC80
}

