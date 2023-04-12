using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;  // ссылка на единственный экземпляр GameManager

    public float horizontalExtent = 3.5f;  // горизонтальный размер игрового поля

    void Awake()
    {
        // устанавливаем единственный экземпляр GameManager
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);  // удаляем дублирующийся объект GameManager

        // сохраняем горизонтальный размер игрового поля
        horizontalExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
    }

}
