using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float flySpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dodaj do wspolrzednycg wartosc x=1, y=0, z=0 pomnozeone przez czas mierzony w sekundach   
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja dzia³ania wyg³adzonego sterowania 
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie prêdkoscia
        //stworz nowy wektor przesunieia o wartosci 1 do przodu
        Vector3 movement = transform.forward;
        //pomnoz go przez czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomnoz go przez "wychylenie joysticka"
        movement *= Input.GetAxis("Vertical");
        //pomnoz przez predkosc lotu
        movement *= flySpeed;
        //dodaj ruch do obiektu
        transform.position += movement;


        //obrót
        //modyfikuj oœ "y" obiektu player
        Vector3 rotation = Vector3.up;
        //przemnó¿ przez czas
        rotation *= Time.deltaTime;
        //przemnó¿ przez klawiaturê
        rotation *= Input.GetAxis("Horizontal");
        //pomno¿ przez predkosc obrotu
        rotation *= rotationSpeed;
        //dodaj obrót do obiektu
        //nie mo¿emy u¿yæ += poniewa¿ unity u¿ywa Quaternionów do zapisu rotacji
        transform.Rotate(rotation);
    }
}
