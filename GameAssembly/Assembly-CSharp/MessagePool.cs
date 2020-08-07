/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MessagePool // TypeDefIndex: 11215
{
	// Fields
	private Dictionary<Type, Stack<Message>> _messagePool; // 0x10
	private Dictionary<Type, int> _poolSizes; // 0x18
	private int _defaultPoolSize; // 0x20

	// Constructors
	public MessagePool(int inDefaultPoolSize); // 0x0000000180BFE050-0x0000000180BFE0E0

	// Methods
	public void SetPoolSize<T>(int inPoolSize)
		where T : Message;
	public void AddMessageToPool<T>(T inMessage)
		where T : Message;
	public T RemoveMessageFromPool<T>()
		where T : Message;
	private Stack<Message> CreatePool(Type inType, int inCapacity); // 0x0000000180BFDEF0-0x0000000180BFE050
}

