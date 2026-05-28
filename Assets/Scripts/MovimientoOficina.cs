using UnityEngine;

public class MovimientoOficina : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float velocidadGiro = 150f;
    public float limiteIzquierdo = -50f;
    public float limiteDerecho = 50f;

    private float rotacionActualY = 0f;
    private float rotacionInicialY;
    private float rotacionInicialX;
    private float rotacionInicialZ;

    void Start()
    {
        // Guardamos la rotación que le pusiste a la cámara en el Inspector
        rotacionInicialY = transform.localEulerAngles.y;
        rotacionInicialX = transform.localEulerAngles.x;
        rotacionInicialZ = transform.localEulerAngles.z;
    }

    void Update()
    {
        // Detectar si el ratón se mueve a los lados
        float movimientoRatonX = Input.GetAxis("Mouse X");

        // Calcular cuánto debe girar según la velocidad
        rotacionActualY += movimientoRatonX * velocidadGiro * Time.deltaTime;

        // Limitar la visión para no dar la vuelta completa
        rotacionActualY = Mathf.Clamp(rotacionActualY, limiteIzquierdo, limiteDerecho);

        // Aplicar la rotación final respetando cómo estaba inclinada al inicio
        transform.localRotation = Quaternion.Euler(rotacionInicialX, rotacionInicialY + rotacionActualY, rotacionInicialZ);
    }
}