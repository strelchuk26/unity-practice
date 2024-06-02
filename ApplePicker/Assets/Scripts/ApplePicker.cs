using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    public void AppleDestroyed()
    {
        // Destroy all falling apples
        GameObject[] list = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject go in list)
        {
            Destroy(go);
        }

        // Destroy one of the baskets
        int index = basketList.Count - 1;
        if (index >= 0)
        {
            var item = basketList[index];
            basketList.RemoveAt(index);
            Destroy(item);
        }

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_End_Scene_");
        }
    }
}
