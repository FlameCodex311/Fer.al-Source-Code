/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PianoSong // TypeDefIndex: 14942
	{
		// Fields
		public int bpm; // 0x10
		public int beat_unit; // 0x14
		public int beats_per_bar; // 0x18
		public int numBars; // 0x1C
		public Bar[] bars; // 0x20
	
		// Nested types
		public enum Pitch // TypeDefIndex: 14943
		{
			NONE = 0,
			C = 1,
			C_SHARP = 2,
			D = 3,
			D_SHARP = 4,
			E = 5,
			F = 6,
			F_SHARP = 7,
			G = 8,
			G_SHARP = 9,
			A = 10,
			A_SHARP = 11,
			B = 12
		}
	
		public class Note // TypeDefIndex: 14944
		{
			// Fields
			public Pitch pitch; // 0x10
			public int length; // 0x14
			public int index; // 0x18
	
			// Constructors
			public Note(int l); // 0x0000000180A4D4E0-0x0000000180A4D510
	
			// Methods
			public void Set(Pitch p, int l, int idx); // 0x0000000180A4D4D0-0x0000000180A4D4E0
		}
	
		public class Beat // TypeDefIndex: 14945
		{
			// Fields
			public int number; // 0x10
			public List<Note> notes; // 0x18
	
			// Constructors
			public Beat(int n); // 0x0000000180A48420-0x0000000180A48580
	
			// Methods
			public void Add(Pitch pitch, int length, int noteIndex); // 0x0000000180A48390-0x0000000180A48420
		}
	
		public class Bar // TypeDefIndex: 14946
		{
			// Fields
			public int numBeats; // 0x10
			public Beat[] beats; // 0x18
	
			// Constructors
			public Bar(int n); // 0x0000000180A48160-0x0000000180A48390
	
			// Methods
			public void Add(int beatNumber, Pitch pitch, int length, int noteIndex); // 0x0000000180A48090-0x0000000180A48160
		}
	
		// Constructors
		public PianoSong(int beat_unit, int beats_per_bar, int numBars, int bpm); // 0x0000000180A507E0-0x0000000180A50900
	
		// Methods
		public void Add(int bar, int beat, Pitch pitch, int length, int noteIndex); // 0x0000000180A506D0-0x0000000180A507E0
	}
}
