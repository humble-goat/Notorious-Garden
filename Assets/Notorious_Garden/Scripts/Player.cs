using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject garden_points;
    public GameObject disease_points;
    public GameObject super_points;
    public static Player instance;
    public int population;
    public float lethality = 0.000001f;
    public double stealth = 100f;
    public double viability = 100f;
    public double insticts = 0.0f;
    public double single_health;
    public double lifespawn;
    public int updateCount;
    public bool isDisease;
    public double score;
    public float timer = 0.0f;
    private int pick;

    void SpawnPoint(int choose){
        Vector3 spawn_potition = new Vector3(Random.Range(-5.5f, -3.7f), Random.Range(-2.6f, 1.5f), 0);
        // Debug.Log("Point number: " + choose.ToString("0"));
        if (choose == 1) {
            GameObject temp_spawn_point = Instantiate(garden_points, spawn_potition, Quaternion.identity) as GameObject;    
        }
        else if (choose == 2) {
            GameObject temp_spawn_point = Instantiate(disease_points, spawn_potition, Quaternion.identity) as GameObject;    
        }
        else if (choose == 3) {
            GameObject temp_spawn_point = Instantiate(super_points, spawn_potition, Quaternion.identity) as GameObject;
        }
        else {
            GameObject temp_spawn_point = Instantiate(garden_points, spawn_potition, Quaternion.identity) as GameObject;    
        }
        
    }
    void Start()
    {

        timer = Time.time;
        instance = this;
        
        
    }


    // Update is called once per frame
    void Update()
    {
        if (isDisease == true){
            viability -= 0.02;
        }
        else {
            viability -= 0.01;
        }

        // spawn ectoplasm points at random
        if (Time.time - timer > Random.Range(10f, 20f)){
            pick = Random.Range(0, 10);
            SpawnPoint(pick);
            timer = Time.time;
        }

        // start Guardian events

        if (viability <= 0.0f){
            Debug.Log("GAME OVER");
            // return to main menu
        }
        // reveal factors
        stealth -= ((lethality * population) + updateCount) / stealth;
        
        // lethal factors
        
    

    }
}
