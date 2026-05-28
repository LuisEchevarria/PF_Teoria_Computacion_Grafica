using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Materiales del Cielo")]
    public Material skybox_proyecto;       // Tu cielo de día
    public Material skybox_proyecto_noche; // Tu cielo de noche

    private bool esNoche = false;

    void Update()
    {
        // Presiona 'N' para alternar entre el día y la noche
        if (Input.GetKeyDown(KeyCode.N))
        {
            esNoche = !esNoche;
            SetModoNoche(esNoche);
        }
    }

    public void SetModoNoche(bool noche)
    {
        if (noche)
        {
            RenderSettings.skybox = skybox_proyecto_noche;
            RenderSettings.ambientIntensity = 0.5f; // Baja la luz ambiental general
        }
        else
        {
            RenderSettings.skybox = skybox_proyecto;
            RenderSettings.ambientIntensity = 1.0f; // Restaura la luz ambiental
        }

        // Actualiza la iluminación global para reflejar el cambio
        DynamicGI.UpdateEnvironment();
    }
}