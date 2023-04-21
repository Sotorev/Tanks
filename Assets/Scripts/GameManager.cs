using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{

    public GameObject[] vehicles;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke vehicle
        InvokeRepeating("SpawnVehicle", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn function
    public void SpawnVehicle()
    {
        //Randomly select a vehicle from the array
        int vehicleIndex = Random.Range(0, vehicles.Length);
        //Spawn the vehicle
        Instantiate(vehicles[vehicleIndex], transform.position, transform.rotation);
    }
}
