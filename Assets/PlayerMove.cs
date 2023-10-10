using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float normalSpeed = 5.0f; // Prędkość poruszania się postaci w trybie normalnym
    public float sprintSpeed = 10.0f; // Prędkość poruszania się postaci w trybie sprintu

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Pobierz wartość klawiszy A i D
        float verticalInput = Input.GetAxis("Vertical"); // Pobierz wartość klawiszy W i S

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput); // Utwórz wektor ruchu

        // Wybierz odpowiednią prędkość w zależności od stanu sprintu
        float speed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : normalSpeed;

        // Przemieszczenie postaci na podstawie wektora ruchu i prędkości
        transform.Translate(movement * speed * Time.deltaTime);
    }
}


