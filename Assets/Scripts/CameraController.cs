using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento
    public float sensibilidadMouse = 2.0f; // Sensibilidad del mouse

    private float rotacionVertical = 0.0f;

    void Update()
    {
        // Movimiento del personaje
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        movimiento = transform.TransformDirection(movimiento);
        transform.position += movimiento * velocidad * Time.deltaTime;

        // Rotación de la cámara
        float rotacionHorizontal = Input.GetAxis("Mouse X") * sensibilidadMouse;
        transform.Rotate(0.0f, rotacionHorizontal, 0.0f);

        rotacionVertical -= Input.GetAxis("Mouse Y") * sensibilidadMouse;
        rotacionVertical = Mathf.Clamp(rotacionVertical, -90.0f, 90.0f);
        Camera.main.transform.localRotation = Quaternion.Euler(rotacionVertical, 0.0f, 0.0f);
    }
}