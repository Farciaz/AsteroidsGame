using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    //gracz (jego pozycja)
    Transform player;

    //prefab statycznej asteroidy
    public GameObject staticAsteroid;

    //czas od ostatio wygenerowanej asteoidy
    float timeSinceSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //znajdz gracz i przypisz do zmiennej
        player = GameObject.FindWithTag("Player").transform;

        //zeruj czas
        timeSinceSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //dolicz czas od ostatniej klatki
        timeSinceSpawn += Time.deltaTime;
        //je¿eli czas przekroczy³ sekundê to spawnuj i zresetuj
        if (timeSinceSpawn > 1)
        {
            GameObject asteroid = SpawnAsteroid(staticAsteroid);
            timeSinceSpawn = 0;
        }

    }

    GameObject SpawnAsteroid(GameObject prefab)
    {
        //generyczna funkcja sluzaca do wylosowania wspolrzednych i umieszczenia
        //w tym miejscu asteroidy z prefaba

        Vector3 randomPosition = Random.onUnitSphere * 10;

        
        randomPosition += player.position;

        
        GameObject asteroid = Instantiate(staticAsteroid, randomPosition, Quaternion.identity);

        //zwróæ asteroidê jako wynik dzia³ania
        return asteroid;
    }
}