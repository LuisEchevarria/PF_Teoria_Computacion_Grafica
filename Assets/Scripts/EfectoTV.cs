using UnityEngine;
using UnityEngine.UI;

public class EfectoTV : MonoBehaviour
{
    private RawImage imagenEstatica;
    private Texture2D texturaRuido;

    void Start()
    {
        // Obtenemos el componente RawImage
        imagenEstatica = GetComponent<RawImage>();

        // 1. Creamos una textura cuadrada de 256x256
        texturaRuido = new Texture2D(256, 256);
        texturaRuido.filterMode = FilterMode.Point; // Estilo pixelado/retro

        // 2. Llenamos la textura de puntos blancos, negros y grises
        Color[] pixeles = new Color[256 * 256];
        for (int i = 0; i < pixeles.Length; i++)
        {
            float gris = Random.Range(0f, 1f);
            pixeles[i] = new Color(gris, gris, gris, 1f);
        }

        // 3. Aplicamos los píxeles y se la asignamos a la imagen
        texturaRuido.SetPixels(pixeles);
        texturaRuido.Apply();
        imagenEstatica.texture = texturaRuido;
    }

    void Update()
    {
        // Desplazamos los ejes UV (X y Y) aleatoriamente cada frame
        // Esto crea la ilusión de que la estática se está moviendo a la velocidad de la luz
        float offsetX = Random.Range(0f, 1f);
        float offsetY = Random.Range(0f, 1f);

        imagenEstatica.uvRect = new Rect(offsetX, offsetY, 2f, 2f);
    }
}