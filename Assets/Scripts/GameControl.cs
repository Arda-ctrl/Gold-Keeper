using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool gameActive = true;
    public int coinCount = 0;
    public UnityEngine.UI.Text coinCountText;
    public GameObject hiddenCube;
    // Start is called before the first frame update
    void Start()
    {
        if (hiddenCube != null)
        {
            SetObjectVisible(hiddenCube, false); // Baþlangýçta küpü görünmez yapar
        }
        else
        {
            Debug.LogWarning("hiddenCube referansý atanmadý!");
        }
        GetComponent<AudioSource> ().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount >= 1 && hiddenCube != null)
        {
            SetObjectVisible(hiddenCube, true); // Küpü görünür hale getirir
        }
    }
    public void Coinincrease()
    {
        coinCount++;
        coinCountText.text = "" + coinCount;
    }

    private void SetObjectVisible(GameObject obj, bool visible)
    {
        Renderer[] renderers = obj.GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            renderer.enabled = visible;
        }
    }
}
