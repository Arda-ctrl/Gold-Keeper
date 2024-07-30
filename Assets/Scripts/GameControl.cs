using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool gameActive = true;
    public int coinCount = 0;
    public UnityEngine.UI.Text coinCountText;
    public GameObject hiddenCube;
    public GameObject hiddenCube1;
    public GameObject hiddenCube2;
    public GameObject hiddenCube3;
    public GameObject hiddenCube4;
    public GameObject hiddenCube5;
    // Start is called before the first frame update
    void Start()
    {
        if (hiddenCube != null)
        {
            SetObjectVisible(hiddenCube, false); // Baþlangýçta küpü görünmez yapar
            SetObjectVisible(hiddenCube1, false);
            SetObjectVisible(hiddenCube2, false);
            SetObjectVisible(hiddenCube3, false);
            SetObjectVisible(hiddenCube4, false);
            SetObjectVisible(hiddenCube5, false);
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
        if (coinCount == 2 && hiddenCube != null)
        {
            SetObjectVisible(hiddenCube, true); // Küpü görünür hale getirir
        }
        if (coinCount == 4 && hiddenCube1 != null)
        {
            SetObjectVisible(hiddenCube1, true);
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
