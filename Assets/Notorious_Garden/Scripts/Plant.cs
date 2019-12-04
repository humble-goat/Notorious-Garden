using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    public Slider waterSlider;
    public Slider plantHealth;
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public float CurrentWater { get; set; }
    public float MaxWater { get; set; }
    // Start is called before the first frame update
    public GameObject FloatingTxt;
    
    public float refillSpeed;
    public bool isTakingDmg;
    public bool isHydrated;
    public float ph;
    public float humidity;
    public string climate;
    public int lifecycle;
    public bool sappling;
    public float sapplingSpawn;
    public float growth;
    public int age;
    private float lethal_timer;
    public ArrayList diseases;
    public ArrayList insects;
    void Start()
    {
        plantHealth = GameObject.Find("Health").GetComponent<Slider>();
        waterSlider = GameObject.Find("Water").GetComponent<Slider>();
        CurrentHealth = 100f;
        CurrentWater = 100f;
        plantHealth.value = CalculateHealth();
        waterSlider.value = CalculateWater();
        refillSpeed = 0.01f;
        
        isTakingDmg = false;
        isHydrated = false;
        CurrentHealth = MaxHealth;
        CurrentWater = MaxWater;
        lethal_timer = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player.instance.lethality > 0)
        {
            if (Time.time - lethal_timer > Random.Range(30f, 100f))
            {
                Player.instance.lethality += Player.instance.population * Player.instance.lethality;
                plantHealth.value -= Player.instance.lethality;
                lethal_timer = Time.time;
            }
            
        }
        if (climate == "summer")
        {
            isHydrated = false;
        }
        if (isHydrated == false)
        {
            // Dehydration
        }

        if (CurrentHealth <= 0)
        {
            Win();
        }
        if (CurrentWater <= 0)
        {
            // Start Damaging the player
        }


    }

    public float CalculateHealth()
    {
        return (CurrentHealth / MaxHealth) * 100;
    }
    public float CalculateWater()
    {
        return (CurrentWater / MaxWater) * 100;
    }


    void Win()
    {
        CurrentHealth = 0f;
        Debug.Log("You Win");
    }

}
