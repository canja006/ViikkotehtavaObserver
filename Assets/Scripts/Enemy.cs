using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Delegaatti, joka ilmoittaa vihollisen tuhoutumisesta
    public static event Action OnEnemyDestroyed;

    // Metodi, joka kutsuu delegaatin kuuntelijoita tuhoutuessa
    private void OnDestroy()
    {
        OnEnemyDestroyed?.Invoke(); 
    }
}