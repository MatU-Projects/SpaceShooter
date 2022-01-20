﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_BOSS_Shooting_LVL3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bullet;
    [SerializeField] float speed_bullet;
    [SerializeField] double _attack;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 1f) { InvokeRepeating("Shoot", 0.4f, 0.1f); }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Shoot()
    {
        GameObject bullet_ = Instantiate(bullet, new Vector3(transform.position.x - 4, transform.position.y, 0), Quaternion.identity);
        bullet_.GetComponent<BulletEnemyBoss>().Initialize(_attack, speed_bullet);
    }
}
