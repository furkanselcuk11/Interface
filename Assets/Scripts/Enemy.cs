using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHealth<int>, IDamageable // IHealth
{
    [SerializeField] private int _health;
    public int health
    {
        get => _health;
        set => _health = value;
    }
    public void TakeDamege(int damageTaken)
    {
        // Health azalat
        health -= damageTaken;
        Debug.Log(gameObject.name + " health --->" + health);

        if (health <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        // Yok et
        Debug.Log(gameObject.name + " Destroyed...!");
        Destroy(gameObject, 0.5f);
    }
}
