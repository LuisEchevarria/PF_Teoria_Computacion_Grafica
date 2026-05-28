using UnityEngine;

public class LuzPasillo : MonoBehaviour
{
    [Header("Configuración")]
    public KeyCode teclaAsignada; // Aquí elegirás la tecla en Unity (ej. Q, E)
    public bool encendidaAlInicio = false; // FNAF suele empezar a oscuras

    private Light componenteLuz;

    void Start()
    {
        // Buscamos el componente Light automáticamente en este objeto
        componenteLuz = GetComponent<Light>();

        if (componenteLuz == null)
        {
            Debug.LogError("🚨 ¡Error! El script LuzPasillo está en un objeto (" + gameObject.name + ") que no tiene una LUZ (Light component).");
            enabled = false; // Desactivamos el script para evitar más errores
            return;
        }

        // Configuramos el estado inicial
        componenteLuz.enabled = encendidaAlInicio;
    }

    void Update()
    {
        // Detectamos si el jugador presionó la tecla asignada
        if (Input.GetKeyDown(teclaAsignada))
        {
            AlternarLuz();
        }
    }

    public void AlternarLuz()
    {
        if (componenteLuz != null)
        {
            // Invertimos el estado actual: si está prendida, se apaga; si está apagada, se prende.
            componenteLuz.enabled = !componenteLuz.enabled;
        }
    }
}