using UnityEngine;

public class ControlCamaras : MonoBehaviour
{
    [Header("Cámara del Jugador")]
    public GameObject camaraOficina;

    [Header("Todas las Cámaras de Seguridad")]
    public GameObject[] camarasSeguridad;

    [Header("Efectos Visuales")]
    public GameObject panelEstatica; // NUEVO: Aquí guardaremos la imagen de estática

    private bool viendoMonitor = false;
    private int indiceCamaraActual = 0;

    void Start()
    {
        camaraOficina.SetActive(true);
        panelEstatica.SetActive(false); // NUEVO: Apagamos la estática al inicio

        foreach (GameObject cam in camarasSeguridad)
        {
            cam.SetActive(false);
        }
    }

    public void AlternarMonitor()
    {
        viendoMonitor = !viendoMonitor;

        // NUEVO: El panel de estática se enciende o apaga igual que el monitor
        panelEstatica.SetActive(viendoMonitor);

        if (viendoMonitor)
        {
            camaraOficina.SetActive(false);
            camarasSeguridad[indiceCamaraActual].SetActive(true);
        }
        else
        {
            camaraOficina.SetActive(true);
            camarasSeguridad[indiceCamaraActual].SetActive(false);
        }
    }

    public void CambiarCamara(int nuevoIndice)
    {
        if (viendoMonitor)
        {
            camarasSeguridad[indiceCamaraActual].SetActive(false);
            indiceCamaraActual = nuevoIndice;
            camarasSeguridad[indiceCamaraActual].SetActive(true);
        }
    }
}