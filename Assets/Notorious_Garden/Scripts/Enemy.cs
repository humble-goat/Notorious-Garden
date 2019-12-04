using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    // Start is called before the first frame update
    public double health;
    public string id;
    public string subclass;
    public double senses;
    public double summonedTime;
    public double damage;
    public double kill_factor;
    public bool canRespawn;
    public float timer;
    private int pick;
    
    
    public bool killingSpree;
    void Properties(int choose){
        if (choose % 2 == 0) {
            id = "LadyBug";
            // Damage 12f-32f
            damage = Random.Range(12f, 32f);
            // Senses 1f-4f
            senses = Random.Range(1f, 4f);
            // Health 1f-2f
            health = Random.Range(1f, 2f);
            // Summoned Time 10f-20f
            summonedTime = Random.Range(10f, 20f);
            // Can Respawn false
            canRespawn = false;
            
            if (choose * Player.instance.population % 2 == 0){
                subclass = "Don Juan";
                // Killing Spree false
                killingSpree = false;
                // Kill factor 3f-4f
                if (damage * health * senses / Player.instance.population >= 2) {
                    kill_factor = 4f;
                }
                else {
                    kill_factor = 3f;
                }
                
            }
            else {
                subclass = "Loner";
                // Killing Spree true
                killingSpree = true;
                // Kill factor 1f-2f
                if (damage * health * senses / Player.instance.population >= 2) {
                    kill_factor = 2f;
                }
                else {
                    kill_factor = 1f;
                }
            }    
        }
        else if (choose % 3 == 0) {
            id = "Praying Mantis";
            // Damage 100f overkill
            damage = 100f;
            // Senses 8f
            senses = 8f;
            // Health 30f-50f
            health = Random.Range(30f, 50f);
            // Summoned Time 60f-100f
            summonedTime = Random.Range(60f, 100f);
            // Can Respawn false
            canRespawn = false;

            // Killing Spree true
            killingSpree = true;

            if (choose * Player.instance.population % 2 == 0){
                subclass = "Static";
                // Kill factor 1f
                kill_factor = 1f;
                
            }
            else {
                subclass = "Hunter";
                // Kill factor 4f
                kill_factor = 4f;
            }    
        }
        else if (choose % 5 == 0) {
            id = "Parasitic Host";
            if (choose * Player.instance.population % 2 == 0){
                subclass = "Agressive";
                // Damage inherit lethal factor
                damage = Player.instance.lethal_factor;
                // Senses inherit insticts
                senses = Player.instance.insticts;
                // Health inherit single_health
                health = Player.instance.single_health;
                // Summoned Time inherit lifespawn
                summonedTime = Player.instance.lifespawn;
                // Can respawn true
                canRespawn = true;
                // Killing Spree true
                killingSpree = true;
            }
            else {
                subclass = "Passive";
                // Damage inherit lethal factor
                damage = Player.instance.lethal_factor;
                // Senses inherit insticts
                senses = Player.instance.insticts;
                // Health inherit single_health
                health = Player.instance.single_health;
                // Summoned Time inherit lifespawn
                summonedTime = Player.instance.lifespawn;
                // Can respawn true
                canRespawn = false;
                // Killing Spree true
                killingSpree = false;
                // Spawn Evolution
                for(int i = 0; i < 20; i++){
                    Debug.Log("Countdown: " + i.ToString("0"));
                }
                // Spawn an Ally
                // SpawnGuardian(999999);
            }   
        }
        else {
            id = "Ant";
            // Damage 100f overkill
            damage = 0.01f;
            // Senses 8f
            senses = 9f;
            // Health 30f-50f
            health = Random.Range(0.01f, 0.08f);
            // Summoned Time 60f-100f
            summonedTime = Random.Range(0.2f, 0.3f);
            // Can Respawn false
            canRespawn = false;

            // Killing Spree true
            killingSpree = true;

            if (choose * Player.instance.population % 2 == 0){
                subclass = "Static";
                // Kill factor 1f
                kill_factor = 1f;
                
            }
            else {
                subclass = "Hunter";
                // Kill factor 4f
                kill_factor = 4f;
            }    
        }
        /* Under Development
        else if (choose == 4) {
            Debug.Log("Human");
            if (choose % 2 == 0){
                Debug.Log("Lazy Fucker");
            }
            else {
                Debug.Log("OCD");
            }   
        }
        else if (choose == 5) {
            Debug.Log("Chicken");
            if (choose % 2 == 0){
                Debug.Log("Ground Digger");
            }
            else {
                Debug.Log("Exterminator");
            }     
        }
        else if (choose == 6) {
            Debug.Log("Turkey");
            if (choose % 2 == 0){
                Debug.Log("Air killer");
            }
            else {
                Debug.Log("Exterminator");
            }     
        }
        else if (choose == 7) {
            Debug.Log("Spider");
            if (choose % 2 == 0){
                Debug.Log("Guardian");
            }
            else {
                Debug.Log("Huntress");
            }   
        }
        else {
            // Debug.Log("Minor boost");
            // Debug.Log("Summon Ants");
        }
         */
        
    }

    void Start()
    {
        timer = Time.time;
        pick = Random.Range(1, 10);
        Properties(pick);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timer > summonedTime){
            Destroy(this.gameObject);
            timer = Time.time;
            
        }
        
    }
}
