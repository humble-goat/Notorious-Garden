using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FloatingTxt;
    public Slider waterSlider;
    public float refillSpeed;
    public bool isHydrated;
    public float ph;
    public float humidity;
    public float health = 100f;
    public string climate;
    public float water = 1f;
    public int lifecycle;
    public bool sappling;
    public float sapplingSpawn;
    public float growth;
    public int age;
    public ArrayList diseases;
    public ArrayList insects;
    void Start()
    {
        waterSlider = GetComponent<Slider>();
        isHydrated = false;
        refillSpeed = 0.01f;

    }

    // Update is called once per frame
    void Update()
    {
        if (waterSlider != null)
        {
            waterSlider.value -= 0.1f;
        }
        
        
    }
    
}
