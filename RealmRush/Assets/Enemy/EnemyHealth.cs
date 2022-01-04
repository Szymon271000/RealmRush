using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currenHitPoints = 0;
    Enemy enemy;
    void OnEnable()
    {  
        currenHitPoints = maxHitPoints;   
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currenHitPoints--;
        if (currenHitPoints <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }
}
