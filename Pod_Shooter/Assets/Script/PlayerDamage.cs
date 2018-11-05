using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour,Damagable {
    PlayerLife playerLife;

    public void DealDamage(int Damage)
    {
        playerLife.TakeDamage(Damage);
    }

    // Use this for initialization
    void Start () {
        playerLife = GetComponent<PlayerLife>();
	}
	
}
