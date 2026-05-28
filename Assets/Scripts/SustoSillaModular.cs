using System.Collections;
using UnityEngine;

public class SustoSillaModular : MonoBehaviour
{
    [Header("Configuración del Input")]
    public KeyCode teclaGatillo = KeyCode.C; // Cada silla puede tener su propia tecla

    [Header("Configuración del Movimiento")]
    public float gradosInclinacion = 15f;   // Qué tanto se va a inclinar la silla hacia atrás
    public float velocidadSusto = 8f;       // Qué tan rápido va a temblar/caer
    public float velocidadRegreso = 4f;     // Qué tan rápido regresa a su lugar

    private Quaternion rotacionOriginal;
    private bool estaAnimando = false;

    void Start()
    {
        // Guardamos la rotación exacta en la que pusiste la silla en la escena
        rotacionOriginal = transform.localRotation;
    }

    void Update()
    {
        // Si presionas la tecla y la silla no se está moviendo actualmente...
        if (Input.GetKeyDown(teclaGatillo) && !estaAnimando)
        {
            StartCoroutine(AnimarSustoCo());
        }
    }

    IEnumerator AnimarSustoCo()
    {
        estaAnimando = true;

        // 1. Calculamos la rotación inclinada (hacia atrás en el eje X)
        Quaternion rotacionInclinada = rotacionOriginal * Quaternion.Euler(gradosInclinacion, 0, 0);

        // 2. Movimiento de ida (Susto rápido)
        while (Quaternion.Angle(transform.localRotation, rotacionInclinada) > 0.05f)
        {
            transform.localRotation = Quaternion.Slerp(
                transform.localRotation,
                rotacionInclinada,
                velocidadSusto * Time.deltaTime
            );
            yield return null;
        }
        transform.localRotation = rotacionInclinada;

        // Esperamos un mini instante en el punto más alto del susto
        yield return new WaitForSeconds(0.05f);

        // 3. Movimiento de regreso (Vuelve a su estado original suavemente)
        while (Quaternion.Angle(transform.localRotation, rotacionOriginal) > 0.05f)
        {
            transform.localRotation = Quaternion.Slerp(
                transform.localRotation,
                rotacionOriginal,
                velocidadRegreso * Time.deltaTime
            );
            yield return null;
        }
        transform.localRotation = rotacionOriginal;

        estaAnimando = false;
    }
}