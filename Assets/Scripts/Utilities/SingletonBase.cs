﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>

namespace ns
{
	public class SingletonBase<T> : MonoBehaviour where T:MonoBehaviour
	{
		private static T instance;
		public static T Instance
        {
			get
            {
				return instance;
            }
        }
		protected virtual void Awake()
        {
			if (instance != null)
            {
				Destroy(gameObject);
            }
			else
            {
				instance = this as T;
            }
        }
	}
}