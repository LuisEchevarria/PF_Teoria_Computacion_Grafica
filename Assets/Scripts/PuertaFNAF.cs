using System.Collections;
using UnityEngine;

public class PuertaFNAF : MonoBehaviour
{
    [Header("Posiciones Locales")]
    public Vector3 posicionAbierta;
    public Vector3 posicionCerrada;

    [Header("Configuración de la Animación")]
    public float velocidad = 10f;

    [Header("Control por Teclado (NUEVO)")]
    public bool usarTeclado = true;
    public KeyCode teclaAsignada; // Aquí elegirás la tecla en Unity (ej. A, D, Space)

    private bool estaAbierta = true;
    private Coroutine coroutineMovimiento;

    void Start()
    {
        transform.localPosition = posicionAbierta;
    }

    void Update()
    {
        // NUEVO: Cada frame revisa si el jugador presionó la tecla asignada
        if (usarTeclado && Input.GetKeyDown(teclaAsignada))
        {
            AlternarPuerta();
        }
    }

    public void AlternarPuerta()
    {
        estaAbierta = !estaAbierta;

        if (coroutineMovimiento != null)
        {
            StopCoroutine(coroutineMovimiento);
        }

        Vector3 destino = estaAbierta ? posicionAbierta : posicionCerrada;
        coroutineMovimiento = StartCoroutine(MoverPuertaCo(destino));
    }

    IEnumerator MoverPuertaCo(Vector3 destino)
    {
        while (Vector3.Distance(transform.localPosition, destino) > 0.001f)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                destino,
                velocidad * Time.deltaTime
            );
            yield return null;
        }
        transform.localPosition = destino;
    }
}