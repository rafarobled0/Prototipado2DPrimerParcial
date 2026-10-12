
using UnityEngine;
using UnityEngine.UI;

public class Personalizador : MonoBehaviour
{
    public GameObject[] ropa;
    public GameObject[] sombreros;

    public Image imagenPinguino;

    private int indiceRopa = 0;
    private int indiceSombrero = 0;

    void Start()
    {
        MostrarRopa();
        MostrarSombrero();
    }

    public void SiguienteRopa()
    {
        indiceRopa = (indiceRopa + 1) % ropa.Length;
        MostrarRopa();
    }

    public void AnteriorRopa()
    {
        indiceRopa = (indiceRopa - 1 + ropa.Length) % ropa.Length;
        MostrarRopa();
    }

    public void SiguienteSombrero()
    {
        indiceSombrero = (indiceSombrero + 1) % sombreros.Length;
        MostrarSombrero();
    }

    public void AnteriorSombrero()
    {
        indiceSombrero = (indiceSombrero - 1 + sombreros.Length)
                         % sombreros.Length;
        MostrarSombrero();
    }

    void MostrarRopa()
    {
        for (int i = 0; i < ropa.Length; i++)
        {
            ropa[i].SetActive(i == indiceRopa);
        }
    }

    void MostrarSombrero()
    {
        for (int i = 0; i < sombreros.Length; i++)
        {
            sombreros[i].SetActive(i == indiceSombrero);
        }
    }

    public void CambiarColor(float valor)
    {
        if (imagenPinguino == null)
        {
            Debug.LogError("No has asignado la imagen del pingüino");
            return;
        }

        Color nuevoColor = Color.HSVToRGB(valor, 1f, 1f);
        imagenPinguino.color = nuevoColor;

        Debug.Log("Valor del slider: " + valor);
    }
}
    