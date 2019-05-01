using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HoudiniData", menuName = "Houdini/Data", order = 1)]
public class HoudiniData : ScriptableObject
{
	[System.Serializable]
	public class Entry
	{
		public int nodeType;
		public Quaternion orient;
		public Vector3 P;
		public Vector3 scale;
	}

	public Entry[] _entries;
}
