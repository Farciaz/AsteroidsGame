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

        //prezentacja dzia�ania wyg�adzonego sterowania 
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie pr�dkoscia
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


        //obr�t
        //modyfikuj o� "y" obiektu player
        Vector3 rotation = Vector3.up;
        //przemn� przez czas
        rotation *= Time.deltaTime;
        //przemn� przez klawiatur�
        rotation *= Input.GetAxis("Horizontal");
        //pomno� przez predkosc obrotu
        rotation *= rotationSpeed;
        //dodaj obr�t do obiektu
        //nie mo�emy u�y� += poniewa� unity u�ywa Quaternion�w do zapisu rotacji
        transform.Rotate(rotation);
    }
}
