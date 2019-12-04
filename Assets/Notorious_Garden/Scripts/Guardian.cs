using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardian : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject guardian;
    public double cooldown = 10.0f;
    private float timer;
    private int pick;
    private int guardiansSummoned = 0;
    
    void SpawnGuardian(int choose){
        guardiansSummoned += 1;
        Debug.Log("I did my job: " + guardiansSummoned.ToString("0"));
        Debug.Log("Guardian Number: " + choose.ToString("0"));
        Vector3 spawn_potition = new Vector3(Random.Range(-5.5f, -3.7f), Random.Range(-2.6f, 1.5f), 0);
        if (choose == 1) {
            GameObject temp_spawn_point = Instantiate(guardian, spawn_potition, Quaternion.identity) as GameObject;    
        }
        else if (choose == 2) {
            GameObject temp_spawn_point = Instantiate(guardian, spawn_potition, Quaternion.identity) as GameObject;    
        }
        else if (choose == 3) {
            GameObject temp_spawn_point = Instantiate(guardian, spawn_potition, Quaternion.identity) as GameObject;
        }
        else {
            GameObject temp_spawn_point = Instantiate(guardian, spawn_potition, Quaternion.identity) as GameObject;    
        }
        
    }
    void Start()
    {
        timer = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        pick = Random.Range(1, 10);
        if (Player.instance.stealth < 80f){
            if (Time.time - timer > cooldown){
                SpawnGuardian(pick);
                cooldown += timer;
                timer = Time.time;
                }
            }
        
    }
}
